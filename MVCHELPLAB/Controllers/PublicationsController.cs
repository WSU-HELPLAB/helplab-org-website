using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHELPLAB.Controllers
{
    public class PublicationsController : Controller
    {
        //
        // GET: /Publications/
        //TO DO: Clean up publication code to generate script each separately without hard coding it. To lessen the number of lines of code....
        public ActionResult Index()
        {

            return View();
        }
	}
}