﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CursoWebMVC.Controllers
{
    public class SallersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}