using ADOLibrary;
using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MovieRentalDAL.Services
{
    public class ServiceCategory : ServiceBase<int, Category>
    {
        private Category Converter(SqlDataReader reader)
        {
            return new Category(
                reader["Name"].ToString()
                );
        }

        public override IEnumerable<Category> Get()
        {
            Command cmd = new Command("GetCategories", true);
            return connection.ExecuteReader<Category>(cmd, Converter);
        }
        
    }
}
