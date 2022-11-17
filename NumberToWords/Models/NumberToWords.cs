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
    
    private Dictionary <int, string> _numberUnits = new Dictionary <int, string>()
    {
      {1,"one"},{2,"two"},{3,"three"},
      {4,"four"},{5,"five"},{6,"six"},
      {7,"seven"},{8,"eight"},{9,"nine"},
      {10,"ten"}
    };

    private Dictionary <int, string> _numberTeens = new Dictionary <int, string>()
    {
      {11,"eleven"},{12,"twelve"},{13,"thirteen"},
      {14,"fourteen"},{15,"fifteen"},{16,"sixteen"},
      {17,"seventeen"},{18,"eighteen"},{19,"nineteen"},
    };

    private Dictionary <int, string> _numberTens = new Dictionary <int, string>()
    {
      {2,"twenty "},{3,"thirty "},
      {4,"fourty "},{5,"fifty "},{6,"sixty "},
      {7,"seventy "},{8,"eighty "},{9,"ninety "},
      {10,"ten"}
    };

    public string NumPasser()
    {
      string convertNum;
      if(numberToPass > 10)
      {
        if(numberToPass > 19)
        {
          string brokenNumber = numberToPass.ToString();

          int tens = int.Parse(brokenNumber[0].ToString());
          int Units = int.Parse(brokenNumber[1].ToString());

          convertNum = _numberTens[tens];
          try
          {
            convertNum += _numberUnits[Units];
          }
          catch{}
        }

        else
        {
        convertNum = _numberTeens[numberToPass];
        }
      }
      
      else
      {
      convertNum = _numberUnits[numberToPass];
      }

      return convertNum;
    }
  }
}