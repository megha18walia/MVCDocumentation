using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCApplication.Models;

namespace TestMVCApplication.Controllers
{
    public abstract class ApplicationController : Controller
    {
        MoviesEntities entities = new MoviesEntities();
       // GET: Application
       public ApplicationController()
        {
            ViewData["User"] = entities.Users.Where(c => c.FirstName.ToUpper() == "Megha").Select(p => p.Id).SingleOrDefault();
        }
    }
}