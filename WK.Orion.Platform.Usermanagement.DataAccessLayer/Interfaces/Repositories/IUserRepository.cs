using System.Threading.Tasks;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for iudf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IUserRepository
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
