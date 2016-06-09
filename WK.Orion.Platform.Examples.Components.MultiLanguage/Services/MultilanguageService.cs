using System.Collections.Generic;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.Interfaces;

namespace WK.Orion.Platform.Examples.Components.ML.Services
{
    /// <summary>   An udf service. </summary>
    public class MultilanguageService : IMultilanguageService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IMultiLingualDto GetOne(long id)
        {
            return new MultiLingualDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        public IEnumerable<IMultiLingualDto> GetAll()
        {
            return new List<MultiLingualDto>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an i orion udf dto using the given item identifier. </summary>
        ///
        /// <param name="itemId">   The item identifier to get. </param>
        ///
        /// <returns>   An IMultiLingualDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IMultiLingualDto Get(long itemId)
        {
            return new MultiLingualDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion udf dto. </summary>
        ///
        /// <param name="multiLingualDto">  The orion udf dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        public void Save(IMultiLingualDto multiLingualDto)
        {
            //add to repo
            // save changes
        }
    }
}
