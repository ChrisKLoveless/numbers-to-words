using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToWord;
using System;

namespace ToWord.Test
{
  [TestClass]
  public class WordFromNumTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstance_WordFromNum()
    {
      int two = 2;
      WordFromNum newObject = new WordFromNum(two);
      Assert.AreEqual(typeof(WordFromNum), newObject.GetType());
    }

    [TestMethod]
    public void GetNumber_ReturnNumber_Number()
    {
      int two = 2;
      WordFromNum newObject = new WordFromNum(two);
      int newNumber = newObject.Number;
      Assert.AreEqual(two, newNumber);
    }

    [TestMethod]
    public void AddWord_AddsWordToField_Word()
    {

      WordFromNum newObject = new WordFromNum(2);
      string word = "million";
      newObject.AddWord(word);
      string result = newObject.Word;

      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void ReadSingleDigit_ReturnsAString_String()
    {

      WordFromNum newObject = new WordFromNum(1);
      string word = "one";
      string result = newObject.ReadSingleDigit();

      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void ReadTeenDigit_ReturnString_String()
    {
      WordFromNum newObject = new WordFromNum(12);
      string word = "twelve";
      string result = newObject.ReadTeenDigit();
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void ReadDoubleDigit_ReturnString_String()
    {
      WordFromNum newObject = new WordFromNum(2);
      string word = "twenty";
      string result = newObject.ReadDoubleDigit();
      Assert.AreEqual(word, result);
    }
    
  }
}