using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;

namespace KendoUIMvcApplication5.Controllers
{

    public class _StagingSpecific : _RecordState
    {
        public string ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string Comments { get; set; }
        public Boolean ToDelete { get; set; }
    }

    public class _RecordState
    {
        public int? Rst_row_id { get; set; }
        public string Rst_record_st { get; set; }
        public string Rst_record_st_desc { get; set; }
    }

    public class RelationshipDetailStag : _StagingSpecific
    {
        public int? Rdt_row_id { get; set; }
        public string Rdt_name { get; set; }
        public string Rdt_desc { get; set; }
        public string Rdt_notes { get; set; }
        public string Rdt_src_wlth { get; set; }
    }


    public class CRMController : Controller
    {
        //
        // GET: /CRM/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RelationshipDetailEdit_Read([DataSourceRequest] DataSourceRequest request)
        {
            var list = new List<RelationshipDetailStag> { new RelationshipDetailStag { Rdt_name = "My second name", Rdt_notes = "My Notes", Rdt_desc = "My Description", Rst_record_st = "My Status" }, new RelationshipDetailStag { Rdt_name = "My name", Rdt_notes = "My Notes", Rdt_desc = "My Description", Rst_record_st = "My Status" }, new RelationshipDetailStag{Rdt_name="My thirdname", Rdt_notes="My Notes", Rdt_desc="My Description", Rst_record_st="My Status"} };
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

    }
}
