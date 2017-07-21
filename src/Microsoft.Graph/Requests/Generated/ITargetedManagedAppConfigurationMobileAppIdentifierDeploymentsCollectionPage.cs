// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface ITargetedManagedAppConfigurationMobileAppIdentifierDeploymentsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<TargetedManagedAppConfigurationMobileAppIdentifierDeploymentsCollectionPage>))]
    public interface ITargetedManagedAppConfigurationMobileAppIdentifierDeploymentsCollectionPage : ICollectionPage<MobileAppIdentifierDeployment>
    {
        /// <summary>
        /// Gets the next page <see cref="ITargetedManagedAppConfigurationMobileAppIdentifierDeploymentsCollectionRequest"/> instance.
        /// </summary>
        ITargetedManagedAppConfigurationMobileAppIdentifierDeploymentsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
