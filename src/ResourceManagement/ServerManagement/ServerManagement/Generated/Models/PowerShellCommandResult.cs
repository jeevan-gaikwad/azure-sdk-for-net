
namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class PowerShellCommandResult
    {
        /// <summary>
        /// Initializes a new instance of the PowerShellCommandResult class.
        /// </summary>
        public PowerShellCommandResult() { }

        /// <summary>
        /// Initializes a new instance of the PowerShellCommandResult class.
        /// </summary>
        public PowerShellCommandResult(int? messageType = default(int?), string foregroundColor = default(string), string backgroundColor = default(string), string value = default(string), string prompt = default(string), int? exitCode = default(int?), int? id = default(int?), string caption = default(string), string message = default(string), IList<PromptFieldDescription> descriptions = default(IList<PromptFieldDescription>))
        {
            MessageType = messageType;
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            Value = value;
            Prompt = prompt;
            ExitCode = exitCode;
            Id = id;
            Caption = caption;
            Message = message;
            Descriptions = descriptions;
        }

        /// <summary>
        /// the type of message
        /// </summary>
        [JsonProperty(PropertyName = "messageType")]
        public int? MessageType { get; set; }

        /// <summary>
        /// the HTML color string representing the foreground color.
        /// </summary>
        [JsonProperty(PropertyName = "foregroundColor")]
        public string ForegroundColor { get; set; }

        /// <summary>
        /// the HTML color string representing the background color.
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// actual result text from the PowerShell Command
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// The interactive prompt message
        /// </summary>
        [JsonProperty(PropertyName = "prompt")]
        public string Prompt { get; set; }

        /// <summary>
        /// the exit code from a executable that was called from powershell.
        /// </summary>
        [JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// ID of the prompt message
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// text that precedes the prompt.
        /// </summary>
        [JsonProperty(PropertyName = "caption")]
        public string Caption { get; set; }

        /// <summary>
        /// text of the prompt.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// collection of PromptFieldDescription objects that contains the
        /// user input
        /// </summary>
        [JsonProperty(PropertyName = "descriptions")]
        public IList<PromptFieldDescription> Descriptions { get; set; }

    }
}
