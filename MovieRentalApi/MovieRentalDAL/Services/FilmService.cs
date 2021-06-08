using ADOLibrary;
using MovieRentalDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MovieRentalDAL.Services
{
    public class FilmService : ServiceBase<int, Film>
    {
        private Film Converter(SqlDataReader reader)
        {
            return new Film(
                (int)reader["FilmId"],
                reader["Title"].ToString(),
                reader["Description"].ToString(),
                (int)reader["ReleaseYear"],
                (int)reader["LanguageId"],
                (int)reader["RentalDuration"],
                (decimal)reader["RentalPrice"],
                (int)reader["Length"],
                (decimal)reader["ReplacementCost"],
                (int)reader["RatingId"]
                );
        }
        public override IEnumerable<Film> Get()
        {
            Command cmd = new Command("GetFilms", true);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetById(int filmId)
        {
            Command cmd = new Command("GetFilmById", true);
            cmd.AddParameter("FilmId", filmId);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByTitle(string title)
        {
            Command cmd = new Command("GetFilmsByTitle", true);
            cmd.AddParameter("Title", title);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByActor(int actorId)
        {
            Command cmd = new Command("GetFilmsByActor", true);
            cmd.AddParameter("ActorId", actorId);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByCategory(int categoryId)
        {
            Command cmd = new Command("GetFilmsByActor", true);
            cmd.AddParameter("CategoryId", categoryId);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByKeyword(string keyword)
        {
            Command cmd = new Command("GetFilmsByKeyword", true);
            cmd.AddParameter("@keyword", keyword);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }

        public IEnumerable<Film> GetByLanguage(int languageId)
        {
            Command cmd = new Command("GetFilmsByLanguage", true);
            cmd.AddParameter("LanguageId", languageId);
            return connection.ExecuteReader<Film>(cmd, Converter);
        }
    }
}
