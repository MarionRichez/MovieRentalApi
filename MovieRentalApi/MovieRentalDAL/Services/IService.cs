using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Services
{
    public interface IService<Tkey, TEntity> where TEntity : IEntity<Tkey>
    {
        IEnumerable<TEntity> Get();
    }
}
