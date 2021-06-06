using AdamBednarzLab6ZadDom.Models;
using System.Collections.Generic;

namespace AdamBednarzLab6ZadDom.Services
{
    public interface IMuseumService
    {
        /// <summary>
        /// Zwraca wszystkie muzea
        /// </summary>
        /// <returns></returns>
        List<Museum> GetAll();

        /// <summary>
        /// Zwraca wybrane muzeum
        /// </summary>
        /// <returns></returns>
        Museum Get(int id);

        /// <summary>
        /// Dodaje nowe muzeum i zwraca jego Id
        /// </summary>
        /// <param name="museum"></param>
        /// <returns></returns>
        int Post(Museum museum);

        /// <summary>
        /// Edycja wskazanego muzeum
        /// </summary>
        /// <param name="id"></param>
        /// <param name="museum"></param>
        /// <returns></returns>
        bool Put(int id, Museum museum);

        /// <summary>
        /// Usuwa wskazane muzeum
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
