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
    /// The type DeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementDefaultManagedAppProtectionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementDefaultManagedAppProtectionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementDefaultManagedAppProtectionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDefaultManagedAppProtectionRequestBuilder"/> for the specified DeviceAppManagementDefaultManagedAppProtection.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementDefaultManagedAppProtection.</param>
        /// <returns>The <see cref="IDefaultManagedAppProtectionRequestBuilder"/>.</returns>
        public IDefaultManagedAppProtectionRequestBuilder this[string id]
        {
            get
            {
                return new DefaultManagedAppProtectionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
