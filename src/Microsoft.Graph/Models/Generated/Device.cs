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
    /// The type Device.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Device : DirectoryObject
    {
    
        /// <summary>
        /// Gets or sets account enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets alternative security ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alternativeSecurityIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AlternativeSecurityId> AlternativeSecurityIds { get; set; }
    
        /// <summary>
        /// Gets or sets approximate last sign in date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approximateLastSignInDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ApproximateLastSignInDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device metadata.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceMetadata", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceMetadata { get; set; }
    
        /// <summary>
        /// Gets or sets device version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceVersion", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeviceVersion { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is compliant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isCompliant", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsCompliant { get; set; }
    
        /// <summary>
        /// Gets or sets is managed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isManaged", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsManaged { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesLastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSyncEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets operating system version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystemVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets physical ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "physicalIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> PhysicalIds { get; set; }
    
        /// <summary>
        /// Gets or sets trust type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trustType", Required = Newtonsoft.Json.Required.Default)]
        public string TrustType { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Manufacturer", Required = Newtonsoft.Json.Required.Default)]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Model", Required = Newtonsoft.Json.Required.Default)]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets kind.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Kind", Required = Newtonsoft.Json.Required.Default)]
        public string Kind { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "Platform", Required = Newtonsoft.Json.Required.Default)]
        public string Platform { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets registered owners.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredOwners", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceRegisteredOwnersCollectionWithReferencesPage RegisteredOwners { get; set; }
    
        /// <summary>
        /// Gets or sets registered users.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredUsers", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceRegisteredUsersCollectionWithReferencesPage RegisteredUsers { get; set; }
    
        /// <summary>
        /// Gets or sets commands.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "commands", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceCommandsCollectionPage Commands { get; set; }
    
    }
}

