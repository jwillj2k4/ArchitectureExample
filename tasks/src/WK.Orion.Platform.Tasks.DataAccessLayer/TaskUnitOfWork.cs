using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class TaskUnitOfWork : ITaskUnitOfWork
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the task repo. </summary>
        ///
        /// <value> The task repo. </value>
        ///-------------------------------------------------------------------------------------------------
        public ITaskRepository TaskRepo { get; }

        public TaskUnitOfWork(ITaskRepository taskRepo)
        {
            TaskRepo = taskRepo;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a task&lt; i orion task dto&gt; using the given identifier. </summary>
        ///
        /// <param name="id">   The identifier to get. </param>
        ///
        /// <returns>   A Task&lt;IOrionTask&gt; </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IOrionTaskDto> Get(long id)
        {
            var taskDto = await TaskRepo.GetOne(id);
             
            return taskDto;
        }
    }
}