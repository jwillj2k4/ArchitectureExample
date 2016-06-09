using System.Threading.Tasks;
using WK.Orion.Platform.SecurityGroups.BusinessLogicLayer.Interfaces;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.SecurityGroups.DataAccessLayer.Interfaces;

namespace WK.Orion.Platform.SecurityGroups.BusinessLogicLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class SecurityGroupService : ISecurityGroupService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The task unit of work. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly ISecurityGroupUnitOfWork _securityGroupUnitOfWork;

        public SecurityGroupService(ISecurityGroupUnitOfWork securityGroupUnitOfWork)
        {
            _securityGroupUnitOfWork = securityGroupUnitOfWork;
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
            var taskDto = await _securityGroupUnitOfWork.SecurityGroupRepo.GetOne(id);

            return taskDto;
        }
    }
}