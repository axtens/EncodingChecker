﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Vietnamese.Viscii_VietnameseModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Vietnamese
{
  public class Viscii_VietnameseModel : VietnameseModel
  {
    private static byte[] CHAR_TO_ORDER_MAP = new byte[256]
    {
      (byte) 254,
      (byte) 254,
      (byte) 88,
      (byte) 254,
      (byte) 254,
      (byte) 95,
      (byte) 77,
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
      (byte) 80,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 79,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 254,
      (byte) 92,
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
      (byte) 6,
      (byte) 17,
      (byte) 3,
      (byte) 22,
      (byte) 21,
      (byte) 66,
      (byte) 5,
      (byte) 1,
      (byte) 4,
      (byte) 75,
      (byte) 24,
      (byte) 14,
      (byte) 8,
      (byte) 0,
      (byte) 9,
      (byte) 16,
      (byte) 36,
      (byte) 11,
      (byte) 19,
      (byte) 2,
      (byte) 7,
      (byte) 13,
      (byte) 69,
      (byte) 54,
      (byte) 20,
      (byte) 82,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 6,
      (byte) 17,
      (byte) 3,
      (byte) 22,
      (byte) 21,
      (byte) 66,
      (byte) 5,
      (byte) 1,
      (byte) 4,
      (byte) 75,
      (byte) 24,
      (byte) 14,
      (byte) 8,
      (byte) 0,
      (byte) 9,
      (byte) 16,
      (byte) 36,
      (byte) 11,
      (byte) 19,
      (byte) 2,
      (byte) 7,
      (byte) 13,
      (byte) 69,
      (byte) 54,
      (byte) 20,
      (byte) 82,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 254,
      (byte) 30,
      (byte) 57,
      (byte) 71,
      (byte) 65,
      (byte) 41,
      (byte) 43,
      (byte) 78,
      (byte) 49,
      (byte) 83,
      (byte) 89,
      (byte) 23,
      (byte) 45,
      (byte) 39,
      (byte) 74,
      (byte) 28,
      (byte) 32,
      (byte) 53,
      (byte) 60,
      (byte) 84,
      (byte) 31,
      (byte) 37,
      (byte) 40,
      (byte) 38,
      (byte) 59,
      (byte) 42,
      (byte) 81,
      (byte) 44,
      (byte) 73,
      (byte) 35,
      (byte) 72,
      (byte) 48,
      (byte) 76,
      (byte) 86,
      (byte) 57,
      (byte) 71,
      (byte) 65,
      (byte) 41,
      (byte) 43,
      (byte) 78,
      (byte) 49,
      (byte) 83,
      (byte) 89,
      (byte) 23,
      (byte) 45,
      (byte) 39,
      (byte) 74,
      (byte) 28,
      (byte) 32,
      (byte) 53,
      (byte) 60,
      (byte) 84,
      (byte) 87,
      (byte) 46,
      (byte) 31,
      (byte) 38,
      (byte) 59,
      (byte) 42,
      (byte) 56,
      (byte) 52,
      (byte) 55,
      (byte) 70,
      (byte) 46,
      (byte) 40,
      (byte) 18,
      (byte) 12,
      (byte) 15,
      (byte) 25,
      (byte) 61,
      (byte) 34,
      (byte) 51,
      (byte) 88,
      (byte) 95,
      (byte) 90,
      (byte) 62,
      (byte) 27,
      (byte) 85,
      (byte) 50,
      (byte) 47,
      (byte) 64,
      (byte) 76,
      (byte) 10,
      (byte) 52,
      (byte) 63,
      (byte) 33,
      (byte) 29,
      (byte) 30,
      (byte) 80,
      (byte) 55,
      (byte) 70,
      (byte) 58,
      (byte) 67,
      (byte) 79,
      (byte) 92,
      (byte) 68,
      (byte) 87,
      (byte) 18,
      (byte) 12,
      (byte) 15,
      (byte) 25,
      (byte) 61,
      (byte) 34,
      (byte) 51,
      (byte) 26,
      (byte) 77,
      (byte) 90,
      (byte) 62,
      (byte) 27,
      (byte) 85,
      (byte) 50,
      (byte) 47,
      (byte) 64,
      (byte) 73,
      (byte) 10,
      (byte) 56,
      (byte) 63,
      (byte) 33,
      (byte) 29,
      (byte) 86,
      (byte) 81,
      (byte) 44,
      (byte) 48,
      (byte) 58,
      (byte) 67,
      (byte) 72,
      (byte) 35,
      (byte) 68,
      (byte) 37,
      (byte) 26
    };

    public Viscii_VietnameseModel()
      : base(Viscii_VietnameseModel.CHAR_TO_ORDER_MAP, "viscii")
    {
    }
  }
}
