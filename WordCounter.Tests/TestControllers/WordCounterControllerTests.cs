using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void CreateString_ReturnsCorrectView_True()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult createStringView = controller.CreateString();

            //Assert
            Assert.IsInstanceOfType(createStringView, typeof(ViewResult));
        }
    }
}
