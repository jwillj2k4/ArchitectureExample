using System.Collections.Generic;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.Interfaces
{
    /// <summary>   Interface for iudf service. </summary>
    public interface IUDFService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        IOrionUdfDto GetOne(long id);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        IEnumerable<IOrionUdfDto> GetAll();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an i orion udf dto using the given item identifier. </summary>
        ///
        /// <param name="itemId">   The item identifier to get. </param>
        ///
        /// <returns>   An IOrionUdfDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        IOrionUdfDto Get(long itemId);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion udf dto. </summary>
        ///
        /// <param name="orionUdfDto">  The orion udf dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        void Save(IOrionUdfDto orionUdfDto);
    }
}
