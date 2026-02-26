// <copyright file="CustomerResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CustomerResponse.
    /// </summary>
    public class CustomerResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse"/> class.
        /// </summary>
        public CustomerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        public CustomerResponse(
            Models.Customer customer)
        {
            this.Customer = customer;
        }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer")]
        public Models.Customer Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomerResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CustomerResponse other &&
                (this.Customer == null && other.Customer == null ||
                 this.Customer?.Equals(other.Customer) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Customer = {(this.Customer == null ? "null" : this.Customer.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}