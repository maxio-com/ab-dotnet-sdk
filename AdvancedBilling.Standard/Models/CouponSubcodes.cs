// <copyright file="CouponSubcodes.cs" company="APIMatic">
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
    /// CouponSubcodes.
    /// </summary>
    public class CouponSubcodes
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is CouponSubcodes other &&                ((this.Codes == null && other.Codes == null) || (this.Codes?.Equals(other.Codes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Codes = {(this.Codes == null ? "null" : $"[{string.Join(", ", this.Codes)} ]")}");
        }
    }
}