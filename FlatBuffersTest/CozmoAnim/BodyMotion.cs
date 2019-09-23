// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace CozmoAnim
{

using global::System;
using global::FlatBuffers;

public struct BodyMotion : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static BodyMotion GetRootAsBodyMotion(ByteBuffer _bb) { return GetRootAsBodyMotion(_bb, new BodyMotion()); }
  public static BodyMotion GetRootAsBodyMotion(ByteBuffer _bb, BodyMotion obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BodyMotion __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint TriggerTimeMs { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint DurationTimeMs { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string RadiusMm { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRadiusMmBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetRadiusMmBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetRadiusMmArray() { return __p.__vector_as_array<byte>(8); }
  public short Speed { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }

  public static Offset<CozmoAnim.BodyMotion> CreateBodyMotion(FlatBufferBuilder builder,
      uint triggerTime_ms = 0,
      uint durationTime_ms = 0,
      StringOffset radius_mmOffset = default(StringOffset),
      short speed = 0) {
    builder.StartTable(4);
    BodyMotion.AddRadiusMm(builder, radius_mmOffset);
    BodyMotion.AddDurationTimeMs(builder, durationTime_ms);
    BodyMotion.AddTriggerTimeMs(builder, triggerTime_ms);
    BodyMotion.AddSpeed(builder, speed);
    return BodyMotion.EndBodyMotion(builder);
  }

  public static void StartBodyMotion(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddTriggerTimeMs(FlatBufferBuilder builder, uint triggerTimeMs) { builder.AddUint(0, triggerTimeMs, 0); }
  public static void AddDurationTimeMs(FlatBufferBuilder builder, uint durationTimeMs) { builder.AddUint(1, durationTimeMs, 0); }
  public static void AddRadiusMm(FlatBufferBuilder builder, StringOffset radiusMmOffset) { builder.AddOffset(2, radiusMmOffset.Value, 0); }
  public static void AddSpeed(FlatBufferBuilder builder, short speed) { builder.AddShort(3, speed, 0); }
  public static Offset<CozmoAnim.BodyMotion> EndBodyMotion(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 8);  // radius_mm
    return new Offset<CozmoAnim.BodyMotion>(o);
  }
};


}
