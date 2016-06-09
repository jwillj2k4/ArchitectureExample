using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Controllers;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Filters;
using WK.Orion.Platform.Examples.Components.Framework.Interfaces;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR;

namespace WK.Orion.Applications.ADM
{
    /// <summary>   An orion container builder. </summary>
    public class OrionContainerBuilder : ContainerBuilder
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Registers this object. </summary>
        ///
        /// <param name="auditDetailManagement">    The audit detail management. </param>
        /// <param name="web">                      The web. </param>
        ///-------------------------------------------------------------------------------------------------
        public void Register(FeatureType auditDetailManagement, ServiceTypes web)
        {
            BoostrapHandler.RegisterDependencies(this, FeatureType.AuditDetailManagement, ServiceTypes.Web);


            RegisterControllers();

            RegisterFilters();

            SetDependencyResolver();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Registers the filters. </summary>
        ///-------------------------------------------------------------------------------------------------
        private void RegisterFilters()
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
        private void RegisterControllers()
        {
            // Register your Web API controllers.
            this.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }
        
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets dependency resolver. </summary>
        ///-------------------------------------------------------------------------------------------------
        private void SetDependencyResolver()
        {
            GlobalConfiguration.Configuration.DependencyResolver = new OrionApiDependencyResolver(Build());
        }
    }
}