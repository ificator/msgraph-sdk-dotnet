// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IApplicationRequestBuilder.
    /// </summary>
    public partial interface IApplicationRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IApplicationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IApplicationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ExtensionProperties.
        /// </summary>
        /// <returns>The <see cref="IApplicationExtensionPropertiesCollectionRequestBuilder"/>.</returns>
        IApplicationExtensionPropertiesCollectionRequestBuilder ExtensionProperties { get; }

        /// <summary>
        /// Gets the request builder for CreatedOnBehalfOf.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder CreatedOnBehalfOf { get; }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IApplicationOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        IApplicationOwnersCollectionWithReferencesRequestBuilder Owners { get; }

        /// <summary>
        /// Gets the request builder for Policies.
        /// </summary>
        /// <returns>The <see cref="IApplicationPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IApplicationPoliciesCollectionWithReferencesRequestBuilder Policies { get; }
    
        /// <summary>
        /// Gets the request builder for Logo.
        /// </summary>
        /// <returns>The <see cref="IApplicationLogoRequestBuilder"/>.</returns>
        IApplicationLogoRequestBuilder Logo { get; }
    
    }
}