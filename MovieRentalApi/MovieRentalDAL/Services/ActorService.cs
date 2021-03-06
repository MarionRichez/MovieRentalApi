using ADOLibrary;
using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MovieRentalDAL.Services
{
    public class ActorService : ServiceBase<int, Actor>
    {
        private Actor Converter(SqlDataReader reader)
        {
            return new Actor
            (
                (int)reader["ActorId"],
                reader["LastName"].ToString(),
                reader["FirstName"].ToString()
            );
        }

        public override IEnumerable<Actor> Get()
        {
            Command cmd = new Command("GetActors", true);
            return connection.ExecuteReader(cmd, Converter);
        }

        public IEnumerable<Actor> GetByFilm(int filmId)
        {
            Command cmd = new Command("GetActorsByFilm", true);
            cmd.AddParameter("filmId", filmId);
            return connection.ExecuteReader(cmd, Converter);
        }

        public IEnumerable<Actor> GetByInitial(char initial)
        {
            Command cmd = new Command("GetActorsByInitial", true);
            cmd.AddParameter("initial", initial);
            return connection.ExecuteReader(cmd, Converter);
        }

        public IEnumerable<string> GetInitials()
        {
            Command cmd = new Command("GetActorInitials", true);
            return connection.ExecuteReader(cmd, Converter).Select(item =>item.LastName).ToList();
        }
    }
}
