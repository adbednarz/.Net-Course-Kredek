using AdamBednarzLab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab6.Services
{
    public interface IPizzaService
    {
        /// <summary>
        /// Zwraca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        List<Pizza> Get();

        /// <summary>
        /// Dodaje nową pizzę i zwraca jej id
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        int Post(Pizza pizza);

        /// <summary>
        /// Edycja wskazanej pizzy
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pizza"></param>
        /// <returns></returns>
        bool Put(int id, Pizza pizza);

        /// <summary>
        /// Usuwa wskazaną pizzę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
