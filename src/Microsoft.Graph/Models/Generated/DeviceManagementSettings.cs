// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceManagementSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceManagementSettings
    {
    
        /// <summary>
        /// Gets or sets windowsCommercialId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsCommercialId", Required = Newtonsoft.Json.Required.Default)]
        public string WindowsCommercialId { get; set; }
    
        /// <summary>
        /// Gets or sets windowsCommercialIdLastModifiedTime.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsCommercialIdLastModifiedTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? WindowsCommercialIdLastModifiedTime { get; set; }
    
        /// <summary>
        /// Gets or sets deviceComplianceCheckinThresholdDays.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceComplianceCheckinThresholdDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeviceComplianceCheckinThresholdDays { get; set; }
    
        /// <summary>
        /// Gets or sets isScheduledActionEnabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isScheduledActionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsScheduledActionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
