using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisualDisplay.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Main()
        {
            return View();
        }

        public PartialViewResult demo() {


            return PartialView();
        }

        public PartialViewResult demo1()
        {


            return PartialView();
        }

        public PartialViewResult partialView3() {

            return PartialView();
        }

        public PartialViewResult absentism() {


            return PartialView();
        }

        public PartialViewResult oee() {

            return PartialView();
        }

        public PartialViewResult breakDown() {


            return PartialView();
        }

        public PartialViewResult planMachine()
        {


            return PartialView();
        }

        public ActionResult dashboard()
        {
            return View();
        }
    }
}