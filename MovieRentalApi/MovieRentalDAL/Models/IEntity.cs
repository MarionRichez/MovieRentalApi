using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Models
{
    public interface IEntity<Tkey>
    {
        Tkey Id { get; }
    }
}
