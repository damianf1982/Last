//using FoxRoles.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace FoxRoles.Controllers
//{
//    [Authorize]
//    public class GymController : Controller
//    {
//        // GET: Gym
//        public ActionResult Index()
//        {
//            GymEntities db = new GymEntities();
//            //  GymSession gymSession = new GymSession();

//            GymSession gymSession = db.GymSessions.SingleOrDefault(x => x.GymSessionsId == 1);
//            ViewGymsModel vgm = new ViewGymsModel();

//        //    vgm.SessionName = gymSession.SessionName;

//            return View(vgm);
//        }
//    }
//}