// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum SubjectNameFormat.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SubjectNameFormat
    {
    
        /// <summary>
        /// common Name
        /// </summary>
        CommonName = 0,
	
        /// <summary>
        /// common Name Including Email
        /// </summary>
        CommonNameIncludingEmail = 1,
	
        /// <summary>
        /// common Name As Email
        /// </summary>
        CommonNameAsEmail = 2,
	
        /// <summary>
        /// custom
        /// </summary>
        Custom = 3,
	
    }
}