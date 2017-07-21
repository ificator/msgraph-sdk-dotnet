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
    /// The type DefaultDeviceEnrollmentWindowsHelloForBusinessSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DefaultDeviceEnrollmentWindowsHelloForBusinessSettings
    {
    
        /// <summary>
        /// Gets or sets pinMinimumLength.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pinMaximumLength.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinMaximumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinMaximumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pinUppercaseLettersUsage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinUppercaseLettersUsage", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessPinUsage? PinUppercaseLettersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pinLowercaseLettersUsage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinLowercaseLettersUsage", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessPinUsage? PinLowercaseLettersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pinSpecialCharactersUsage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinSpecialCharactersUsage", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessPinUsage? PinSpecialCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets windowsHelloForBusiness.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsHelloForBusiness", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessConfiguration? WindowsHelloForBusiness { get; set; }
    
        /// <summary>
        /// Gets or sets securityDeviceRequired.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityDeviceRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityDeviceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets unlockWithBiometricsEnabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unlockWithBiometricsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? UnlockWithBiometricsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets mobilePinSignInEnabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobilePinSignInEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? MobilePinSignInEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets pinPreviousBlockCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinPreviousBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinPreviousBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets pinExpirationInDays.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinExpirationInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinExpirationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets enhancedBiometrics.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enhancedBiometrics", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessConfiguration? EnhancedBiometrics { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}