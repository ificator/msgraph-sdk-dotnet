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
    /// The type Activity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Activity : Entity
    {
    
        /// <summary>
        /// Gets or sets visual elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visualElements", Required = Newtonsoft.Json.Required.Default)]
        public VisualInfo VisualElements { get; set; }
    
        /// <summary>
        /// Gets or sets activity source host.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activitySourceHost", Required = Newtonsoft.Json.Required.Default)]
        public string ActivitySourceHost { get; set; }
    
        /// <summary>
        /// Gets or sets activation url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ActivationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets app activity id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActivityId", Required = Newtonsoft.Json.Required.Default)]
        public string AppActivityId { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets content url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ContentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets fallback url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fallbackUrl", Required = Newtonsoft.Json.Required.Default)]
        public string FallbackUrl { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user timezone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userTimezone", Required = Newtonsoft.Json.Required.Default)]
        public string UserTimezone { get; set; }
    
        /// <summary>
        /// Gets or sets content info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentInfo", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken ContentInfo { get; set; }
    
        /// <summary>
        /// Gets or sets history items.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "historyItems", Required = Newtonsoft.Json.Required.Default)]
        public IActivityHistoryItemsCollectionPage HistoryItems { get; set; }
    
    }
}

