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
    /// The type OutlookUserTaskFoldersCollectionRequestBuilder.
    /// </summary>
    public partial class OutlookUserTaskFoldersCollectionRequestBuilder : BaseRequestBuilder, IOutlookUserTaskFoldersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OutlookUserTaskFoldersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OutlookUserTaskFoldersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOutlookUserTaskFoldersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOutlookUserTaskFoldersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OutlookUserTaskFoldersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOutlookTaskFolderRequestBuilder"/> for the specified OutlookUserOutlookTaskFolder.
        /// </summary>
        /// <param name="id">The ID for the OutlookUserOutlookTaskFolder.</param>
        /// <returns>The <see cref="IOutlookTaskFolderRequestBuilder"/>.</returns>
        public IOutlookTaskFolderRequestBuilder this[string id]
        {
            get
            {
                return new OutlookTaskFolderRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
