using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface ITaskUnitOfWork
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the task repo. </summary>
        ///
        /// <value> The task repo. </value>
        ///-------------------------------------------------------------------------------------------------
        ITaskRepository TaskRepo { get; }
    }
}
