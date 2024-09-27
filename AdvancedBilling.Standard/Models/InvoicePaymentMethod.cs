// <copyright file="InvoicePaymentMethod.cs" company="APIMatic">
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
    /// InvoicePaymentMethod.
    /// </summary>
    public class InvoicePaymentMethod : BaseModel
    {
        private string lastFour;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "last_four", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePaymentMethod"/> class.
        /// </summary>
        public InvoicePaymentMethod()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePaymentMethod"/> class.
        /// </summary>
        /// <param name="details">details.</param>
        /// <param name="kind">kind.</param>
        /// <param name="memo">memo.</param>
        /// <param name="type">type.</param>
        /// <param name="cardBrand">card_brand.</param>
        /// <param name="cardExpiration">card_expiration.</param>
        /// <param name="lastFour">last_four.</param>
        /// <param name="maskedCardNumber">masked_card_number.</param>
        public InvoicePaymentMethod(
            string details = null,
            string kind = null,
            string memo = null,
            string type = null,
            string cardBrand = null,
            string cardExpiration = null,
            string lastFour = null,
            string maskedCardNumber = null)
        {
            this.Details = details;
            this.Kind = kind;
            this.Memo = memo;
            this.Type = type;
            this.CardBrand = cardBrand;
            this.CardExpiration = cardExpiration;
            if (lastFour != null)
            {
                this.LastFour = lastFour;
            }

            this.MaskedCardNumber = maskedCardNumber;
        }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets CardBrand.
        /// </summary>
        [JsonProperty("card_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string CardBrand { get; set; }

        /// <summary>
        /// Gets or sets CardExpiration.
        /// </summary>
        [JsonProperty("card_expiration", NullValueHandling = NullValueHandling.Ignore)]
        public string CardExpiration { get; set; }

        /// <summary>
        /// Gets or sets LastFour.
        /// </summary>
        [JsonProperty("last_four")]
        public string LastFour
        {
            get
            {
                return this.lastFour;
            }

            set
            {
                this.shouldSerialize["last_four"] = true;
                this.lastFour = value;
            }
        }

        /// <summary>
        /// Gets or sets MaskedCardNumber.
        /// </summary>
        [JsonProperty("masked_card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedCardNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoicePaymentMethod : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastFour()
        {
            this.shouldSerialize["last_four"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastFour()
        {
            return this.shouldSerialize["last_four"];
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
            return obj is InvoicePaymentMethod other &&                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.CardBrand == null && other.CardBrand == null) || (this.CardBrand?.Equals(other.CardBrand) == true)) &&
                ((this.CardExpiration == null && other.CardExpiration == null) || (this.CardExpiration?.Equals(other.CardExpiration) == true)) &&
                ((this.LastFour == null && other.LastFour == null) || (this.LastFour?.Equals(other.LastFour) == true)) &&
                ((this.MaskedCardNumber == null && other.MaskedCardNumber == null) || (this.MaskedCardNumber?.Equals(other.MaskedCardNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.CardBrand = {(this.CardBrand == null ? "null" : this.CardBrand)}");
            toStringOutput.Add($"this.CardExpiration = {(this.CardExpiration == null ? "null" : this.CardExpiration)}");
            toStringOutput.Add($"this.LastFour = {(this.LastFour == null ? "null" : this.LastFour)}");
            toStringOutput.Add($"this.MaskedCardNumber = {(this.MaskedCardNumber == null ? "null" : this.MaskedCardNumber)}");

            base.ToString(toStringOutput);
        }
    }
}