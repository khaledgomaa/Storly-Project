using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Storly.Models;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> Adding dataTables and using ajax to call web api

namespace Storly.ViewModels
{
    public class MovieViewlModel
    {
        public IEnumerable<Genre> Genre { get; set; }
<<<<<<< HEAD
        public Movie Movie { get; set; }
=======

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "GenreType")]
        [Required]
        public byte GenreTypeId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Range(5, 100)]
        public int NumberInStock { get; set; }

        public MovieViewlModel()
        {
            Id = 0;
        }
        public MovieViewlModel(Movie movie)
        {
            Id = movie.Id;
            ReleaseDate = movie.ReleaseDate;
            GenreTypeId = movie.GenreTypeId;
            Name = movie.Name;
            NumberInStock = movie.NumberInStock;
        }
>>>>>>> Adding dataTables and using ajax to call web api
    }
}