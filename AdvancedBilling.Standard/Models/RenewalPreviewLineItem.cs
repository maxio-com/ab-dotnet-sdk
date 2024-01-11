// <copyright file="RenewalPreviewLineItem.cs" company="APIMatic">
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
    /// RenewalPreviewLineItem.
    /// </summary>
    public class RenewalPreviewLineItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewLineItem"/> class.
        /// </summary>
        public RenewalPreviewLineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewLineItem"/> class.
        /// </summary>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="kind">kind.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="memo">memo.</param>
        /// <param name="discountAmountInCents">discount_amount_in_cents.</param>
        /// <param name="taxableAmountInCents">taxable_amount_in_cents.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productName">product_name.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="componentName">component_name.</param>
        /// <param name="productHandle">product_handle.</param>
        /// <param name="periodRangeStart">period_range_start.</param>
        /// <param name="periodRangeEnd">period_range_end.</param>
        public RenewalPreviewLineItem(
            Models.LineItemTransactionType? transactionType = null,
            Models.LineItemKind? kind = null,
            long? amountInCents = null,
            string memo = null,
            long? discountAmountInCents = null,
            long? taxableAmountInCents = null,
            int? productId = null,
            string productName = null,
            int? componentId = null,
            string componentHandle = null,
            string componentName = null,
            string productHandle = null,
            string periodRangeStart = null,
            string periodRangeEnd = null)
        {
            this.TransactionType = transactionType;
            this.Kind = kind;
            this.AmountInCents = amountInCents;
            this.Memo = memo;
            this.DiscountAmountInCents = discountAmountInCents;
            this.TaxableAmountInCents = taxableAmountInCents;
            this.ProductId = productId;
            this.ProductName = productName;
            this.ComponentId = componentId;
            this.ComponentHandle = componentHandle;
            this.ComponentName = componentName;
            this.ProductHandle = productHandle;
            this.PeriodRangeStart = periodRangeStart;
            this.PeriodRangeEnd = periodRangeEnd;
        }

        /// <summary>
        /// A handle for the line item transaction type
        /// </summary>
        [JsonProperty("transaction_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LineItemTransactionType? TransactionType { get; set; }

        /// <summary>
        /// A handle for the line item kind
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LineItemKind? Kind { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets DiscountAmountInCents.
        /// </summary>
        [JsonProperty("discount_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? DiscountAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets TaxableAmountInCents.
        /// </summary>
        [JsonProperty("taxable_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaxableAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or sets ProductName.
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets ComponentHandle.
        /// </summary>
        [JsonProperty("component_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentHandle { get; set; }

        /// <summary>
        /// Gets or sets ComponentName.
        /// </summary>
        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Gets or sets ProductHandle.
        /// </summary>
        [JsonProperty("product_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductHandle { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RenewalPreviewLineItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is RenewalPreviewLineItem other &&                ((this.TransactionType == null && other.TransactionType == null) || (this.TransactionType?.Equals(other.TransactionType) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.DiscountAmountInCents == null && other.DiscountAmountInCents == null) || (this.DiscountAmountInCents?.Equals(other.DiscountAmountInCents) == true)) &&
                ((this.TaxableAmountInCents == null && other.TaxableAmountInCents == null) || (this.TaxableAmountInCents?.Equals(other.TaxableAmountInCents) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true)) &&
                ((this.ComponentName == null && other.ComponentName == null) || (this.ComponentName?.Equals(other.ComponentName) == true)) &&
                ((this.ProductHandle == null && other.ProductHandle == null) || (this.ProductHandle?.Equals(other.ProductHandle) == true)) &&
                ((this.PeriodRangeStart == null && other.PeriodRangeStart == null) || (this.PeriodRangeStart?.Equals(other.PeriodRangeStart) == true)) &&
                ((this.PeriodRangeEnd == null && other.PeriodRangeEnd == null) || (this.PeriodRangeEnd?.Equals(other.PeriodRangeEnd) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType.ToString())}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind.ToString())}");
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.DiscountAmountInCents = {(this.DiscountAmountInCents == null ? "null" : this.DiscountAmountInCents.ToString())}");
            toStringOutput.Add($"this.TaxableAmountInCents = {(this.TaxableAmountInCents == null ? "null" : this.TaxableAmountInCents.ToString())}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
            toStringOutput.Add($"this.ComponentName = {(this.ComponentName == null ? "null" : this.ComponentName)}");
            toStringOutput.Add($"this.ProductHandle = {(this.ProductHandle == null ? "null" : this.ProductHandle)}");
            toStringOutput.Add($"this.PeriodRangeStart = {(this.PeriodRangeStart == null ? "null" : this.PeriodRangeStart)}");
            toStringOutput.Add($"this.PeriodRangeEnd = {(this.PeriodRangeEnd == null ? "null" : this.PeriodRangeEnd)}");
        }
    }
}