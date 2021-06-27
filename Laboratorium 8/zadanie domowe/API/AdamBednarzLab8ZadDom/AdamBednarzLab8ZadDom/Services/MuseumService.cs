using AdamBednarzLab8ZadDom.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AdamBednarzLab8ZadDom.Services
{
    public class MuseumService : IMuseumService
    {
        private readonly DataBaseContext _context;

        public MuseumService(DataBaseContext context)
        {
            this._context = context;
        }

        public List<Museum> GetAll()
        {
            return _context.Museums.ToList();
        }


        public List<ArtWork> GetArtWorks(int id)
        {
            return _context.ArtWorks.Include(m => m.Artist).Include(m => m.Museum).Where(a => a.MuseumId.Equals(id)).ToList();
        }

        public int Post(Museum museum)
        {
            // żaden inne muzeum nie będzie miało klucza 0, więc nie wyrzuci błędu,
            // a nadpisze automatycznie wygenerowaną wartością Id
            museum.Id = 0;
            _context.Museums.Add(museum);
            _context.SaveChanges();
            return museum.Id;
        }

        public bool Put(int id, Museum museum)
        {
            // jeżeli znajduję się muzeum o takim id
            if (_context.Museums.Any(o => o.Id == id))
            {
                _context.Museums.Update(museum);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var museumToDelete = _context.Museums.FirstOrDefault(d => d.Id.Equals(id));
            // usuwa wszystkie dzieła, które znajdują się w danym miejscu
            _context.ArtWorks.RemoveRange(_context.ArtWorks.Where(m => m.Museum.Equals(museumToDelete)));
            // usuwa muzeum
            _context.Museums.Remove(museumToDelete);
            _context.SaveChanges();
            return true;
        }
    }
}
