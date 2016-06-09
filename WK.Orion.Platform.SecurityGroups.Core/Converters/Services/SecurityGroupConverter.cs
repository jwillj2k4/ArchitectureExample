using WK.Orion.Platform.SecurityGroups.Core.Converters.Interfaces;
using WK.Orion.Platform.SecurityGroups.Core.Models.Entities;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections;

namespace WK.Orion.Platform.SecurityGroups.Core.Converters.Services
{
    /// <summary>   A securityGroup converter. </summary>
    public class SecurityGroupConverter : ISecurityGroupConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given securityGroup. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An orionSecurityGroupDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionSecurityGroup Convert(OrionSecurityGroupDto dto)
        {
            var orionSecurityGroup = new OrionSecurityGroup()
            {
                Id = dto.Id,
                CreatedByUserId = dto.CreatedByUserId,
                DateCreated = dto.DateCreated,
                Name = dto.Name

            };

            return orionSecurityGroup;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given securityGroup. </summary>
        ///
        /// <param name="securityGroup"> The securityGroup. </param>
        ///
        /// <returns>   An orionSecurityGroupDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionSecurityGroupDto Convert(OrionSecurityGroup securityGroup)
        {
            var orionSecurityGroupDto = new OrionSecurityGroupDto()
            {
                Id = securityGroup.Id,
                CreatedByUserId = securityGroup.CreatedByUserId,
                DateCreated = securityGroup.DateCreated,
                Name = securityGroup.Name
            };

            return orionSecurityGroupDto;
        }
    }
}