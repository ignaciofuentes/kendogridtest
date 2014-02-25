using KendoUIMvcApplication5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace KendoUIMvcApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<Arbitrator> { 
                new Arbitrator {Id=1, AverageRating="100", Company="Ford", Location="Boston", MostRecentArbitration="One Day Ago", Name="John Doe" },
                new Arbitrator {Id=2, AverageRating="100", Company="Chevrolet", Location="Boston", MostRecentArbitration="Two Days Ago", Name="Jane Doe" },
                new Arbitrator {Id=3, AverageRating="90", Company="Chrysler", Location="Boston", MostRecentArbitration="Three Days Ago", Name="Jean Doe" }            
            };

            return View(list);
        }


        public ActionResult Index2()
        {

            return View();
        }

        public ActionResult GridDetail()
        {
            var l = new List<Person>() { new Person() { AssignedTo = "Me", BaseId = 1, Icon = "s", Title="Whats up" } };
            return View(l);
        }

        public ActionResult GridData([DataSourceRequest] DataSourceRequest request)
        {
            var list = new List<Arbitrator> { 
                new Arbitrator {Id=1, AverageRating="101", Company="Ford", Location="Boston", MostRecentArbitration="One Day Ago", Name="John Doe" },
                new Arbitrator {Id=2, AverageRating="100", Company="Chevrolet", Location="Boston", MostRecentArbitration="Two Days Ago", Name="Jane Doe" },
                new Arbitrator {Id=3, AverageRating="90", Company="Chrysler", Location="Boston", MostRecentArbitration="Three Days Ago", Name="Jean Doe" }            
            };

            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }


    }
}
