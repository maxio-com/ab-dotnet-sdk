// <copyright file="AllocationPreviewLineItem.cs" company="APIMatic">
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
    /// AllocationPreviewLineItem.
    /// </summary>
    public class AllocationPreviewLineItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewLineItem"/> class.
        /// </summary>
        public AllocationPreviewLineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationPreviewLineItem"/> class.
        /// </summary>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="kind">kind.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="memo">memo.</param>
        /// <param name="discountAmountInCents">discount_amount_in_cents.</param>
        /// <param name="taxableAmountInCents">taxable_amount_in_cents.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="direction">direction.</param>
        public AllocationPreviewLineItem(
            Models.LineItemTransactionType? transactionType = null,
            Models.AllocationPreviewLineItemKind? kind = null,
            long? amountInCents = null,
            string memo = null,
            long? discountAmountInCents = null,
            long? taxableAmountInCents = null,
            int? componentId = null,
            string componentHandle = null,
            Models.AllocationPreviewDirection? direction = null)
        {
            this.TransactionType = transactionType;
            this.Kind = kind;
            this.AmountInCents = amountInCents;
            this.Memo = memo;
            this.DiscountAmountInCents = discountAmountInCents;
            this.TaxableAmountInCents = taxableAmountInCents;
            this.ComponentId = componentId;
            this.ComponentHandle = componentHandle;
            this.Direction = direction;
        }

        /// <summary>
        /// A handle for the line item transaction type
        /// </summary>
        [JsonProperty("transaction_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LineItemTransactionType? TransactionType { get; set; }

        /// <summary>
        /// A handle for the line item kind for allocation preview
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AllocationPreviewLineItemKind? Kind { get; set; }

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
        /// Visible when using Fine-grained Component Control
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AllocationPreviewDirection? Direction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AllocationPreviewLineItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AllocationPreviewLineItem other &&
                (this.TransactionType == null && other.TransactionType == null ||
                 this.TransactionType?.Equals(other.TransactionType) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.DiscountAmountInCents == null && other.DiscountAmountInCents == null ||
                 this.DiscountAmountInCents?.Equals(other.DiscountAmountInCents) == true) &&
                (this.TaxableAmountInCents == null && other.TaxableAmountInCents == null ||
                 this.TaxableAmountInCents?.Equals(other.TaxableAmountInCents) == true) &&
                (this.ComponentId == null && other.ComponentId == null ||
                 this.ComponentId?.Equals(other.ComponentId) == true) &&
                (this.ComponentHandle == null && other.ComponentHandle == null ||
                 this.ComponentHandle?.Equals(other.ComponentHandle) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType.ToString())}");
            toStringOutput.Add($"Kind = {(this.Kind == null ? "null" : this.Kind.ToString())}");
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"DiscountAmountInCents = {(this.DiscountAmountInCents == null ? "null" : this.DiscountAmountInCents.ToString())}");
            toStringOutput.Add($"TaxableAmountInCents = {(this.TaxableAmountInCents == null ? "null" : this.TaxableAmountInCents.ToString())}");
            toStringOutput.Add($"ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"ComponentHandle = {this.ComponentHandle ?? "null"}");
            toStringOutput.Add($"Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}