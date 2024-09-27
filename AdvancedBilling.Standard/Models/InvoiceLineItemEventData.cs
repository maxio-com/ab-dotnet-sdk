// <copyright file="InvoiceLineItemEventData.cs" company="APIMatic">
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
    /// InvoiceLineItemEventData.
    /// </summary>
    public class InvoiceLineItemEventData : BaseModel
    {
        private int? quantityDelta;
        private int? pricingDetailsIndex;
        private string taxCode;
        private int? productPricePointId;
        private int? pricePointId;
        private int? componentId;
        private int? billingScheduleItemId;
        private bool? customItem;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "quantity_delta", false },
            { "pricing_details_index", false },
            { "tax_code", false },
            { "product_price_point_id", false },
            { "price_point_id", false },
            { "component_id", false },
            { "billing_schedule_item_id", false },
            { "custom_item", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItemEventData"/> class.
        /// </summary>
        public InvoiceLineItemEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItemEventData"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="quantityDelta">quantity_delta.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="periodRangeStart">period_range_start.</param>
        /// <param name="periodRangeEnd">period_range_end.</param>
        /// <param name="amount">amount.</param>
        /// <param name="lineReferences">line_references.</param>
        /// <param name="pricingDetailsIndex">pricing_details_index.</param>
        /// <param name="pricingDetails">pricing_details.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="taxAmount">tax_amount.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="billingScheduleItemId">billing_schedule_item_id.</param>
        /// <param name="customItem">custom_item.</param>
        public InvoiceLineItemEventData(
            string uid = null,
            string title = null,
            string description = null,
            int? quantity = null,
            int? quantityDelta = null,
            string unitPrice = null,
            string periodRangeStart = null,
            string periodRangeEnd = null,
            string amount = null,
            string lineReferences = null,
            int? pricingDetailsIndex = null,
            List<Models.InvoiceLineItemPricingDetail> pricingDetails = null,
            string taxCode = null,
            string taxAmount = null,
            int? productId = null,
            int? productPricePointId = null,
            int? pricePointId = null,
            int? componentId = null,
            int? billingScheduleItemId = null,
            bool? customItem = null)
        {
            this.Uid = uid;
            this.Title = title;
            this.Description = description;
            this.Quantity = quantity;
            if (quantityDelta != null)
            {
                this.QuantityDelta = quantityDelta;
            }

            this.UnitPrice = unitPrice;
            this.PeriodRangeStart = periodRangeStart;
            this.PeriodRangeEnd = periodRangeEnd;
            this.Amount = amount;
            this.LineReferences = lineReferences;
            if (pricingDetailsIndex != null)
            {
                this.PricingDetailsIndex = pricingDetailsIndex;
            }

            this.PricingDetails = pricingDetails;
            if (taxCode != null)
            {
                this.TaxCode = taxCode;
            }

            this.TaxAmount = taxAmount;
            this.ProductId = productId;
            if (productPricePointId != null)
            {
                this.ProductPricePointId = productPricePointId;
            }

            if (pricePointId != null)
            {
                this.PricePointId = pricePointId;
            }

            if (componentId != null)
            {
                this.ComponentId = componentId;
            }

            if (billingScheduleItemId != null)
            {
                this.BillingScheduleItemId = billingScheduleItemId;
            }

            if (customItem != null)
            {
                this.CustomItem = customItem;
            }

        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets QuantityDelta.
        /// </summary>
        [JsonProperty("quantity_delta")]
        public int? QuantityDelta
        {
            get
            {
                return this.quantityDelta;
            }

            set
            {
                this.shouldSerialize["quantity_delta"] = true;
                this.quantityDelta = value;
            }
        }

        /// <summary>
        /// Gets or sets UnitPrice.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets PeriodRangeStart.
        /// </summary>
        [JsonProperty("period_range_start", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodRangeStart { get; set; }

        /// <summary>
        /// Gets or sets PeriodRangeEnd.
        /// </summary>
        [JsonProperty("period_range_end", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodRangeEnd { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets LineReferences.
        /// </summary>
        [JsonProperty("line_references", NullValueHandling = NullValueHandling.Ignore)]
        public string LineReferences { get; set; }

        /// <summary>
        /// Gets or sets PricingDetailsIndex.
        /// </summary>
        [JsonProperty("pricing_details_index")]
        public int? PricingDetailsIndex
        {
            get
            {
                return this.pricingDetailsIndex;
            }

            set
            {
                this.shouldSerialize["pricing_details_index"] = true;
                this.pricingDetailsIndex = value;
            }
        }

        /// <summary>
        /// Gets or sets PricingDetails.
        /// </summary>
        [JsonProperty("pricing_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceLineItemPricingDetail> PricingDetails { get; set; }

        /// <summary>
        /// Gets or sets TaxCode.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode
        {
            get
            {
                return this.taxCode;
            }

            set
            {
                this.shouldSerialize["tax_code"] = true;
                this.taxCode = value;
            }
        }

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonProperty("tax_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id")]
        public int? ProductPricePointId
        {
            get
            {
                return this.productPricePointId;
            }

            set
            {
                this.shouldSerialize["product_price_point_id"] = true;
                this.productPricePointId = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePointId.
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
        /// Gets or sets ComponentId.
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
        [JsonProperty("custom_item")]
        public bool? CustomItem
        {
            get
            {
                return this.customItem;
            }

            set
            {
                this.shouldSerialize["custom_item"] = true;
                this.customItem = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceLineItemEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetQuantityDelta()
        {
            this.shouldSerialize["quantity_delta"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricingDetailsIndex()
        {
            this.shouldSerialize["pricing_details_index"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTaxCode()
        {
            this.shouldSerialize["tax_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductPricePointId()
        {
            this.shouldSerialize["product_price_point_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePointId()
        {
            this.shouldSerialize["price_point_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetComponentId()
        {
            this.shouldSerialize["component_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingScheduleItemId()
        {
            this.shouldSerialize["billing_schedule_item_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomItem()
        {
            this.shouldSerialize["custom_item"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeQuantityDelta()
        {
            return this.shouldSerialize["quantity_delta"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingDetailsIndex()
        {
            return this.shouldSerialize["pricing_details_index"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTaxCode()
        {
            return this.shouldSerialize["tax_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductPricePointId()
        {
            return this.shouldSerialize["product_price_point_id"];
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
        public bool ShouldSerializeComponentId()
        {
            return this.shouldSerialize["component_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingScheduleItemId()
        {
            return this.shouldSerialize["billing_schedule_item_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomItem()
        {
            return this.shouldSerialize["custom_item"];
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
            return obj is InvoiceLineItemEventData other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.QuantityDelta == null && other.QuantityDelta == null) || (this.QuantityDelta?.Equals(other.QuantityDelta) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.PeriodRangeStart == null && other.PeriodRangeStart == null) || (this.PeriodRangeStart?.Equals(other.PeriodRangeStart) == true)) &&
                ((this.PeriodRangeEnd == null && other.PeriodRangeEnd == null) || (this.PeriodRangeEnd?.Equals(other.PeriodRangeEnd) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.LineReferences == null && other.LineReferences == null) || (this.LineReferences?.Equals(other.LineReferences) == true)) &&
                ((this.PricingDetailsIndex == null && other.PricingDetailsIndex == null) || (this.PricingDetailsIndex?.Equals(other.PricingDetailsIndex) == true)) &&
                ((this.PricingDetails == null && other.PricingDetails == null) || (this.PricingDetails?.Equals(other.PricingDetails) == true)) &&
                ((this.TaxCode == null && other.TaxCode == null) || (this.TaxCode?.Equals(other.TaxCode) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.BillingScheduleItemId == null && other.BillingScheduleItemId == null) || (this.BillingScheduleItemId?.Equals(other.BillingScheduleItemId) == true)) &&
                ((this.CustomItem == null && other.CustomItem == null) || (this.CustomItem?.Equals(other.CustomItem) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.QuantityDelta = {(this.QuantityDelta == null ? "null" : this.QuantityDelta.ToString())}");
            toStringOutput.Add($"this.UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice)}");
            toStringOutput.Add($"this.PeriodRangeStart = {(this.PeriodRangeStart == null ? "null" : this.PeriodRangeStart)}");
            toStringOutput.Add($"this.PeriodRangeEnd = {(this.PeriodRangeEnd == null ? "null" : this.PeriodRangeEnd)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount)}");
            toStringOutput.Add($"this.LineReferences = {(this.LineReferences == null ? "null" : this.LineReferences)}");
            toStringOutput.Add($"this.PricingDetailsIndex = {(this.PricingDetailsIndex == null ? "null" : this.PricingDetailsIndex.ToString())}");
            toStringOutput.Add($"this.PricingDetails = {(this.PricingDetails == null ? "null" : $"[{string.Join(", ", this.PricingDetails)} ]")}");
            toStringOutput.Add($"this.TaxCode = {(this.TaxCode == null ? "null" : this.TaxCode)}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.BillingScheduleItemId = {(this.BillingScheduleItemId == null ? "null" : this.BillingScheduleItemId.ToString())}");
            toStringOutput.Add($"this.CustomItem = {(this.CustomItem == null ? "null" : this.CustomItem.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}