using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CursoWebMVC.Services;
using CursoWebMVC.Models;

namespace CursoWebMVC.Controllers
{
    public class SallersController : Controller
    {
        private readonly SallerService _sallerService;

        public SallersController(SallerService sallerService)
        {
            _sallerService = sallerService;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Saller> list = _sallerService.findAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Saller saller)
        {
            _sallerService.Insert(saller);
            return RedirectToAction(nameof(Index));
        }
    }
}