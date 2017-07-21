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
    /// The type Android For Work Settings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidForWorkSettings : Entity
    {
    
        /// <summary>
        /// Gets or sets bind status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bindStatus", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkBindStatus? BindStatus { get; set; }
    
        /// <summary>
        /// Gets or sets last app sync date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastAppSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastAppSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last app sync status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastAppSyncStatus", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkSyncStatus? LastAppSyncStatus { get; set; }
    
        /// <summary>
        /// Gets or sets owner user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerUserPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string OwnerUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets owner organization name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerOrganizationName", Required = Newtonsoft.Json.Required.Default)]
        public string OwnerOrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment target.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentTarget", Required = Newtonsoft.Json.Required.Default)]
        public AndroidForWorkEnrollmentTarget? EnrollmentTarget { get; set; }
    
        /// <summary>
        /// Gets or sets target group ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetGroupIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TargetGroupIds { get; set; }
    
    }
}

