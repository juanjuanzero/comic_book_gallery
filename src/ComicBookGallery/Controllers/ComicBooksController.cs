using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //added this to inherit from MVC

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller //added this to inherit from MVC
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController() //contructor for ComicBooksRepo, note constructors dont have a return type
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index() //created an index method? or property in this class so that MVC will display this because MVC looks for a home directory and an index action.
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks); //pass it to the view
        }

        public ActionResult Detail(int? id) //adding the ? after int makes it nullable
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook); //passed the comicBook model instance in the view method call to make the view to be strongly typed.
        }//adding an action method.. performing an action required to prepare a response for request
    }
}