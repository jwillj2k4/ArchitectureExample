using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class TaskService : ITaskService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The task unit of work. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly ITaskUnitOfWork _taskUnitOfWork;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer.Interfaces.TaskService class.
        /// </summary>
        ///
        /// <param name="taskUnitOfWork">   The task unit of work. </param>
        ///-------------------------------------------------------------------------------------------------
        public TaskService(ITaskUnitOfWork taskUnitOfWork)
        {
            _taskUnitOfWork = taskUnitOfWork;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IOrionTaskDto> GetOne(long id)
        {
            var taskDto = await _taskUnitOfWork.TaskRepo.GetOne(id);

            return taskDto;
        }
    }
}