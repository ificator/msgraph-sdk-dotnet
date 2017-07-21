// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows Management App Health Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsManagementAppHealthSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets healthy device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "healthyDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? HealthyDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unhealthy device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unhealthyDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnhealthyDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unknownDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnknownDeviceCount { get; set; }
    
    }
}

