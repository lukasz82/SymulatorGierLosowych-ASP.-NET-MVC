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
            int x = 1234;
            return Json(x, JsonRequestBehavior.AllowGet);
        }

    }
}