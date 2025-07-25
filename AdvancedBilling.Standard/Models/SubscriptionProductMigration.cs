// <copyright file="SubscriptionProductMigration.cs" company="APIMatic">
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
    /// SubscriptionProductMigration.
    /// </summary>
    public class SubscriptionProductMigration : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductMigration"/> class.
        /// </summary>
        public SubscriptionProductMigration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductMigration"/> class.
        /// </summary>
        /// <param name="productId">product_id.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="includeTrial">include_trial.</param>
        /// <param name="includeInitialCharge">include_initial_charge.</param>
        /// <param name="includeCoupons">include_coupons.</param>
        /// <param name="preservePeriod">preserve_period.</param>
        /// <param name="productHandle">product_handle.</param>
        /// <param name="productPricePointHandle">product_price_point_handle.</param>
        /// <param name="proration">proration.</param>
        public SubscriptionProductMigration(
            int? productId = null,
            int? productPricePointId = null,
            bool? includeTrial = false,
            bool? includeInitialCharge = false,
            bool? includeCoupons = true,
            bool? preservePeriod = false,
            string productHandle = null,
            string productPricePointHandle = null,
            Models.Proration proration = null)
        {
            this.ProductId = productId;
            this.ProductPricePointId = productPricePointId;
            this.IncludeTrial = includeTrial;
            this.IncludeInitialCharge = includeInitialCharge;
            this.IncludeCoupons = includeCoupons;
            this.PreservePeriod = preservePeriod;
            this.ProductHandle = productHandle;
            this.ProductPricePointHandle = productPricePointHandle;
            this.Proration = proration;
        }

        /// <summary>
        /// The ID of the target Product. Either a product_id or product_handle must be present. A Subscription can be migrated to another product for both the current Product Family and another Product Family. Note: Going to another Product Family, components will not be migrated as well.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// The ID of the specified product's price point. This can be passed to migrate to a non-default price point.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// Whether to include the trial period configured for the product price point when starting a new billing period. Note that if preserve_period is set, then include_trial will be ignored.
        /// </summary>
        [JsonProperty("include_trial", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeTrial { get; set; }

        /// <summary>
        /// If `true` is sent initial charges will be assessed.
        /// </summary>
        [JsonProperty("include_initial_charge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeInitialCharge { get; set; }

        /// <summary>
        /// If `true` is sent, any coupons associated with the subscription will be applied to the migration. If `false` is sent, coupons will not be applied. Note: When migrating to a new product family, the coupon cannot migrate.
        /// </summary>
        [JsonProperty("include_coupons", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeCoupons { get; set; }

        /// <summary>
        /// If `false` is sent, the subscription's billing period will be reset to today and the full price of the new product will be charged. If `true` is sent, the billing period will not change and a prorated charge will be issued for the new product.
        /// </summary>
        [JsonProperty("preserve_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreservePeriod { get; set; }

        /// <summary>
        /// The handle of the target Product. Either a product_id or product_handle must be present. A Subscription can be migrated to another product for both the current Product Family and another Product Family. Note: Going to another Product Family, components will not be migrated as well.
        /// </summary>
        [JsonProperty("product_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductHandle { get; set; }

        /// <summary>
        /// The ID or handle of the specified product's price point. This can be passed to migrate to a non-default price point.
        /// </summary>
        [JsonProperty("product_price_point_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointHandle { get; set; }

        /// <summary>
        /// Gets or sets Proration.
        /// </summary>
        [JsonProperty("proration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Proration Proration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionProductMigration : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionProductMigration other &&
                (this.ProductId == null && other.ProductId == null ||
                 this.ProductId?.Equals(other.ProductId) == true) &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                (this.IncludeTrial == null && other.IncludeTrial == null ||
                 this.IncludeTrial?.Equals(other.IncludeTrial) == true) &&
                (this.IncludeInitialCharge == null && other.IncludeInitialCharge == null ||
                 this.IncludeInitialCharge?.Equals(other.IncludeInitialCharge) == true) &&
                (this.IncludeCoupons == null && other.IncludeCoupons == null ||
                 this.IncludeCoupons?.Equals(other.IncludeCoupons) == true) &&
                (this.PreservePeriod == null && other.PreservePeriod == null ||
                 this.PreservePeriod?.Equals(other.PreservePeriod) == true) &&
                (this.ProductHandle == null && other.ProductHandle == null ||
                 this.ProductHandle?.Equals(other.ProductHandle) == true) &&
                (this.ProductPricePointHandle == null && other.ProductPricePointHandle == null ||
                 this.ProductPricePointHandle?.Equals(other.ProductPricePointHandle) == true) &&
                (this.Proration == null && other.Proration == null ||
                 this.Proration?.Equals(other.Proration) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"IncludeTrial = {(this.IncludeTrial == null ? "null" : this.IncludeTrial.ToString())}");
            toStringOutput.Add($"IncludeInitialCharge = {(this.IncludeInitialCharge == null ? "null" : this.IncludeInitialCharge.ToString())}");
            toStringOutput.Add($"IncludeCoupons = {(this.IncludeCoupons == null ? "null" : this.IncludeCoupons.ToString())}");
            toStringOutput.Add($"PreservePeriod = {(this.PreservePeriod == null ? "null" : this.PreservePeriod.ToString())}");
            toStringOutput.Add($"ProductHandle = {this.ProductHandle ?? "null"}");
            toStringOutput.Add($"ProductPricePointHandle = {this.ProductPricePointHandle ?? "null"}");
            toStringOutput.Add($"Proration = {(this.Proration == null ? "null" : this.Proration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}