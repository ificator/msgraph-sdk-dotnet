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
    /// The type GraphServiceDeviceConfigurationGroupAssignmentCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceDeviceConfigurationGroupAssignmentCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceDeviceConfigurationGroupAssignmentCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceDeviceConfigurationGroupAssignmentCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceDeviceConfigurationGroupAssignmentCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceDeviceConfigurationGroupAssignmentCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceDeviceConfigurationGroupAssignmentCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceDeviceConfigurationGroupAssignmentCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationGroupAssignmentRequestBuilder"/> for the specified GraphServiceDeviceConfigurationGroupAssignment.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceDeviceConfigurationGroupAssignment.</param>
        /// <returns>The <see cref="IDeviceConfigurationGroupAssignmentRequestBuilder"/>.</returns>
        public IDeviceConfigurationGroupAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new DeviceConfigurationGroupAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
