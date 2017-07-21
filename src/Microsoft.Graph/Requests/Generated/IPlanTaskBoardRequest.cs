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
    /// The interface IPlanTaskBoardRequest.
    /// </summary>
    public partial interface IPlanTaskBoardRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlanTaskBoard using PUT.
        /// </summary>
        /// <param name="planTaskBoardToCreate">The PlanTaskBoard to create.</param>
        /// <returns>The created PlanTaskBoard.</returns>
        System.Threading.Tasks.Task<PlanTaskBoard> CreateAsync(PlanTaskBoard planTaskBoardToCreate);        /// <summary>
        /// Creates the specified PlanTaskBoard using PUT.
        /// </summary>
        /// <param name="planTaskBoardToCreate">The PlanTaskBoard to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlanTaskBoard.</returns>
        System.Threading.Tasks.Task<PlanTaskBoard> CreateAsync(PlanTaskBoard planTaskBoardToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlanTaskBoard.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlanTaskBoard.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlanTaskBoard.
        /// </summary>
        /// <returns>The PlanTaskBoard.</returns>
        System.Threading.Tasks.Task<PlanTaskBoard> GetAsync();

        /// <summary>
        /// Gets the specified PlanTaskBoard.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlanTaskBoard.</returns>
        System.Threading.Tasks.Task<PlanTaskBoard> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlanTaskBoard using PATCH.
        /// </summary>
        /// <param name="planTaskBoardToUpdate">The PlanTaskBoard to update.</param>
        /// <returns>The updated PlanTaskBoard.</returns>
        System.Threading.Tasks.Task<PlanTaskBoard> UpdateAsync(PlanTaskBoard planTaskBoardToUpdate);

        /// <summary>
        /// Updates the specified PlanTaskBoard using PATCH.
        /// </summary>
        /// <param name="planTaskBoardToUpdate">The PlanTaskBoard to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PlanTaskBoard.</returns>
        System.Threading.Tasks.Task<PlanTaskBoard> UpdateAsync(PlanTaskBoard planTaskBoardToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlanTaskBoardRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlanTaskBoardRequest Expand(Expression<Func<PlanTaskBoard, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlanTaskBoardRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlanTaskBoardRequest Select(Expression<Func<PlanTaskBoard, object>> selectExpression);

    }
}
