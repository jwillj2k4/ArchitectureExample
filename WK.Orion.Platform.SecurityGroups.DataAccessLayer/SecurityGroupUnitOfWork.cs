using System.Threading.Tasks;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.SecurityGroups.DataAccessLayer.Interfaces;
using WK.Orion.Platform.SecurityGroups.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.SecurityGroups.DataAccessLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class SecurityGroupUnitOfWork : ISecurityGroupUnitOfWork
    {
        public ISecurityGroupRepository SecurityGroupRepo { get; }

        public SecurityGroupUnitOfWork(ISecurityGroupRepository securityGroupRepo)
        {
            SecurityGroupRepo = securityGroupRepo;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a task&lt; i orion udf dto&gt; using the given identifier. </summary>
        ///
        /// <param name="id">   The identifier to get. </param>
        ///
        /// <returns>   A Task&lt;IOrionUdfDto&gt; </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IOrionSecurityGroupDto> Get(long id)
        {
            var taskDto = await SecurityGroupRepo.GetOne(id);
             
            return taskDto;
        }
    }
}