// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PayloadResponseWithReferenceRequestBuilder.
    /// </summary>
    public partial class PayloadResponseWithReferenceRequestBuilder : BaseRequestBuilder, IPayloadResponseWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new PayloadResponseWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PayloadResponseWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPayloadResponseWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPayloadResponseWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new PayloadResponseWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the payloadResponse.
        /// </summary>
        /// <returns>The <see cref="IPayloadResponseReferenceRequestBuilder"/>.</returns>
        public IPayloadResponseReferenceRequestBuilder Reference
        {
            get
            {
                return new PayloadResponseReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
