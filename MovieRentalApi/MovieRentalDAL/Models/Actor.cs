using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Models
{
    public class Actor : IEntity<int>
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Actor(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public Actor(int id, string lastName, string firstName) : this(lastName, firstName)
        {
            Id = id;
        }

        public Actor() { }
    }
}
