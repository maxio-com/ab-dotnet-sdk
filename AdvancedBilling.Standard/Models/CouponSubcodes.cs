// <copyright file="CouponSubcodes.cs" company="APIMatic">
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
    /// CouponSubcodes.
    /// </summary>
    public class CouponSubcodes : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponSubcodes"/> class.
        /// </summary>
        public CouponSubcodes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponSubcodes"/> class.
        /// </summary>
        /// <param name="codes">codes.</param>
        public CouponSubcodes(
            List<string> codes = null)
        {
            this.Codes = codes;
        }

        /// <summary>
        /// Gets or sets Codes.
        /// </summary>
        [JsonProperty("codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Codes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CouponSubcodes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CouponSubcodes other &&
                (this.Codes == null && other.Codes == null ||
                 this.Codes?.Equals(other.Codes) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Codes = {(this.Codes == null ? "null" : $"[{string.Join(", ", this.Codes)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}