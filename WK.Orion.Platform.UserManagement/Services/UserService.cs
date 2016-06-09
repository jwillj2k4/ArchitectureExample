using System.Collections.Generic;
using WK.Orion.Platform.UserManagement.Core.Models.Projections;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.UserManagement.Interfaces;

namespace WK.Orion.Platform.UserManagement.Services
{
    /// <summary>   An udf service. </summary>
    public class UserService : IUserService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IOrionUserDto GetOne(long id)
        {
            return new OrionUserDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        public IEnumerable<IOrionUserDto> GetAll()
        {
            return new List<OrionUserDto>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an i orion udf dto using the given item identifier. </summary>
        ///
        /// <param name="itemId">   The item identifier to get. </param>
        ///
        /// <returns>   An IOrionUserDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IOrionUserDto Get(long itemId)
        {
            return new OrionUserDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion udf dto. </summary>
        ///
        /// <param name="orionUserDto">  The orion udf dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        public void Save(IOrionUserDto orionUserDto)
        {
            //add to repo
            // save changes
        }
    }
}
