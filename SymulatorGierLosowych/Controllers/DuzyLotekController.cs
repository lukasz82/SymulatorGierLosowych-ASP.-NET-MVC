using SymulatorGierLosowych.ClassOfGenerators;
using SymulatorGierLosowych.MyCalsses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace SymulatorGierLosowych.Controllers
{
    public class DuzyLotekController : Controller
    {
        // GET: DuzyLotek
        public ActionResult DuzyLotek()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetNumber()
        {
            List<GeneratorModel> list = new List<GeneratorModel>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new GeneratorModel { num_of_numbers = i, name = "nowe" });
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetNumbers()
        {
            RandomNumbersGenerator numberGenerator = new RandomNumbersGenerator();
           
            var table = numberGenerator.ReturnNumbers(6);
            return Json(table, JsonRequestBehavior.AllowGet);
        }

    }
}