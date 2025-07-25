// <copyright file="CouponRequest.cs" company="APIMatic">
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
    /// CouponRequest.
    /// </summary>
    public class CouponRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponRequest"/> class.
        /// </summary>
        public CouponRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponRequest"/> class.
        /// </summary>
        /// <param name="coupon">coupon.</param>
        /// <param name="restrictedProducts">restricted_products.</param>
        /// <param name="restrictedComponents">restricted_components.</param>
        public CouponRequest(
            Models.CouponPayload coupon = null,
            Dictionary<string, bool> restrictedProducts = null,
            Dictionary<string, bool> restrictedComponents = null)
        {
            this.Coupon = coupon;
            this.RestrictedProducts = restrictedProducts;
            this.RestrictedComponents = restrictedComponents;
        }

        /// <summary>
        /// Gets or sets Coupon.
        /// </summary>
        [JsonProperty("coupon", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CouponPayload Coupon { get; set; }

        /// <summary>
        /// An object where the keys are product IDs or handles (prefixed with 'handle:'), and the values are booleans indicating if the coupon should be applicable to the product
        /// </summary>
        [JsonProperty("restricted_products", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> RestrictedProducts { get; set; }

        /// <summary>
        /// An object where the keys are component IDs or handles (prefixed with 'handle:'), and the values are booleans indicating if the coupon should be applicable to the component
        /// </summary>
        [JsonProperty("restricted_components", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> RestrictedComponents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CouponRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CouponRequest other &&
                (this.Coupon == null && other.Coupon == null ||
                 this.Coupon?.Equals(other.Coupon) == true) &&
                (this.RestrictedProducts == null && other.RestrictedProducts == null ||
                 this.RestrictedProducts?.Equals(other.RestrictedProducts) == true) &&
                (this.RestrictedComponents == null && other.RestrictedComponents == null ||
                 this.RestrictedComponents?.Equals(other.RestrictedComponents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Coupon = {(this.Coupon == null ? "null" : this.Coupon.ToString())}");
            toStringOutput.Add($"RestrictedProducts = {(this.RestrictedProducts == null ? "null" : this.RestrictedProducts.ToString())}");
            toStringOutput.Add($"RestrictedComponents = {(this.RestrictedComponents == null ? "null" : this.RestrictedComponents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}