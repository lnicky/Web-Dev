using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieTime.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "{0} is required.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public string Genre { get; set; }

        public string Actor { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public decimal Price { get; set; }

        public string Img { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public decimal Star { get; set; }
    }

    public class MovieTimeDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}