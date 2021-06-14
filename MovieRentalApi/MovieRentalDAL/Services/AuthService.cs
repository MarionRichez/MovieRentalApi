using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Services
{
    public class AuthService : IAuthService
    {
        private CustomerService _service;

        public AuthService()
        {
            _service = new CustomerService();
        }

        public bool Check(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Login(string email, string password)
        {
            Customer c = new Customer
            {
                Email = email,
                Password = password
            };
            return _service.Check(c);
        }

        public int Register(Customer customer)
        {
            return _service.Insert(customer);
        }
    }
}
