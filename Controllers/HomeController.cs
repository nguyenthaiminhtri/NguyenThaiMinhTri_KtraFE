using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenThaiMinhTri_KtraFE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TrangChu()
        {
            return View();
        }

        public ActionResult MasterLayout1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        ////public ActionResult Contact()
        ////{
        ////    ViewBag.Message = "Your contact page.";

        ////    return View();
        //}
    }
}