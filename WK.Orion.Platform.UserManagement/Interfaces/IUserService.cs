using System.Collections.Generic;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.UserManagement.Interfaces
{
    /// <summary>   Interface for iudf service. </summary>
    public interface IUserService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        IOrionUserDto GetOne(long id);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        IEnumerable<IOrionUserDto> GetAll();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an i orion udf dto using the given item identifier. </summary>
        ///
        /// <param name="itemId">   The item identifier to get. </param>
        ///
        /// <returns>   An IOrionUserDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        IOrionUserDto Get(long itemId);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion udf dto. </summary>
        ///
        /// <param name="orionUserDto">  The orion udf dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        void Save(IOrionUserDto orionUserDto);
    }
}
