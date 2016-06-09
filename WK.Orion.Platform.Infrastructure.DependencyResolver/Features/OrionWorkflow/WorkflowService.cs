using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features.OrionWorkflow
{
    public class WorkflowService : FeatureServiceBase, IFeatureService
    {
        public FeatureType FeatureType => FeatureType.Workflow;
    }
}