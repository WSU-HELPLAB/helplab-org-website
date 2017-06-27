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
            string[] divAuthorNames = new string[11] { "carter-publistdiv", "hundhausen-publistdiv", "agrawal-publistdiv","pagrawal-publistdiv","brown-publistdiv","farley-publistdiv","nevins-publistdiv","stefik-publistdiv","trent-publistdiv","vatrapu-publistdiv","wingstrom-publistdiv" };
            string[] tagAuthorNames = new string[11] { "adam-carter", "chris-hundhausen", "anu-agrawal", "pawan-agrawal", "jonathan-brown", "sean-farley", "cole-nevins", "andreas-stefik", "stephen-trent", "ravikiran-vatrapu", "josh-wingstrom" };

            ViewBag.divs = divAuthorNames;
            ViewBag.tags = tagAuthorNames; 


            return View();
        }
	}
}