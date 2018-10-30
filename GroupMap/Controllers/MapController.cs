using GroupMap.Common.Constant;
using GroupMap.Controllers.Base;
using GroupMap.Models;
using GroupMap.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupMap.Controllers
{
    public class MapController : AuthorizeController
    {
        private IProfileService _service = new ProfileService();
        // GET: Map
        public ActionResult Index()
        {
            ViewBag.Title = Constant.PAGE_TITLE_GROUPMAP_INDEX;
            UserProfile profile = _service.GetByUserID(User.Identity.GetUserId());
            ViewBag.LatestCoordinate = profile.Coordinates.OrderByDescending(x => x.ReceivedDate).FirstOrDefault();
            return View();
        }
    }
}