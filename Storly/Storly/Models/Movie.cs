using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Storly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre GenreType { get; set; }

        [Display(Name = "GenreType")]
<<<<<<< HEAD
        public byte GenreTypeId { get; set; }

=======
        [Required]
        public byte GenreTypeId { get; set; }

        [Required]
>>>>>>> Adding dataTables and using ajax to call web api
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

<<<<<<< HEAD
=======
        
>>>>>>> Adding dataTables and using ajax to call web api
        [Range(5, 100)]
        public int NumberInStock { get; set; }
    }
}