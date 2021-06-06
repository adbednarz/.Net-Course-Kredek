using AdamBednarzLab6ZadDom.Models;
using AdamBednarzLab6ZadDom.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdamBednarzLab6ZadDom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuseumController : ControllerBase
    {
        private IMuseumService _museumService;

        public MuseumController(IMuseumService museumService)
        {
            _museumService = museumService;
        }

        /// <summary>
        /// Zwraca wszystkie muzea
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Museum>))]
        public IActionResult GetAllMuseums()
        {
            var museums = _museumService.GetAll();
            return Ok(museums);
        }

        /// <summary>
        /// Zwraca wybrane muzeum
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(Museum))]
        [Route("{id}")]
        public IActionResult GetMuseum([FromRoute] int id)
        {
            Museum museum = _museumService.Get(id);
            if (museum != null)
            {
                return Ok(museum);
            }
            else
                return NotFound();
        }

        /// <summary>
        /// Dodaje nowe muzeum
        /// </summary>
        /// <param name="museum"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Museum museum)
        {
            int id = _museumService.Post(museum);
            return Ok(id);
        }

        /// <summary>
        /// Edytuje istniejące muzeum
        /// </summary>
        /// <param name="id"></param>
        /// <param name="museum"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Museum museum)
        {
            if (id != museum.Id)
            {
                return Conflict("Podane Id są różne");
            }
            else
            {
                var result = _museumService.Put(id, museum);

                if (result)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Usuwa istniejące muzeum
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _museumService.Delete(id);

            if (result)
                return NoContent();
            else
                return NotFound();
        }
    }
}
