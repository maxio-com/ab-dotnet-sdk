// <copyright file="PaymentProfileParams.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// PaymentProfileParams.
    /// </summary>
    public class PaymentProfileParams : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProfileParams"/> class.
        /// </summary>
        public PaymentProfileParams()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProfileParams"/> class.
        /// </summary>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="cardType">card_type.</param>
        public PaymentProfileParams(
            string firstName = null,
            string lastName = null,
            string cardType = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CardType = cardType;
        }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets CardType.
        /// </summary>
        [JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentProfileParams : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentProfileParams other &&
                (this.FirstName == null && other.FirstName == null ||
                 this.FirstName?.Equals(other.FirstName) == true) &&
                (this.LastName == null && other.LastName == null ||
                 this.LastName?.Equals(other.LastName) == true) &&
                (this.CardType == null && other.CardType == null ||
                 this.CardType?.Equals(other.CardType) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FirstName = {this.FirstName ?? "null"}");
            toStringOutput.Add($"LastName = {this.LastName ?? "null"}");
            toStringOutput.Add($"CardType = {this.CardType ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}