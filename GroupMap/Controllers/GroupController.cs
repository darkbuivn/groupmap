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
    }
}