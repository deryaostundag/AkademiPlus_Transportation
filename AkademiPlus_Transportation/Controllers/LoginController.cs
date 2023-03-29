﻿using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AkademiPlus_Transportation.Controllers
{
    public class LoginController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin p)
        {
            var values = db.TblAdmin.Where(x => x.UserName == p.UserName & x.Password == p.Password).FirstOrDefault();
            if (values != null )
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["Username"] = p.UserName;
                return RedirectToAction("Index", "Customer");
            }
            return View();
        }
    }
}