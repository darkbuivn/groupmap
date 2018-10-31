using GroupMap.Common.Constant;
using GroupMap.Controllers.Base;
using System.Web.Mvc;

namespace GroupMap.Controllers
{
    public class GroupController : AuthorizeController
    {
        // GET: Group
        public ActionResult Index()
        {
            return View();
        }

        // Get
        public ActionResult CreateGroup()
        {
            ViewBag.Title = Constant.PAGE_TITLE_GROUPMAP_CREATE;
            return View();
        }

        //[HttpPost]
        //public ActionResult CreateGroup()
        //{
        //    return View();
        //}
    }
}