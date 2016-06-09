using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface ITaskRepository
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
