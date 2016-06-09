using System.Threading.Tasks;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.UserManagement.BusinessLogicLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IUserService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        Task<IOrionUserDto> GetOne(long id);
    }
}
