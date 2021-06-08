using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Models
{
    public class Rental : IEntity<int>
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int[] FilmIds { get; set; }

        public Rental(int customerId, int[] filmIds)
        {
            CustomerId = customerId;
            FilmIds = filmIds;
        }

        public Rental(int id, int customerId, int[] filmIds) : this(customerId, filmIds)
        {
            Id = id;
        }

        public Rental() { }
    }
}
