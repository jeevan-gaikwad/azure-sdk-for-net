
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
    /// Expanded gateway status information
    /// </summary>
    public partial class GatewayStatus
    {
        /// <summary>
        /// Initializes a new instance of the GatewayStatus class.
        /// </summary>
        public GatewayStatus() { }

        /// <summary>
        /// Initializes a new instance of the GatewayStatus class.
        /// </summary>
        public GatewayStatus(double? availableMemoryMByte = default(double?), double? gatewayCpuUtilizationPercent = default(double?), double? totalCpuUtilizationPercent = default(double?), string gatewayVersion = default(string), string friendlyOsName = default(string), DateTime? installedDate = default(DateTime?), int? logicalProcessorCount = default(int?), string name = default(string), string gatewayId = default(string), double? gatewayWorkingSetMByte = default(double?), DateTime? statusUpdated = default(DateTime?))
        {
            AvailableMemoryMByte = availableMemoryMByte;
            GatewayCpuUtilizationPercent = gatewayCpuUtilizationPercent;
            TotalCpuUtilizationPercent = totalCpuUtilizationPercent;
            GatewayVersion = gatewayVersion;
            FriendlyOsName = friendlyOsName;
            InstalledDate = installedDate;
            LogicalProcessorCount = logicalProcessorCount;
            Name = name;
            GatewayId = gatewayId;
            GatewayWorkingSetMByte = gatewayWorkingSetMByte;
            StatusUpdated = statusUpdated;
        }

        /// <summary>
        /// The available memory on the gateway host machine in megabytes.
        /// </summary>
        [JsonProperty(PropertyName = "availableMemoryMByte")]
        public double? AvailableMemoryMByte { get; set; }

        /// <summary>
        /// The CPU utilization of the gateway process (numeric value between
        /// 0 and 100).
        /// </summary>
        [JsonProperty(PropertyName = "gatewayCpuUtilizationPercent")]
        public double? GatewayCpuUtilizationPercent { get; set; }

        /// <summary>
        /// CPU Utilization of the whole system.
        /// </summary>
        [JsonProperty(PropertyName = "totalCpuUtilizationPercent")]
        public double? TotalCpuUtilizationPercent { get; set; }

        /// <summary>
        /// The version of the gateway that is installed on the system.
        /// </summary>
        [JsonProperty(PropertyName = "gatewayVersion")]
        public string GatewayVersion { get; set; }

        /// <summary>
        /// The Plaintext description of the OS on the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyOsName")]
        public string FriendlyOsName { get; set; }

        /// <summary>
        /// The date the gateway was installed
        /// </summary>
        [JsonProperty(PropertyName = "installedDate")]
        public DateTime? InstalledDate { get; set; }

        /// <summary>
        /// Number of logical processors in the gateway system.
        /// </summary>
        [JsonProperty(PropertyName = "logicalProcessorCount")]
        public int? LogicalProcessorCount { get; set; }

        /// <summary>
        /// The computer name of the gateway system.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The gateway resource id.
        /// </summary>
        [JsonProperty(PropertyName = "gatewayId")]
        public string GatewayId { get; set; }

        /// <summary>
        /// The working set size of the gateway process in megabytes.
        /// </summary>
        [JsonProperty(PropertyName = "gatewayWorkingSetMByte")]
        public double? GatewayWorkingSetMByte { get; set; }

        /// <summary>
        /// UTC date and time when gateway status was last updated
        /// </summary>
        [JsonProperty(PropertyName = "statusUpdated")]
        public DateTime? StatusUpdated { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.GatewayCpuUtilizationPercent > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "GatewayCpuUtilizationPercent", 100);
            }
            if (this.GatewayCpuUtilizationPercent < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "GatewayCpuUtilizationPercent", 0);
            }
        }
    }
}
