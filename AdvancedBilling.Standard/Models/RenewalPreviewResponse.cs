// <copyright file="RenewalPreviewResponse.cs" company="APIMatic">
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
    /// RenewalPreviewResponse.
    /// </summary>
    public class RenewalPreviewResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewResponse"/> class.
        /// </summary>
        public RenewalPreviewResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewResponse"/> class.
        /// </summary>
        /// <param name="renewalPreview">renewal_preview.</param>
        public RenewalPreviewResponse(
            Models.RenewalPreview renewalPreview)
        {
            this.RenewalPreview = renewalPreview;
        }

        /// <summary>
        /// Gets or sets RenewalPreview.
        /// </summary>
        [JsonProperty("renewal_preview")]
        public Models.RenewalPreview RenewalPreview { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RenewalPreviewResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RenewalPreviewResponse other &&
                (this.RenewalPreview == null && other.RenewalPreview == null ||
                 this.RenewalPreview?.Equals(other.RenewalPreview) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RenewalPreview = {(this.RenewalPreview == null ? "null" : this.RenewalPreview.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}