using AdamBednarzLab6ZadDom.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdamBednarzLab6ZadDom.Services
{
    public class ArtWorkService : IArtWorkService
    {
        private readonly DataBaseContext _context;

        public ArtWorkService(DataBaseContext context)
        {
            this._context = context;
        }

        public List<ArtWork> GetAll()
        {
            return _context.ArtWorks.ToList();
        }

        public ArtWork Get(int id)
        {
            return _context.ArtWorks.Find(id);
        }

        public string Post(ArtWork artWork)
        {
            // żaden inne dzieło nie będzie miało klucza 0, więc nie wyrzuci błędu,
            // a nadpisze automatycznie wygenerowaną wartością Id
            artWork.Id = 0;
            _context.ArtWorks.Add(artWork);
            try
            {
                _context.SaveChanges();
            }
            catch
            {
                return "Wystąpił konflikt z kluczami obcymi";
            }
            return artWork.Id.ToString();
        }

        public string Put(int id, ArtWork artWork)
        {
            if (_context.ArtWorks.Any(o => o.Id == id))
            {
                _context.ArtWorks.Update(artWork);
                try
                {
                    _context.SaveChanges();
                }
                catch
                {
                    return "Wystąpił konflikt z kluczami obcymi";
                }
                return "OK";
            }
            else
            {
                return "Brak dzieła o takim indeksie";
            }
        }

        public bool Delete(int id)
        {
            var artWork = _context.ArtWorks.FirstOrDefault(m => m.Id.Equals(id));
            if (artWork == null)
                return false;
            _context.ArtWorks.Remove(artWork);
            _context.SaveChanges();
            return true;
        }
    }

}
