
namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    [JsonTransformation]
    public partial class GatewayResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the GatewayResource class.
        /// </summary>
        public GatewayResource() { }

        /// <summary>
        /// Initializes a new instance of the GatewayResource class.
        /// </summary>
        public GatewayResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), DateTime? created = default(DateTime?), DateTime? updated = default(DateTime?), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), string desiredVersion = default(string), IList<GatewayStatus> instances = default(IList<GatewayStatus>), int? activeMessageCount = default(int?), string latestPublishedMsiVersion = default(string), DateTime? publishedTimeUtc = default(DateTime?))
            : base(id, type, name, location, tags, etag)
        {
            Created = created;
            Updated = updated;
            AutoUpgrade = autoUpgrade;
            DesiredVersion = desiredVersion;
            Instances = instances;
            ActiveMessageCount = activeMessageCount;
            LatestPublishedMsiVersion = latestPublishedMsiVersion;
            PublishedTimeUtc = publishedTimeUtc;
        }

        /// <summary>
        /// UTC date and time when gateway was first added to management
        /// service
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// UTC date and time when node was last updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// setting of the autoupgrade. Possible values include: 'On', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoUpgrade")]
        public AutoUpgrade? AutoUpgrade { get; set; }

        /// <summary>
        /// latest available msi version
        /// </summary>
        [JsonProperty(PropertyName = "properties.desiredVersion")]
        public string DesiredVersion { get; set; }

        /// <summary>
        /// names of the nodes in the gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.instances")]
        public IList<GatewayStatus> Instances { get; set; }

        /// <summary>
        /// number of active messages
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeMessageCount")]
        public int? ActiveMessageCount { get; set; }

        /// <summary>
        /// last published msi version
        /// </summary>
        [JsonProperty(PropertyName = "properties.latestPublishedMsiVersion")]
        public string LatestPublishedMsiVersion { get; set; }

        /// <summary>
        /// the date/time of the last published gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishedTimeUtc")]
        public DateTime? PublishedTimeUtc { get; set; }

    }
}
