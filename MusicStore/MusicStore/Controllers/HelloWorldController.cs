using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return ("neo... the matrix has you...");
        }
        public IActionResult WhiteRabbit()
        {
            return View();
        }
    }
}