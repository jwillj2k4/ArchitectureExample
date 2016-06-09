using WK.Orion.Platform.Examples.Components.ML.Core.Converters.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections;

namespace WK.Orion.Platform.Examples.Components.ML.Core.Converters.Services
{
    /// <summary>   A multilingual converter. </summary>
    public class MultilingualConverter : IMultilingualConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given multilingual. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An multiLingualDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public Multilingual Convert(MultiLingualDto dto)
        {
            var orionUDF = new Multilingual()
            {
                Id = dto.Id,
                CreatedByUserId = dto.CreatedByUserId,
                DateCreated = dto.DateCreated,
                Name = dto.Name

            };

            return orionUDF;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given multilingual. </summary>
        ///
        /// <param name="multilingual"> The multilingual. </param>
        ///
        /// <returns>   An multiLingualDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        public MultiLingualDto Convert(Multilingual multilingual)
        {
            var orionUDFDto = new MultiLingualDto()
            {
                Id = multilingual.Id,
                CreatedByUserId = multilingual.CreatedByUserId,
                DateCreated = multilingual.DateCreated,
                Name = multilingual.Name
            };

            return orionUDFDto;
        }
    }
}