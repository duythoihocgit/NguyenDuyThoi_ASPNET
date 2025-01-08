using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDuyThoi_2122110066.Context;

namespace NguyenDuyThoi_2122110066.Controllers
{
    public class ProductController : Controller
    {
        Asp_netEntitie2s objAsp_NetEntities = new Asp_netEntitie2s();
        // GET: Product
        public ActionResult Detail(int Id)
        {
            var objProduct = objAsp_NetEntities.Products.Where(n => n.Id == Id).FirstOrDefault();
            return View(objProduct);
        }
        public ActionResult Listing_large(int Id)
        {
            var listProduct = objAsp_NetEntities.Products.Where(n => n.CategoryId == Id).ToList();
            return View(listProduct);
        }

        public ActionResult Listing_grid()
        {
            return View();
        }

        //GET Category
        public ActionResult Category()
        {
            var lstCategory = objAsp_NetEntities.Categories.ToList();
            return View(lstCategory);
        }
    }
}