﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Irish.Windows_1252_IrishModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Irish
{
  public class Windows_1252_IrishModel : IrishModel
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
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      (byte) 75,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 34,
      (byte) 253,
      (byte) 76,
      byte.MaxValue,
      (byte) 77,
      byte.MaxValue,
      byte.MaxValue,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 34,
      (byte) 253,
      (byte) 78,
      byte.MaxValue,
      (byte) 79,
      (byte) 80,
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
      (byte) 81,
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
      (byte) 82,
      (byte) 14,
      (byte) 83,
      (byte) 84,
      (byte) 33,
      (byte) 85,
      (byte) 86,
      (byte) 39,
      (byte) 35,
      (byte) 18,
      (byte) 42,
      (byte) 37,
      (byte) 87,
      (byte) 17,
      (byte) 88,
      (byte) 40,
      (byte) 89,
      (byte) 32,
      (byte) 43,
      (byte) 22,
      (byte) 90,
      (byte) 91,
      (byte) 38,
      (byte) 253,
      (byte) 36,
      (byte) 92,
      (byte) 20,
      (byte) 93,
      (byte) 31,
      (byte) 94,
      (byte) 95,
      (byte) 96,
      (byte) 97,
      (byte) 14,
      (byte) 98,
      (byte) 99,
      (byte) 33,
      (byte) 100,
      (byte) 101,
      (byte) 39,
      (byte) 35,
      (byte) 18,
      (byte) 42,
      (byte) 37,
      (byte) 102,
      (byte) 17,
      (byte) 103,
      (byte) 40,
      (byte) 104,
      (byte) 32,
      (byte) 43,
      (byte) 22,
      (byte) 105,
      (byte) 106,
      (byte) 38,
      (byte) 253,
      (byte) 36,
      (byte) 107,
      (byte) 20,
      (byte) 108,
      (byte) 31,
      (byte) 109,
      (byte) 110,
      (byte) 111
    };

    public Windows_1252_IrishModel()
      : base(Windows_1252_IrishModel.CHAR_TO_ORDER_MAP, "windows-1252")
    {
    }
  }
}
