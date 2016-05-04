
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
    public partial class SessionParameters
    {
        /// <summary>
        /// Initializes a new instance of the SessionParameters class.
        /// </summary>
        public SessionParameters() { }

        /// <summary>
        /// Initializes a new instance of the SessionParameters class.
        /// </summary>
        public SessionParameters(string userName = default(string), string password = default(string))
        {
            UserName = userName;
            Password = password;
        }

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
