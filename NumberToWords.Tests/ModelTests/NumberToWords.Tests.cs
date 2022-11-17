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
      NumberToAlpha translate = new NumberToAlpha(0);
    }
    [TestMethod]
    public void Translate_TakesIntergerArgument_Interger()
    {
      // Arrange
      int numInput = 5;
      NumberToAlpha translate = new NumberToAlpha(numInput);
      // Act
      // Assert
      Assert.AreEqual(numInput,translate.numberToPass);
    }
    [TestMethod]
    public void Translate_ReturnsStringFromInt_String()
    {
      int numInput = 28;
      string numToString = "twenty eight";
      NumberToAlpha translate = new NumberToAlpha(numInput);
      Assert.AreEqual(numToString, translate.NumPasser());
    }
  }
}