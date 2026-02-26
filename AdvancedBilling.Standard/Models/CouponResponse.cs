// <copyright file="CouponResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CouponResponse.
    /// </summary>
    public class CouponResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponResponse"/> class.
        /// </summary>
        public CouponResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponResponse"/> class.
        /// </summary>
        /// <param name="coupon">coupon.</param>
        public CouponResponse(
            Models.Coupon coupon = null)
        {
            this.Coupon = coupon;
        }

        /// <summary>
        /// Gets or sets Coupon.
        /// </summary>
        [JsonProperty("coupon", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Coupon Coupon { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CouponResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CouponResponse other &&
                (this.Coupon == null && other.Coupon == null ||
                 this.Coupon?.Equals(other.Coupon) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Coupon = {(this.Coupon == null ? "null" : this.Coupon.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}