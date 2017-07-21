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
    /// The type Mac OSGeneral Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets compliant apps list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppsList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> CompliantAppsList { get; set; }
    
        /// <summary>
        /// Gets or sets compliant app list type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantAppListType", Required = Newtonsoft.Json.Required.Default)]
        public AppListType? CompliantAppListType { get; set; }
    
        /// <summary>
        /// Gets or sets email in domain suffixes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailInDomainSuffixes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> EmailInDomainSuffixes { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockSimple", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
    }
}

