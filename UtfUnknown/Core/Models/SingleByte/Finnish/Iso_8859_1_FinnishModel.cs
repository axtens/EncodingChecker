﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Finnish.Iso_8859_1_FinnishModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Finnish
{
  public class Iso_8859_1_FinnishModel : FinnishModel
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
      (byte) 19,
      (byte) 21,
      (byte) 18,
      (byte) 4,
      (byte) 23,
      (byte) 20,
      (byte) 14,
      (byte) 1,
      (byte) 15,
      (byte) 9,
      (byte) 6,
      (byte) 12,
      (byte) 2,
      (byte) 7,
      (byte) 16,
      (byte) 29,
      (byte) 10,
      (byte) 5,
      (byte) 3,
      (byte) 8,
      (byte) 13,
      (byte) 24,
      (byte) 26,
      (byte) 17,
      (byte) 25,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 0,
      (byte) 19,
      (byte) 21,
      (byte) 18,
      (byte) 4,
      (byte) 23,
      (byte) 20,
      (byte) 14,
      (byte) 1,
      (byte) 15,
      (byte) 9,
      (byte) 6,
      (byte) 12,
      (byte) 2,
      (byte) 7,
      (byte) 16,
      (byte) 29,
      (byte) 10,
      (byte) 5,
      (byte) 3,
      (byte) 8,
      (byte) 13,
      (byte) 24,
      (byte) 26,
      (byte) 17,
      (byte) 25,
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
      (byte) 197,
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
      (byte) 49,
      (byte) 35,
      (byte) 198,
      (byte) 46,
      (byte) 11,
      (byte) 56,
      (byte) 39,
      (byte) 37,
      (byte) 40,
      (byte) 30,
      (byte) 51,
      (byte) 31,
      (byte) 199,
      (byte) 36,
      (byte) 200,
      (byte) 57,
      (byte) 201,
      (byte) 58,
      (byte) 52,
      (byte) 33,
      (byte) 34,
      (byte) 59,
      (byte) 22,
      (byte) 253,
      (byte) 202,
      (byte) 203,
      (byte) 38,
      (byte) 204,
      (byte) 32,
      (byte) 205,
      (byte) 206,
      (byte) 55,
      (byte) 49,
      (byte) 35,
      (byte) 207,
      (byte) 46,
      (byte) 11,
      (byte) 56,
      (byte) 39,
      (byte) 37,
      (byte) 40,
      (byte) 30,
      (byte) 51,
      (byte) 31,
      (byte) 208,
      (byte) 36,
      (byte) 209,
      (byte) 57,
      (byte) 210,
      (byte) 58,
      (byte) 52,
      (byte) 33,
      (byte) 34,
      (byte) 59,
      (byte) 22,
      (byte) 253,
      (byte) 211,
      (byte) 212,
      (byte) 38,
      (byte) 213,
      (byte) 32,
      (byte) 214,
      (byte) 215,
      (byte) 216
    };

    public Iso_8859_1_FinnishModel()
      : base(Iso_8859_1_FinnishModel.CHAR_TO_ORDER_MAP, "iso-8859-1")
    {
    }
  }
}
