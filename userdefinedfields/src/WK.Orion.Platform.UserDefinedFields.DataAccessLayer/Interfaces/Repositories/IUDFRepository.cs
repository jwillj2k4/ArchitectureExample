using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Interfaces.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for iudf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IUDFRepository
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        Task<IOrionUdfDto> GetOne(long id);
    }
}
