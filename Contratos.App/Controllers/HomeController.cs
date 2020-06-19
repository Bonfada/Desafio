﻿using System.Web.Mvc;

namespace Contratos.App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Mensagens()
        {
            return View();
        }
    }
}