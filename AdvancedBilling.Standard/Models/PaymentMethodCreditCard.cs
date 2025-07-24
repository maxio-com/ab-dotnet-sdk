// <copyright file="PaymentMethodCreditCard.cs" company="APIMatic">
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
    /// PaymentMethodCreditCard.
    /// </summary>
    public class PaymentMethodCreditCard : BaseModel
    {
        private string lastFour;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "last_four", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCreditCard"/> class.
        /// </summary>
        public PaymentMethodCreditCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCreditCard"/> class.
        /// </summary>
        /// <param name="cardBrand">card_brand.</param>
        /// <param name="maskedCardNumber">masked_card_number.</param>
        /// <param name="type">type.</param>
        /// <param name="cardExpiration">card_expiration.</param>
        /// <param name="lastFour">last_four.</param>
        public PaymentMethodCreditCard(
            string cardBrand,
            string maskedCardNumber,
            Models.InvoiceEventPaymentMethod type,
            string cardExpiration = null,
            string lastFour = null)
        {
            this.CardBrand = cardBrand;
            this.CardExpiration = cardExpiration;

            if (lastFour != null)
            {
                this.LastFour = lastFour;
            }
            this.MaskedCardNumber = maskedCardNumber;
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets CardBrand.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("card_brand")]
        [JsonRequired]
        public string CardBrand { get; set; }

        /// <summary>
        /// Gets or sets CardExpiration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("card_expiration", NullValueHandling = NullValueHandling.Ignore)]
        public string CardExpiration { get; set; }

        /// <summary>
        /// Gets or sets LastFour.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("masked_card_number")]
        [JsonRequired]
        public string MaskedCardNumber { get; set; }

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
            return $"PaymentMethodCreditCard : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentMethodCreditCard other &&
                (this.CardBrand == null && other.CardBrand == null ||
                 this.CardBrand?.Equals(other.CardBrand) == true) &&
                (this.CardExpiration == null && other.CardExpiration == null ||
                 this.CardExpiration?.Equals(other.CardExpiration) == true) &&
                (this.LastFour == null && other.LastFour == null ||
                 this.LastFour?.Equals(other.LastFour) == true) &&
                (this.MaskedCardNumber == null && other.MaskedCardNumber == null ||
                 this.MaskedCardNumber?.Equals(other.MaskedCardNumber) == true) &&
                (this.Type.Equals(other.Type)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CardBrand = {this.CardBrand ?? "null"}");
            toStringOutput.Add($"CardExpiration = {this.CardExpiration ?? "null"}");
            toStringOutput.Add($"LastFour = {this.LastFour ?? "null"}");
            toStringOutput.Add($"MaskedCardNumber = {this.MaskedCardNumber ?? "null"}");
            toStringOutput.Add($"Type = {this.Type}");

            base.ToString(toStringOutput);
        }
    }
}