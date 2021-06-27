using AdamBednarzLab8ZadDom.Models;
using System.Collections.Generic;

namespace AdamBednarzLab8ZadDom.Services
{
    public interface IArtWorkService
    {
        /// <summary>
        /// Zwraca wszystkie dzieła sztuki
        /// </summary>
        /// <returns></returns>
        List<ArtWork> GetAll();

        /// <summary>
        /// Dodaje nowe dzieło sztuki i zwraca jego Id
        /// </summary>
        /// <param name="artWork"></param>
        /// <returns></returns>
        string Post(ArtWork artWork);

        /// <summary>
        /// Edycja wskazanego dzieła sztuki
        /// </summary>
        /// <param name="id"></param>
        /// <param name="artWork"></param>
        /// <returns></returns>
        string Put(int id, ArtWork artWork);

        /// <summary>
        /// Usuwa wskazane dzieło sztuki
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
