// <copyright file="CreditCardAttributes.cs" company="APIMatic">
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
    /// CreditCardAttributes.
    /// </summary>
    public class CreditCardAttributes : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardAttributes"/> class.
        /// </summary>
        public CreditCardAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardAttributes"/> class.
        /// </summary>
        /// <param name="fullNumber">full_number.</param>
        /// <param name="expirationMonth">expiration_month.</param>
        /// <param name="expirationYear">expiration_year.</param>
        public CreditCardAttributes(
            string fullNumber = null,
            string expirationMonth = null,
            string expirationYear = null)
        {
            this.FullNumber = fullNumber;
            this.ExpirationMonth = expirationMonth;
            this.ExpirationYear = expirationYear;
        }

        /// <summary>
        /// Gets or sets FullNumber.
        /// </summary>
        [JsonProperty("full_number", NullValueHandling = NullValueHandling.Ignore)]
        public string FullNumber { get; set; }

        /// <summary>
        /// Gets or sets ExpirationMonth.
        /// </summary>
        [JsonProperty("expiration_month", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets ExpirationYear.
        /// </summary>
        [JsonProperty("expiration_year", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationYear { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreditCardAttributes : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreditCardAttributes other &&
                (this.FullNumber == null && other.FullNumber == null ||
                 this.FullNumber?.Equals(other.FullNumber) == true) &&
                (this.ExpirationMonth == null && other.ExpirationMonth == null ||
                 this.ExpirationMonth?.Equals(other.ExpirationMonth) == true) &&
                (this.ExpirationYear == null && other.ExpirationYear == null ||
                 this.ExpirationYear?.Equals(other.ExpirationYear) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"FullNumber = {this.FullNumber ?? "null"}");
            toStringOutput.Add($"ExpirationMonth = {this.ExpirationMonth ?? "null"}");
            toStringOutput.Add($"ExpirationYear = {this.ExpirationYear ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}