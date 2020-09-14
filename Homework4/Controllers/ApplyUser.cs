using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Homework4.Models;

namespace Homework4.Controllers
{
    public class ApplyUser : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
