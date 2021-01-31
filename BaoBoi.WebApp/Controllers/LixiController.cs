using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaoBoi.WebApp.Controllers
{
    public class LixiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
