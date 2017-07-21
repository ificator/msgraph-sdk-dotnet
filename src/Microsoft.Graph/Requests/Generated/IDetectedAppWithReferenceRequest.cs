// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDetectedAppWithReferenceRequest.
    /// </summary>
    public partial interface IDetectedAppWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified DetectedApp.
        /// </summary>
        /// <returns>The DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> GetAsync();

        /// <summary>
        /// Gets the specified DetectedApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DetectedApp.</returns>
        System.Threading.Tasks.Task<DetectedApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppWithReferenceRequest Expand(Expression<Func<DetectedApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDetectedAppWithReferenceRequest Select(Expression<Func<DetectedApp, object>> selectExpression);

    }
}
