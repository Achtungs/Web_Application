using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class RaController : Controller
    {
        public IActionResult Index(string value = null)
        {
            return View(new OneModel(value));
        }
    }
}
