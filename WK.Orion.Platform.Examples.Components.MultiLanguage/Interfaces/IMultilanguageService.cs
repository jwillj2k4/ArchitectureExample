using System.Collections.Generic;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.ML.Interfaces
{
    /// <summary>   Interface for iudf service. </summary>
    public interface IMultilanguageService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        IMultiLingualDto GetOne(long id);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        IEnumerable<IMultiLingualDto> GetAll();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an i orion udf dto using the given item identifier. </summary>
        ///
        /// <param name="itemId">   The item identifier to get. </param>
        ///
        /// <returns>   An IMultiLingualDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        IMultiLingualDto Get(long itemId);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion udf dto. </summary>
        ///
        /// <param name="multiLingualDto">  The orion udf dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        void Save(IMultiLingualDto multiLingualDto);
    }
}
