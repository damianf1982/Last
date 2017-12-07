using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoxRoles.Controllers
{
    [Authorize(Roles = "Nobody")]
    public class OoopsController : Controller
    {
        // GET: Ooops
        public ActionResult Index()
        {
            return View();
        }
    }
}