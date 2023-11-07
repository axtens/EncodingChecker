﻿// Decompiled with JetBrains decompiler
// Type: UtfUnknown.Core.Models.SingleByte.Croatian.Ibm852_CroatianModel
// Assembly: EncodingChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FEDCF0FC-E3C6-4738-80E4-21B9D554C05E
// Assembly location: C:\Users\bugma\Downloads\P3a\P3\bin\Debug\net7.0\EncodingChecker.dll


#nullable enable
namespace UtfUnknown.Core.Models.SingleByte.Croatian
{
  public class Ibm852_CroatianModel : CroatianModel
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
      (byte) 20,
      (byte) 15,
      (byte) 2,
      (byte) 22,
      (byte) 17,
      (byte) 21,
      (byte) 1,
      (byte) 7,
      (byte) 9,
      (byte) 10,
      (byte) 12,
      (byte) 4,
      (byte) 3,
      (byte) 14,
      (byte) 30,
      (byte) 6,
      (byte) 8,
      (byte) 5,
      (byte) 11,
      (byte) 13,
      (byte) 28,
      (byte) 29,
      (byte) 27,
      (byte) 16,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 0,
      (byte) 19,
      (byte) 20,
      (byte) 15,
      (byte) 2,
      (byte) 22,
      (byte) 17,
      (byte) 21,
      (byte) 1,
      (byte) 7,
      (byte) 9,
      (byte) 10,
      (byte) 12,
      (byte) 4,
      (byte) 3,
      (byte) 14,
      (byte) 30,
      (byte) 6,
      (byte) 8,
      (byte) 5,
      (byte) 11,
      (byte) 13,
      (byte) 28,
      (byte) 29,
      (byte) 27,
      (byte) 16,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 254,
      (byte) 39,
      (byte) 33,
      (byte) 31,
      (byte) 43,
      (byte) 36,
      (byte) 249,
      (byte) 25,
      (byte) 39,
      (byte) 40,
      (byte) 47,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 36,
      (byte) 25,
      (byte) 31,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 32,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 32,
      (byte) 33,
      (byte) 249,
      (byte) 249,
      (byte) 40,
      (byte) 253,
      (byte) 18,
      (byte) 41,
      (byte) 249,
      (byte) 44,
      (byte) 48,
      (byte) 249,
      (byte) 249,
      (byte) 24,
      (byte) 24,
      (byte) 249,
      (byte) 249,
      (byte) 253,
      (byte) 249,
      (byte) 18,
      (byte) 249,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 41,
      (byte) 43,
      (byte) 249,
      (byte) 249,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 249,
      (byte) 249,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 249,
      (byte) 249,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 26,
      (byte) 26,
      (byte) 249,
      (byte) 47,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 253,
      (byte) 249,
      (byte) 249,
      (byte) 253,
      (byte) 44,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 23,
      (byte) 23,
      (byte) 249,
      (byte) 48,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 249,
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
      (byte) 249,
      (byte) 249,
      (byte) 249,
      (byte) 253,
      (byte) 253
    };

    public Ibm852_CroatianModel()
      : base(Ibm852_CroatianModel.CHAR_TO_ORDER_MAP, "ibm852")
    {
    }
  }
}
