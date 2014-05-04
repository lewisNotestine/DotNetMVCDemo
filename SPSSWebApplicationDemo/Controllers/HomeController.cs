using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPSSWebApplicationDemo.Controllers {
    public class HomeController : Controller {

        private const string DEFAULT_MESSAGE = "This is the main page.";
        
        //TODO: put this in the web config?
        private const string AUTHOR_NAME = "Lewis Notestine";
        private const string PAGE_HEADER = "SPSS demonstration";


        public ActionResult Index() {
            ViewBag.Message = DEFAULT_MESSAGE;
            ViewBag.MyName = AUTHOR_NAME;
            ViewBag.PageHeader = PAGE_HEADER;
            return View();
        }
        /*
        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}
