using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Serilog;

namespace MVCProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var logPath = @"D:\Work\MVCProject\Logs\log-.txt";

            if (!System.IO.Directory.Exists(@"D:\Work\MVCProject\Logs"))
            {
                System.IO.Directory.CreateDirectory(@"D:\Work\MVCProject\Logs");
            }

            Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.File(logPath,
            rollingInterval: RollingInterval.Day)
        .CreateLogger();

    Log.Information("Application Started Successfully");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_End()
        {
            Log.CloseAndFlush();
        }
    }
}
