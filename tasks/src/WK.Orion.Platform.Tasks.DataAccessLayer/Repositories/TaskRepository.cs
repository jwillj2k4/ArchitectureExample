using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Converters.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class TaskRepository : ITaskRepository
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The task converter. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly ITaskConverter _taskConverter;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Repositories.TaskRepository class.
        /// </summary>
        ///
        /// <param name="taskConverter">    The task converter. </param>
        ///-------------------------------------------------------------------------------------------------
        public TaskRepository(ITaskConverter taskConverter)
        {
            _taskConverter = taskConverter;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<Core.Models.Projections.Interfaces.IOrionTaskDto> GetOne(long id)
        {
            //wire up db context, call to get task
            var task = await Task.FromResult(new OrionTask());

            var taskDto = _taskConverter.Convert(task);

            return taskDto;
        }
    }
}