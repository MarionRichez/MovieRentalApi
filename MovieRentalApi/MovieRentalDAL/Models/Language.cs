using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Models
{
    public class Language : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Language(string name)
        {
            Name = name;
        }

        public Language(int id, string name) : this(name)
        {
            Id = id;
        }

        public Language() { }
    }
}
