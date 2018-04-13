﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TobChatWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TobChat About Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact the developers at: ";

            return View();
        }
    }
}