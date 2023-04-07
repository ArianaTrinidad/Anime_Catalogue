using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Catalogue_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        /*private readonly IAnimeService _service;

        public AnimeController(IAnimeService service)
        {
            _service = service;
        }


        [HttpGet]
        public ActionResult GetAll ([FromQuery] GetAnimeDto dto)
        {
            var result = _service.GetAll(dto);

            return result;
        }*/
    }
}
