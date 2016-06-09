using System.Threading.Tasks;
using WK.Orion.Platform.UserManagement.Core.Converters.Interfaces;
using WK.Orion.Platform.UserManagement.Core.Models.Entities;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.UserManagement.DataAccessLayer.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An udf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class UserRepository : IUserRepository
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The udf converter. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly IUserConverter _iudfConverter;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Repositories.UserRepository class.
        /// </summary>
        ///
        /// <param name="iudfConverter"> The udf converter. </param>
        ///-------------------------------------------------------------------------------------------------
        public UserRepository(IUserConverter iudfConverter)
        {
            _iudfConverter = iudfConverter;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IOrionUserDto> GetOne(long id)
        {
            //wire up db context, call to get task
            var task = await Task.FromResult(new OrionUser());

            var taskDto = _iudfConverter.Convert(task);

            return taskDto;
        }
    }
}