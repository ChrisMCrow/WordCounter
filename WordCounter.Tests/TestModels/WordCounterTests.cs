using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void SetString_ReturnsString_True()
    {
      //Arrange
      string inputString = "Purple Rain";
      RepeatCounter newCounter = new RepeatCounter();

      //Act
      newCounter.SetString(inputString);
      string resultString = newCounter.GetString();

      //Assert
      Assert.AreEqual(inputString, resultString);
    }

    [TestMethod]
    public void StringToArray_ConvertsStringToArrayOfWords_True()
    {
      //Arrange
      string inputString = "Little Red Corvette";
      string[] inputArray = {"Little", "Red", "Corvette"};
      RepeatCounter newCounter = new RepeatCounter();

      //Act
      newCounter.SetString(inputString);
      string[] resultArray = newCounter.StringToArray();

      //Assert
      CollectionAssert.AreEqual(inputArray, resultArray);
    }

    [TestMethod]
    public void HowManyMatches_DoesWordMatchString_True()
    {
      //Arrange
      string inputString = "I just want your extra time and your kiss";
      string inputWord = "your";
      RepeatCounter newCounter = new RepeatCounter();

      //Act
      newCounter.SetString(inputString);
      newCounter.SetWord(inputWord);
      int wordMatches = newCounter.HowManyMatches();

      //Assert
      Assert.AreEqual(2, wordMatches);
    }
  }
}
