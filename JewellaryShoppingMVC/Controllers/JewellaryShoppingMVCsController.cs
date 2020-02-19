using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JewellaryShoppingMVC.Controllers
{
    public class JewellaryShoppingMVCsController : Controller
    {
        // GET: JewellaryShoppingMVC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}