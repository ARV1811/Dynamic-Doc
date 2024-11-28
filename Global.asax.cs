using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SyncfusionMvcApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			//Syncfusion Licensing Register
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBPh8sVXJzS0d+WFlPdV5fXGFUd1p/THNbfFR1fV9DaVdTRHRbQ1xhTn9WckNmUXxcdnU=");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
