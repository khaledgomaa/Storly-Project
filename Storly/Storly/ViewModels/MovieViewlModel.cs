using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Storly.Models;

namespace Storly.ViewModels
{
    public class MovieViewlModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public Movie Movie { get; set; }
    }
}