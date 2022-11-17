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
    [TestMethod]
    public void Translate_TakesIntergerArgument_Interger()
    {
      // Arrange
      int numInput = 5;
      NumberToAlpha translate = new NumberToAlpha(numInput);
      // Act

      // Assert
      Assert.AreEqual(typeof(int),numInput.GetType());
    }
  }
}
