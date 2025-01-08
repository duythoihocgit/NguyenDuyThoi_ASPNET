using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDuyThoi_2122110066.Context;
using NguyenDuyThoi_2122110066.Models;

namespace NguyenDuyThoi_2122110066.Controllers
{
    public class HomeController : Controller
    {
        Asp_netEntitie2s objAsp_NetEntities = new Asp_netEntitie2s();
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            objHomeModel.ListCategory = objAsp_NetEntities.Categories.ToList();
            objHomeModel.ListProduct = objAsp_NetEntities.Products.ToList();
            return View(objHomeModel);
        }

    }
}