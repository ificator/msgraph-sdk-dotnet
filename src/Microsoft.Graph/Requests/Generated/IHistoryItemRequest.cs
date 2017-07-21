// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IHistoryItemRequest.
    /// </summary>
    public partial interface IHistoryItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified HistoryItem using PUT.
        /// </summary>
        /// <param name="historyItemToCreate">The HistoryItem to create.</param>
        /// <returns>The created HistoryItem.</returns>
        System.Threading.Tasks.Task<HistoryItem> CreateAsync(HistoryItem historyItemToCreate);        /// <summary>
        /// Creates the specified HistoryItem using PUT.
        /// </summary>
        /// <param name="historyItemToCreate">The HistoryItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created HistoryItem.</returns>
        System.Threading.Tasks.Task<HistoryItem> CreateAsync(HistoryItem historyItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified HistoryItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified HistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified HistoryItem.
        /// </summary>
        /// <returns>The HistoryItem.</returns>
        System.Threading.Tasks.Task<HistoryItem> GetAsync();

        /// <summary>
        /// Gets the specified HistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The HistoryItem.</returns>
        System.Threading.Tasks.Task<HistoryItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified HistoryItem using PATCH.
        /// </summary>
        /// <param name="historyItemToUpdate">The HistoryItem to update.</param>
        /// <returns>The updated HistoryItem.</returns>
        System.Threading.Tasks.Task<HistoryItem> UpdateAsync(HistoryItem historyItemToUpdate);

        /// <summary>
        /// Updates the specified HistoryItem using PATCH.
        /// </summary>
        /// <param name="historyItemToUpdate">The HistoryItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated HistoryItem.</returns>
        System.Threading.Tasks.Task<HistoryItem> UpdateAsync(HistoryItem historyItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IHistoryItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IHistoryItemRequest Expand(Expression<Func<HistoryItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IHistoryItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IHistoryItemRequest Select(Expression<Func<HistoryItem, object>> selectExpression);

    }
}