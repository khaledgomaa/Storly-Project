using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Storly.Models;
using System.ComponentModel.DataAnnotations;

namespace Storly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto GenreType { get; set; }

        [Display(Name = "GenreType")]
        [Required]
        public byte GenreTypeId { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }


        [Range(5, 100)]
        public int NumberInStock { get; set; }
    }
}