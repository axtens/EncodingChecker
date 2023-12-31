﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Greek.Windows_1253_GreekModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Greek
{
  public class Windows_1253_GreekModel : GreekModel
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
      (byte) 32,
      (byte) 46,
      (byte) 41,
      (byte) 40,
      (byte) 30,
      (byte) 52,
      (byte) 48,
      (byte) 42,
      (byte) 33,
      (byte) 56,
      (byte) 49,
      (byte) 39,
      (byte) 44,
      (byte) 36,
      (byte) 34,
      (byte) 47,
      (byte) 59,
      (byte) 35,
      (byte) 38,
      (byte) 37,
      (byte) 43,
      (byte) 54,
      (byte) 50,
      (byte) 58,
      (byte) 53,
      (byte) 57,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 32,
      (byte) 46,
      (byte) 41,
      (byte) 40,
      (byte) 30,
      (byte) 52,
      (byte) 48,
      (byte) 42,
      (byte) 33,
      (byte) 56,
      (byte) 49,
      (byte) 39,
      (byte) 44,
      (byte) 36,
      (byte) 34,
      (byte) 47,
      (byte) 59,
      (byte) 35,
      (byte) 38,
      (byte) 37,
      (byte) 43,
      (byte) 54,
      (byte) 50,
      (byte) 58,
      (byte) 53,
      (byte) 57,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 254,
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      byte.MaxValue,
      (byte) 253,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
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
      byte.MaxValue,
      (byte) 253,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      (byte) 253,
      (byte) 253,
      (byte) 17,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
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
      (byte) 253,
      (byte) 62,
      (byte) 253,
      (byte) 253,
      (byte) 19,
      (byte) 22,
      (byte) 15,
      (byte) 253,
      (byte) 16,
      (byte) 253,
      (byte) 24,
      (byte) 28,
      (byte) 55,
      (byte) 0,
      (byte) 25,
      (byte) 18,
      (byte) 20,
      (byte) 5,
      (byte) 29,
      (byte) 10,
      (byte) 26,
      (byte) 3,
      (byte) 8,
      (byte) 14,
      (byte) 13,
      (byte) 4,
      (byte) 31,
      (byte) 1,
      (byte) 11,
      (byte) 6,
      byte.MaxValue,
      (byte) 7,
      (byte) 2,
      (byte) 12,
      (byte) 27,
      (byte) 23,
      (byte) 45,
      (byte) 21,
      (byte) 51,
      (byte) 60,
      (byte) 17,
      (byte) 19,
      (byte) 22,
      (byte) 15,
      (byte) 61,
      (byte) 0,
      (byte) 25,
      (byte) 18,
      (byte) 20,
      (byte) 5,
      (byte) 29,
      (byte) 10,
      (byte) 26,
      (byte) 3,
      (byte) 8,
      (byte) 14,
      (byte) 13,
      (byte) 4,
      (byte) 31,
      (byte) 1,
      (byte) 11,
      (byte) 6,
      (byte) 9,
      (byte) 7,
      (byte) 2,
      (byte) 12,
      (byte) 27,
      (byte) 23,
      (byte) 45,
      (byte) 21,
      (byte) 51,
      (byte) 60,
      (byte) 16,
      (byte) 24,
      (byte) 28,
      byte.MaxValue
    };

    public Windows_1253_GreekModel()
      : base(Windows_1253_GreekModel.CHAR_TO_ORDER_MAP, "windows-1253")
    {
    }
  }
}
