using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace DevExpressMvcApplication17.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            return View();
        }
        public ActionResult PivotGridPartial() {
            return PartialView("PivotGridPartial");
        }

        [HttpPost]
        public ActionResult PostPivotGridState() {
            ViewBag.Message = "The PivotGrid state has been restored successfully";
            return View("Index");
        }
    }
}