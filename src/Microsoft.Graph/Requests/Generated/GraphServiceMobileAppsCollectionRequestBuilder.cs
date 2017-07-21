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
    /// The type GraphServiceMobileAppsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceMobileAppsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceMobileAppsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceMobileAppsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceMobileAppsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceMobileAppsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceMobileAppsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceMobileAppsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMobileAppRequestBuilder"/> for the specified GraphServiceMobileApp.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceMobileApp.</param>
        /// <returns>The <see cref="IMobileAppRequestBuilder"/>.</returns>
        public IMobileAppRequestBuilder this[string id]
        {
            get
            {
                return new MobileAppRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MobileAppGetMobileAppCount.
        /// </summary>
        /// <returns>The <see cref="IMobileAppGetMobileAppCountRequestBuilder"/>.</returns>
        public IMobileAppGetMobileAppCountRequestBuilder GetMobileAppCount(
            string status = null)
        {
            return new MobileAppGetMobileAppCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getMobileAppCount"),
                this.Client,
                status);
        }

        /// <summary>
        /// Gets the request builder for MobileAppGetTopMobileApps.
        /// </summary>
        /// <returns>The <see cref="IMobileAppGetTopMobileAppsRequestBuilder"/>.</returns>
        public IMobileAppGetTopMobileAppsRequestBuilder GetTopMobileApps(
            Int64 count,
            string status = null)
        {
            return new MobileAppGetTopMobileAppsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getTopMobileApps"),
                this.Client,
                count,
                status);
        }
    }
}
