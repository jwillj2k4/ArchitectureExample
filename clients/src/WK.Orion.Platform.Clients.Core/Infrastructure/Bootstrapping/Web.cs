using Autofac;

namespace WK.Orion.Platform.Examples.Components.Clients.Core.Infrastructure.Bootstrapping
{
    public class Web : Base
    {
        public new static void BootStrap(ContainerBuilder builder)
        {
            Base.BootStrap(builder);
        }
    }
}