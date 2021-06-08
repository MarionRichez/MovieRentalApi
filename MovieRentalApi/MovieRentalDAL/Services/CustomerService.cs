using ADOLibrary;
using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MovieRentalDAL.Services
{
    public class CustomerService : ServiceBase<int, Customer>
    {
        private Customer Converter(SqlDataReader reader)
        {
            return new Customer(
                (int)reader["CustomerId"],
                reader["LastName"].ToString(),
                reader["FirstName"].ToString(),
                reader["Email"].ToString()
                );
        }
        public override IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer entity)
        {
            Command cmd = new Command("RegisterCustomer", true);
            cmd.AddParameter("LastName", entity.LastName);
            cmd.AddParameter("FirstName", entity.FirstName);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Password", entity.Password);
            return connection.ExecuteNonQuery(cmd);
        }

        public Customer Check(Customer entity)
        {
            Command cmd = new Command("CheckCustomer", true);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Password", entity.Password);
            return connection.ExecuteReader<Customer>(cmd, Converter).FirstOrDefault();
        }
    }
}
