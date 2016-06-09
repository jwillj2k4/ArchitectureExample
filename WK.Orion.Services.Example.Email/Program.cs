using System.ServiceProcess;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features;
using WK.Orion.Services.Example.Email.BusinessLogic.Interfaces;

namespace WK.Orion.Services.Example.Email
{
    static class Program
    {
        private static OrionDependencyResolver _orionDependencyResolver;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var containerBuilder = new OrionContainerBuilder();

            //resolve anything specific to the service first (if needed)
            Infrastructure.Bootstrapper.RegisterTypes(containerBuilder);

            //resolve dependencies
            _orionDependencyResolver = containerBuilder.Register(FeatureType.Email, ServiceTypes.Windows);

            var servicesToRun = new ServiceBase[]
            {
                //inject dependencies
                new Service1(_orionDependencyResolver.GetService<IEmailService>())
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
