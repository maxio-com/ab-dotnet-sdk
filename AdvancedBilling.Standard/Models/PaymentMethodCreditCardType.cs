// <copyright file="PaymentMethodCreditCardType.cs" company="APIMatic">
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
    /// PaymentMethodCreditCardType.
    /// </summary>
    public class PaymentMethodCreditCardType
    {
        private string lastFour;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "last_four", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCreditCardType"/> class.
        /// </summary>
        public PaymentMethodCreditCardType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCreditCardType"/> class.
        /// </summary>
        /// <param name="cardBrand">card_brand.</param>
        /// <param name="cardExpiration">card_expiration.</param>
        /// <param name="lastFour">last_four.</param>
        /// <param name="maskedCardNumber">masked_card_number.</param>
        /// <param name="type">type.</param>
        public PaymentMethodCreditCardType(
            string cardBrand = null,
            string cardExpiration = null,
            string lastFour = null,
            string maskedCardNumber = null,
            string type = "credit_card")
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
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("card_brand", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("masked_card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedCardNumber { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentMethodCreditCardType : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentMethodCreditCardType other &&                ((this.CardBrand == null && other.CardBrand == null) || (this.CardBrand?.Equals(other.CardBrand) == true)) &&
                ((this.CardExpiration == null && other.CardExpiration == null) || (this.CardExpiration?.Equals(other.CardExpiration) == true)) &&
                ((this.LastFour == null && other.LastFour == null) || (this.LastFour?.Equals(other.LastFour) == true)) &&
                ((this.MaskedCardNumber == null && other.MaskedCardNumber == null) || (this.MaskedCardNumber?.Equals(other.MaskedCardNumber) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardBrand = {(this.CardBrand == null ? "null" : this.CardBrand)}");
            toStringOutput.Add($"this.CardExpiration = {(this.CardExpiration == null ? "null" : this.CardExpiration)}");
            toStringOutput.Add($"this.LastFour = {(this.LastFour == null ? "null" : this.LastFour)}");
            toStringOutput.Add($"this.MaskedCardNumber = {(this.MaskedCardNumber == null ? "null" : this.MaskedCardNumber)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}