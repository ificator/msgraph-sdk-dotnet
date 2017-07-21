// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ManagedAppPinCharacterSet.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedAppPinCharacterSet
    {
    
        /// <summary>
        /// any
        /// </summary>
        Any = 0,
	
        /// <summary>
        /// numeric
        /// </summary>
        Numeric = 1,
	
        /// <summary>
        /// alphanumeric
        /// </summary>
        Alphanumeric = 2,
	
        /// <summary>
        /// alphanumeric And Symbol
        /// </summary>
        AlphanumericAndSymbol = 3,
	
    }
}
