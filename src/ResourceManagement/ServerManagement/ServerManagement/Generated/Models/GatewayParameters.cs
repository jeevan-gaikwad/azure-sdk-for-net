
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
    public partial class GatewayParameters
    {
        /// <summary>
        /// Initializes a new instance of the GatewayParameters class.
        /// </summary>
        public GatewayParameters() { }

        /// <summary>
        /// Initializes a new instance of the GatewayParameters class.
        /// </summary>
        public GatewayParameters(string location = default(string), object tags = default(object), AutoUpgrade? autoUpgrade = default(AutoUpgrade?))
        {
            Location = location;
            Tags = tags;
            AutoUpgrade = autoUpgrade;
        }

        /// <summary>
        /// location of the resource
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public object Tags { get; set; }

        /// <summary>
        /// The autoUpgrade property gives the flexibility to gateway to auto
        /// upgrade itself. If properties value not specified, then we assume
        /// autoUpgrade = Off. Possible values include: 'On', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoUpgrade")]
        public AutoUpgrade? AutoUpgrade { get; set; }

    }
}
