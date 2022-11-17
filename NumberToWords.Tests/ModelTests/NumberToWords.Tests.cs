using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWords.Models;
using System;

namespace NumberToWords.Tests {
  [TestClass]
  public class NumberToAlphaTests
  {
    [TestMethod]
    public void Translate_CreateInstanceOfClass_True()
    {
      NumberToAlpha translate = new NumberToAlpha();
    }
  }
}
