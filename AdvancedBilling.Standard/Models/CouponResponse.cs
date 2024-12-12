// <copyright file="CouponResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
            toStringOutput.Add($"this.Coupon = {(this.Coupon == null ? "null" : this.Coupon.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}