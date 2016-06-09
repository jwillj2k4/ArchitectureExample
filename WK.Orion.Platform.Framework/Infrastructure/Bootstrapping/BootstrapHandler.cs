using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Framework.Interfaces;
using WK.Orion.Platform.Examples.Components.Framework.Services;

namespace WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping
{
    public class BootstrapHandler
    {
        public static void Run(ContainerBuilder builder, ServiceTypes serviceType)
        {
            if (serviceType == ServiceTypes.Web)
            {
                builder.RegisterType<LogService>().As<ILogService>();
                builder.RegisterType<ExceptionService>().As<IExceptionService>();
            }
            else
            {
                builder.RegisterType<LogService>().As<ILogService>();
                builder.RegisterType<ExceptionService>().As<IExceptionService>();
            }
        }
    }
}