using WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IMultilingualUnitOfWork
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the task repo. </summary>
        ///
        /// <value> The task repo. </value>
        ///-------------------------------------------------------------------------------------------------
        IMultiLingualRepository MultiLingualRepo { get; }
    }
}
