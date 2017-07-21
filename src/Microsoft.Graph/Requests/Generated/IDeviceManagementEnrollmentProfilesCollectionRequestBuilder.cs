// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceManagementEnrollmentProfilesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementEnrollmentProfilesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementEnrollmentProfilesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementEnrollmentProfilesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IEnrollmentProfileRequestBuilder"/> for the specified EnrollmentProfile.
        /// </summary>
        /// <param name="id">The ID for the EnrollmentProfile.</param>
        /// <returns>The <see cref="IEnrollmentProfileRequestBuilder"/>.</returns>
        IEnrollmentProfileRequestBuilder this[string id] { get; }

        
    }
}
