using KendoUIMvcApplication5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIMvcApplication5.Controllers
{
    public class ChartController : Controller
    {

        public ActionResult Index()
        {
            var model = new ChartModel();
            var elements = new List<dynamic>();
            elements.Add(new { value = 100, color = "blue" });
            elements.Add(new { value = 12, color = "red" });
            elements.Add(new { value = 60, color = "purple" });
            model.BarElements = elements;
            model.Categories = new List<string> { "total", "halfway", "actual" };
            return View(model);
        }
    }
}
