using SymulatorGierLosowych.DAL;
using SymulatorGierLosowych.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SymulatorGierLosowych.Controllers
{
    public class HomeController : Controller
    {
        private StoreContex db = new StoreContex();

        // GET: Home
        public ActionResult Index()
        {
            var genres = db.GameGenres;

            return View();
        }

        // GET: Home
        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}