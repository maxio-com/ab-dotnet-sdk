// <copyright file="BulkCreateSegments.cs" company="APIMatic">
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
    /// BulkCreateSegments.
    /// </summary>
    public class BulkCreateSegments
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is BulkCreateSegments other &&                ((this.Segments == null && other.Segments == null) || (this.Segments?.Equals(other.Segments) == true));
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