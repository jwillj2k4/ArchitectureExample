using WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IUserUnitOfWork
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the task repo. </summary>
        ///
        /// <value> The task repo. </value>
        ///-------------------------------------------------------------------------------------------------
        IUserRepository UserRepo { get; }
    }
}
