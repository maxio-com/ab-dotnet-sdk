// <copyright file="CreditNoteLineItem.cs" company="APIMatic">
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
    /// CreditNoteLineItem.
    /// </summary>
    public class CreditNoteLineItem : BaseModel
    {
        private int? componentId;
        private int? pricePointId;
        private int? billingScheduleItemId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "component_id", false },
            { "price_point_id", false },
            { "billing_schedule_item_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteLineItem"/> class.
        /// </summary>
        public CreditNoteLineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteLineItem"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="subtotalAmount">subtotal_amount.</param>
        /// <param name="discountAmount">discount_amount.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="totalAmount">total_amount.</param>
        /// <param name="tieredUnitPrice">tiered_unit_price.</param>
        /// <param name="periodRangeStart">period_range_start.</param>
        /// <param name="periodRangeEnd">period_range_end.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productVersion">product_version.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="billingScheduleItemId">billing_schedule_item_id.</param>
        /// <param name="customItem">custom_item.</param>
        public CreditNoteLineItem(
            string uid = null,
            string title = null,
            string description = null,
            string quantity = null,
            string unitPrice = null,
            string subtotalAmount = null,
            string discountAmount = null,
            string taxAmount = null,
            string totalAmount = null,
            bool? tieredUnitPrice = null,
            DateTime? periodRangeStart = null,
            DateTime? periodRangeEnd = null,
            int? productId = null,
            int? productVersion = null,
            int? componentId = null,
            int? pricePointId = null,
            int? billingScheduleItemId = null,
            bool? customItem = null)
        {
            this.Uid = uid;
            this.Title = title;
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.SubtotalAmount = subtotalAmount;
            this.DiscountAmount = discountAmount;
            this.TaxAmount = taxAmount;
            this.TotalAmount = totalAmount;
            this.TieredUnitPrice = tieredUnitPrice;
            this.PeriodRangeStart = periodRangeStart;
            this.PeriodRangeEnd = periodRangeEnd;
            this.ProductId = productId;
            this.ProductVersion = productVersion;

            if (componentId != null)
            {
                this.ComponentId = componentId;
            }

            if (pricePointId != null)
            {
                this.PricePointId = pricePointId;
            }

            if (billingScheduleItemId != null)
            {
                this.BillingScheduleItemId = billingScheduleItemId;
            }
            this.CustomItem = customItem;
        }

        /// <summary>
        /// Unique identifier for the line item.  Useful when cross-referencing the line against individual discounts in the `discounts` or `taxes` lists.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// A short descriptor for the credit given by this line.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Detailed description for the credit given by this line.  May include proration details in plain text.
        /// Note: this string may contain line breaks that are hints for the best display format on the credit note.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The quantity or count of units credited by the line item.
        /// This is a decimal number represented as a string. (See "About Decimal Numbers".)
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        /// <summary>
        /// The price per unit for the line item.
        /// When tiered pricing was used (i.e. not every unit was actually priced at the same price) this will be the blended average cost per unit and the `tiered_unit_price` field will be set to `true`.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// The line subtotal, generally calculated as `quantity * unit_price`. This is the canonical amount of record for the line - when rounding differences are in play, `subtotal_amount` takes precedence over the value derived from `quantity * unit_price` (which may not have the proper precision to exactly equal this amount).
        /// </summary>
        [JsonProperty("subtotal_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalAmount { get; set; }

        /// <summary>
        /// The approximate discount of just this line.
        /// The value is approximated in cases where rounding errors make it difficult to apportion exactly a total discount among many lines. Several lines may have been summed prior to applying the discount to arrive at `discount_amount` for the invoice - backing that out to the discount on a single line may introduce rounding or precision errors.
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// The approximate tax of just this line.
        /// The value is approximated in cases where rounding errors make it difficult to apportion exactly a total tax among many lines. Several lines may have been summed prior to applying the tax rate to arrive at `tax_amount` for the invoice - backing that out to the tax on a single line may introduce rounding or precision errors.
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// The non-canonical total amount for the line.
        /// `subtotal_amount` is the canonical amount for a line. The invoice `total_amount` is derived from the sum of the line `subtotal_amount`s and discounts or taxes applied thereafter.  Therefore, due to rounding or precision errors, the sum of line `total_amount`s may not equal the invoice `total_amount`.
        /// </summary>
        [JsonProperty("total_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// When `true`, indicates that the actual pricing scheme for the line was tiered, so the `unit_price` shown is the blended average for all units.
        /// </summary>
        [JsonProperty("tiered_unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TieredUnitPrice { get; set; }

        /// <summary>
        /// Start date for the period credited by this line. The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("period_range_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PeriodRangeStart { get; set; }

        /// <summary>
        /// End date for the period credited by this line. The format is `"YYYY-MM-DD"`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("period_range_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PeriodRangeEnd { get; set; }

        /// <summary>
        /// The ID of the product being credited.
        /// This may be set even for component credits, so true product-only (non-component) credits will also have a nil `component_id`.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// The version of the product being credited.
        /// </summary>
        [JsonProperty("product_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductVersion { get; set; }

        /// <summary>
        /// The ID of the component being credited. Will be `nil` for non-component credits.
        /// </summary>
        [JsonProperty("component_id")]
        public int? ComponentId
        {
            get
            {
                return this.componentId;
            }

            set
            {
                this.shouldSerialize["component_id"] = true;
                this.componentId = value;
            }
        }

        /// <summary>
        /// The price point ID of the component being credited. Will be `nil` for non-component credits.
        /// </summary>
        [JsonProperty("price_point_id")]
        public int? PricePointId
        {
            get
            {
                return this.pricePointId;
            }

            set
            {
                this.shouldSerialize["price_point_id"] = true;
                this.pricePointId = value;
            }
        }

        /// <summary>
        /// Gets or sets BillingScheduleItemId.
        /// </summary>
        [JsonProperty("billing_schedule_item_id")]
        public int? BillingScheduleItemId
        {
            get
            {
                return this.billingScheduleItemId;
            }

            set
            {
                this.shouldSerialize["billing_schedule_item_id"] = true;
                this.billingScheduleItemId = value;
            }
        }

        /// <summary>
        /// Gets or sets CustomItem.
        /// </summary>
        [JsonProperty("custom_item", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomItem { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreditNoteLineItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetComponentId()
        {
            this.shouldSerialize["component_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPricePointId()
        {
            this.shouldSerialize["price_point_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetBillingScheduleItemId()
        {
            this.shouldSerialize["billing_schedule_item_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeComponentId()
        {
            return this.shouldSerialize["component_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointId()
        {
            return this.shouldSerialize["price_point_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingScheduleItemId()
        {
            return this.shouldSerialize["billing_schedule_item_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreditNoteLineItem other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.Title == null && other.Title == null ||
                 this.Title?.Equals(other.Title) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.UnitPrice == null && other.UnitPrice == null ||
                 this.UnitPrice?.Equals(other.UnitPrice) == true) &&
                (this.SubtotalAmount == null && other.SubtotalAmount == null ||
                 this.SubtotalAmount?.Equals(other.SubtotalAmount) == true) &&
                (this.DiscountAmount == null && other.DiscountAmount == null ||
                 this.DiscountAmount?.Equals(other.DiscountAmount) == true) &&
                (this.TaxAmount == null && other.TaxAmount == null ||
                 this.TaxAmount?.Equals(other.TaxAmount) == true) &&
                (this.TotalAmount == null && other.TotalAmount == null ||
                 this.TotalAmount?.Equals(other.TotalAmount) == true) &&
                (this.TieredUnitPrice == null && other.TieredUnitPrice == null ||
                 this.TieredUnitPrice?.Equals(other.TieredUnitPrice) == true) &&
                (this.PeriodRangeStart == null && other.PeriodRangeStart == null ||
                 this.PeriodRangeStart?.Equals(other.PeriodRangeStart) == true) &&
                (this.PeriodRangeEnd == null && other.PeriodRangeEnd == null ||
                 this.PeriodRangeEnd?.Equals(other.PeriodRangeEnd) == true) &&
                (this.ProductId == null && other.ProductId == null ||
                 this.ProductId?.Equals(other.ProductId) == true) &&
                (this.ProductVersion == null && other.ProductVersion == null ||
                 this.ProductVersion?.Equals(other.ProductVersion) == true) &&
                (this.ComponentId == null && other.ComponentId == null ||
                 this.ComponentId?.Equals(other.ComponentId) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.BillingScheduleItemId == null && other.BillingScheduleItemId == null ||
                 this.BillingScheduleItemId?.Equals(other.BillingScheduleItemId) == true) &&
                (this.CustomItem == null && other.CustomItem == null ||
                 this.CustomItem?.Equals(other.CustomItem) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"Title = {this.Title ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Quantity = {this.Quantity ?? "null"}");
            toStringOutput.Add($"UnitPrice = {this.UnitPrice ?? "null"}");
            toStringOutput.Add($"SubtotalAmount = {this.SubtotalAmount ?? "null"}");
            toStringOutput.Add($"DiscountAmount = {this.DiscountAmount ?? "null"}");
            toStringOutput.Add($"TaxAmount = {this.TaxAmount ?? "null"}");
            toStringOutput.Add($"TotalAmount = {this.TotalAmount ?? "null"}");
            toStringOutput.Add($"TieredUnitPrice = {(this.TieredUnitPrice == null ? "null" : this.TieredUnitPrice.ToString())}");
            toStringOutput.Add($"PeriodRangeStart = {(this.PeriodRangeStart == null ? "null" : this.PeriodRangeStart.ToString())}");
            toStringOutput.Add($"PeriodRangeEnd = {(this.PeriodRangeEnd == null ? "null" : this.PeriodRangeEnd.ToString())}");
            toStringOutput.Add($"ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"ProductVersion = {(this.ProductVersion == null ? "null" : this.ProductVersion.ToString())}");
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"BillingScheduleItemId = {(this.BillingScheduleItemId == null ? "null" : this.BillingScheduleItemId.ToString())}");
            toStringOutput.Add($"CustomItem = {(this.CustomItem == null ? "null" : this.CustomItem.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}