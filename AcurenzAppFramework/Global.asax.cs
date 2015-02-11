﻿using AcurenzAppFramework.DataAccess;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TwitterBootstrapMVC;

namespace AcurenzAppFramework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Bootstrap.Configure();

            using (var ctx = new DriverLicenseStoreContext())
            {
                ctx.Database.Initialize(false);
            }

            // Use feature view locations
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new AcurenzViewEngine());
        }
    }
}
