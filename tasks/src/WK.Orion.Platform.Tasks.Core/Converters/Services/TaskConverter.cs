using WK.Orion.Platform.Examples.Components.Tasks.Core.Converters.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections;

namespace WK.Orion.Platform.Examples.Components.Tasks.Core.Converters.Services
{
    /// <summary>   A task converter. </summary>
    public class TaskConverter : ITaskConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given task. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An OrionTaskDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionTask Convert(OrionTaskDto dto)
        {
            var orionTask = new OrionTask()
            {
                Id = dto.Id,
                CreatedByUserId = dto.CreatedByUserId,
                DateCreated = dto.DateCreated,
                Name = dto.Name,
                ItemId = dto.ItemId

            };

            return orionTask;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given task. </summary>
        ///
        /// <param name="task"> The task. </param>
        ///
        /// <returns>   An OrionTaskDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionTaskDto Convert(OrionTask task)
        {
            var orionTaskDto = new OrionTaskDto()
            {
                Id = task.Id,
                CreatedByUserId = task.CreatedByUserId,
                DateCreated = task.DateCreated,
                Name = task.Name,
                ItemId = task.ItemId

            };

            return orionTaskDto;
        }
    }
}