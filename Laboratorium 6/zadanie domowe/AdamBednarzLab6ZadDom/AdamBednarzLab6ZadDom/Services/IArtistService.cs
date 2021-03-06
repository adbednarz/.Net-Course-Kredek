using AdamBednarzLab6ZadDom.Models;
using System.Collections.Generic;

namespace AdamBednarzLab6ZadDom.Services
{
    public interface IArtistService
    {
        /// <summary>
        /// Zwraca wszystkich artystów
        /// </summary>
        /// <returns></returns>
        List<Artist> GetAll();

        /// <summary>
        /// Zwraca wybranego artystę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Artist Get(int id);

        /// <summary>
        /// Dodaje nowe dzieło sztuki i zwraca jego Id
        /// </summary>
        /// <param name="artist"></param>
        /// <returns></returns>
        int Post(Artist artist);

        /// <summary>
        /// Edycja wskazanego artysty
        /// </summary>
        /// <param name="id"></param>
        /// <param name="artist"></param>
        /// <returns></returns>
        bool Put(int id, Artist artist);

        /// <summary>
        /// Usuwa wskazanego artystę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
