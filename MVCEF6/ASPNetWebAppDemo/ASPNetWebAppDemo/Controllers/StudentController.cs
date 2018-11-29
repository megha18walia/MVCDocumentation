using ASPNetWebAppDemo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetWebAppDemo.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext context = new SchoolContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(context.Students.ToList());
        }


    }
}