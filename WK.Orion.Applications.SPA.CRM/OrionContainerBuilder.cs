using System.Reflection;
using System.Web.Http;
using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Controllers;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Filters;
using WK.Orion.Platform.Examples.Components.Framework.Interfaces;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features;

namespace WK.Orion.Applications.SPA.CRM
{
    /// <summary>   An orion container builder. </summary>
    public class OrionContainerBuilder : ContainerBuilder
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Registers the filters. </summary>
        ///-------------------------------------------------------------------------------------------------
        public void RegisterFilters()
        {
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Registers the controllers. </summary>
        ///-------------------------------------------------------------------------------------------------
        public void RegisterControllers()
        {
            // Register your Web API controllers.
            this.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }
        
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets dependency resolver. </summary>
        ///-------------------------------------------------------------------------------------------------
        public void SetDependencyResolver()
        {
            GlobalConfiguration.Configuration.DependencyResolver = new OrionApiDependencyResolver(Build());
        }
    }
}