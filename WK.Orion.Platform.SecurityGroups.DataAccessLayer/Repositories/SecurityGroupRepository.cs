using System.Threading.Tasks;
using WK.Orion.Platform.SecurityGroups.Core.Converters.Interfaces;
using WK.Orion.Platform.SecurityGroups.Core.Models.Entities;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.SecurityGroups.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.SecurityGroups.DataAccessLayer.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An udf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class SecurityGroupRepository : ISecurityGroupRepository
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The udf converter. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly ISecurityGroupConverter _securityGroupConverter;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Repositories.SecurityGroupRepository class.
        /// </summary>
        ///
        /// <param name="securityGroupConverter"> The udf converter. </param>
        ///-------------------------------------------------------------------------------------------------
        public SecurityGroupRepository(ISecurityGroupConverter securityGroupConverter)
        {
            _securityGroupConverter = securityGroupConverter;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IOrionSecurityGroupDto> GetOne(long id)
        {
            //wire up db context, call to get task
            var orionSecurityGroup = await Task.FromResult(new OrionSecurityGroup());

            var taskDto = _securityGroupConverter.Convert(orionSecurityGroup);

            return taskDto;
        }
    }
}