using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Controllers;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Filters;
using WK.Orion.Platform.Examples.Components.Framework.Interfaces;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features;

namespace WK.Orion.Applications.ADM
{
    /// <summary>   An orion container builder. </summary>
    public class OrionContainerBuilder : ContainerBuilder
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Registers the filters. </summary>
        ///-------------------------------------------------------------------------------------------------
        public void RegisterFilters()
        {
            // Register the Autofac filter provider.
            this.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            //Register Logging for all controller actions
            this.Register(z => new LoggingActionFilter(z.Resolve<ILogService>()))
                .AsWebApiActionFilterFor<OrionApiController>()
                .InstancePerRequest();

            //Register Exception handling for all controller actions
            this.Register(z => new ExceptionHandlerActionFilter(z.Resolve<IExceptionService>(), z.Resolve<ILogService>()))
                .AsWebApiExceptionFilterFor<OrionApiController>();
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