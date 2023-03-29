using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class StatisticController : Controller
    {
        DbTransportEntities db=new DbTransportEntities();   
        public ActionResult Index()
        {
            //ViewBag - ViewData
            
            
            var value1 = db.TblCustomer.Count();
            ViewBag.v1 = value1;
            ViewBag.test = "Selam Nasılsın";

            ViewBag.customerCount = db.TblCustomer.Count();
            ViewBag.cityAnkara = db.TblCustomer.Where(x => x.CustomerCity == "Ankara").Count();
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.customerCity = db.TblCustomer.Where(x => x.CustomerID == 1).Select(y => y.CustomerCity).FirstOrDefault();
            


            return View();
        }
    }
}