using AdamBednarzLab8ZadDom.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AdamBednarzLab8ZadDom.Services
{
    public class ArtistService : IArtistService
    {
        private readonly DataBaseContext _context;

        public ArtistService(DataBaseContext context)
        {
            this._context = context;
        }

        public List<Artist> GetAll()
        {
            return _context.Artists.ToList();
        }

        public List<ArtWork> GetArtWorks(int id)
        {
            return _context.ArtWorks.Include(m => m.Museum).Include(m => m.Artist).Where(a => a.ArtistId.Equals(id)).ToList();
        }

        public int Post(Artist artist)
        {
            // żaden inny artysta nie będzie miał klucza 0, więc nie wyrzuci błędu,
            // a nadpisze automatycznie wygenerowaną wartością Id
            artist.Id = 0;
            _context.Artists.Add(artist);
            _context.SaveChanges();
            return artist.Id;
        }

        public bool Put(int id, Artist artist)
        {
            // jeżeli znajduję się artysta o takim id
            if (_context.Artists.Any(o => o.Id == id))
            {
                _context.Artists.Update(artist);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var artistToDelete = _context.Artists.FirstOrDefault(d => d.Id.Equals(id));
            if (artistToDelete == null)
                return false;
            // usuwa wszystkie dzieła, których autorem jest dany artysta
            _context.ArtWorks.RemoveRange(_context.ArtWorks.Where(m => m.Artist.Equals(artistToDelete)));
            // usuwa artystę
            _context.Artists.Remove(artistToDelete);
            _context.SaveChanges();
            return true;
        }
    }
}
