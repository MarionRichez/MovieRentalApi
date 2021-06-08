using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalDAL.Models;
using MovieRentalDAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private FilmService _service;

        public FilmController()
        {
            _service = new FilmService();
        }

        [HttpGet]
        public IEnumerable<Film> GetFilms()
        {
            return _service.Get();
        }

        [HttpGet]
        [Route("FilmId")]
        public IEnumerable<Film> GetById(int filmId)
        {
            return _service.GetById(filmId);
        }

        [HttpGet]
        [Route("CategoryId")]
        public IEnumerable<Film> GetByCategory(int categoryId)
        {
            return _service.GetByCategory(categoryId);
        }

        [HttpGet]
        [Route("ActorId")]
        public IEnumerable<Film> GetByActor(int actorId)
        {
            return _service.GetByActor(actorId);
        }

        [HttpGet]
        [Route("Title")]
        public IEnumerable<Film> GetByTitle(string title)
        {
            return _service.GetByTitle(title);
        }

        [HttpGet]
        [Route("keyword")]
        public IEnumerable<Film> GetByKeyword(string keyword)
        {
            return _service.GetByKeyword(keyword);
        }

        [HttpGet]
        [Route("LanguageId")]
        public IEnumerable<Film> GetByLanguage(int languageId)
        {
            return _service.GetByLanguage(languageId);
        }
    }
}
