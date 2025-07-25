// <copyright file="CreateSegmentRequest.cs" company="APIMatic">
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
    /// CreateSegmentRequest.
    /// </summary>
    public class CreateSegmentRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegmentRequest"/> class.
        /// </summary>
        public CreateSegmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegmentRequest"/> class.
        /// </summary>
        /// <param name="segment">segment.</param>
        public CreateSegmentRequest(
            Models.CreateSegment segment)
        {
            this.Segment = segment;
        }

        /// <summary>
        /// Gets or sets Segment.
        /// </summary>
        [JsonProperty("segment")]
        public Models.CreateSegment Segment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSegmentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSegmentRequest other &&
                (this.Segment == null && other.Segment == null ||
                 this.Segment?.Equals(other.Segment) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Segment = {(this.Segment == null ? "null" : this.Segment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}