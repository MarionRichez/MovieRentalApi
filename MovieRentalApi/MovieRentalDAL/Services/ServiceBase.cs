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
            this.connection = new Connection(@"Data Source=LAPTOP-KPUOAHT1;Initial Catalog=MovieRentalDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
        }

        public abstract IEnumerable<TEntity> Get();
    }
}
