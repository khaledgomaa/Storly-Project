using Storly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
<<<<<<< HEAD
=======
using AutoMapper;
using Storly.Dtos;
using System.Data.Entity;
>>>>>>> Adding dataTables and using ajax to call web api

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
<<<<<<< HEAD
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
=======
        public IHttpActionResult GetMovies()
        {
            return Ok(dbContext.Movie.Include(m=>m.GenreType).ToList().Select(Mapper.Map<Movie,MovieDto>));
        }
        public IHttpActionResult GetMovie(int id)
        {
            var movieInDb = dbContext.Movie.SingleOrDefault(c=>c.Id==id);
            if (movieInDb == null)
                return NotFound();
            return Ok(Mapper.Map<Movie, MovieDto>(movieInDb));
        }

        [HttpPost]
        public IHttpActionResult AddMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            dbContext.Movie.Add(movie);
            dbContext.SaveChanges();
            return Created (new Uri(Request.RequestUri + "/" + movie.Id),movie);
        }
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id,MovieDto movieDto)
        {
            var movieInDb = dbContext.Movie.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return NotFound();
            Mapper.Map(movieDto, movieInDb);
            dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = dbContext.Movie.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return NotFound();
            dbContext.Movie.Remove(movieInDb);
            dbContext.SaveChanges();
            return Ok();
>>>>>>> Adding dataTables and using ajax to call web api
        }

    }
}
