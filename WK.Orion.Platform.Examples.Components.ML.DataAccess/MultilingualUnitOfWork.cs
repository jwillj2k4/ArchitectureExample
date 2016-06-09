using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.ML.DataAccessLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class MultilingualUnitOfWork : IMultilingualUnitOfWork
    {
        public IMultiLingualRepository MultiLingualRepo { get; }

        public MultilingualUnitOfWork(IMultiLingualRepository multiLingualRepository)
        {
            MultiLingualRepo = multiLingualRepository;
        }
        
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a task&lt; i orion udf dto&gt; using the given identifier. </summary>
        ///
        /// <param name="id">   The identifier to get. </param>
        ///
        /// <returns>   A Task&lt;IOrionUdfDto&gt; </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IMultiLingualDto> Get(long id)
        {
            var multiLingualDto = await MultiLingualRepo.GetOne(id);
             
            return multiLingualDto;
        }
    }
}