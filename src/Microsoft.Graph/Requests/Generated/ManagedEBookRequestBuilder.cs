// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedEBookRequestBuilder.
    /// </summary>
    public partial class ManagedEBookRequestBuilder : EntityRequestBuilder, IManagedEBookRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedEBookRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedEBookRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagedEBookRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagedEBookRequest Request(IEnumerable<Option> options)
        {
            return new ManagedEBookRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for GroupAssignments.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookGroupAssignmentsCollectionRequestBuilder"/>.</returns>
        public IManagedEBookGroupAssignmentsCollectionRequestBuilder GroupAssignments
        {
            get
            {
                return new ManagedEBookGroupAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("groupAssignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for InstallSummary.
        /// </summary>
        /// <returns>The <see cref="IEBookInstallSummaryRequestBuilder"/>.</returns>
        public IEBookInstallSummaryRequestBuilder InstallSummary
        {
            get
            {
                return new EBookInstallSummaryRequestBuilder(this.AppendSegmentToRequestUrl("installSummary"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStates.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookDeviceStatesCollectionRequestBuilder"/>.</returns>
        public IManagedEBookDeviceStatesCollectionRequestBuilder DeviceStates
        {
            get
            {
                return new ManagedEBookDeviceStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserStateSummary.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookUserStateSummaryCollectionRequestBuilder"/>.</returns>
        public IManagedEBookUserStateSummaryCollectionRequestBuilder UserStateSummary
        {
            get
            {
                return new ManagedEBookUserStateSummaryCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userStateSummary"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ManagedEBookAssign.
        /// </summary>
        /// <returns>The <see cref="IManagedEBookAssignRequestBuilder"/>.</returns>
        public IManagedEBookAssignRequestBuilder Assign(
            IEnumerable<EBookGroupAssignment> eBookGroupAssignments = null)
        {
            return new ManagedEBookAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                eBookGroupAssignments);
        }
    
    }
}