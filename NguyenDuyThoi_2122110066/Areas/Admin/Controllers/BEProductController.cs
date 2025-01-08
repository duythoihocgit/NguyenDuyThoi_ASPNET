using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDuyThoi_2122110066.Context;

namespace NguyenDuyThoi_2122110066.Areas.Admin.Controllers
{
    public class BEProductController : Controller
    {
        Asp_netEntitie2s objAsp_NetEntities = new Asp_netEntitie2s();
        // GET: Admin/BEProduct
        public ActionResult Index()
        {
            var lstProduct = objAsp_NetEntities.Products.ToList();
            return View(lstProduct);
        }
        [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product objProduct)
        {
            try
            {
                if (objProduct.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(objProduct.ImageUpload.FileName);
                    string extension=Path.GetExtension(objProduct.ImageUpload.FileName);    
                    fileName=fileName+"_"+long.Parse(DateTime.Now.ToString("yyyyMMddhhmmss")) + extension;
                    objProduct.Avatar = fileName;
                    objProduct.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/images/items/"), fileName));

                }
                objAsp_NetEntities.Products.Add(objProduct);
                objAsp_NetEntities.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception)
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var objProduct = objAsp_NetEntities.Products.Where(n => n.Id == id).FirstOrDefault();

            return View(objProduct);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var objProduct = objAsp_NetEntities.Products.Where(n => n.Id == id).FirstOrDefault();
            return View(objProduct);
        }

        [HttpPost]
        public ActionResult Delete(Product objPro)
        {
            var objProduct = objAsp_NetEntities.Products.Where(n => n.Id == objPro.Id).FirstOrDefault();
            objAsp_NetEntities.Products.Remove(objProduct);
            objAsp_NetEntities.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}