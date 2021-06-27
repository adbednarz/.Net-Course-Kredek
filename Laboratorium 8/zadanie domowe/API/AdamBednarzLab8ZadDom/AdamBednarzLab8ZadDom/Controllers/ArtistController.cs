using AdamBednarzLab8ZadDom.Models;
using AdamBednarzLab8ZadDom.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AdamBednarzLab8ZadDom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private IArtistService _artistService;

        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        /// <summary>
        /// Zwraca wszystkich artystów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<Artist>))]
        public IActionResult GetAllArtists()
        {
            var artists = _artistService.GetAll();
            return Ok(artists);
        }

        /// <summary>
        /// Zwraca dzieła wybranego artysty
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(List<ArtWork>))]
        [Route("{id}/ArtWorks")]
        public IActionResult GetArtistArtWorks([FromRoute] int id)
        {
            List<ArtWork> artWorks = _artistService.GetArtWorks(id);
            return Ok(artWorks);
        }

        /// <summary>
        /// Dodaje nowego artystę
        /// </summary>
        /// <param name="artist"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Artist artist)
        {
            int id = _artistService.Post(artist);
            return Ok(id);
        }

        /// <summary>
        /// Edytuje istniejącego artystę
        /// </summary>
        /// <param name="id"></param>
        /// <param name="artist"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Artist artist)
        {
            if (id != artist.Id)
            {
                return Conflict("Podane Id są różne");
            }
            else
            {
                var result = _artistService.Put(id, artist);

                if (result)
                    return NoContent();
                else
                    return NotFound();
            }
        }

        /// <summary>
        /// Usuwa istniejącego artystę
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var result = _artistService.Delete(id);

            if (result)
                return NoContent();
            else
                return NotFound();
        }
    }
}
