using System.Web.Mvc;
using GroupMap.Common.Constant;
using GroupMap.Controllers.Base;
using GroupMap.Service;
using GroupMap.Models.ViewModels;
using GroupMap.Models;
using Microsoft.AspNet.Identity;
using AutoMapper;

namespace GroupMap.Controllers
{
    public class ProfileController : AuthorizeController
    {
        IProfileService _service = new ProfileService();
        // GET: Profile
        public ActionResult Index()
        {
            ViewBag.Title = Constant.PAGE_TITLE_PROFILE_INDEX;

            ProfileViewModel model = new ProfileViewModel();
            UserProfile profile = _service.GetByUserID(User.Identity.GetUserId());
            model = Mapper.Map<ProfileViewModel>(profile);
            return View(model);
        }
    }
}