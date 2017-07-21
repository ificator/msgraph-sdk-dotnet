// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedEBookGroupAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedEBookGroupAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IManagedEBookGroupAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedEBookGroupAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedEBookGroupAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedEBookGroupAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedEBookGroupAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ManagedEBookGroupAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEBookGroupAssignmentRequestBuilder"/> for the specified ManagedEBookEBookGroupAssignment.
        /// </summary>
        /// <param name="id">The ID for the ManagedEBookEBookGroupAssignment.</param>
        /// <returns>The <see cref="IEBookGroupAssignmentRequestBuilder"/>.</returns>
        public IEBookGroupAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new EBookGroupAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
