
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
    /// A multipart-numeric version number
    /// </summary>
    public partial class Version
    {
        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version() { }

        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version(int? major = default(int?), int? minor = default(int?), int? build = default(int?), int? revision = default(int?), int? majorRevision = default(int?), int? minorRevision = default(int?))
        {
            Major = major;
            Minor = minor;
            Build = build;
            Revision = revision;
            MajorRevision = majorRevision;
            MinorRevision = minorRevision;
        }

        /// <summary>
        /// the leftmost number of the version
        /// </summary>
        [JsonProperty(PropertyName = "major")]
        public int? Major { get; set; }

        /// <summary>
        /// the second leftmost number of the version
        /// </summary>
        [JsonProperty(PropertyName = "minor")]
        public int? Minor { get; set; }

        /// <summary>
        /// the third number of the version
        /// </summary>
        [JsonProperty(PropertyName = "build")]
        public int? Build { get; set; }

        /// <summary>
        /// the fourth number of the version
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// the MSW of the fourth part
        /// </summary>
        [JsonProperty(PropertyName = "majorRevision")]
        public int? MajorRevision { get; set; }

        /// <summary>
        /// the LSW of the fourth part
        /// </summary>
        [JsonProperty(PropertyName = "minorRevision")]
        public int? MinorRevision { get; set; }

    }
}
