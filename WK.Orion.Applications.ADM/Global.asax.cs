using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WK.Orion.Platform.Examples.Components.Framework.Enums;

namespace WK.Orion.Applications.ADM
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalRegistration();

            var containerBuilder = new OrionContainerBuilder();

            containerBuilder.Register(FeatureType.AuditDetailManagement, ServiceTypes.Web);
        }

        private static void GlobalRegistration()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}