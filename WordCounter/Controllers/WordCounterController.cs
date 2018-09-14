using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/WordCounter/CreateString")]
        public ActionResult CreateString()
        {
            return View();
        }

        [HttpPost("/WordCounter/CreateWord")]
        public ActionResult CreateWord()
        {
            RepeatCounter newInstance = new RepeatCounter();
            newInstance.SetString(Request.Form["new-string"]);
            return View(newInstance);
        }

        [HttpPost("/WordCounter/Result")]
        public ActionResult CreateResult()
        {
            RepeatCounter newInstance = new RepeatCounter();
            newInstance.SetString(Request.Form["original-string"]);
            newInstance.SetWord(Request.Form["new-word"]);
            return View("Result", newInstance);
        }
    }
}
