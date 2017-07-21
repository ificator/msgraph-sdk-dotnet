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
    /// The type Windows10Team General Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10TeamGeneralConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets azure operational insights block telemetry.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureOperationalInsightsBlockTelemetry", Required = Newtonsoft.Json.Required.Default)]
        public bool? AzureOperationalInsightsBlockTelemetry { get; set; }
    
        /// <summary>
        /// Gets or sets azure operational insights workspace id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureOperationalInsightsWorkspaceId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureOperationalInsightsWorkspaceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure operational insights workspace key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureOperationalInsightsWorkspaceKey", Required = Newtonsoft.Json.Required.Default)]
        public string AzureOperationalInsightsWorkspaceKey { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maintenanceWindowBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? MaintenanceWindowBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window duration in hours.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maintenanceWindowDurationInHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaintenanceWindowDurationInHours { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window start time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maintenanceWindowStartTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay MaintenanceWindowStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets miracast channel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "miracastChannel", Required = Newtonsoft.Json.Required.Default)]
        public MiracastChannel? MiracastChannel { get; set; }
    
        /// <summary>
        /// Gets or sets miracast blocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "miracastBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? MiracastBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets miracast require pin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "miracastRequirePin", Required = Newtonsoft.Json.Required.Default)]
        public bool? MiracastRequirePin { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen block automatic wake up.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "welcomeScreenBlockAutomaticWakeUp", Required = Newtonsoft.Json.Required.Default)]
        public bool? WelcomeScreenBlockAutomaticWakeUp { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen background image url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "welcomeScreenBackgroundImageUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WelcomeScreenBackgroundImageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen meeting information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "welcomeScreenMeetingInformation", Required = Newtonsoft.Json.Required.Default)]
        public WelcomeScreenMeetingInformation? WelcomeScreenMeetingInformation { get; set; }
    
    }
}

