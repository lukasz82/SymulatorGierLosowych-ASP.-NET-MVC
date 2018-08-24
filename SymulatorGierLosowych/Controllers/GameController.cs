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
    public class GameController : Controller
    {
        private StoreContex db = new StoreContex();
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult AddGameToDB(string name, int genreid, string description)
        {
            var games = db.Set<Game>();
            games.Add(new Game {GameName = name, GameGenreId = genreid, Description = description });

            ViewBag.name = name;
            ViewBag.genreid = genreid;
            ViewBag.description = description;

            try
            {
                db.SaveChanges();
                ViewBag.succes = "<br />Wszystko ok, wgrano dane do bazy<br />";
            }
            catch (Exception e)
            {
                ViewBag.error = "<br />Ups, kuźwa, jakiś błąd :) <br /> Prawdopodobnie nie wpisałeś wszystkich wymaganych pól. </br> Poniżej kod błędu: <br /><br />";
                ViewBag.e = e;
                ViewBag.succes = "";
                return View(e);
            }
            return View();
        }

        public ActionResult AddNewGame()
        {
            var genres = db.GameGenres.ToList();
            var vm = new HomeViewModel()
            {
                GameGenres = genres
            };
            return View(vm);
        }

        public ActionResult List(int id)
        {

            var games = db.Games.Where(q => q.GameGenreId == id).ToList();
            //var genres = db.GameGenres.Where(g => g.GenreName == "Lotto").OrderByDescending(a => a.GenreName).ToList();

            var vm = new HomeViewModel()
            {
                Games = games
            };
            ViewBag.numer = id;
            return View(vm);
            //return View();
        }
    }
}