using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCApplication.Helper;

namespace TestMVCApplication.Controllers
{
    [LogActionFilter]
    public class HelloWorldController : ApplicationController
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

        [OutputCache(Duration = 10)]
        public ActionResult Time()
        {
            ViewData["message"] = DateTime.Now.ToString();
            return View();
        }
    }

  

    public class WelcomeViewModel
    {
        public string Message { get; set; }
        public int numOfTimes { get; set; }
    }
}