// <copyright file="OfferDiscount.cs" company="APIMatic">
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
    /// OfferDiscount.
    /// </summary>
    public class OfferDiscount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDiscount"/> class.
        /// </summary>
        public OfferDiscount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDiscount"/> class.
        /// </summary>
        /// <param name="couponCode">coupon_code.</param>
        /// <param name="couponId">coupon_id.</param>
        /// <param name="couponName">coupon_name.</param>
        public OfferDiscount(
            string couponCode = null,
            int? couponId = null,
            string couponName = null)
        {
            this.CouponCode = couponCode;
            this.CouponId = couponId;
            this.CouponName = couponName;
        }

        /// <summary>
        /// Gets or sets CouponCode.
        /// </summary>
        [JsonProperty("coupon_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponCode { get; set; }

        /// <summary>
        /// Gets or sets CouponId.
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponId { get; set; }

        /// <summary>
        /// Gets or sets CouponName.
        /// </summary>
        [JsonProperty("coupon_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OfferDiscount : ({string.Join(", ", toStringOutput)})";
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
            return obj is OfferDiscount other &&                ((this.CouponCode == null && other.CouponCode == null) || (this.CouponCode?.Equals(other.CouponCode) == true)) &&
                ((this.CouponId == null && other.CouponId == null) || (this.CouponId?.Equals(other.CouponId) == true)) &&
                ((this.CouponName == null && other.CouponName == null) || (this.CouponName?.Equals(other.CouponName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CouponCode = {(this.CouponCode == null ? "null" : this.CouponCode)}");
            toStringOutput.Add($"this.CouponId = {(this.CouponId == null ? "null" : this.CouponId.ToString())}");
            toStringOutput.Add($"this.CouponName = {(this.CouponName == null ? "null" : this.CouponName)}");
        }
    }
}