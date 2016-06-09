using WK.Orion.Platform.SecurityGroups.Core.Models.Entities;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections;

namespace WK.Orion.Platform.SecurityGroups.Core.Converters.Interfaces
{
    /// <summary>   Interface for securityGroup converter. </summary>
    public interface ISecurityGroupConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given securityGroup. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An orionSecurityGroupDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionSecurityGroup Convert(OrionSecurityGroupDto dto);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given securityGroup. </summary>
        ///
        /// <param name="securityGroup"> The securityGroup. </param>
        ///
        /// <returns>   An orionSecurityGroupDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionSecurityGroupDto Convert(OrionSecurityGroup securityGroup);
    }
}