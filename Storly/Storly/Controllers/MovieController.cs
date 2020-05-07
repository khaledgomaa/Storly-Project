using Storly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Storly.ViewModels;

namespace Storly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private ApplicationDbContext dbContext;

        public MovieController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }
        public ViewResult New()
        {
<<<<<<< HEAD
            var movieViewModel = new MovieViewlModel
=======
            var movieViewModel = new MovieViewlModel()
>>>>>>> Adding dataTables and using ajax to call web api
            {
                Genre = dbContext.Genre.ToList(),
            };
            return View(movieViewModel);
        }

        [HttpPost]
<<<<<<< HEAD
        public ActionResult Create(Movie movie)
        {
=======
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if(!ModelState.IsValid)
            {
                var movieViewModel = new MovieViewlModel(movie)
                {
                    Genre = dbContext.Genre.ToList(),
                };
                return View("New", movieViewModel);
            }
>>>>>>> Adding dataTables and using ajax to call web api
            if(movie.Id ==0)
            {
                movie.DateAdded = DateTime.Now;
                dbContext.Movie.Add(movie);
            }
<<<<<<< HEAD
            var movieInDb = dbContext.Movie.SingleOrDefault(m => m.Id == movie.Id);
            movieInDb.Name = movie.Name;
            movieInDb.ReleaseDate = movie.ReleaseDate;
            movieInDb.GenreTypeId = movie.GenreTypeId;
            movieInDb.NumberInStock = movie.NumberInStock;
=======
            else
            {
                var movieInDb = dbContext.Movie.SingleOrDefault(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreTypeId = movie.GenreTypeId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            
>>>>>>> Adding dataTables and using ajax to call web api

            dbContext.SaveChanges();
            return RedirectToAction("Index","Movie");
        }
        public ActionResult Edit(int id)
        {
            var movieInDb = dbContext.Movie.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return HttpNotFound();
<<<<<<< HEAD
            var movieViewModel = new MovieViewlModel
            {
                Movie = movieInDb,
=======
            var movieViewModel = new MovieViewlModel(movieInDb)
            {
>>>>>>> Adding dataTables and using ajax to call web api
                Genre = dbContext.Genre.ToList(),
            };
            return View("New", movieViewModel);
        }
        public ActionResult Delete(int id)
        {
            var movieInDb = dbContext.Movie.SingleOrDefault(m => m.Id == id);
            if(movieInDb == null)
            {
                return HttpNotFound();
            }
            dbContext.Movie.Remove(movieInDb);
            dbContext.SaveChanges();
            return RedirectToAction("Index","Movie");
        }

        public ViewResult Index()
        {
            var movies = dbContext.Movie.Include(m => m.GenreType).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movies = dbContext.Movie.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id);
            if(movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }
    }
}