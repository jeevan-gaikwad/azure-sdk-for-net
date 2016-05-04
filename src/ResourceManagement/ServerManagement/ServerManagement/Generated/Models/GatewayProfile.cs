
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
    /// JSON properties that the gateway service uses know how to communicate
    /// with the resource.
    /// </summary>
    public partial class GatewayProfile
    {
        /// <summary>
        /// Initializes a new instance of the GatewayProfile class.
        /// </summary>
        public GatewayProfile() { }

        /// <summary>
        /// Initializes a new instance of the GatewayProfile class.
        /// </summary>
        public GatewayProfile(string dataPlaneServiceBaseAddress = default(string), string gatewayId = default(string), string environment = default(string), string upgradeManifestUrl = default(string), string messagingNamespace = default(string), string messagingAccount = default(string), string messagingKey = default(string), string requestQueue = default(string), string responseTopic = default(string), string statusBlobSignature = default(string))
        {
            DataPlaneServiceBaseAddress = dataPlaneServiceBaseAddress;
            GatewayId = gatewayId;
            Environment = environment;
            UpgradeManifestUrl = upgradeManifestUrl;
            MessagingNamespace = messagingNamespace;
            MessagingAccount = messagingAccount;
            MessagingKey = messagingKey;
            RequestQueue = requestQueue;
            ResponseTopic = responseTopic;
            StatusBlobSignature = statusBlobSignature;
        }

        /// <summary>
        /// the Dataplane connection URL
        /// </summary>
        [JsonProperty(PropertyName = "dataPlaneServiceBaseAddress")]
        public string DataPlaneServiceBaseAddress { get; set; }

        /// <summary>
        /// the ID of the gateway
        /// </summary>
        [JsonProperty(PropertyName = "gatewayId")]
        public string GatewayId { get; set; }

        /// <summary>
        /// the environment for the gateway (DEV, DogFood, or Production)
        /// </summary>
        [JsonProperty(PropertyName = "environment")]
        public string Environment { get; set; }

        /// <summary>
        /// Gateway upgrade manifest URL
        /// </summary>
        [JsonProperty(PropertyName = "upgradeManifestUrl")]
        public string UpgradeManifestUrl { get; set; }

        /// <summary>
        /// Messaging namespace
        /// </summary>
        [JsonProperty(PropertyName = "messagingNamespace")]
        public string MessagingNamespace { get; set; }

        /// <summary>
        /// Messaging Account
        /// </summary>
        [JsonProperty(PropertyName = "messagingAccount")]
        public string MessagingAccount { get; set; }

        /// <summary>
        /// Messaging Key
        /// </summary>
        [JsonProperty(PropertyName = "messagingKey")]
        public string MessagingKey { get; set; }

        /// <summary>
        /// Request queue name
        /// </summary>
        [JsonProperty(PropertyName = "requestQueue")]
        public string RequestQueue { get; set; }

        /// <summary>
        /// Response topic name
        /// </summary>
        [JsonProperty(PropertyName = "responseTopic")]
        public string ResponseTopic { get; set; }

        /// <summary>
        /// The gateway status blob SAS url
        /// </summary>
        [JsonProperty(PropertyName = "statusBlobSignature")]
        public string StatusBlobSignature { get; set; }

    }
}
