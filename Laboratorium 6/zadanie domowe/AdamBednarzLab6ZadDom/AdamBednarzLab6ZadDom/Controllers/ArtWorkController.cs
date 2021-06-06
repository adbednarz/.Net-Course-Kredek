using AdamBednarzLab6ZadDom.Models;
using AdamBednarzLab6ZadDom.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdamBednarzLab6ZadDom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtWorkController : ControllerBase
    {
        private IArtWorkService _artWorkService;

        public ArtWorkController(IArtWorkService artWorkService)
        {
            _artWorkService = artWorkService;
        }

        /// <summary>
        /// Zwraca wszystkie dzieła sztuki
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<ArtWork>))]
        public IActionResult GetAllArtWorks()
        {
            var artWorks = _artWorkService.GetAll();
            return Ok(artWorks);
        }

        /// <summary>
        /// Zwraca wybrane dzieło sztuki
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(ArtWork))]
        [Route("{id}")]
        public IActionResult GetArtWork([FromRoute] int id)
        {
            ArtWork artWork = _artWorkService.Get(id);
            if (artWork != null)
            {
                return Ok(artWork);
            }
            else
                return NotFound();
        }

        /// <summary>   
        /// Dodaje nowe dzieło sztuki
        /// </summary>
        /// <param name="artWork"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] ArtWork artWork)
        {
            string result = _artWorkService.Post(artWork);
            if (result.Equals("Wystąpił konflikt z kluczami obcymi"))
                return Conflict(result);
            else
                return Ok(result);
        }

        /// <summary>
        /// Edytuje istniejące dzieło sztuki
        /// </summary>
        /// <param name="id"></param>
        /// <param name="artWork"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] ArtWork artWork)
        {
            if (id != artWork.Id)
            {
                return Conflict("Podane Id są różne");
            }
            else
            {
                string result = _artWorkService.Put(id, artWork);

                if (result.Equals("Wystąpił konflikt z kluczami obcymi"))
                    return Conflict(result);
                else if (result.Equals("Brak dzieła o takim indeksie"))
                    return NotFound();
                else
                    return NoContent();
            }
        }

        /// <summary>
        /// Usuwa istniejące dzieło sztuki
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _artWorkService.Delete(id);

            if (result)
                return NoContent();
            else
                return NotFound();
        }
    }
}
