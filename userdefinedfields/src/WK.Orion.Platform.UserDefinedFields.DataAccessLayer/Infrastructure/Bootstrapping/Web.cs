using Autofac;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Infrastructure.Bootstrapping
{
    public class Web : Base
    {
        public new static void BootStrap(ContainerBuilder builder)
        {
            Base.BootStrap(builder);
        }
    }
}