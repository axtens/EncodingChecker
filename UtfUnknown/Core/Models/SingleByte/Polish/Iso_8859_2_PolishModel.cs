﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Polish.Iso_8859_2_PolishModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Polish
{
  public class Iso_8859_2_PolishModel : PolishModel
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
      (byte) 20,
      (byte) 11,
      (byte) 14,
      (byte) 3,
      (byte) 26,
      (byte) 21,
      (byte) 22,
      (byte) 1,
      (byte) 18,
      (byte) 7,
      (byte) 15,
      (byte) 16,
      (byte) 5,
      (byte) 2,
      (byte) 13,
      (byte) 36,
      (byte) 4,
      (byte) 6,
      (byte) 10,
      (byte) 17,
      (byte) 31,
      (byte) 9,
      (byte) 33,
      (byte) 12,
      (byte) 8,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 0,
      (byte) 20,
      (byte) 11,
      (byte) 14,
      (byte) 3,
      (byte) 26,
      (byte) 21,
      (byte) 22,
      (byte) 1,
      (byte) 18,
      (byte) 7,
      (byte) 15,
      (byte) 16,
      (byte) 5,
      (byte) 2,
      (byte) 13,
      (byte) 36,
      (byte) 4,
      (byte) 6,
      (byte) 10,
      (byte) 17,
      (byte) 31,
      (byte) 9,
      (byte) 33,
      (byte) 12,
      (byte) 8,
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
      (byte) 25,
      (byte) 253,
      (byte) 19,
      (byte) 253,
      (byte) 74,
      (byte) 28,
      (byte) 253,
      (byte) 253,
      (byte) 41,
      (byte) 56,
      (byte) 76,
      (byte) 32,
      (byte) 253,
      (byte) 45,
      (byte) 27,
      (byte) 253,
      (byte) 25,
      (byte) 253,
      (byte) 19,
      (byte) 253,
      (byte) 74,
      (byte) 28,
      (byte) 253,
      (byte) 253,
      (byte) 41,
      (byte) 56,
      (byte) 76,
      (byte) 32,
      (byte) 253,
      (byte) 45,
      (byte) 27,
      (byte) 100,
      (byte) 35,
      (byte) 54,
      (byte) 53,
      (byte) 40,
      (byte) 101,
      (byte) 30,
      (byte) 47,
      (byte) 44,
      (byte) 34,
      (byte) 23,
      (byte) 58,
      (byte) 46,
      (byte) 37,
      (byte) 77,
      (byte) 69,
      (byte) 70,
      (byte) 29,
      (byte) 102,
      (byte) 24,
      (byte) 55,
      (byte) 49,
      (byte) 38,
      (byte) 253,
      (byte) 50,
      (byte) 103,
      (byte) 51,
      (byte) 104,
      (byte) 39,
      (byte) 60,
      (byte) 65,
      (byte) 57,
      (byte) 105,
      (byte) 35,
      (byte) 54,
      (byte) 53,
      (byte) 40,
      (byte) 106,
      (byte) 30,
      (byte) 47,
      (byte) 44,
      (byte) 34,
      (byte) 23,
      (byte) 58,
      (byte) 46,
      (byte) 37,
      (byte) 77,
      (byte) 69,
      (byte) 70,
      (byte) 29,
      (byte) 107,
      (byte) 24,
      (byte) 55,
      (byte) 49,
      (byte) 38,
      (byte) 253,
      (byte) 50,
      (byte) 108,
      (byte) 51,
      (byte) 109,
      (byte) 39,
      (byte) 60,
      (byte) 65,
      (byte) 253
    };

    public Iso_8859_2_PolishModel()
      : base(Iso_8859_2_PolishModel.CHAR_TO_ORDER_MAP, "iso-8859-2")
    {
    }
  }
}
