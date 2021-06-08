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
    public class RentalController : ControllerBase
    {
        private RentalService _service;

        public RentalController()
        {
            _service = new RentalService();
        }

        [HttpPost]
        [Route("Location")]
        public int Insert(Rental rental)
        {
            return _service.Insert(rental);
        }
    }
}
