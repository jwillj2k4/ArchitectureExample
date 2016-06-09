using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.ML.BusinessLogicLayer.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Interfaces;

namespace WK.Orion.Platform.Examples.Components.ML.BusinessLogicLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class MultilingualService : IMultilanguageService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The task unit of work. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly IMultilingualUnitOfWork _multilingualUnitOfWork;

        public MultilingualService(IMultilingualUnitOfWork multilingualUnitOfWork)
        {
            _multilingualUnitOfWork = multilingualUnitOfWork;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IMultiLingualDto> GetOne(long id)
        {
            var taskDto = await _multilingualUnitOfWork.MultiLingualRepo.GetOne(id);

            return taskDto;
        }
    }
}