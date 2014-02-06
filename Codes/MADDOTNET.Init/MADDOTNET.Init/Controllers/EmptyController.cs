using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MADDOTNET.Init.Controllers
{
    public class EmptyController : Controller
    {

        //private Logger logger = new Logger();
        //
        // GET: /Empty/
        public ActionResult Index()
        {
            //logger.Warn("dave")
            return View();
        }
	}
}