using System.Collections.Generic;
using WK.Orion.Platform.UserDefinedFields.Core.Models.Projections;
using WK.Orion.Platform.UserDefinedFields.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.UserDefinedFields.Interfaces;

namespace WK.Orion.Platform.UserDefinedFields.Services
{
    /// <summary>   An udf service. </summary>
    public class UDFWindowsService : IUDFService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IOrionUdfDto GetOne(long id)
        {
            return new OrionUdfDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets all items in this collection. </summary>
        ///
        /// <returns>
        ///     An enumerator that allows foreach to be used to process all items in this collection.
        /// </returns>
        ///-------------------------------------------------------------------------------------------------
        public IEnumerable<IOrionUdfDto> GetAll()
        {
            return new List<OrionUdfDto>();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an i orion udf dto using the given item identifier. </summary>
        ///
        /// <param name="itemId">   The item identifier to get. </param>
        ///
        /// <returns>   An IOrionUdfDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public IOrionUdfDto Get(long itemId)
        {
            return new OrionUdfDto();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves the given orion udf dto. </summary>
        ///
        /// <param name="orionUdfDto">  The orion udf dto to save. </param>
        ///-------------------------------------------------------------------------------------------------
        public void Save(IOrionUdfDto orionUdfDto)
        {
            //add to repo
            // save changes
        }
    }
}
