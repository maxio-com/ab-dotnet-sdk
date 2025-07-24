// <copyright file="CreateInvoiceItem.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateInvoiceItem.
    /// </summary>
    public class CreateInvoiceItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceItem"/> class.
        /// </summary>
        public CreateInvoiceItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInvoiceItem"/> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="periodRangeStart">period_range_start.</param>
        /// <param name="periodRangeEnd">period_range_end.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="description">description.</param>
        public CreateInvoiceItem(
            string title = null,
            CreateInvoiceItemQuantity quantity = null,
            CreateInvoiceItemUnitPrice unitPrice = null,
            bool? taxable = null,
            string taxCode = null,
            string periodRangeStart = null,
            string periodRangeEnd = null,
            CreateInvoiceItemProductId productId = null,
            CreateInvoiceItemComponentId componentId = null,
            CreateInvoiceItemPricePointId pricePointId = null,
            CreateInvoiceItemProductPricePointId productPricePointId = null,
            string description = null)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.Taxable = taxable;
            this.TaxCode = taxCode;
            this.PeriodRangeStart = periodRangeStart;
            this.PeriodRangeEnd = periodRangeEnd;
            this.ProductId = productId;
            this.ComponentId = componentId;
            this.PricePointId = pricePointId;
            this.ProductPricePointId = productPricePointId;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The quantity can contain up to 8 decimal places. i.e. 1.00 or 0.0012 or 0.00000065. If you submit a value with more than 8 decimal places, we will round it down to the 8th decimal place.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceItemQuantity Quantity { get; set; }

        /// <summary>
        /// The unit_price can contain up to 8 decimal places. i.e. 1.00 or 0.0012 or 0.00000065. If you submit a value with more than 8 decimal places, we will round it down to the 8th decimal place.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceItemUnitPrice UnitPrice { get; set; }

        /// <summary>
        /// Set to true to automatically calculate taxes. Site must be configured to use and calculate taxes.
        /// If using Avalara, a tax_code parameter must also be sent.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Gets or sets TaxCode.
        /// </summary>
        [JsonProperty("tax_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxCode { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// </summary>
        [JsonProperty("period_range_start", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodRangeStart { get; set; }

        /// <summary>
        /// YYYY-MM-DD
        /// </summary>
        [JsonProperty("period_range_end", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodRangeEnd { get; set; }

        /// <summary>
        /// Product handle or product id.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceItemProductId ProductId { get; set; }

        /// <summary>
        /// Component handle or component id.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceItemComponentId ComponentId { get; set; }

        /// <summary>
        /// Price point handle or id. For component.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceItemPricePointId PricePointId { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInvoiceItemProductPricePointId ProductPricePointId { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateInvoiceItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateInvoiceItem other &&
                (this.Title == null && other.Title == null ||
                 this.Title?.Equals(other.Title) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.UnitPrice == null && other.UnitPrice == null ||
                 this.UnitPrice?.Equals(other.UnitPrice) == true) &&
                (this.Taxable == null && other.Taxable == null ||
                 this.Taxable?.Equals(other.Taxable) == true) &&
                (this.TaxCode == null && other.TaxCode == null ||
                 this.TaxCode?.Equals(other.TaxCode) == true) &&
                (this.PeriodRangeStart == null && other.PeriodRangeStart == null ||
                 this.PeriodRangeStart?.Equals(other.PeriodRangeStart) == true) &&
                (this.PeriodRangeEnd == null && other.PeriodRangeEnd == null ||
                 this.PeriodRangeEnd?.Equals(other.PeriodRangeEnd) == true) &&
                (this.ProductId == null && other.ProductId == null ||
                 this.ProductId?.Equals(other.ProductId) == true) &&
                (this.ComponentId == null && other.ComponentId == null ||
                 this.ComponentId?.Equals(other.ComponentId) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Title = {this.Title ?? "null"}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"TaxCode = {this.TaxCode ?? "null"}");
            toStringOutput.Add($"PeriodRangeStart = {this.PeriodRangeStart ?? "null"}");
            toStringOutput.Add($"PeriodRangeEnd = {this.PeriodRangeEnd ?? "null"}");
            toStringOutput.Add($"ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}