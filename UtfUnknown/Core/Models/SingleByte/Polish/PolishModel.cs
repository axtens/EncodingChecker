﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Polish.PolishModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Polish
{
  public abstract class PolishModel : SequenceModel
  {
    private static byte[] LANG_MODEL = new byte[1369]
    {
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 1,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 1,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 1,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 1,
      (byte) 1,
      (byte) 3,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 1,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 1,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 1,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 1,
      (byte) 1,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 1,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 3,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 1,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 1,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 2,
      (byte) 0,
      (byte) 2,
      (byte) 1,
      (byte) 2,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 2,
      (byte) 1,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };

    public PolishModel(byte[] charToOrderMap, string name)
      : base(charToOrderMap, PolishModel.LANG_MODEL, 37, 0.9894532f, true, name)
    {
    }
  }
}
