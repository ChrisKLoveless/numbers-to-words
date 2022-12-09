using System;
using System.Collections.Generic;

namespace ToWord
{
  public class WordFromNum
  {
    public int Number { get; set; }
    public string Word { get; set; }
    
    public WordFromNum(int number)
    {
      Number = number;
    }

    public void AddWord(string word)
    {
      Word += word; //adds to complexity of number
    }

    private Dictionary<int, string> SingleDigit = new Dictionary<int, string> () {{1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};
    private Dictionary<int, string> TeenDigit = new Dictionary<int, string> () {{10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}};
    private Dictionary<int, string> DoubleDigit = new Dictionary<int, string> () {{2, "twenty"}, {3, "thirty"}, {4, "forty"}, {5, "fifty"}, {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"}};

  //   public static string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    public string ReadSingleDigit()
    {
      return SingleDigit[this.Number];
    }

    public string ReadTeenDigit()
    {
      return TeenDigit[this.Number];
    }

    public string ReadDoubleDigit()
    {
      return DoubleDigit[this.Number];
    }
  }
}