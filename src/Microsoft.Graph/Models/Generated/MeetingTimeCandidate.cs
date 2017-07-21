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
    /// The type MeetingTimeCandidate.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MeetingTimeCandidate
    {
    
        /// <summary>
        /// Gets or sets meetingTimeSlot.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingTimeSlot", Required = Newtonsoft.Json.Required.Default)]
        public TimeSlotOLD MeetingTimeSlot { get; set; }
    
        /// <summary>
        /// Gets or sets confidence.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "confidence", Required = Newtonsoft.Json.Required.Default)]
        public double? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets organizerAvailability.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizerAvailability", Required = Newtonsoft.Json.Required.Default)]
        public FreeBusyStatus? OrganizerAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets attendeeAvailability.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attendeeAvailability", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AttendeeAvailability> AttendeeAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Location> Locations { get; set; }
    
        /// <summary>
        /// Gets or sets suggestionHint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "suggestionHint", Required = Newtonsoft.Json.Required.Default)]
        public string SuggestionHint { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
