// <copyright file="BulkUpdateSegments.cs" company="APIMatic">
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
    /// BulkUpdateSegments.
    /// </summary>
    public class BulkUpdateSegments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSegments"/> class.
        /// </summary>
        public BulkUpdateSegments()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateSegments"/> class.
        /// </summary>
        /// <param name="segments">segments.</param>
        public BulkUpdateSegments(
            List<Models.BulkUpdateSegmentsItem> segments = null)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// Gets or sets Segments.
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BulkUpdateSegmentsItem> Segments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BulkUpdateSegments : ({string.Join(", ", toStringOutput)})";
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
            return obj is BulkUpdateSegments other &&                ((this.Segments == null && other.Segments == null) || (this.Segments?.Equals(other.Segments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Segments = {(this.Segments == null ? "null" : $"[{string.Join(", ", this.Segments)} ]")}");
        }
    }
}