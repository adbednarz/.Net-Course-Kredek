using AdamBednarzZadDom5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzZadDom5.Controllers
{
    public class CountriesController : Controller
    {
        private readonly DataBaseContext _context;

        public CountriesController(DataBaseContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Countries.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            _context.Countries.Add(country);
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
            var country = _context.Countries.FirstOrDefault(m => m.Id.Equals(id));

            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        [HttpPost]
        public IActionResult Edit(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Update(country);
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

            return View(country);
        }

        public IActionResult Delete(int id)
        {
            // wybiera po id bitwę, którą chcemy usunąć i korzystając z klucza obcego podstawia wartość pod indeks relacyjny
            var country = _context.Countries.Include(m => m.Battles).FirstOrDefault(d => d.Id.Equals(id));

            if (country == null)
            {
                return NotFound();
            }

            return View(country);
        }

        [HttpPost]
        public IActionResult Delete(Country country)
        {
            // usuwa wszystkie bitwy, w których brało udział to państwo
            _context.Battles.RemoveRange(_context.Battles.Where(m => m.Country.Equals(country)));
            _context.Countries.Remove(country);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
