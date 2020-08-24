using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Test"
            };
            return View(movie);
            //return Content("Yo");
            //return HttpNotFound();
            //return new EmptyResult();
        }

        public ActionResult Edit(int id)
        {
            return Content("ID: " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/release/year/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ReleaseByDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}