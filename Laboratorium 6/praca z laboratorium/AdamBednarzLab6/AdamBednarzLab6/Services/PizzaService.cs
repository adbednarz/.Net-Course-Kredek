using AdamBednarzLab6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab6.Services
{
    public class PizzaService : IPizzaService
    {
        private static List<Pizza> pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 0,
                Name = "Wiejska",
                Description = "Pyszna",
                Cost = 19
            },
            new Pizza()
            {
                Id = 1,
                Name = "Wiejska",
                Description = "Pyszna",
                Cost = 19
            }
        };

        public List<Pizza> Get()
        {
            return pizzas;
        }

        public int Post(Pizza pizza)
        {
            int id = 0;
            if(pizzas.Count() == 0)
            {
                id = 0;
            }
            else
            {
                id = pizzas.Max(x => x.Id) + 1;
            }
            pizza.Id = id;
            pizzas.Add(pizza);
            return id;
        }

        public bool Put(int id, Pizza pizza)
        {
            var pizzaToUpdate = pizzas.Where(p => p.Id.Equals(id)).SingleOrDefault();
            if (pizzaToUpdate == null)
                return false;

            pizzaToUpdate.Name = pizza.Name;
            pizzaToUpdate.Description = pizza.Description;
            pizzaToUpdate.Cost = pizza.Cost;

            return true;
        }

        public bool Delete(int id)
        {
            var pizzaToDelete = pizzas.Where(p => p.Id.Equals(id)).SingleOrDefault();
            if (pizzaToDelete == null)
            {
                return false;
            }
            pizzas.Remove(pizzaToDelete);
            return true;
        }
    }
}
