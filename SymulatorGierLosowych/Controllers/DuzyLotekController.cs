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
        public JsonResult GetNumbers2(int x, int y)
        {
            RandomNumbersGenerator numberGenerator = new RandomNumbersGenerator();
           
            var table = numberGenerator.ReturnNumbers(x,y);
            return Json(table, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetNumbers4(int x1, int y1, int x2, int y2)
        {
            RandomNumbersGenerator numberGenerator1 = new RandomNumbersGenerator();
            RandomNumbersGenerator numberGenerator2 = new RandomNumbersGenerator();
           
            var table1 = numberGenerator1.ReturnNumbers(x1,y1);
            var table2 = numberGenerator2.ReturnNumbers(x2,y2);
            return Json(new { tab1 = table1, tab2 = table2 },JsonRequestBehavior.AllowGet);
        }

        //[HttpGet]
        //public JsonResult GetNumbers(int x, int y, int x1, int y1)
        //{
        //    RandomNumbersGenerator numberGenerator = new RandomNumbersGenerator();
           
        //    var table = numberGenerator.ReturnNumbers(x,y);
        //    return Json(table, JsonRequestBehavior.AllowGet);
        //}

    }
}