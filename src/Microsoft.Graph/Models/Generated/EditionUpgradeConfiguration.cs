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
    /// The type Edition Upgrade Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EditionUpgradeConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets license type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseType", Required = Newtonsoft.Json.Required.Default)]
        public EditionUpgradeLicenseType? LicenseType { get; set; }
    
        /// <summary>
        /// Gets or sets target edition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetEdition", Required = Newtonsoft.Json.Required.Default)]
        public Windows10EditionType? TargetEdition { get; set; }
    
        /// <summary>
        /// Gets or sets license.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "license", Required = Newtonsoft.Json.Required.Default)]
        public string License { get; set; }
    
        /// <summary>
        /// Gets or sets product key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productKey", Required = Newtonsoft.Json.Required.Default)]
        public string ProductKey { get; set; }
    
    }
}

