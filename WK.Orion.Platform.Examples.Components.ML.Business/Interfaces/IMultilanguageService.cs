using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.ML.BusinessLogicLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IMultilanguageService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        Task<IMultiLingualDto> GetOne(long id);
    }
}
