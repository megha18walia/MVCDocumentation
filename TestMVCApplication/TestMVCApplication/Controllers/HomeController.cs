using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCApplication.Models;

namespace TestMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MoviesEntities dbContext = new MoviesEntities();

            IEnumerable<Movie> Result = dbContext.Movies.Where(p => p.ReleaseDate > new DateTime(2012, 1, 1));
            return View(Result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
       public ActionResult Create([Bind(Exclude = "Id")]Movie movie)
        {
            if(ModelState.IsValid)
            {
                MoviesEntities entities = new MoviesEntities();
                entities.Movies.Add(movie);
                entities.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }
        }
    }
}