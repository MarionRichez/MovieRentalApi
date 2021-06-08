using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Models
{
    public class Customer : IEntity<int>
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }


        public Customer(string lastName, string firstName, string email, string password)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Password = password;
        }

        public Customer(int id, string lastName, string firstName, string email, string password) : this(lastName, firstName, email, password)
        {
            Id = id;
        }

        public Customer() { }
    }
}
