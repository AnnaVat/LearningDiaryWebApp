using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiaryWeb.Controllers
{
    public class Existing_Topics : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
