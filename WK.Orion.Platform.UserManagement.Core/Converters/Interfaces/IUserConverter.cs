using WK.Orion.Platform.UserManagement.Core.Models.Entities;
using WK.Orion.Platform.UserManagement.Core.Models.Projections;

namespace WK.Orion.Platform.UserManagement.Core.Converters.Interfaces
{
    /// <summary>   Interface for user converter. </summary>
    public interface IUserConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given user. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An OrionUserDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionUser Convert(OrionUserDto dto);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given user. </summary>
        ///
        /// <param name="user"> The user. </param>
        ///
        /// <returns>   An OrionUserDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionUserDto Convert(OrionUser user);
    }
}