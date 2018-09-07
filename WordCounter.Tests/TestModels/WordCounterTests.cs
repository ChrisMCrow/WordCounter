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
  }
}
