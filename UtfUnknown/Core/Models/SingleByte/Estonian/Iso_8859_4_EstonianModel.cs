﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Estonian.Iso_8859_4_EstonianModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Estonian
{
  public class Iso_8859_4_EstonianModel : EstonianModel
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
      (byte) 23,
      (byte) 10,
      (byte) 2,
      (byte) 22,
      (byte) 15,
      (byte) 16,
      (byte) 1,
      (byte) 17,
      (byte) 8,
      (byte) 5,
      (byte) 12,
      (byte) 7,
      (byte) 9,
      (byte) 14,
      (byte) 28,
      (byte) 11,
      (byte) 3,
      (byte) 4,
      (byte) 6,
      (byte) 13,
      (byte) 27,
      (byte) 26,
      (byte) 25,
      (byte) 30,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 0,
      (byte) 19,
      (byte) 23,
      (byte) 10,
      (byte) 2,
      (byte) 22,
      (byte) 15,
      (byte) 16,
      (byte) 1,
      (byte) 17,
      (byte) 8,
      (byte) 5,
      (byte) 12,
      (byte) 7,
      (byte) 9,
      (byte) 14,
      (byte) 28,
      (byte) 11,
      (byte) 3,
      (byte) 4,
      (byte) 6,
      (byte) 13,
      (byte) 27,
      (byte) 26,
      (byte) 25,
      (byte) 30,
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
      (byte) 55,
      (byte) 56,
      (byte) 57,
      (byte) 253,
      (byte) 58,
      (byte) 59,
      (byte) 253,
      (byte) 253,
      (byte) 29,
      (byte) 45,
      (byte) 60,
      (byte) 61,
      (byte) 253,
      (byte) 32,
      (byte) 253,
      (byte) 253,
      (byte) 62,
      (byte) 253,
      (byte) 63,
      (byte) 253,
      (byte) 64,
      (byte) 65,
      (byte) 253,
      (byte) 253,
      (byte) 29,
      (byte) 45,
      (byte) 66,
      (byte) 67,
      (byte) 68,
      (byte) 32,
      (byte) 69,
      (byte) 37,
      (byte) 43,
      (byte) 70,
      (byte) 71,
      (byte) 18,
      (byte) 44,
      (byte) 47,
      (byte) 72,
      (byte) 73,
      (byte) 33,
      (byte) 74,
      (byte) 75,
      (byte) 76,
      (byte) 36,
      (byte) 77,
      (byte) 39,
      (byte) 78,
      (byte) 79,
      (byte) 31,
      (byte) 80,
      (byte) 81,
      (byte) 20,
      (byte) 24,
      (byte) 253,
      (byte) 38,
      (byte) 82,
      (byte) 52,
      (byte) 83,
      (byte) 21,
      (byte) 84,
      (byte) 34,
      (byte) 85,
      (byte) 37,
      (byte) 43,
      (byte) 86,
      (byte) 87,
      (byte) 18,
      (byte) 44,
      (byte) 47,
      (byte) 88,
      (byte) 89,
      (byte) 33,
      (byte) 90,
      (byte) 91,
      (byte) 92,
      (byte) 36,
      (byte) 93,
      (byte) 39,
      (byte) 94,
      (byte) 95,
      (byte) 31,
      (byte) 96,
      (byte) 97,
      (byte) 20,
      (byte) 24,
      (byte) 253,
      (byte) 38,
      (byte) 98,
      (byte) 52,
      (byte) 99,
      (byte) 21,
      (byte) 100,
      (byte) 34,
      (byte) 253
    };

    public Iso_8859_4_EstonianModel()
      : base(Iso_8859_4_EstonianModel.CHAR_TO_ORDER_MAP, "iso-8859-4")
    {
    }
  }
}
