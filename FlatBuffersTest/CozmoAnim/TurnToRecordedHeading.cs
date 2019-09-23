// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace CozmoAnim
{

using global::System;
using global::FlatBuffers;

public struct TurnToRecordedHeading : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static TurnToRecordedHeading GetRootAsTurnToRecordedHeading(ByteBuffer _bb) { return GetRootAsTurnToRecordedHeading(_bb, new TurnToRecordedHeading()); }
  public static TurnToRecordedHeading GetRootAsTurnToRecordedHeading(ByteBuffer _bb, TurnToRecordedHeading obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TurnToRecordedHeading __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint TriggerTimeMs { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint DurationTimeMs { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public short OffsetDeg { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public short SpeedDegPerSec { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public short AccelDegPerSec2 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)1000; } }
  public short DecelDegPerSec2 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)1000; } }
  public ushort ToleranceDeg { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)2; } }
  public ushort NumHalfRevs { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public bool UseShortestDir { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<CozmoAnim.TurnToRecordedHeading> CreateTurnToRecordedHeading(FlatBufferBuilder builder,
      uint triggerTime_ms = 0,
      uint durationTime_ms = 0,
      short offset_deg = 0,
      short speed_degPerSec = 0,
      short accel_degPerSec2 = 1000,
      short decel_degPerSec2 = 1000,
      ushort tolerance_deg = 2,
      ushort numHalfRevs = 0,
      bool useShortestDir = false) {
    builder.StartTable(9);
    TurnToRecordedHeading.AddDurationTimeMs(builder, durationTime_ms);
    TurnToRecordedHeading.AddTriggerTimeMs(builder, triggerTime_ms);
    TurnToRecordedHeading.AddNumHalfRevs(builder, numHalfRevs);
    TurnToRecordedHeading.AddToleranceDeg(builder, tolerance_deg);
    TurnToRecordedHeading.AddDecelDegPerSec2(builder, decel_degPerSec2);
    TurnToRecordedHeading.AddAccelDegPerSec2(builder, accel_degPerSec2);
    TurnToRecordedHeading.AddSpeedDegPerSec(builder, speed_degPerSec);
    TurnToRecordedHeading.AddOffsetDeg(builder, offset_deg);
    TurnToRecordedHeading.AddUseShortestDir(builder, useShortestDir);
    return TurnToRecordedHeading.EndTurnToRecordedHeading(builder);
  }

  public static void StartTurnToRecordedHeading(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddTriggerTimeMs(FlatBufferBuilder builder, uint triggerTimeMs) { builder.AddUint(0, triggerTimeMs, 0); }
  public static void AddDurationTimeMs(FlatBufferBuilder builder, uint durationTimeMs) { builder.AddUint(1, durationTimeMs, 0); }
  public static void AddOffsetDeg(FlatBufferBuilder builder, short offsetDeg) { builder.AddShort(2, offsetDeg, 0); }
  public static void AddSpeedDegPerSec(FlatBufferBuilder builder, short speedDegPerSec) { builder.AddShort(3, speedDegPerSec, 0); }
  public static void AddAccelDegPerSec2(FlatBufferBuilder builder, short accelDegPerSec2) { builder.AddShort(4, accelDegPerSec2, 1000); }
  public static void AddDecelDegPerSec2(FlatBufferBuilder builder, short decelDegPerSec2) { builder.AddShort(5, decelDegPerSec2, 1000); }
  public static void AddToleranceDeg(FlatBufferBuilder builder, ushort toleranceDeg) { builder.AddUshort(6, toleranceDeg, 2); }
  public static void AddNumHalfRevs(FlatBufferBuilder builder, ushort numHalfRevs) { builder.AddUshort(7, numHalfRevs, 0); }
  public static void AddUseShortestDir(FlatBufferBuilder builder, bool useShortestDir) { builder.AddBool(8, useShortestDir, false); }
  public static Offset<CozmoAnim.TurnToRecordedHeading> EndTurnToRecordedHeading(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<CozmoAnim.TurnToRecordedHeading>(o);
  }
};


}