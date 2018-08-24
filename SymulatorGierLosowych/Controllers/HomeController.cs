using SymulatorGierLosowych.DAL;
using SymulatorGierLosowych.Models;
using SymulatorGierLosowych.ViewModels;
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
            var genres = db.GameGenres.ToList();
            //var genres = db.GameGenres.Where(g => g.GenreName == "Lotto").OrderByDescending(a => a.GenreName).ToList();

            var vm = new HomeViewModel()
            {
                GameGenres = genres
            };

            return View(vm);
        }

        // GET: Home
        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
    }
}