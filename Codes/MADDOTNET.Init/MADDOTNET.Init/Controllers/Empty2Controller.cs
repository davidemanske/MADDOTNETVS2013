using MADDOTNET.Init.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MADDOTNET.Init.Controllers
{
    public class Empty2Controller : Controller
    {
        public ActionResult Index()
        {
            MADDOTNETDbContext dbContext = new MADDOTNETDbContext();
            return View();
        }
	}
}