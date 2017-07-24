// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Contains utilization and resource usage statistics for the lifetime of
    /// a pool.
    /// </summary>
    public partial class PoolStatistics
    {
        /// <summary>
        /// Initializes a new instance of the PoolStatistics class.
        /// </summary>
        public PoolStatistics() { }

        /// <summary>
        /// Initializes a new instance of the PoolStatistics class.
        /// </summary>
        /// <param name="url">The URL for the statistics.</param>
        /// <param name="startTime">The start time of the time range covered by
        /// the statistics.</param>
        /// <param name="lastUpdateTime">The time at which the statistics were
        /// last updated. All statistics are limited to the range between
        /// startTime and lastUpdateTime.</param>
        /// <param name="usageStats">Statistics related to pool usage, such as
        /// the amount of core-time used.</param>
        /// <param name="resourceStats">Statistics related to resource
        /// consumption by compute nodes in the pool.</param>
        public PoolStatistics(string url, System.DateTime startTime, System.DateTime lastUpdateTime, UsageStatistics usageStats = default(UsageStatistics), ResourceStatistics resourceStats = default(ResourceStatistics))
        {
            this.Url = url;
            this.StartTime = startTime;
            this.LastUpdateTime = lastUpdateTime;
            this.UsageStats = usageStats;
            this.ResourceStats = resourceStats;
        }

        /// <summary>
        /// Gets or sets the URL for the statistics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the start time of the time range covered by the
        /// statistics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the statistics were last updated.
        /// All statistics are limited to the range between startTime and
        /// lastUpdateTime.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets statistics related to pool usage, such as the amount
        /// of core-time used.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usageStats")]
        public UsageStatistics UsageStats { get; set; }

        /// <summary>
        /// Gets or sets statistics related to resource consumption by compute
        /// nodes in the pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceStats")]
        public ResourceStatistics ResourceStats { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Url == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Url");
            }
            if (this.UsageStats != null)
            {
                this.UsageStats.Validate();
            }
            if (this.ResourceStats != null)
            {
                this.ResourceStats.Validate();
            }
        }
    }
}
