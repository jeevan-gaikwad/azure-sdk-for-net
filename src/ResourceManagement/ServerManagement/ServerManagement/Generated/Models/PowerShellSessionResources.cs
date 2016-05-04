
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
    /// a collaction of powershell session resources
    /// </summary>
    public partial class PowerShellSessionResources
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellSessionResources class.
        /// </summary>
        public PowerShellSessionResources() { }

        /// <summary>
        /// Initializes a new instance of the PowerShellSessionResources class.
        /// </summary>
        public PowerShellSessionResources(IList<PowerShellSessionResource> value = default(IList<PowerShellSessionResource>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Colleciton of powershell session resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<PowerShellSessionResource> Value { get; set; }

        /// <summary>
        /// the URL to the next set of resources
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
