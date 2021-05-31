using AdamBednarzLab6.Models;
using AdamBednarzLab6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdamBednarzLab6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaService _pizzaService;
        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        /// <summary>
        /// Zwraca wszystkie pizze
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Pizza>))]
        public IActionResult GetAllPizzas()
        {
            var pizzas = _pizzaService.Get();
            return Ok(pizzas);
        }

        /// <summary>
        /// Dodaje nową pizzę
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Pizza pizza)
        {
            int id = _pizzaService.Post(pizza);
            return Ok(id);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return Conflict("Podane Id są różne");
            }
            else
            {
                var IsUpdateSuccessful = _pizzaService.Put(id, pizza);
                if (IsUpdateSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
        }

        /// <summary>
        /// Usuwa pizzę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
        var IsUpdateSuccessful = _pizzaService.Delete(id);
            if (IsUpdateSuccessful)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
