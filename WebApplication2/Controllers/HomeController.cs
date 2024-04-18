using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopularMovies = MovieRepository.Movies
            };
            return View(model);
        }
        public IActionResult About()
        {
            return View();
        }


    }
}
