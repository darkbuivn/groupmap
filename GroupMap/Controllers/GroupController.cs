using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupMap.Service;
using GroupMap.Models;

namespace GroupMap.Controllers
{
    [Authorize]
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult Index()
        {
            return View();
        }
    }
}