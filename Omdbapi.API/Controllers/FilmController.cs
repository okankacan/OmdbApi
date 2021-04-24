using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omdbapi.Core.Model.ResponseModel;
using Omdbapi.Core.Services;

namespace Omdbapi.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly OmdbService _omdbService;

        public FilmController(OmdbService omdbService)
        {
            _omdbService = omdbService;
        }

        [HttpGet]
        public async Task<IActionResult> FilmSearch(string filmData)

        {
             if (string.IsNullOrWhiteSpace(filmData))
                return BadRequest("Film ismini giriniz");

           var  result= await _omdbService.FilmSearch(filmData);
            if (result == null)
                return NotFound();

            return Ok(new BaseResponseModel
            {
                HttpStatusCode = HttpStatusCode.OK,
                Data = result
            });

        }

    }
}