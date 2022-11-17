using System.Collections.Generic;
using System;

namespace NumberToWords.Models  
{
  public class NumberToAlpha
  {
    public int numberToPass { get; set;}

    public NumberToAlpha(int number)
    {
      numberToPass = number;
    }
    
    private Dictionary <int, string> _numberWord = new Dictionary <int, string>()
    {
      {1,"one"},{2,"two"},{3,"three"},
      {4,"four"},{5,"five"},{6,"six"},
      {7,"seven"},{8,"eight"},{9,"nine"},
      {10,"ten"}
    };

    public string NumPasser()
    {
      string convertNum = "hans";
      return convertNum;
    }
  }
}