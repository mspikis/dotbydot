﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DotByDotProj.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
