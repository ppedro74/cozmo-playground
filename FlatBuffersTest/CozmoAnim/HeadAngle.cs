// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace CozmoAnim
{

using global::System;
using global::FlatBuffers;

public struct HeadAngle : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static HeadAngle GetRootAsHeadAngle(ByteBuffer _bb) { return GetRootAsHeadAngle(_bb, new HeadAngle()); }
  public static HeadAngle GetRootAsHeadAngle(ByteBuffer _bb, HeadAngle obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public HeadAngle __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint TriggerTimeMs { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint DurationTimeMs { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public sbyte AngleDeg { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
  public byte AngleVariabilityDeg { get { int o = __p.__offset(10); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<CozmoAnim.HeadAngle> CreateHeadAngle(FlatBufferBuilder builder,
      uint triggerTime_ms = 0,
      uint durationTime_ms = 0,
      sbyte angle_deg = 0,
      byte angleVariability_deg = 0) {
    builder.StartTable(4);
    HeadAngle.AddDurationTimeMs(builder, durationTime_ms);
    HeadAngle.AddTriggerTimeMs(builder, triggerTime_ms);
    HeadAngle.AddAngleVariabilityDeg(builder, angleVariability_deg);
    HeadAngle.AddAngleDeg(builder, angle_deg);
    return HeadAngle.EndHeadAngle(builder);
  }

  public static void StartHeadAngle(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddTriggerTimeMs(FlatBufferBuilder builder, uint triggerTimeMs) { builder.AddUint(0, triggerTimeMs, 0); }
  public static void AddDurationTimeMs(FlatBufferBuilder builder, uint durationTimeMs) { builder.AddUint(1, durationTimeMs, 0); }
  public static void AddAngleDeg(FlatBufferBuilder builder, sbyte angleDeg) { builder.AddSbyte(2, angleDeg, 0); }
  public static void AddAngleVariabilityDeg(FlatBufferBuilder builder, byte angleVariabilityDeg) { builder.AddByte(3, angleVariabilityDeg, 0); }
  public static Offset<CozmoAnim.HeadAngle> EndHeadAngle(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<CozmoAnim.HeadAngle>(o);
  }
};


}
