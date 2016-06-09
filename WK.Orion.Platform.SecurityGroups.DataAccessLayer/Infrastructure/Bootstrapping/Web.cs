using Autofac;

namespace WK.Orion.Platform.SecurityGroups.DataAccessLayer.Infrastructure.Bootstrapping
{
    public class Web : Base
    {
        public new static void BootStrap(ContainerBuilder builder)
        {
            Base.BootStrap(builder);
        }
    }
}