// <copyright file="ListSegmentsResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ListSegmentsResponse other &&                ((this.Segments == null && other.Segments == null) || (this.Segments?.Equals(other.Segments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Segments = {(this.Segments == null ? "null" : $"[{string.Join(", ", this.Segments)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}