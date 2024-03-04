// <copyright file="AllocationPreviewResponse.cs" company="APIMatic">
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
    /// AllocationPreviewResponse.
    /// </summary>
    public class AllocationPreviewResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewResponse"/> class.
        /// </summary>
        public AllocationPreviewResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewResponse"/> class.
        /// </summary>
        /// <param name="allocationPreview">allocation_preview.</param>
        public AllocationPreviewResponse(
            Models.AllocationPreview allocationPreview)
        {
            this.AllocationPreview = allocationPreview;
        }

        /// <summary>
        /// Gets or sets AllocationPreview.
        /// </summary>
        [JsonProperty("allocation_preview")]
        public Models.AllocationPreview AllocationPreview { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AllocationPreviewResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AllocationPreviewResponse other &&                ((this.AllocationPreview == null && other.AllocationPreview == null) || (this.AllocationPreview?.Equals(other.AllocationPreview) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllocationPreview = {(this.AllocationPreview == null ? "null" : this.AllocationPreview.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}