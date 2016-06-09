using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Interfaces.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for iudf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IMultiLingualRepository
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
