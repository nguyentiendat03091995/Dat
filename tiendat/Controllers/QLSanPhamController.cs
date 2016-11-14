using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tiendat.Models;
using System.IO;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace tiendat.Controllers
{
    public class QLSanPhamController : Controller
    {
        //
        // GET: /QLSanPham/
        ibebizEntities1 db = new ibebizEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListSP()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult Themsp()
        {
            
            ViewBag.danhmuc = new SelectList(db.Brands.ToList().OrderBy(n=> n.Name), "ID", "danhmuc");
            var danhmuc = from d in db.Brands
                          select new { d.ID, d.Name };
            var list = danhmuc.ToList().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.ID.ToString(),
                Selected = (c.ID == 1)
            }).ToList();
            ViewBag.danhmuc = list;
            return View();
        }
        [HttpPost, ActionName("Themsp")]
        public ActionResult Themsps(HttpPostedFileBase Photo, FormCollection cl)
        {
            ViewBag.danhmuc = new SelectList(db.Brands.ToList().OrderBy(n => n.Name), "ID", "danhmuc");
                        Product pro = new Product();
                        ProductL prol = new ProductL();

                        var guid = Guid.NewGuid().ToString();
                        //var nam = DateTime.Now.Year;
                        //var thang = DateTime.Now.Month;fhsàhdskahfkdsa
                        //var ngay = DateTime.Now.Day;
                        var pathFile = "/files/" + guid + "/images/";
                        var fileName = Path.GetFileName(Photo.FileName);
                        var path = Path.Combine(Server.MapPath(pathFile), fileName);
                        bool exists = System.IO.Directory.Exists(Server.MapPath(pathFile));
                        if (!exists)
                        {
                            System.IO.Directory.CreateDirectory(Server.MapPath(pathFile));
                        }
                        Photo.SaveAs(path);
                        var datefrom = String.Format("{0:dd/MM/yyyy}", cl["DateFrom"]);
                        var dateto = String.Format("{0:dd/MM/yyyy}", cl["DateTo"]);
                        pro.DateFrom = DateTime.Parse(datefrom);
                        pro.DateTo = DateTime.Parse(dateto);
                        pro.IsNew = true;
                        db.Products.Add(pro);
                        db.SaveChanges();
            return View();
        }
	}
}