using System.Threading.Tasks;
using WK.Orion.Platform.SecurityGroups.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.SecurityGroups.BusinessLogicLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface ISecurityGroupService
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
