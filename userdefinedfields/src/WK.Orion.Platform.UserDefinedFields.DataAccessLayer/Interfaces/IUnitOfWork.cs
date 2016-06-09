using WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface IUDFUnitOfWork
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the task repo. </summary>
        ///
        /// <value> The task repo. </value>
        ///-------------------------------------------------------------------------------------------------
        IUDFRepository UDFRepo { get; }
    }
}
