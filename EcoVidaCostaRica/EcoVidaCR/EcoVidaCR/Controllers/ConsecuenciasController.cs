﻿using EcoVidaCR.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcoVidaCR.Controllers
{
    public class ConsecuenciasController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

