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
    /// The type Ios Edu Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosEduDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets teacher certificate settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teacherCertificateSettings", Required = Newtonsoft.Json.Required.Default)]
        public IosEduCertificateSettings TeacherCertificateSettings { get; set; }
    
        /// <summary>
        /// Gets or sets student certificate settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "studentCertificateSettings", Required = Newtonsoft.Json.Required.Default)]
        public IosEduCertificateSettings StudentCertificateSettings { get; set; }
    
        /// <summary>
        /// Gets or sets device certificate settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCertificateSettings", Required = Newtonsoft.Json.Required.Default)]
        public IosEduCertificateSettings DeviceCertificateSettings { get; set; }
    
    }
}

