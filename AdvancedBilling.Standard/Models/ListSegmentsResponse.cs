// <copyright file="ListSegmentsResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListSegmentsResponse.
    /// </summary>
    public class ListSegmentsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentsResponse"/> class.
        /// </summary>
        public ListSegmentsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentsResponse"/> class.
        /// </summary>
        /// <param name="segments">segments.</param>
        public ListSegmentsResponse(
            List<Models.Segment> segments = null)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// Gets or sets Segments.
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Segment> Segments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSegmentsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSegmentsResponse other &&
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