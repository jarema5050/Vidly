using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System.Web.UI.WebControls;
using System.Web.WebSockets;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");
          
            return View("ReadOnlyList");
        }

        public ViewResult Details(int id)
        {
            var movie = _context.Movies.Include(m=>m.Genre).SingleOrDefault(m=>m.Id==id);
            return View(movie);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ViewResult Edit(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
             
            var viewModel = new MovieFormViewModel
            {
               Movie=movie,
               Genres=_context.Genres.ToList()
            };
            return View("MovieForm",viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres=_context.Genres.ToList()
                };
                return View("MovieForm",viewModel);
            }
            if (movie.Id == 0)
            { 
                movie.DateAdded=DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.DateAdded=DateTime.Now;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        [Authorize(Roles=RoleName.CanManageMovies)]
        public ActionResult New()
        {

            var viewModel = new MovieFormViewModel
            {
                Movie= new Movie(),
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm",viewModel);
        }
    }
}