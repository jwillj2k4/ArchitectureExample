using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Converters.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Converters.Services
{
    /// <summary>   A udf converter. </summary>
    public class UDFConverter : IUDFConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given udf. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An OrionUdfDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionUdf Convert(OrionUdfDto dto)
        {
            var orionUDF = new OrionUdf()
            {
                Id = dto.Id,
                CreatedByUserId = dto.CreatedByUserId,
                DateCreated = dto.DateCreated,
                Name = dto.Name

            };

            return orionUDF;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given udf. </summary>
        ///
        /// <param name="udf"> The udf. </param>
        ///
        /// <returns>   An OrionUdfDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public OrionUdfDto Convert(OrionUdf udf)
        {
            var orionUDFDto = new OrionUdfDto()
            {
                Id = udf.Id,
                CreatedByUserId = udf.CreatedByUserId,
                DateCreated = udf.DateCreated,
                Name = udf.Name
            };

            return orionUDFDto;
        }
    }
}