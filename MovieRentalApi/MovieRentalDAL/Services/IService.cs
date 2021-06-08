using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Services
{
    public interface IService<Tkey, TEntity> where TEntity : IEntity<Tkey>
    {
        Tkey Insert(TEntity entity);
        TEntity GetById(Tkey key);
        IEnumerable<TEntity> GetAll();
        bool Update(TEntity entity);
        bool Delete(Tkey key);
    }
}
