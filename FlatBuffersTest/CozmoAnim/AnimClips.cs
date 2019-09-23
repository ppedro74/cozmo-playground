// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace CozmoAnim
{

using global::System;
using global::FlatBuffers;

public struct AnimClips : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static AnimClips GetRootAsAnimClips(ByteBuffer _bb) { return GetRootAsAnimClips(_bb, new AnimClips()); }
  public static AnimClips GetRootAsAnimClips(ByteBuffer _bb, AnimClips obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AnimClips __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public CozmoAnim.AnimClip? Clips(int j) { int o = __p.__offset(4); return o != 0 ? (CozmoAnim.AnimClip?)(new CozmoAnim.AnimClip()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ClipsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<CozmoAnim.AnimClips> CreateAnimClips(FlatBufferBuilder builder,
      VectorOffset clipsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    AnimClips.AddClips(builder, clipsOffset);
    return AnimClips.EndAnimClips(builder);
  }

  public static void StartAnimClips(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddClips(FlatBufferBuilder builder, VectorOffset clipsOffset) { builder.AddOffset(0, clipsOffset.Value, 0); }
  public static VectorOffset CreateClipsVector(FlatBufferBuilder builder, Offset<CozmoAnim.AnimClip>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateClipsVectorBlock(FlatBufferBuilder builder, Offset<CozmoAnim.AnimClip>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartClipsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<CozmoAnim.AnimClips> EndAnimClips(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<CozmoAnim.AnimClips>(o);
  }
  public static void FinishAnimClipsBuffer(FlatBufferBuilder builder, Offset<CozmoAnim.AnimClips> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedAnimClipsBuffer(FlatBufferBuilder builder, Offset<CozmoAnim.AnimClips> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
