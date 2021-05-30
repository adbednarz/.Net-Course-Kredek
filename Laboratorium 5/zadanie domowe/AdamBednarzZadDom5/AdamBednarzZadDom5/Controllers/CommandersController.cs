using AdamBednarzZadDom5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzZadDom5.Controllers
{
    public class CommandersController : Controller
    {
        private readonly DataBaseContext _context;

        public CommandersController(DataBaseContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Commanders.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Commander commander)
        {
            _context.Commanders.Add(commander);
            try
            {
                _context.SaveChanges();
            }
            catch
            {
                // jeśli nie udało się pomyślnie zapisać zmian w bazie, to załaduj stronę jeszcze raz
                return RedirectToAction(nameof(Create));
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var commander = _context.Commanders.FirstOrDefault(m => m.Id.Equals(id));

            if (commander == null)
            {
                return NotFound();
            }

            return View(commander);
        }

        [HttpPost]
        public IActionResult Edit(Commander commander)
        {
            if (ModelState.IsValid)
            {
                _context.Commanders.Update(commander);
                try
                {
                    _context.SaveChanges();
                }
                catch
                {
                    // jeśli nie udało się pomyślnie zapisać zmian w bazie, to załaduj stronę jeszcze raz
                    return RedirectToAction(nameof(Edit));
                }
                return RedirectToAction(nameof(Index));
            }

            return View(commander);
        }

        public IActionResult Delete(int id)
        {
            // wybiera po id bitwę, którą chcemy usunąć i korzystając z klucza obcego podstawia wartość pod indeks relacyjny
            var director = _context.Commanders.Include(m => m.Battles).FirstOrDefault(d => d.Id.Equals(id));

            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        [HttpPost]
        public IActionResult Delete(Commander commander)
        {
            // usuwa wszystkie bitwy, w których brał udział ten dowódca
            _context.Battles.RemoveRange(_context.Battles.Where(m => m.Commander.Equals(commander)));
            _context.Commanders.Remove(commander);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
