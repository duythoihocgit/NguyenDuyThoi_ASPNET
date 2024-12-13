using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenDuyThoi_2122110066.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Listing_large()
        {
            return View();
        }

        public ActionResult Listing_grid()
        {
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }
    }
}