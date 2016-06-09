using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface ITaskService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        Task<IOrionTaskDto> GetOne(long id);
    }
}
