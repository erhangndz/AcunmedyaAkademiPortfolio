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
        DbAcunmedyaAkademiPortfolioEntities db = new DbAcunmedyaAkademiPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblProjects.ToList();
            return View(values);
        }
    }
}