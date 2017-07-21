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
    /// The type DeviceManagementCloudPkiSubscriptionsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementCloudPkiSubscriptionsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementCloudPkiSubscriptionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementCloudPkiSubscriptionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementCloudPkiSubscriptionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementCloudPkiSubscriptionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementCloudPkiSubscriptionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementCloudPkiSubscriptionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICloudPkiSubscriptionRequestBuilder"/> for the specified DeviceManagementCloudPkiSubscription.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementCloudPkiSubscription.</param>
        /// <returns>The <see cref="ICloudPkiSubscriptionRequestBuilder"/>.</returns>
        public ICloudPkiSubscriptionRequestBuilder this[string id]
        {
            get
            {
                return new CloudPkiSubscriptionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
