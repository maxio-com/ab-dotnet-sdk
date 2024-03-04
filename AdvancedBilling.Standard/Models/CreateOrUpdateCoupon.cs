// <copyright file="CreateOrUpdateCoupon.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreateOrUpdateCoupon.
    /// </summary>
    public class CreateOrUpdateCoupon : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateCoupon"/> class.
        /// </summary>
        public CreateOrUpdateCoupon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateCoupon"/> class.
        /// </summary>
        /// <param name="coupon">coupon.</param>
        /// <param name="restrictedProducts">restricted_products.</param>
        /// <param name="restrictedComponents">restricted_components.</param>
        public CreateOrUpdateCoupon(
            CreateOrUpdateCouponCoupon coupon = null,
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
        public CreateOrUpdateCouponCoupon Coupon { get; set; }

        /// <summary>
        /// An object where the keys are product_ids and the values are booleans indicating if the coupon should be applicable to the product
        /// </summary>
        [JsonProperty("restricted_products", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> RestrictedProducts { get; set; }

        /// <summary>
        /// An object where the keys are component_ids and the values are booleans indicating if the coupon should be applicable to the component
        /// </summary>
        [JsonProperty("restricted_components", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool> RestrictedComponents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrUpdateCoupon : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrUpdateCoupon other &&                ((this.Coupon == null && other.Coupon == null) || (this.Coupon?.Equals(other.Coupon) == true)) &&
                ((this.RestrictedProducts == null && other.RestrictedProducts == null) || (this.RestrictedProducts?.Equals(other.RestrictedProducts) == true)) &&
                ((this.RestrictedComponents == null && other.RestrictedComponents == null) || (this.RestrictedComponents?.Equals(other.RestrictedComponents) == true));
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