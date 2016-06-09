using Autofac;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Services;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.Infrastructure.Bootstrapping
{
    public class Web
    {
        public static void BootStrap(ContainerBuilder builder)
        {
            Base.BootStrap(builder);

            builder.RegisterType<UDFService>().As<IUDFService>();
        }
    }
}