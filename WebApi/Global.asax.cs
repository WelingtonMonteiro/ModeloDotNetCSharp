using WebApi.App_Start;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Mvc;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AutoMapperConfig.Configure();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
