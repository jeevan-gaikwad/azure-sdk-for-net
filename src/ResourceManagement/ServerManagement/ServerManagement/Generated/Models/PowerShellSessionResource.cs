
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
    /// A powershell session resource (practically equivalent to a runspace
    /// instance)
    /// </summary>
    [JsonTransformation]
    public partial class PowerShellSessionResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellSessionResource class.
        /// </summary>
        public PowerShellSessionResource() { }

        /// <summary>
        /// Initializes a new instance of the PowerShellSessionResource class.
        /// </summary>
        public PowerShellSessionResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string sessionId = default(string), string state = default(string), string runspaceAvailability = default(string), DateTime? disconnectedOn = default(DateTime?), DateTime? expiresOn = default(DateTime?), Version version = default(Version), string powerShellSessionResourceName = default(string))
            : base(id, type, name, location, tags, etag)
        {
            SessionId = sessionId;
            State = state;
            RunspaceAvailability = runspaceAvailability;
            DisconnectedOn = disconnectedOn;
            ExpiresOn = expiresOn;
            Version = version;
            PowerShellSessionResourceName = powerShellSessionResourceName;
        }

        /// <summary>
        /// the PowerShell Session Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// The runspace state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// The availability of the runspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runspaceAvailability")]
        public string RunspaceAvailability { get; set; }

        /// <summary>
        /// Timestamp of last time the service disconnected from the runspace.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disconnectedOn")]
        public DateTime? DisconnectedOn { get; set; }

        /// <summary>
        /// Timestamp when the runspace expires.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiresOn")]
        public DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public Version Version { get; set; }

        /// <summary>
        /// Name of the runspace
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string PowerShellSessionResourceName { get; set; }

    }
}
