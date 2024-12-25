using AcunmedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        //CRUD ==> Create Read

        DbAcunmedyaAkademiPortfolioEntities db = new DbAcunmedyaAkademiPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblProjects.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            var categoryList = db.TblCategories.ToList();

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                Text= x.CategoryName,
                                                Value=x.CategoryId.ToString()
                                               }).ToList();

            ViewBag.categories = categories;

           

            return View();
        }

        [HttpPost]
        public ActionResult AddProject(TblProject model)
        {
            //ekleme işlemleri

            return RedirectToAction("Index");
        }


    }
}