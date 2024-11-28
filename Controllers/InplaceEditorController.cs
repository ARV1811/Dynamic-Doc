using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SyncfusionMvcApplication1.Controllers
{
    public partial class InplaceEditorController : Controller
    {
        public ActionResult InplaceEditorFeatures()
        {
              ViewBag.data = new { placeholder = "Enter employee name" };
			  ViewBag.value = "Andrew";
            return View();
        }        
    }
}
