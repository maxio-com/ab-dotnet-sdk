// <copyright file="SubscriptionGroupPaymentProfile.cs" company="APIMatic">
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
    /// SubscriptionGroupPaymentProfile.
    /// </summary>
    public class SubscriptionGroupPaymentProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupPaymentProfile"/> class.
        /// </summary>
        public SubscriptionGroupPaymentProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupPaymentProfile"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="maskedCardNumber">masked_card_number.</param>
        public SubscriptionGroupPaymentProfile(
            int? id = null,
            string firstName = null,
            string lastName = null,
            string maskedCardNumber = null)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MaskedCardNumber = maskedCardNumber;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

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
        /// Gets or sets MaskedCardNumber.
        /// </summary>
        [JsonProperty("masked_card_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MaskedCardNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupPaymentProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupPaymentProfile other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.MaskedCardNumber == null && other.MaskedCardNumber == null) || (this.MaskedCardNumber?.Equals(other.MaskedCardNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.MaskedCardNumber = {(this.MaskedCardNumber == null ? "null" : this.MaskedCardNumber)}");
        }
    }
}