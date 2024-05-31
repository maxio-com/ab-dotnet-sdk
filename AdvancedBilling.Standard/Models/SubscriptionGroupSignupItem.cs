// <copyright file="SubscriptionGroupSignupItem.cs" company="APIMatic">
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
    /// SubscriptionGroupSignupItem.
    /// </summary>
    public class SubscriptionGroupSignupItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupItem"/> class.
        /// </summary>
        public SubscriptionGroupSignupItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupItem"/> class.
        /// </summary>
        /// <param name="productHandle">product_handle.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="productPricePointHandle">product_price_point_handle.</param>
        /// <param name="offerId">offer_id.</param>
        /// <param name="reference">reference.</param>
        /// <param name="primary">primary.</param>
        /// <param name="currency">currency.</param>
        /// <param name="couponCodes">coupon_codes.</param>
        /// <param name="components">components.</param>
        /// <param name="customPrice">custom_price.</param>
        /// <param name="calendarBilling">calendar_billing.</param>
        /// <param name="metafields">metafields.</param>
        public SubscriptionGroupSignupItem(
            string productHandle = null,
            int? productId = null,
            int? productPricePointId = null,
            string productPricePointHandle = null,
            int? offerId = null,
            string reference = null,
            bool? primary = null,
            string currency = null,
            List<string> couponCodes = null,
            List<Models.SubscriptionGroupSignupComponent> components = null,
            Models.SubscriptionCustomPrice customPrice = null,
            Models.CalendarBilling calendarBilling = null,
            Dictionary<string, string> metafields = null)
        {
            this.ProductHandle = productHandle;
            this.ProductId = productId;
            this.ProductPricePointId = productPricePointId;
            this.ProductPricePointHandle = productPricePointHandle;
            this.OfferId = offerId;
            this.Reference = reference;
            this.Primary = primary;
            this.Currency = currency;
            this.CouponCodes = couponCodes;
            this.Components = components;
            this.CustomPrice = customPrice;
            this.CalendarBilling = calendarBilling;
            this.Metafields = metafields;
        }

        /// <summary>
        /// The API Handle of the product for which you are creating a subscription. Required, unless a `product_id` is given instead.
        /// </summary>
        [JsonProperty("product_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductHandle { get; set; }

        /// <summary>
        /// The Product ID of the product for which you are creating a subscription. You can pass either `product_id` or `product_handle`.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// The ID of the particular price point on the product.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// The user-friendly API handle of a product's particular price point.
        /// </summary>
        [JsonProperty("product_price_point_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointHandle { get; set; }

        /// <summary>
        /// Use in place of passing product and component information to set up the subscription with an existing offer. May be either the Chargify ID of the offer or its handle prefixed with `handle:`
        /// </summary>
        [JsonProperty("offer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? OfferId { get; set; }

        /// <summary>
        /// The reference value (provided by your app) for the subscription itelf.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// One of the subscriptions must be marked as primary in the group.
        /// </summary>
        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        /// <summary>
        /// (Optional) If Multi-Currency is enabled and the currency is configured in Chargify, pass it at signup to create a subscription on a non-default currency. Note that you cannot update the currency of an existing subscription.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// An array for all the coupons attached to the subscription.
        /// </summary>
        [JsonProperty("coupon_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// Gets or sets Components.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionGroupSignupComponent> Components { get; set; }

        /// <summary>
        /// (Optional) Used in place of `product_price_point_id` to define a custom price point unique to the subscription
        /// </summary>
        [JsonProperty("custom_price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionCustomPrice CustomPrice { get; set; }

        /// <summary>
        /// (Optional). Cannot be used when also specifying next_billing_at
        /// </summary>
        [JsonProperty("calendar_billing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CalendarBilling CalendarBilling { get; set; }

        /// <summary>
        /// (Optional) A set of key/value pairs representing custom fields and their values. Metafields will be created “on-the-fly” in your site for a given key, if they have not been created yet.
        /// </summary>
        [JsonProperty("metafields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metafields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSignupItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSignupItem other &&                ((this.ProductHandle == null && other.ProductHandle == null) || (this.ProductHandle?.Equals(other.ProductHandle) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.ProductPricePointHandle == null && other.ProductPricePointHandle == null) || (this.ProductPricePointHandle?.Equals(other.ProductPricePointHandle) == true)) &&
                ((this.OfferId == null && other.OfferId == null) || (this.OfferId?.Equals(other.OfferId) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Primary == null && other.Primary == null) || (this.Primary?.Equals(other.Primary) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.CouponCodes == null && other.CouponCodes == null) || (this.CouponCodes?.Equals(other.CouponCodes) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.CustomPrice == null && other.CustomPrice == null) || (this.CustomPrice?.Equals(other.CustomPrice) == true)) &&
                ((this.CalendarBilling == null && other.CalendarBilling == null) || (this.CalendarBilling?.Equals(other.CalendarBilling) == true)) &&
                ((this.Metafields == null && other.Metafields == null) || (this.Metafields?.Equals(other.Metafields) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductHandle = {(this.ProductHandle == null ? "null" : this.ProductHandle)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointHandle = {(this.ProductPricePointHandle == null ? "null" : this.ProductPricePointHandle)}");
            toStringOutput.Add($"this.OfferId = {(this.OfferId == null ? "null" : this.OfferId.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Primary = {(this.Primary == null ? "null" : this.Primary.ToString())}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.CouponCodes = {(this.CouponCodes == null ? "null" : $"[{string.Join(", ", this.CouponCodes)} ]")}");
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : $"[{string.Join(", ", this.Components)} ]")}");
            toStringOutput.Add($"this.CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");
            toStringOutput.Add($"this.CalendarBilling = {(this.CalendarBilling == null ? "null" : this.CalendarBilling.ToString())}");
            toStringOutput.Add($"Metafields = {(this.Metafields == null ? "null" : this.Metafields.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}