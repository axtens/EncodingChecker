﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Swedish.Iso_8859_4_SwedishModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Swedish
{
  public class Iso_8859_4_SwedishModel : SwedishModel
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
      (byte) 22,
      (byte) 20,
      (byte) 9,
      (byte) 1,
      (byte) 14,
      (byte) 12,
      (byte) 18,
      (byte) 6,
      (byte) 23,
      (byte) 10,
      (byte) 7,
      (byte) 11,
      (byte) 3,
      (byte) 8,
      (byte) 15,
      (byte) 30,
      (byte) 2,
      (byte) 5,
      (byte) 4,
      (byte) 16,
      (byte) 13,
      (byte) 26,
      (byte) 25,
      (byte) 24,
      (byte) 27,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 0,
      (byte) 22,
      (byte) 20,
      (byte) 9,
      (byte) 1,
      (byte) 14,
      (byte) 12,
      (byte) 18,
      (byte) 6,
      (byte) 23,
      (byte) 10,
      (byte) 7,
      (byte) 11,
      (byte) 3,
      (byte) 8,
      (byte) 15,
      (byte) 30,
      (byte) 2,
      (byte) 5,
      (byte) 4,
      (byte) 16,
      (byte) 13,
      (byte) 26,
      (byte) 25,
      (byte) 24,
      (byte) 27,
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
      (byte) 165,
      (byte) 166,
      (byte) 167,
      (byte) 253,
      (byte) 168,
      (byte) 169,
      (byte) 253,
      (byte) 253,
      (byte) 170,
      (byte) 171,
      (byte) 172,
      (byte) 173,
      (byte) 253,
      (byte) 174,
      (byte) 253,
      (byte) 253,
      (byte) 175,
      (byte) 253,
      (byte) 176,
      (byte) 253,
      (byte) 177,
      (byte) 178,
      (byte) 253,
      (byte) 253,
      (byte) 179,
      (byte) 180,
      (byte) 181,
      (byte) 182,
      (byte) 43,
      (byte) 183,
      (byte) 43,
      (byte) 29,
      (byte) 44,
      (byte) 184,
      (byte) 185,
      (byte) 17,
      (byte) 19,
      (byte) 38,
      (byte) 186,
      (byte) 187,
      (byte) 28,
      (byte) 188,
      (byte) 189,
      (byte) 39,
      (byte) 190,
      (byte) 47,
      (byte) 41,
      (byte) 191,
      (byte) 192,
      (byte) 33,
      (byte) 193,
      (byte) 35,
      (byte) 194,
      (byte) 21,
      (byte) 253,
      (byte) 37,
      (byte) 36,
      (byte) 195,
      (byte) 196,
      (byte) 31,
      (byte) 197,
      (byte) 46,
      (byte) 198,
      (byte) 29,
      (byte) 44,
      (byte) 199,
      (byte) 200,
      (byte) 17,
      (byte) 19,
      (byte) 38,
      (byte) 201,
      (byte) 202,
      (byte) 28,
      (byte) 203,
      (byte) 204,
      (byte) 39,
      (byte) 205,
      (byte) 47,
      (byte) 41,
      (byte) 206,
      (byte) 207,
      (byte) 33,
      (byte) 208,
      (byte) 35,
      (byte) 209,
      (byte) 21,
      (byte) 253,
      (byte) 37,
      (byte) 36,
      (byte) 210,
      (byte) 211,
      (byte) 31,
      (byte) 212,
      (byte) 46,
      (byte) 253
    };

    public Iso_8859_4_SwedishModel()
      : base(Iso_8859_4_SwedishModel.CHAR_TO_ORDER_MAP, "iso-8859-4")
    {
    }
  }
}
