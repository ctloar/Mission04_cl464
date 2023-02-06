using Microsoft.AspNetCore.Mvc;
using Mission04_cl464.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Controller page more or less directs the traffic/handles routes */

namespace Mission04_cl464.Controllers
{
    public class M5Controller : Controller
    {
        // Default controller sends to index view
        public IActionResult Index()
        {
            return View();
        }

        // Called if the request is a GET 
        [HttpGet]
        public IActionResult Calculate()
        {
            return View();
        }

        // Called if the request is a POST i.e. if a form is submitted in this case
        [HttpPost]
        public IActionResult Calculate(CalculateModel model)
        {
            return View();
        }
    }
}
