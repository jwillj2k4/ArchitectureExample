using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Enums;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features
{
    public abstract class FeatureServiceBase
    {
        public virtual void Run(ContainerBuilder builder, ServiceTypes serviceTypes)
        {
            //calls into base components that are apart of every feature
            
            //framework
            Framework.Infrastructure.Bootstrapping.BootstrapHandler.Run(builder, serviceTypes);

            //user defined fields
            UserDefinedFields.DR.Bootstrapping.BootstrapHandler.Run(builder, serviceTypes);

            //clients
            Clients.DR.Bootstrapping.BootstrapHandler.Run(builder, serviceTypes);
            
            //multilingual
            ML.DR.Bootstrapping.BootstrapHandler.Run(builder, serviceTypes);

            //user management
            UserManagement.DR.Bootstrapping.BootstrapHandler.Run(builder,serviceTypes);

            //security groups
            SecurityGroups.DR.Bootstrapping.BootstrapHandler.Run(builder, serviceTypes);

            //tasks
            Tasks.DR.Bootstrapping.BootstrapHandler.Run(builder, serviceTypes);
        }
    }
}