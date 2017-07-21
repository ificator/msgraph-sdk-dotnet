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
    /// The type DeviceCompliancePolicyGroupAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceCompliancePolicyGroupAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IDeviceCompliancePolicyGroupAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceCompliancePolicyGroupAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceCompliancePolicyGroupAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceCompliancePolicyGroupAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceCompliancePolicyGroupAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceCompliancePolicyGroupAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceCompliancePolicyGroupAssignmentRequestBuilder"/> for the specified DeviceCompliancePolicyDeviceCompliancePolicyGroupAssignment.
        /// </summary>
        /// <param name="id">The ID for the DeviceCompliancePolicyDeviceCompliancePolicyGroupAssignment.</param>
        /// <returns>The <see cref="IDeviceCompliancePolicyGroupAssignmentRequestBuilder"/>.</returns>
        public IDeviceCompliancePolicyGroupAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new DeviceCompliancePolicyGroupAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
