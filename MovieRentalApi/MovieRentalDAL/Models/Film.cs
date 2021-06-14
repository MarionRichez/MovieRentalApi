using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRentalDAL.Models
{
    public class Film : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public string Language { get; set; }
        public int RentalDuration { get; set; }
        public decimal RentalPrice { get; set; }
        public int Length { get; set; }
        public decimal ReplacementCost { get; set;  }
        public string Rating { get; set; }

        public Film(string title, string description, int releaseYear, string language, int rentalDuration, decimal rentalPrice, int length, decimal replacementCost, string rating)
        {
            Title = title;
            Description = description;
            ReleaseYear = releaseYear;
            Language = language;
            RentalDuration = rentalDuration;
            RentalPrice = rentalPrice;
            Length = length;
            ReplacementCost = replacementCost;
            Rating = rating;
        }

        public Film(int id, string title, string description, int releaseYear, string language, int rentalDuration, decimal rentalPrice, int length, decimal replacementCost, string rating) : this(title, description, releaseYear, language, rentalDuration, rentalPrice, length, replacementCost, rating)
        {
            Id = id;
        }

        public Film() { }
    }
}
