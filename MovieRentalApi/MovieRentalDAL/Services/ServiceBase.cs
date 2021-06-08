using ADOLibrary;
using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Services
{
    public abstract class ServiceBase<Tkey, TEntity> : IService<Tkey, TEntity> where TEntity : IEntity<Tkey>
    {
        protected Connection connection;

        public ServiceBase()
        {
            this.connection = new Connection(@"Data Source=LAPTOP-KPUOAHT1;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
        }

        public abstract IEnumerable<TEntity> Get();
    }
}
