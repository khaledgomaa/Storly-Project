using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
<<<<<<< HEAD
=======
using AutoMapper;
using Storly.App_Start;
>>>>>>> Adding dataTables and using ajax to call web api

namespace Storly
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
<<<<<<< HEAD
=======
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
>>>>>>> Adding dataTables and using ajax to call web api
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
