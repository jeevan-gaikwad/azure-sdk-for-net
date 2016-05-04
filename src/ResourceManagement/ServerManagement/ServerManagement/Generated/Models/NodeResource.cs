
namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Node Resource
    /// </summary>
    [JsonTransformation]
    public partial class NodeResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NodeResource class.
        /// </summary>
        public NodeResource() { }

        /// <summary>
        /// Initializes a new instance of the NodeResource class.
        /// </summary>
        public NodeResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string gatewayId = default(string), string connectionName = default(string), DateTime? created = default(DateTime?), DateTime? updated = default(DateTime?))
            : base(id, type, name, location, tags, etag)
        {
            GatewayId = gatewayId;
            ConnectionName = connectionName;
            Created = created;
            Updated = updated;
        }

        /// <summary>
        /// Id of the gateway
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayId")]
        public string GatewayId { get; set; }

        /// <summary>
        /// myhost.domain.com
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionName")]
        public string ConnectionName { get; set; }

        /// <summary>
        /// UTC date and time when node was first added to management service
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// UTC date and time when node was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public DateTime? Updated { get; set; }

    }
}
