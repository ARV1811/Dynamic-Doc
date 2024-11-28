using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.QueryBuilder;
namespace SyncfusionMvcApplication1.Controllers
{
    public partial class QueryBuilderController : Controller
    {
        public ActionResult QueryBuilderFeatures()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="Employee ID", Field="EmployeeID", Type="number", Operator="equal", Value = 1 },
                    new QueryBuilderRule { Label="Title", Field="Title", Type="string", Operator="equal", Value = "Sales Manager" }
                }
            };
            ViewBag.importRules = rule;
            return View();
        }
    }
}
