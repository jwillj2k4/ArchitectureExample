using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features.ContractRelationshipManagement
{
    public class ContractRelationshipManagement : FeatureServiceBase, IFeatureService
    {
        public FeatureType FeatureType => FeatureType.ContractRelationshipManagement;
    }
}