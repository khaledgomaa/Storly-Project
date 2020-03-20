using Storly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Storly.Controllers.api
{
    public class MovieController : ApiController
    {
        private ApplicationDbContext dbContext;

        public MovieController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovie()
        {
            var movie = dbContext.Movie.ToList();
            return movie;
        }
        [HttpPost]
        public Movie AddMovie(Movie movie)
        {
            //if (customer == null)
            //   return 
            dbContext.Movie.Add(movie);
            dbContext.SaveChanges();
            return movie;
        }
        [HttpPut]
        public Movie UpdateMovie(int id,Movie movie)
        {
            var movieInDb = dbContext.Movie.SingleOrDefault(m => m.Id == id);
            if(movieInDb == null)
            {

            }
            movieInDb.Name = movie.Name;
            movieInDb.GenreTypeId = movie.GenreTypeId;
            movieInDb.DateAdded = movie.DateAdded;
            movieInDb.ReleaseDate = movie.ReleaseDate;
            movieInDb.NumberInStock = movie.NumberInStock;
            dbContext.SaveChanges();
            return movie;
        }

    }
}
