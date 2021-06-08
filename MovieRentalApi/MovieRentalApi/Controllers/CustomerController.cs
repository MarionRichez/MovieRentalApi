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
    public class CustomerController : ControllerBase
    {
        private CustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }

        [HttpPost]
        [Route("/Login")]
        public Customer Login(Customer entity)
        {
            return _service.Check(entity);
        }

        [HttpPost]
        [Route("/Register")]
        public int Register(Customer entity)
        {
            return _service.Insert(entity);
        }
    }
}
