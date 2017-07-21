// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ManagedAppRegistrationIntendedPoliciesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedAppPolicyWithReferenceRequestBuilder"/> for the specified ManagedAppRegistrationManagedAppPolicy.
        /// </summary>
        /// <param name="id">The ID for the ManagedAppRegistrationManagedAppPolicy.</param>
        /// <returns>The <see cref="IManagedAppPolicyWithReferenceRequestBuilder"/>.</returns>
        public IManagedAppPolicyWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ManagedAppPolicyWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IManagedAppRegistrationIntendedPoliciesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagedAppRegistrationIntendedPoliciesCollectionReferencesRequestBuilder"/>.</returns>
        public IManagedAppRegistrationIntendedPoliciesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ManagedAppRegistrationIntendedPoliciesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
