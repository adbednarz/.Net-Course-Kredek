using AdamBednarzZadDom5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AdamBednarzZadDom5.Controllers
{
    public class BattlesController : Controller
    {
        private readonly DataBaseContext _context;

        public BattlesController(DataBaseContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Battles.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Battle battle)
        {
            _context.Battles.Add(battle);
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
            var movie = _context.Battles.FirstOrDefault(m => m.Id.Equals(id));

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Battle battle)
        {
            if (ModelState.IsValid)
            {
                _context.Battles.Update(battle);
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

            return View(battle);
        }

        public IActionResult Delete(int id)
        {
            // wybiera po id bitwę, którą chcemy usunąć i korzystając z kluczy obcy podstawia wartości pod indeksy relacyjne
            var battle = _context.Battles.Include(m => m.Age).Include(m => m.Country).Include(m => m.Commander).FirstOrDefault(m => m.Id.Equals(id));

            if (battle == null)
            {
                return NotFound();
            }

            return View(battle);
        }

        [HttpPost]
        public IActionResult Delete(Battle battle)
        {
            _context.Battles.Remove(battle);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
