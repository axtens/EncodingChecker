﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Hungarian.Windows_1250_HungarianModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Hungarian
{
  public class Windows_1250_HungarianModel : HungarianModel
  {
    private static readonly byte[] CHAR_TO_ORDER_MAP = new byte[256]
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
      (byte) 1,
      (byte) 15,
      (byte) 23,
      (byte) 16,
      (byte) 0,
      (byte) 24,
      (byte) 13,
      (byte) 20,
      (byte) 7,
      (byte) 22,
      (byte) 9,
      (byte) 4,
      (byte) 12,
      (byte) 6,
      (byte) 8,
      (byte) 21,
      (byte) 34,
      (byte) 5,
      (byte) 3,
      (byte) 2,
      (byte) 19,
      (byte) 17,
      (byte) 32,
      (byte) 33,
      (byte) 18,
      (byte) 10,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 1,
      (byte) 15,
      (byte) 23,
      (byte) 16,
      (byte) 0,
      (byte) 24,
      (byte) 13,
      (byte) 20,
      (byte) 7,
      (byte) 22,
      (byte) 9,
      (byte) 4,
      (byte) 12,
      (byte) 6,
      (byte) 8,
      (byte) 21,
      (byte) 34,
      (byte) 5,
      (byte) 3,
      (byte) 2,
      (byte) 19,
      (byte) 17,
      (byte) 32,
      (byte) 33,
      (byte) 18,
      (byte) 10,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 254,
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      (byte) 37,
      (byte) 253,
      (byte) 46,
      (byte) 78,
      (byte) 48,
      (byte) 79,
      byte.MaxValue,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      (byte) 37,
      (byte) 253,
      (byte) 46,
      (byte) 80,
      (byte) 48,
      (byte) 81,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 42,
      (byte) 253,
      (byte) 82,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 52,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 83,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 42,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 84,
      (byte) 52,
      (byte) 253,
      (byte) 85,
      (byte) 253,
      (byte) 86,
      (byte) 87,
      (byte) 88,
      (byte) 11,
      (byte) 40,
      (byte) 36,
      (byte) 35,
      (byte) 89,
      (byte) 38,
      (byte) 39,
      (byte) 41,
      (byte) 14,
      (byte) 50,
      (byte) 90,
      (byte) 53,
      (byte) 28,
      (byte) 45,
      (byte) 91,
      (byte) 49,
      (byte) 43,
      (byte) 54,
      (byte) 26,
      (byte) 92,
      (byte) 27,
      (byte) 25,
      (byte) 253,
      (byte) 44,
      (byte) 93,
      (byte) 30,
      (byte) 31,
      (byte) 29,
      (byte) 47,
      (byte) 51,
      (byte) 94,
      (byte) 95,
      (byte) 11,
      (byte) 40,
      (byte) 36,
      (byte) 35,
      (byte) 96,
      (byte) 38,
      (byte) 39,
      (byte) 41,
      (byte) 14,
      (byte) 50,
      (byte) 97,
      (byte) 53,
      (byte) 28,
      (byte) 45,
      (byte) 98,
      (byte) 49,
      (byte) 43,
      (byte) 54,
      (byte) 26,
      (byte) 99,
      (byte) 27,
      (byte) 25,
      (byte) 253,
      (byte) 44,
      (byte) 100,
      (byte) 30,
      (byte) 31,
      (byte) 29,
      (byte) 47,
      (byte) 51,
      (byte) 253
    };

    public Windows_1250_HungarianModel()
      : base(Windows_1250_HungarianModel.CHAR_TO_ORDER_MAP, "windows-1250")
    {
    }
  }
}
