using Microsoft.AspNetCore.Mvc;
using Mission04_cl464.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_cl464.Controllers
{
    public class M5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(CalculateModel model)
        {
            return View();
        }
    }
}
