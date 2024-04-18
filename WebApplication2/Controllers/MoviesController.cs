using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{


    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List(int? id,string q)
        {

            var movies = MovieRepository.Movies;
            if (id!= null)
            {
                movies = movies.Where(p => p.GenreId == id).ToList();
            }


            //Arama Filtreleme
            if (!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => i.Title.ToLower().Contains(q.ToLower())).ToList();
            }

            var model = new MoviesViewModel()
            {
                Movies = movies
                
            };

            return View("Movies",model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie m)
        {
           
            //if (ModelState.IsValid)
            //{
                MovieRepository.Add(m);
                return RedirectToAction("List");
            //}
            // ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            //return View(); 
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            return View(MovieRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            
                MovieRepository.Edit(m);
                return RedirectToAction("Details", "Movies", new { @id = m.MovieId });
            
            //ViewBag.Genres = new SelectList(GenreRepository.Genres, "GenreId", "Name");
            //return View(m); 
        }

        [HttpPost]
        public IActionResult Delete(int MovieId)
        {
            MovieRepository.Delete(MovieId);
            return RedirectToAction("List");
        }
    }
}
