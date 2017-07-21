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
    /// The interface IEBookVppGroupAssignmentRequest.
    /// </summary>
    public partial interface IEBookVppGroupAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EBookVppGroupAssignment using PUT.
        /// </summary>
        /// <param name="eBookVppGroupAssignmentToCreate">The EBookVppGroupAssignment to create.</param>
        /// <returns>The created EBookVppGroupAssignment.</returns>
        System.Threading.Tasks.Task<EBookVppGroupAssignment> CreateAsync(EBookVppGroupAssignment eBookVppGroupAssignmentToCreate);        /// <summary>
        /// Creates the specified EBookVppGroupAssignment using PUT.
        /// </summary>
        /// <param name="eBookVppGroupAssignmentToCreate">The EBookVppGroupAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EBookVppGroupAssignment.</returns>
        System.Threading.Tasks.Task<EBookVppGroupAssignment> CreateAsync(EBookVppGroupAssignment eBookVppGroupAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EBookVppGroupAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EBookVppGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EBookVppGroupAssignment.
        /// </summary>
        /// <returns>The EBookVppGroupAssignment.</returns>
        System.Threading.Tasks.Task<EBookVppGroupAssignment> GetAsync();

        /// <summary>
        /// Gets the specified EBookVppGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EBookVppGroupAssignment.</returns>
        System.Threading.Tasks.Task<EBookVppGroupAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EBookVppGroupAssignment using PATCH.
        /// </summary>
        /// <param name="eBookVppGroupAssignmentToUpdate">The EBookVppGroupAssignment to update.</param>
        /// <returns>The updated EBookVppGroupAssignment.</returns>
        System.Threading.Tasks.Task<EBookVppGroupAssignment> UpdateAsync(EBookVppGroupAssignment eBookVppGroupAssignmentToUpdate);

        /// <summary>
        /// Updates the specified EBookVppGroupAssignment using PATCH.
        /// </summary>
        /// <param name="eBookVppGroupAssignmentToUpdate">The EBookVppGroupAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EBookVppGroupAssignment.</returns>
        System.Threading.Tasks.Task<EBookVppGroupAssignment> UpdateAsync(EBookVppGroupAssignment eBookVppGroupAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEBookVppGroupAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEBookVppGroupAssignmentRequest Expand(Expression<Func<EBookVppGroupAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEBookVppGroupAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEBookVppGroupAssignmentRequest Select(Expression<Func<EBookVppGroupAssignment, object>> selectExpression);

    }
}