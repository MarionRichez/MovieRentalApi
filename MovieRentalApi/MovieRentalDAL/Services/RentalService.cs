using ADOLibrary;
using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MovieRentalDAL.Services
{
    public class RentalService : ServiceBase<int, Rental>
    {
        public override IEnumerable<Rental> Get()
        {
            throw new NotImplementedException();
        }

        public int Insert(Rental entity)
        {
            Command cmd = new Command("CreateRental", true);
            cmd.AddParameter("CustomerId", entity.CustomerId);

            DataTable filmIds = new DataTable();
            filmIds.Columns.Add("FilmId", typeof(int));

            foreach (int filmId in entity.FilmIds)
            {
                filmIds.Rows.Add(filmId);
            }

            
            cmd.AddParameter("FilmsIds", filmIds);
            return (int)connection.ExecuteScalar(cmd);
        }
    }
}
