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
    public class CategoryController : ControllerBase
    {
        private ServiceCategory _service;

        public CategoryController()
        {
            _service = new ServiceCategory();
        }

        [HttpGet]
        public IEnumerable<Category> GetCategory()
        {
            return _service.Get();
        }
    }
}
