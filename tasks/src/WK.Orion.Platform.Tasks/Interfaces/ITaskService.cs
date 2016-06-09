using System.Collections.Generic;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Tasks.Interfaces
{
    /// <summary>   Interface for task service. </summary>
    public interface ITaskService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        IEnumerable<IOrionTaskDto> GetAll();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        IOrionTaskDto GetOne(long id);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion task dto. </summary>
        ///
        /// <param name="orionTaskDto"> The orion task dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        void Save(IOrionTaskDto orionTaskDto);
    }
}
