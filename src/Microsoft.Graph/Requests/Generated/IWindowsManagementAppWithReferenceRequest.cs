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
    /// The interface IWindowsManagementAppWithReferenceRequest.
    /// </summary>
    public partial interface IWindowsManagementAppWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified WindowsManagementApp.
        /// </summary>
        /// <returns>The WindowsManagementApp.</returns>
        System.Threading.Tasks.Task<WindowsManagementApp> GetAsync();

        /// <summary>
        /// Gets the specified WindowsManagementApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsManagementApp.</returns>
        System.Threading.Tasks.Task<WindowsManagementApp> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppWithReferenceRequest Expand(Expression<Func<WindowsManagementApp, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsManagementAppWithReferenceRequest Select(Expression<Func<WindowsManagementApp, object>> selectExpression);

    }
}
