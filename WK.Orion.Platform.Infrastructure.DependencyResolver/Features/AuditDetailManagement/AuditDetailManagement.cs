using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features.AuditDetailManagement
{
    public class AuditDetailManagement : FeatureServiceBase, IFeatureService
    {
        public FeatureType FeatureType => FeatureType.AuditDetailManagement;

        public override void Run(ContainerBuilder builder, ServiceTypes serviceTypes)
        {
            base.Run(builder, serviceTypes);
            
            //tasks
            Tasks.DR.Bootstrapping.BootstrapHandler.Run(builder, serviceTypes);
        }
    }
}