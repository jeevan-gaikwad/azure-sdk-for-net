
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
    /// a collection of results from a powershell command
    /// </summary>
    public partial class PowerShellCommandResults
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellCommandResults class.
        /// </summary>
        public PowerShellCommandResults() { }

        /// <summary>
        /// Initializes a new instance of the PowerShellCommandResults class.
        /// </summary>
        public PowerShellCommandResults(IList<PowerShellCommandResult> results = default(IList<PowerShellCommandResult>), string pssession = default(string), string command = default(string), bool? completed = default(bool?))
        {
            Results = results;
            Pssession = pssession;
            Command = command;
            Completed = completed;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<PowerShellCommandResult> Results { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pssession")]
        public string Pssession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completed")]
        public bool? Completed { get; set; }

    }
}
