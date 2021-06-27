using AdamBednarzLab8ZadDom.Models;
using AdamBednarzLab8ZadDom.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdamBednarzLab8ZadDom.Controllers
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
        /// Zwraca dzieła znajdujące się w wybranym muzeum
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<ArtWork>))]
        [Route("{id}/ArtWorks")]
        public IActionResult GetMuseumArtWorks([FromRoute] int id)
        {
            List<ArtWork> artWorks = _museumService.GetArtWorks(id);
            return Ok(artWorks);
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
