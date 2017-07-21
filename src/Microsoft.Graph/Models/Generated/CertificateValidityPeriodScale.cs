// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum CertificateValidityPeriodScale.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CertificateValidityPeriodScale
    {
    
        /// <summary>
        /// days
        /// </summary>
        Days = 0,
	
        /// <summary>
        /// months
        /// </summary>
        Months = 1,
	
        /// <summary>
        /// years
        /// </summary>
        Years = 2,
	
    }
}
