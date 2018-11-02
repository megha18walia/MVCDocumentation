using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int nOfTimes = 1)
        {
            WelcomeViewModel wcm = new WelcomeViewModel
            {
                Message = "Name is : " + name,
                numOfTimes = nOfTimes
            };

            return View(wcm);
        }
    }

    public class WelcomeViewModel
    {
        public string Message { get; set; }
        public int numOfTimes { get; set; }
    }
}