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
    /// The type PhysicalAddress.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PhysicalAddress
    {
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "type", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddressType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets postOfficeBox.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postOfficeBox", Required = Newtonsoft.Json.Required.Default)]
        public string PostOfficeBox { get; set; }
    
        /// <summary>
        /// Gets or sets street.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "street", Required = Newtonsoft.Json.Required.Default)]
        public string Street { get; set; }
    
        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city", Required = Newtonsoft.Json.Required.Default)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets countryOrRegion.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryOrRegion", Required = Newtonsoft.Json.Required.Default)]
        public string CountryOrRegion { get; set; }
    
        /// <summary>
        /// Gets or sets postalCode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postalCode", Required = Newtonsoft.Json.Required.Default)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
