using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FlatBuffersTest
{
    internal static class Utils
    {
        public static string EnsurePathExists(string path)
        {
            return !Directory.Exists(path) ? Directory.GetCurrentDirectory() : path;
        }

        public static string GetRelativePath(string fullPath, string basePath = null)
        {
            if (basePath == null)
            {
                basePath = Directory.GetCurrentDirectory();
            }

            // Require trailing backslash for path
            if (!basePath.EndsWith("\\"))
            {
                basePath += "\\";
            }

            var baseUri = new Uri(basePath);
            var fullUri = new Uri(fullPath);

            var relativeUri = baseUri.MakeRelativeUri(fullUri);

            // Uri's use forward slashes so convert back to backward slashes
            return relativeUri.ToString().Replace("/", "\\");
        }

        public static string GetFullPath(string relativePath, string basePath = null)
        {
            if (Path.IsPathRooted(relativePath))
            {
                //do nothing
                return relativePath;
            }

            if (basePath == null)
            {
                basePath = Directory.GetCurrentDirectory();
            }

            if (!basePath.EndsWith(@"\"))
            {
                basePath += @"\";
            }

            var basePathUri = new Uri(basePath);
            var full = new Uri(basePathUri, relativePath).LocalPath;

            return full;
        }

        public static void EnumerateFiles(string dir, string searchPattern, SearchOption searchOption, Func<FileInfo, bool> fileInfoFunc)
        {
            var directoryInfo = new DirectoryInfo(dir);
            var files = directoryInfo.EnumerateFiles(searchPattern, searchOption);

            foreach (var file in files)
            {
                if (false == fileInfoFunc(file))
                {
                    return;
                }
            }
        }

        public static void EnumerateFilesParallel(string dir, string searchPattern, SearchOption searchOption, Func<FileInfo, bool> fileInfoFunc)
        {
            var directoryInfo = new DirectoryInfo(dir);
            IEnumerable<FileInfo> files;

            if (searchOption == SearchOption.TopDirectoryOnly)
            {
                files = directoryInfo.EnumerateFiles(searchPattern, SearchOption.TopDirectoryOnly);
            }
            else
            {
                files = directoryInfo.EnumerateFiles(searchPattern, SearchOption.TopDirectoryOnly).Union
                (
                    directoryInfo.EnumerateDirectories().AsParallel()
                        //.WithDegreeOfParallelism(Environment.ProcessorCount * 2)
                        .SelectMany(
                            di => di.EnumerateFiles(searchPattern, SearchOption.AllDirectories)
                        )
                );
            }

            Parallel.ForEach(
                files,
                (file, state) =>
                {
                    if (false == fileInfoFunc(file))
                    {
                        state.Break();
                    }
                });
        }
    }
}