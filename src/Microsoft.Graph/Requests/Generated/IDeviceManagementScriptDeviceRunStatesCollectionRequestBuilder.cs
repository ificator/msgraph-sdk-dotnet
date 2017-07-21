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
    /// The interface IDeviceManagementScriptDeviceRunStatesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementScriptDeviceRunStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementScriptDeviceRunStatesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementScriptDeviceRunStatesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceManagementScriptDeviceStateRequestBuilder"/> for the specified DeviceManagementScriptDeviceState.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementScriptDeviceState.</param>
        /// <returns>The <see cref="IDeviceManagementScriptDeviceStateRequestBuilder"/>.</returns>
        IDeviceManagementScriptDeviceStateRequestBuilder this[string id] { get; }

        
    }
}
