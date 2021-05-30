using AdamBednarzZadDom5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzZadDom5.Controllers
{
    public class AgesController : Controller
    {
        private readonly DataBaseContext _context;
        public AgesController(DataBaseContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Ages.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Age age)
        {
            _context.Ages.Add(age);
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
            var age = _context.Ages.FirstOrDefault(m => m.Id.Equals(id));

            if (age == null)
            {
                return NotFound();
            }

            return View(age);
        }

        [HttpPost]
        public IActionResult Edit(Age age)
        {
            if (ModelState.IsValid)
            {
                _context.Ages.Update(age);
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

            return View(age);
        }

        public IActionResult Delete(int id)
        {
            // wybiera po id bitwę, którą chcemy usunąć i korzystając z klucza obcego podstawia wartość pod indeks relacyjny
            var age = _context.Ages.Include(m => m.Battles).FirstOrDefault(d => d.Id.Equals(id));

            if (age == null)
            {
                return NotFound();
            }

            return View(age);
        }

        [HttpPost]
        public IActionResult Delete(Age age)
        {
            // usuwa wszystkie bitwy, które odbywały się w tej epoce
            _context.Battles.RemoveRange(_context.Battles.Where(m => m.Age.Equals(age)));
            _context.Ages.Remove(age);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
