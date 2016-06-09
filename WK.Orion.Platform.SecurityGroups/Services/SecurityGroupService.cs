using System.Collections.Generic;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.SecurityGroups.Interfaces;

namespace WK.Orion.Platform.SecurityGroups.Services
{
    /// <summary>   An udf service. </summary>
    public class SecurityGroupService : ISecurityGroupService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IOrionSecurityGroupDto GetOne(long id)
        {
            return new OrionSecurityGroupDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        public IEnumerable<IOrionSecurityGroupDto> GetAll()
        {
            return new List<OrionSecurityGroupDto>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an i orion udf dto using the given item identifier. </summary>
        ///
        /// <param name="itemId">   The item identifier to get. </param>
        ///
        /// <returns>   An IOrionSecurityGroupDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IOrionSecurityGroupDto Get(long itemId)
        {
            return new OrionSecurityGroupDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion udf dto. </summary>
        ///
        /// <param name="orionSecurityGroupDto">  The orion udf dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        public void Save(IOrionSecurityGroupDto orionSecurityGroupDto)
        {
            //add to repo
            // save changes
        }
    }
}
