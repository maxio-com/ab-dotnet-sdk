// <copyright file="BulkCreateSegments.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// BulkCreateSegments.
    /// </summary>
    public class BulkCreateSegments : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateSegments"/> class.
        /// </summary>
        public BulkCreateSegments()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateSegments"/> class.
        /// </summary>
        /// <param name="segments">segments.</param>
        public BulkCreateSegments(
            List<Models.CreateSegment> segments = null)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// Gets or sets Segments.
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateSegment> Segments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BulkCreateSegments : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BulkCreateSegments other &&
                (this.Segments == null && other.Segments == null ||
                 this.Segments?.Equals(other.Segments) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Segments = {(this.Segments == null ? "null" : $"[{string.Join(", ", this.Segments)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}