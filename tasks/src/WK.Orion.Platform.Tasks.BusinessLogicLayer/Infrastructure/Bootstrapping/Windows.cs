using Autofac;

namespace WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer.Infrastructure.Bootstrapping
{
    public class Windows : Base
    {
        public new static void BootStrap(ContainerBuilder builder)
        {
            Base.BootStrap(builder);
        }
    }
}