﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Finnish.Iso_8859_9_FinnishModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Finnish
{
  public class Iso_8859_9_FinnishModel : FinnishModel
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
      (byte) 108,
      (byte) 109,
      (byte) 47,
      (byte) 253,
      (byte) 110,
      (byte) 111,
      (byte) 253,
      (byte) 253,
      (byte) 27,
      (byte) 112,
      (byte) 113,
      (byte) 114,
      (byte) 253,
      (byte) 28,
      (byte) 253,
      (byte) 253,
      (byte) 115,
      (byte) 253,
      (byte) 47,
      (byte) 253,
      (byte) 116,
      (byte) 117,
      (byte) 253,
      (byte) 253,
      (byte) 27,
      (byte) 118,
      (byte) 119,
      (byte) 120,
      (byte) 45,
      (byte) 28,
      (byte) 45,
      (byte) 53,
      (byte) 35,
      (byte) 121,
      (byte) 46,
      (byte) 11,
      (byte) 56,
      (byte) 39,
      (byte) 122,
      (byte) 43,
      (byte) 30,
      (byte) 123,
      (byte) 31,
      (byte) 124,
      (byte) 36,
      (byte) 125,
      (byte) 126,
      (byte) 127,
      (byte) 54,
      (byte) 128,
      (byte) 129,
      (byte) 34,
      (byte) 59,
      (byte) 22,
      (byte) 253,
      (byte) 130,
      (byte) 131,
      (byte) 38,
      (byte) 132,
      (byte) 32,
      (byte) 133,
      (byte) 134,
      (byte) 55,
      (byte) 53,
      (byte) 35,
      (byte) 135,
      (byte) 46,
      (byte) 11,
      (byte) 56,
      (byte) 39,
      (byte) 136,
      (byte) 43,
      (byte) 30,
      (byte) 137,
      (byte) 31,
      (byte) 138,
      (byte) 36,
      (byte) 139,
      (byte) 140,
      (byte) 141,
      (byte) 54,
      (byte) 142,
      (byte) 143,
      (byte) 34,
      (byte) 59,
      (byte) 22,
      (byte) 253,
      (byte) 144,
      (byte) 145,
      (byte) 38,
      (byte) 146,
      (byte) 32,
      (byte) 147,
      (byte) 148,
      (byte) 253
    };

    public Iso_8859_9_FinnishModel()
      : base(Iso_8859_9_FinnishModel.CHAR_TO_ORDER_MAP, "iso-8859-9")
    {
    }
  }
}
