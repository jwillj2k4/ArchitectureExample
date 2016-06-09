using System.Collections.Generic;
using WK.Orion.Platform.Examples.Components.Tasks.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Tasks.Services
{
    /// <summary>   A task service. </summary>
    public class TaskService : ITaskService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        public IEnumerable<IOrionTaskDto> GetAll()
        {
            return new List<IOrionTaskDto>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IOrionTaskDto GetOne(long id)
        {
            return new OrionTaskDto();
        }

        public void Save(IOrionTaskDto orionTaskDto)
        {
            //add to repo
            // save changes
        }
    }
}