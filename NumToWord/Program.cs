using System;
using ToWord;
using System.Runtime;
using System.Collections.Generic;

namespace ToWord.Program
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Please enter a number: ");
      string userNum1 = Console.ReadLine();
      WordFromNum userWord = new WordFromNum(int.Parse(userNum1));
      string returnedWord = "";
      char[] charArray = {};

      // foreach(char i in userNum1){
      //   charArray.Add(i);
      // }

      int count = 0;
      for (int i = 0; i < userNum1.Length; i++)
      {
        count++;
      }
      // Console.WriteLine(count);

      int numToString = int.Parse(userNum1);

      if (count <= 2 && numToString % 10 == 0)
      {
        // int firstDigit = int.Parse(userNum1[0]);
        // Console.WriteLine(stringArray);
        // userWord.Number = firstDigit;
        returnedWord = userWord.ReadDoubleDigit();
        Console.WriteLine("\n" + returnedWord);
      }
      else if (count <= 1)
      {
        returnedWord = userWord.ReadSingleDigit();
        Console.WriteLine("\n" + returnedWord);
      }
      else if (count >= 2 && numToString < 20)
      {
        returnedWord = userWord.ReadTeenDigit();
        Console.WriteLine("\n" + returnedWord);
      }
    }




  }
}