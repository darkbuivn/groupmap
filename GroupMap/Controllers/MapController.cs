using GroupMap.Common.Constant;
using GroupMap.Controllers.Base;
using GroupMap.Models;
using GroupMap.Service;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
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
        public ActionResult Index(string groupId)
        {
            ViewBag.Title = Constant.PAGE_TITLE_GROUPMAP_INDEX;            
            UserProfile profile = _service.GetByUserID(User.Identity.GetUserId());
            ViewBag.Me = Constant.ME;
            ViewBag.locations = JsonConvert.SerializeObject(new List <object>
            {   
                new { lat = 10.8289, lng = 106.612 },
                new { lat = 10.8189, lng = 106.621 },
                new { lat = 10.8233, lng = 106.617 },
                new { lat = 10.8210, lng = 106.6164 }
            });
            
            ViewBag.MyLatestCoordinate = profile.Coordinates.OrderByDescending(x => x.ReceivedDate).FirstOrDefault();
            return View();
        }
    }
}