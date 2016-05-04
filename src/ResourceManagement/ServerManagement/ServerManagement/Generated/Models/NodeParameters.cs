
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
    public partial class NodeParameters
    {
        /// <summary>
        /// Initializes a new instance of the NodeParameters class.
        /// </summary>
        public NodeParameters() { }

        /// <summary>
        /// Initializes a new instance of the NodeParameters class.
        /// </summary>
        public NodeParameters(string location = default(string), object tags = default(object), string gatewayId = default(string), string connectionName = default(string), string userName = default(string), string password = default(string))
        {
            Location = location;
            Tags = tags;
            GatewayId = gatewayId;
            ConnectionName = connectionName;
            UserName = userName;
            Password = password;
        }

        /// <summary>
        /// location of the resource?
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public object Tags { get; set; }

        /// <summary>
        /// Gateway id which will manage this node
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayId")]
        public string GatewayId { get; set; }

        /// <summary>
        /// myhost.domain.com
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionName")]
        public string ConnectionName { get; set; }

        /// <summary>
        /// User name to be used to connect to node
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Password associated with user name
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

    }
}
