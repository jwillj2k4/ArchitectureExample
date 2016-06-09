using WK.Orion.Platform.UserManagement.Core.Converters.Interfaces;
using WK.Orion.Platform.UserManagement.Core.Models.Entities;
using WK.Orion.Platform.UserManagement.Core.Models.Projections;

namespace WK.Orion.Platform.UserManagement.Core.Converters.Services
{
    /// <summary>   A user converter. </summary>
    public class UserConverter : IUserConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given user. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An OrionUserDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionUser Convert(OrionUserDto dto)
        {
            var orionUDF = new OrionUser()
            {
                Id = dto.Id,
                CreatedByUserId = dto.CreatedByUserId,
                DateCreated = dto.DateCreated,
                Name = dto.Name

            };

            return orionUDF;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given user. </summary>
        ///
        /// <param name="user"> The user. </param>
        ///
        /// <returns>   An OrionUserDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionUserDto Convert(OrionUser user)
        {
            var orionUDFDto = new OrionUserDto()
            {
                Id = user.Id,
                CreatedByUserId = user.CreatedByUserId,
                DateCreated = user.DateCreated,
                Name = user.Name
            };

            return orionUDFDto;
        }
    }
}