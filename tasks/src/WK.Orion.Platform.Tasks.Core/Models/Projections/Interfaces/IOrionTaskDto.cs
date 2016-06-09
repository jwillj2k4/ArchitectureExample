using System;

namespace WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces
{
    /// <summary>   Interface for orion task dto. </summary>
    public interface IOrionTaskDto
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        ///-------------------------------------------------------------------------------------------------
        int Id { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        ///-------------------------------------------------------------------------------------------------
        string Name { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the date created. </summary>
        ///
        /// <value> The date created. </value>
        ///-------------------------------------------------------------------------------------------------
        DateTimeOffset DateCreated { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the identifier of the created by user. </summary>
        ///
        /// <value> The identifier of the created by user. </value>
        ///-------------------------------------------------------------------------------------------------
        long CreatedByUserId { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the identifier of the item. </summary>
        ///
        /// <value> The identifier of the item. </value>
        ///-------------------------------------------------------------------------------------------------
        long ItemId { get; set; }
    }
}