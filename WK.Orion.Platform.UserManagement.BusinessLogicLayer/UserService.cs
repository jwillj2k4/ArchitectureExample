using System.Threading.Tasks;
using WK.Orion.Platform.UserManagement.BusinessLogicLayer.Interfaces;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces;

namespace WK.Orion.Platform.UserManagement.BusinessLogicLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class UserService : IUserService
    {
        private readonly IUserUnitOfWork _userUnitOfWork;

        public UserService(IUserUnitOfWork userUnitOfWork)
        {
            _userUnitOfWork = userUnitOfWork;
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
            var taskDto = await _userUnitOfWork.UserRepo.GetOne(id);

            return taskDto;
        }
    }
}