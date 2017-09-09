using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //added this to inherit from MVC

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller //added this to inherit from MVC
    {
        public ActionResult Detail()
        {
            return View();
        }//adding an action method.. performing an action required to prepare a response for request
    }
}