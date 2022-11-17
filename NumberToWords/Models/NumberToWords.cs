using System;

namespace NumberToWords.Models  
{
  public class NumberToAlpha
  {
    public int numberToPass { get; set; }

    public NumberToAlpha(int number)
    {
      numberToPass = number;
    }
  }
}