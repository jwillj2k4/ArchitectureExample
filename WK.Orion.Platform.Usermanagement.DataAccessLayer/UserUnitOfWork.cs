using System.Threading.Tasks;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces;
using WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.UserManagement.DataAccessLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class UserUnitOfWork : IUserUnitOfWork
    {
        public IUserRepository UserRepo { get; }

        public UserUnitOfWork(IUserRepository userRepo)
        {
            UserRepo = userRepo;
        }
        
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a task&lt; i orion udf dto&gt; using the given identifier. </summary>
        ///
        /// <param name="id">   The identifier to get. </param>
        ///
        /// <returns>   A Task&lt;IOrionUdfDto&gt; </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IOrionUserDto> Get(long id)
        {
            var taskDto = await UserRepo.GetOne(id);
             
            return taskDto;
        }

    }
}