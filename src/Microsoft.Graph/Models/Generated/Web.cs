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
    /// The type Web.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Web
    {
    
        /// <summary>
        /// Gets or sets redirectUrls.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "redirectUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RedirectUrls { get; set; }
    
        /// <summary>
        /// Gets or sets logoutUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "logoutUrl", Required = Newtonsoft.Json.Required.Default)]
        public string LogoutUrl { get; set; }
    
        /// <summary>
        /// Gets or sets oauth2AllowImplicitFlow.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oauth2AllowImplicitFlow", Required = Newtonsoft.Json.Required.Default)]
        public bool? Oauth2AllowImplicitFlow { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
