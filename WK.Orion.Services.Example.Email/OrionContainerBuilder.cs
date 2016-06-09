using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features;

namespace WK.Orion.Services.Example.Email
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
        public OrionDependencyResolver Register(FeatureType auditDetailManagement, ServiceTypes web)
        {
            BoostrapHandler.RegisterDependencies(this, FeatureType.DocumentPolicyManagement, ServiceTypes.Windows);
            
            RegisterFilters();

           return SetDependencyResolver();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Registers the filters. </summary>
        ///-------------------------------------------------------------------------------------------------
        private static void RegisterFilters()
        {
            //// Register the Autofac filter provider.
            //this.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            ////Register Logging for all controller actions
            //this.Register(z => new LoggingActionFilter(z.Resolve<ILogService>()))
            //    .AsWebApiActionFilterFor<OrionApiController>()
            //    .InstancePerRequest();

            ////Register Exception handling for all controller actions
            //this.Register(z => new ExceptionHandlerActionFilter(z.Resolve<IExceptionService>(), z.Resolve<ILogService>()))
            //    .AsWebApiExceptionFilterFor<OrionApiController>();
        }
  
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets dependency resolver. </summary>
        ///-------------------------------------------------------------------------------------------------
        private OrionDependencyResolver SetDependencyResolver()
        {
            //create a resolver
            return new OrionDependencyResolver(Build());
        }
    }
}