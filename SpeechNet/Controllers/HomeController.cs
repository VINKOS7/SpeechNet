using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpeechNet.ViewModels;
using System.Diagnostics;
using SpeechNet.Services;
using System;

namespace SpeechNet.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult CalcTypeWord()
        {
            return View("CalcTypeWord");
        }

        public IActionResult PersonalArea()
        {
            return View("PersonalArea");
        }

        public IActionResult CalcTypeText()
        {
            return View("CalcTypeText");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string InsidewordTYPE(string word = null)
        {
            if (String.IsNullOrEmpty(word))
            {
                return "ошибка";
            }
            else
            {
                string res = TypeWordService.TypeWord(word, 11);

                return res;
            }
        }

        [HttpPost]
        [Route("wordTYPE")]
        public IActionResult wordTYPE(string word = null)
        {
            if (String.IsNullOrEmpty(word))
                return StatusCode(1);
            else
            {
                string res = TypeWordService.TypeWord(word, 11);
                return new JsonResult(res);
            }
        }

        [HttpPost]
        [Route("Text")]
        public IActionResult Text(string text = null)
        {
            if (String.IsNullOrEmpty(text))
                return StatusCode(400);
            else
            {
                string res = TypeTextService.TypeText(text);

                return new JsonResult(res);
            }
        }
    }
}