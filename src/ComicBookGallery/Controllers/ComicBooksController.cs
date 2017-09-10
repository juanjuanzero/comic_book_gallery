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
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[] //start with instanciating the array
                {
                    new Artist() {Name = "Dan Slott", Role = "Script" }, //then add an Artist model property that would be inside the array for a total of 5 elements
                    new Artist() {Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() {Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() {Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() {Name = "Chris Eliopoulos", Role = "Letters" }
                }
            };

            return View(comicBook); //passed the comicBook model instance in the view method call to make the view to be strongly typed.
        }//adding an action method.. performing an action required to prepare a response for request
    }
}