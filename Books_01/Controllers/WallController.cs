using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Books_01.Models.Wall;

namespace Books_01.Controllers
{
    public class WallController: Controller
    {

        WallRepository wallReppo;
        public WallController()
        {
            wallReppo = new WallRepository();
        }
        public ActionResult Wall()
        {
            return View();
        }
    }
}