// <copyright file="PaymentMethodExternal.cs" company="APIMatic">
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
    /// PaymentMethodExternal.
    /// </summary>
    public class PaymentMethodExternal : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodExternal"/> class.
        /// </summary>
        public PaymentMethodExternal()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodExternal"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="type">type.</param>
        /// <param name="details">details.</param>
        /// <param name="memo">memo.</param>
        public PaymentMethodExternal(
            string kind,
            Models.InvoiceEventPaymentMethod type,
            string details = null,
            string memo = null)
        {
            this.Details = details;
            this.Kind = kind;
            this.Memo = memo;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("details", NullValueHandling = NullValueHandling.Include)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("kind")]
        [JsonRequired]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Include)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public Models.InvoiceEventPaymentMethod Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentMethodExternal : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentMethodExternal other &&
                (this.Details == null && other.Details == null ||
                 this.Details?.Equals(other.Details) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.Type.Equals(other.Type)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Details = {this.Details ?? "null"}");
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"Type = {this.Type}");

            base.ToString(toStringOutput);
        }
    }
}