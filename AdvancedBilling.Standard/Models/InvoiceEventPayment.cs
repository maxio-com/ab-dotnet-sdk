// <copyright file="InvoiceEventPayment.cs" company="APIMatic">
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
    /// InvoiceEventPayment.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    public class InvoiceEventPayment
    {
        private string lastFour;
        private string details;
        private string memo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "last_four", false },
            { "details", false },
            { "memo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEventPayment"/> class.
        /// </summary>
        public InvoiceEventPayment()
        {
            this.Type = "Invoice Event Payment";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEventPayment"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="maskedAccountNumber">masked_account_number.</param>
        /// <param name="maskedRoutingNumber">masked_routing_number.</param>
        /// <param name="cardBrand">card_brand.</param>
        /// <param name="cardExpiration">card_expiration.</param>
        /// <param name="lastFour">last_four.</param>
        /// <param name="maskedCardNumber">masked_card_number.</param>
        /// <param name="details">details.</param>
        /// <param name="kind">kind.</param>
        /// <param name="memo">memo.</param>
        /// <param name="email">email.</param>
        public InvoiceEventPayment(
            string type = "Invoice Event Payment",
            string maskedAccountNumber = null,
            string maskedRoutingNumber = null,
            string cardBrand = null,
            string cardExpiration = null,
            string lastFour = null,
            string maskedCardNumber = null,
            string details = null,
            string kind = null,
            string memo = null,
            string email = null)
        {
            this.Type = type;
            this.MaskedAccountNumber = maskedAccountNumber;
            this.MaskedRoutingNumber = maskedRoutingNumber;
            this.CardBrand = cardBrand;
            this.CardExpiration = cardExpiration;
            if (lastFour != null)
            {
                this.LastFour = lastFour;
            }

            this.MaskedCardNumber = maskedCardNumber;
            if (details != null)
            {
                this.Details = details;
            }

            this.Kind = kind;
            if (memo != null)
            {
                this.Memo = memo;
            }

            this.Email = email;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets MaskedAccountNumber.
        /// </summary>
        [JsonProperty("masked_account_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedAccountNumber { get; set; }

        /// <summary>
        /// Gets or sets MaskedRoutingNumber.
        /// </summary>
        [JsonProperty("masked_routing_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedRoutingNumber { get; set; }

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

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details")]
        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                this.shouldSerialize["details"] = true;
                this.details = value;
            }
        }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo
        {
            get
            {
                return this.memo;
            }

            set
            {
                this.shouldSerialize["memo"] = true;
                this.memo = value;
            }
        }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceEventPayment : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastFour()
        {
            this.shouldSerialize["last_four"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDetails()
        {
            this.shouldSerialize["details"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastFour()
        {
            return this.shouldSerialize["last_four"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDetails()
        {
            return this.shouldSerialize["details"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
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
            return obj is InvoiceEventPayment other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.MaskedAccountNumber == null && other.MaskedAccountNumber == null) || (this.MaskedAccountNumber?.Equals(other.MaskedAccountNumber) == true)) &&
                ((this.MaskedRoutingNumber == null && other.MaskedRoutingNumber == null) || (this.MaskedRoutingNumber?.Equals(other.MaskedRoutingNumber) == true)) &&
                ((this.CardBrand == null && other.CardBrand == null) || (this.CardBrand?.Equals(other.CardBrand) == true)) &&
                ((this.CardExpiration == null && other.CardExpiration == null) || (this.CardExpiration?.Equals(other.CardExpiration) == true)) &&
                ((this.LastFour == null && other.LastFour == null) || (this.LastFour?.Equals(other.LastFour) == true)) &&
                ((this.MaskedCardNumber == null && other.MaskedCardNumber == null) || (this.MaskedCardNumber?.Equals(other.MaskedCardNumber) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.MaskedAccountNumber = {(this.MaskedAccountNumber == null ? "null" : this.MaskedAccountNumber)}");
            toStringOutput.Add($"this.MaskedRoutingNumber = {(this.MaskedRoutingNumber == null ? "null" : this.MaskedRoutingNumber)}");
            toStringOutput.Add($"this.CardBrand = {(this.CardBrand == null ? "null" : this.CardBrand)}");
            toStringOutput.Add($"this.CardExpiration = {(this.CardExpiration == null ? "null" : this.CardExpiration)}");
            toStringOutput.Add($"this.LastFour = {(this.LastFour == null ? "null" : this.LastFour)}");
            toStringOutput.Add($"this.MaskedCardNumber = {(this.MaskedCardNumber == null ? "null" : this.MaskedCardNumber)}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
        }
    }
}