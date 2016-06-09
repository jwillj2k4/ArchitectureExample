using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections;

namespace WK.Orion.Platform.Examples.Components.Tasks.Core.Converters.Interfaces
{
    /// <summary>   Interface for task converter. </summary>
    public interface ITaskConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given task. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An OrionTaskDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionTask Convert(OrionTaskDto dto);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given task. </summary>
        ///
        /// <param name="task"> The task. </param>
        ///
        /// <returns>   An OrionTaskDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionTaskDto Convert(OrionTask task);
    }
}