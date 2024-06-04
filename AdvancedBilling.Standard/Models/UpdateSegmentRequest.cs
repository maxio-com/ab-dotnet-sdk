// <copyright file="UpdateSegmentRequest.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UpdateSegmentRequest.
    /// </summary>
    public class UpdateSegmentRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSegmentRequest"/> class.
        /// </summary>
        public UpdateSegmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSegmentRequest"/> class.
        /// </summary>
        /// <param name="segment">segment.</param>
        public UpdateSegmentRequest(
            Models.UpdateSegment segment)
        {
            this.Segment = segment;
        }

        /// <summary>
        /// Gets or sets Segment.
        /// </summary>
        [JsonProperty("segment")]
        public Models.UpdateSegment Segment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateSegmentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateSegmentRequest other &&                ((this.Segment == null && other.Segment == null) || (this.Segment?.Equals(other.Segment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Segment = {(this.Segment == null ? "null" : this.Segment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}