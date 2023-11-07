﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Irish.Iso_8859_9_IrishModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Irish
{
  public class Iso_8859_9_IrishModel : IrishModel
  {
    private static byte[] CHAR_TO_ORDER_MAP = new byte[256]
    {
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 252,
      (byte) 254,
      (byte) 254,
      (byte) 252,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 251,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 0,
      (byte) 16,
      (byte) 8,
      (byte) 11,
      (byte) 5,
      (byte) 19,
      (byte) 12,
      (byte) 3,
      (byte) 1,
      (byte) 27,
      (byte) 25,
      (byte) 9,
      (byte) 13,
      (byte) 2,
      (byte) 10,
      (byte) 21,
      (byte) 30,
      (byte) 4,
      (byte) 6,
      (byte) 7,
      (byte) 15,
      (byte) 23,
      (byte) 26,
      (byte) 29,
      (byte) 24,
      (byte) 28,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 0,
      (byte) 16,
      (byte) 8,
      (byte) 11,
      (byte) 5,
      (byte) 19,
      (byte) 12,
      (byte) 3,
      (byte) 1,
      (byte) 27,
      (byte) 25,
      (byte) 9,
      (byte) 13,
      (byte) 2,
      (byte) 10,
      (byte) 21,
      (byte) 30,
      (byte) 4,
      (byte) 6,
      (byte) 7,
      (byte) 15,
      (byte) 23,
      (byte) 26,
      (byte) 29,
      (byte) 24,
      (byte) 28,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 148,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 149,
      (byte) 14,
      (byte) 150,
      (byte) 151,
      (byte) 33,
      (byte) 152,
      (byte) 153,
      (byte) 39,
      (byte) 35,
      (byte) 18,
      (byte) 42,
      (byte) 37,
      (byte) 154,
      (byte) 17,
      (byte) 155,
      (byte) 40,
      (byte) 156,
      (byte) 32,
      (byte) 43,
      (byte) 22,
      (byte) 157,
      (byte) 158,
      (byte) 38,
      (byte) 253,
      (byte) 36,
      (byte) 159,
      (byte) 20,
      (byte) 160,
      (byte) 31,
      (byte) 161,
      (byte) 162,
      (byte) 163,
      (byte) 164,
      (byte) 14,
      (byte) 165,
      (byte) 166,
      (byte) 33,
      (byte) 167,
      (byte) 168,
      (byte) 39,
      (byte) 35,
      (byte) 18,
      (byte) 42,
      (byte) 37,
      (byte) 169,
      (byte) 17,
      (byte) 170,
      (byte) 40,
      (byte) 171,
      (byte) 32,
      (byte) 43,
      (byte) 22,
      (byte) 172,
      (byte) 173,
      (byte) 38,
      (byte) 253,
      (byte) 36,
      (byte) 174,
      (byte) 20,
      (byte) 175,
      (byte) 31,
      (byte) 41,
      (byte) 176,
      (byte) 177
    };

    public Iso_8859_9_IrishModel()
      : base(Iso_8859_9_IrishModel.CHAR_TO_ORDER_MAP, "iso-8859-9")
    {
    }
  }
}