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
    /// The type OrganizationAppleVolumePurchaseProgramTokensCollectionRequestBuilder.
    /// </summary>
    public partial class OrganizationAppleVolumePurchaseProgramTokensCollectionRequestBuilder : BaseRequestBuilder, IOrganizationAppleVolumePurchaseProgramTokensCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new OrganizationAppleVolumePurchaseProgramTokensCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OrganizationAppleVolumePurchaseProgramTokensCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IOrganizationAppleVolumePurchaseProgramTokensCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IOrganizationAppleVolumePurchaseProgramTokensCollectionRequest Request(IEnumerable<Option> options)
        {
            return new OrganizationAppleVolumePurchaseProgramTokensCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAppleVolumePurchaseProgramTokenRequestBuilder"/> for the specified OrganizationAppleVolumePurchaseProgramToken.
        /// </summary>
        /// <param name="id">The ID for the OrganizationAppleVolumePurchaseProgramToken.</param>
        /// <returns>The <see cref="IAppleVolumePurchaseProgramTokenRequestBuilder"/>.</returns>
        public IAppleVolumePurchaseProgramTokenRequestBuilder this[string id]
        {
            get
            {
                return new AppleVolumePurchaseProgramTokenRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}