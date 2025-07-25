// <copyright file="CouponSubcodesResponse.cs" company="APIMatic">
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
    /// CouponSubcodesResponse.
    /// </summary>
    public class CouponSubcodesResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponSubcodesResponse"/> class.
        /// </summary>
        public CouponSubcodesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponSubcodesResponse"/> class.
        /// </summary>
        /// <param name="createdCodes">created_codes.</param>
        /// <param name="duplicateCodes">duplicate_codes.</param>
        /// <param name="invalidCodes">invalid_codes.</param>
        public CouponSubcodesResponse(
            List<string> createdCodes = null,
            List<string> duplicateCodes = null,
            List<string> invalidCodes = null)
        {
            this.CreatedCodes = createdCodes;
            this.DuplicateCodes = duplicateCodes;
            this.InvalidCodes = invalidCodes;
        }

        /// <summary>
        /// Gets or sets CreatedCodes.
        /// </summary>
        [JsonProperty("created_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CreatedCodes { get; set; }

        /// <summary>
        /// Gets or sets DuplicateCodes.
        /// </summary>
        [JsonProperty("duplicate_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DuplicateCodes { get; set; }

        /// <summary>
        /// Gets or sets InvalidCodes.
        /// </summary>
        [JsonProperty("invalid_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvalidCodes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CouponSubcodesResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CouponSubcodesResponse other &&
                (this.CreatedCodes == null && other.CreatedCodes == null ||
                 this.CreatedCodes?.Equals(other.CreatedCodes) == true) &&
                (this.DuplicateCodes == null && other.DuplicateCodes == null ||
                 this.DuplicateCodes?.Equals(other.DuplicateCodes) == true) &&
                (this.InvalidCodes == null && other.InvalidCodes == null ||
                 this.InvalidCodes?.Equals(other.InvalidCodes) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreatedCodes = {(this.CreatedCodes == null ? "null" : $"[{string.Join(", ", this.CreatedCodes)} ]")}");
            toStringOutput.Add($"DuplicateCodes = {(this.DuplicateCodes == null ? "null" : $"[{string.Join(", ", this.DuplicateCodes)} ]")}");
            toStringOutput.Add($"InvalidCodes = {(this.InvalidCodes == null ? "null" : $"[{string.Join(", ", this.InvalidCodes)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}