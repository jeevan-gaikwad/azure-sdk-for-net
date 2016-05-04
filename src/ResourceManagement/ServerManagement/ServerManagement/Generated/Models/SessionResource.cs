
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
    /// the session object
    /// </summary>
    [JsonTransformation]
    public partial class SessionResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SessionResource class.
        /// </summary>
        public SessionResource() { }

        /// <summary>
        /// Initializes a new instance of the SessionResource class.
        /// </summary>
        public SessionResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string userName = default(string), DateTime? created = default(DateTime?), DateTime? updated = default(DateTime?))
            : base(id, type, name, location, tags, etag)
        {
            UserName = userName;
            Created = created;
            Updated = updated;
        }

        /// <summary>
        /// the username connecting to the session
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

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
