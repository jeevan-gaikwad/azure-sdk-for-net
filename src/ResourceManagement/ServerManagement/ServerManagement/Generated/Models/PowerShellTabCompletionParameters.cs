
namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class PowerShellTabCompletionParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PowerShellTabCompletionParameters class.
        /// </summary>
        public PowerShellTabCompletionParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// PowerShellTabCompletionParameters class.
        /// </summary>
        public PowerShellTabCompletionParameters(string command = default(string))
        {
            Command = command;
        }

        /// <summary>
        /// Command to get tab completion for.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public string Command { get; set; }

    }
}
