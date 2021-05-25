using AdamBednarzLab5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab5.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DatabaseContext _context;

        public MoviesController(DatabaseContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Movies.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
