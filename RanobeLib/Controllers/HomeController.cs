﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RanobeLib.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Redirect("~/Book/datatest");
        }
        public IActionResult About()
        {
            return View();
        }

        public string Hello(string name,string nametwo)
        {
            return $"Hello {name}  , {nametwo}";
        }
    }
}
