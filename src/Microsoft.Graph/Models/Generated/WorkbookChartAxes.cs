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
    /// The type Workbook Chart Axes.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartAxes : Entity
    {
    
        /// <summary>
        /// Gets or sets category axis.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "categoryAxis", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartAxis CategoryAxis { get; set; }
    
        /// <summary>
        /// Gets or sets series axis.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "seriesAxis", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartAxis SeriesAxis { get; set; }
    
        /// <summary>
        /// Gets or sets value axis.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueAxis", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartAxis ValueAxis { get; set; }
    
    }
}

