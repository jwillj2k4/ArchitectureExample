using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR;

namespace WK.Orion.Applications.DPM
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalRegistration();

            var containerBuilder = new OrionContainerBuilder();

            BoostrapHandler.RegisterDependencies(containerBuilder,
                FeatureType.DocumentPolicyManagement, ServiceTypes.Web);

            containerBuilder.RegisterControllers();
            containerBuilder.RegisterFilters();

            containerBuilder.SetDependencyResolver();
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