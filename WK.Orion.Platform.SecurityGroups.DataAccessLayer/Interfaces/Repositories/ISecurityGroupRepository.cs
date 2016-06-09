using System.Threading.Tasks;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.SecurityGroups.DataAccessLayer.Interfaces.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for iudf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface ISecurityGroupRepository
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        Task<IOrionSecurityGroupDto> GetOne(long id);
    }
}
