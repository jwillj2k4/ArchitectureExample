using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.BusinessLogicLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IUDFService
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
