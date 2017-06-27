using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHELPLAB.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OSBLE()
        {
            return View();
        }
        public ActionResult BlindProgrammingProject()
        {
            return View();
        }
        public ActionResult ChemProV()
        {
            return View();
        }
        public ActionResult ProtoWalkthrough()
        {
            return View();
        }

        public ActionResult WOZPro()
        {
            return View();
        }

        public ActionResult ALVIS()
        {
            return View();
        }
	}
}