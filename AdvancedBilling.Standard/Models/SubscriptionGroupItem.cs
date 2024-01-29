// <copyright file="SubscriptionGroupItem.cs" company="APIMatic">
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
    /// SubscriptionGroupItem.
    /// </summary>
    public class SubscriptionGroupItem
    {
        private string reference;
        private string productHandle;
        private string couponCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "reference", false },
            { "product_handle", false },
            { "coupon_code", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupItem"/> class.
        /// </summary>
        public SubscriptionGroupItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="reference">reference.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productHandle">product_handle.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="productPricePointHandle">product_price_point_handle.</param>
        /// <param name="currency">currency.</param>
        /// <param name="couponCode">coupon_code.</param>
        /// <param name="totalRevenueInCents">total_revenue_in_cents.</param>
        /// <param name="balanceInCents">balance_in_cents.</param>
        public SubscriptionGroupItem(
            int? id = null,
            string reference = null,
            int? productId = null,
            string productHandle = null,
            int? productPricePointId = null,
            string productPricePointHandle = null,
            string currency = null,
            string couponCode = null,
            long? totalRevenueInCents = null,
            long? balanceInCents = null)
        {
            this.Id = id;
            if (reference != null)
            {
                this.Reference = reference;
            }

            this.ProductId = productId;
            if (productHandle != null)
            {
                this.ProductHandle = productHandle;
            }

            this.ProductPricePointId = productPricePointId;
            this.ProductPricePointHandle = productPricePointHandle;
            this.Currency = currency;
            if (couponCode != null)
            {
                this.CouponCode = couponCode;
            }

            this.TotalRevenueInCents = totalRevenueInCents;
            this.BalanceInCents = balanceInCents;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Reference.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference
        {
            get
            {
                return this.reference;
            }

            set
            {
                this.shouldSerialize["reference"] = true;
                this.reference = value;
            }
        }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets ProductHandle.
        /// </summary>
        [JsonProperty("product_handle")]
        public string ProductHandle
        {
            get
            {
                return this.productHandle;
            }

            set
            {
                this.shouldSerialize["product_handle"] = true;
                this.productHandle = value;
            }
        }

        /// <summary>
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointHandle.
        /// </summary>
        [JsonProperty("product_price_point_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointHandle { get; set; }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets CouponCode.
        /// </summary>
        [JsonProperty("coupon_code")]
        public string CouponCode
        {
            get
            {
                return this.couponCode;
            }

            set
            {
                this.shouldSerialize["coupon_code"] = true;
                this.couponCode = value;
            }
        }

        /// <summary>
        /// Gets or sets TotalRevenueInCents.
        /// </summary>
        [JsonProperty("total_revenue_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalRevenueInCents { get; set; }

        /// <summary>
        /// Gets or sets BalanceInCents.
        /// </summary>
        [JsonProperty("balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? BalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReference()
        {
            this.shouldSerialize["reference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductHandle()
        {
            this.shouldSerialize["product_handle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCouponCode()
        {
            this.shouldSerialize["coupon_code"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReference()
        {
            return this.shouldSerialize["reference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductHandle()
        {
            return this.shouldSerialize["product_handle"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCouponCode()
        {
            return this.shouldSerialize["coupon_code"];
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
            return obj is SubscriptionGroupItem other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductHandle == null && other.ProductHandle == null) || (this.ProductHandle?.Equals(other.ProductHandle) == true)) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.ProductPricePointHandle == null && other.ProductPricePointHandle == null) || (this.ProductPricePointHandle?.Equals(other.ProductPricePointHandle) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.CouponCode == null && other.CouponCode == null) || (this.CouponCode?.Equals(other.CouponCode) == true)) &&
                ((this.TotalRevenueInCents == null && other.TotalRevenueInCents == null) || (this.TotalRevenueInCents?.Equals(other.TotalRevenueInCents) == true)) &&
                ((this.BalanceInCents == null && other.BalanceInCents == null) || (this.BalanceInCents?.Equals(other.BalanceInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductHandle = {(this.ProductHandle == null ? "null" : this.ProductHandle)}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointHandle = {(this.ProductPricePointHandle == null ? "null" : this.ProductPricePointHandle)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.CouponCode = {(this.CouponCode == null ? "null" : this.CouponCode)}");
            toStringOutput.Add($"this.TotalRevenueInCents = {(this.TotalRevenueInCents == null ? "null" : this.TotalRevenueInCents.ToString())}");
            toStringOutput.Add($"this.BalanceInCents = {(this.BalanceInCents == null ? "null" : this.BalanceInCents.ToString())}");
        }
    }
}