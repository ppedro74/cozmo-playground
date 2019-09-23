using System;
using System.Reflection;
using System.Text;

namespace FlatBuffersTest.Cozmo
{
    public enum ProceduralEyeParameter
    {
        EyeCenterX,
        EyeCenterY,
        EyeScaleX,
        EyeScaleY,
        EyeAngle,
        LowerInnerRadiusX,
        LowerInnerRadiusY,
        UpperInnerRadiusX,
        UpperInnerRadiusY,
        UpperOuterRadiusX,
        UpperOuterRadiusY,
        LowerOuterRadiusX,
        LowerOuterRadiusY,
        UpperLidY,
        UpperLidAngle,
        UpperLidBend,
        LowerLidY,
        LowerLidAngle,
        LowerLidBend,
        LastParameter
    }

    public class ProceduralEye
    {
        public float EyeCenterX { get; set; }

        public float EyeCenterY { get; set; }

        public float EyeScaleX { get; set; }

        public float EyeScaleY { get; set; }

        public float EyeAngle { get; set; }

        public float LowerInnerRadiusX { get; set; }

        public float LowerInnerRadiusY { get; set; }

        public float UpperInnerRadiusX { get; set; }

        public float UpperInnerRadiusY { get; set; }

        public float UpperOuterRadiusX { get; set; }

        public float UpperOuterRadiusY { get; set; }

        public float LowerOuterRadiusX { get; set; }

        public float LowerOuterRadiusY { get; set; }

        public float UpperLidY { get; set; }

        public float UpperLidAngle { get; set; }

        public float UpperLidBend { get; set; }

        public float LowerLidY { get; set; }

        public float LowerLidAngle { get; set; }

        public float LowerLidBend { get; set; }

        public ProceduralEye(float[] parameters)
        {
            for (var ix = 0; ix < parameters.Length; ix++)
            {
                if (ix < (int)ProceduralEyeParameter.LastParameter)
                {
                    var parameter = (ProceduralEyeParameter)ix;
                    this.GetType().InvokeMember(
                        parameter.ToString(),
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
                        Type.DefaultBinder,
                        this,
                        new object[] { parameters[ix] }
                    );
                }
                else
                {
                    throw new NotImplementedException(string.Format("Not expecting parameter index:{0}", ix));
                }
            }
        }

        public static string ToCsvHeader(string prefix)
        {
            var sb = new StringBuilder();
            for (var ix = 0; ix < (int)ProceduralEyeParameter.LastParameter; ix++)
            {
                if (ix > 0)
                {
                    sb.Append(",");
                }

                sb.AppendFormat("{0}{1}", prefix, (ProceduralEyeParameter)ix);
            }

            return sb.ToString();
        }

        public string ToCsv()
        {
            var sb = new StringBuilder();

            for (var ix = 0; ix < (int)ProceduralEyeParameter.LastParameter; ix++)
            {
                if (ix > 0)
                {
                    sb.Append(",");
                }

                var parameter = (ProceduralEyeParameter)ix;
                var value = this.GetType().InvokeMember(
                    parameter.ToString(),
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty,
                    Type.DefaultBinder,
                    this,
                    null
                );
                sb.Append(value);
            }

            return sb.ToString();
        }
    }

    public class ProceduralFace
    {
        public uint TriggerTimeMs { get; set; }

        public float FaceAngle { get; set; }

        public float FaceCenterX { get; set; }

        public float FaceCenterY { get; set; }

        public float FaceScaleX { get; set; }

        public float FaceScaleY { get; set; }

        public ProceduralEye LeftEye { get; set; }

        public ProceduralEye RightEye { get; set; }

        public ProceduralFace(CozmoAnim.ProceduralFace proceduralFace)
        {
            this.TriggerTimeMs = proceduralFace.TriggerTimeMs;
            this.FaceAngle = proceduralFace.FaceAngle;
            this.FaceCenterX = proceduralFace.FaceCenterX;
            this.FaceCenterY = proceduralFace.FaceCenterY;
            this.FaceScaleX = proceduralFace.FaceScaleX;
            this.FaceScaleY = proceduralFace.FaceScaleY;
            this.LeftEye = new ProceduralEye(proceduralFace.GetLeftEyeArray());
            this.RightEye = new ProceduralEye(proceduralFace.GetRightEyeArray());
        }

        public static string ToCsvHeader()
        {
            return "TriggerTimeMs,FaceAngle,FaceCenterX,FaceCenterY,FaceScaleX,FaceScaleY," + ProceduralEye.ToCsvHeader("LeftEye") + "," + ProceduralEye.ToCsvHeader("RightEye");
        }

        public string ToCsv()
        {
            var sb = new StringBuilder();

            sb.Append(this.TriggerTimeMs);
            sb.Append(",");
            sb.Append(this.FaceAngle);
            sb.Append(",");
            sb.Append(this.FaceCenterX);
            sb.Append(",");
            sb.Append(this.FaceCenterY);
            sb.Append(",");
            sb.Append(this.FaceScaleX);
            sb.Append(",");
            sb.Append(this.FaceScaleY);
            sb.Append(",");
            sb.Append(this.LeftEye.ToCsv());
            sb.Append(",");
            sb.Append(this.RightEye.ToCsv());

            return sb.ToString();
        }
    }
}