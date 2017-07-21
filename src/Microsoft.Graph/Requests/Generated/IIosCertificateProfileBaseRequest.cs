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
    /// The interface IIosCertificateProfileBaseRequest.
    /// </summary>
    public partial interface IIosCertificateProfileBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosCertificateProfileBase using PUT.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToCreate">The IosCertificateProfileBase to create.</param>
        /// <returns>The created IosCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<IosCertificateProfileBase> CreateAsync(IosCertificateProfileBase iosCertificateProfileBaseToCreate);        /// <summary>
        /// Creates the specified IosCertificateProfileBase using PUT.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToCreate">The IosCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<IosCertificateProfileBase> CreateAsync(IosCertificateProfileBase iosCertificateProfileBaseToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosCertificateProfileBase.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosCertificateProfileBase.
        /// </summary>
        /// <returns>The IosCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<IosCertificateProfileBase> GetAsync();

        /// <summary>
        /// Gets the specified IosCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<IosCertificateProfileBase> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToUpdate">The IosCertificateProfileBase to update.</param>
        /// <returns>The updated IosCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<IosCertificateProfileBase> UpdateAsync(IosCertificateProfileBase iosCertificateProfileBaseToUpdate);

        /// <summary>
        /// Updates the specified IosCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="iosCertificateProfileBaseToUpdate">The IosCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated IosCertificateProfileBase.</returns>
        System.Threading.Tasks.Task<IosCertificateProfileBase> UpdateAsync(IosCertificateProfileBase iosCertificateProfileBaseToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileBaseRequest Expand(Expression<Func<IosCertificateProfileBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosCertificateProfileBaseRequest Select(Expression<Func<IosCertificateProfileBase, object>> selectExpression);

    }
}
