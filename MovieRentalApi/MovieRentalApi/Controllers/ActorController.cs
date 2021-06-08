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
    public class ActorController : ControllerBase
    {
        private ActorService _service;

        public ActorController()
        {
            _service = new ActorService();
        }

        [HttpGet]
        public IEnumerable<Actor> GetActors()
        {
            return _service.Get();
        }

        [HttpGet]
        [Route("FilmId")]
        public IEnumerable<Actor> GetByFilm(int FilmId)
        {
            return _service.GetByFilm(FilmId);
        }

        [HttpGet]
        [Route("Initial")]
        public IEnumerable<Actor> GetByInitial(char Initial)
        {
            return _service.GetByInitial(Initial);
        }

        [HttpGet]
        [Route("Initials")]
        public IEnumerable<String> GetInitial()
        {
            return _service.GetInitials();
        }
    }
}
