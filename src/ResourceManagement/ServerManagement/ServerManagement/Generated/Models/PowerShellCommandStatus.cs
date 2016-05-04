
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
    public partial class PowerShellCommandStatus : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellCommandStatus class.
        /// </summary>
        public PowerShellCommandStatus() { }

        /// <summary>
        /// Initializes a new instance of the PowerShellCommandStatus class.
        /// </summary>
        public PowerShellCommandStatus(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), IList<PowerShellCommandResult> results = default(IList<PowerShellCommandResult>), string pssession = default(string), string command = default(string), bool? completed = default(bool?))
            : base(id, type, name, location, tags, etag)
        {
            Results = results;
            Pssession = pssession;
            Command = command;
            Completed = completed;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.results")]
        public IList<PowerShellCommandResult> Results { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.pssession")]
        public string Pssession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.command")]
        public string Command { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.completed")]
        public bool? Completed { get; set; }

    }
}
