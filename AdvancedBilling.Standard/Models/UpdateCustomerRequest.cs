// <copyright file="UpdateCustomerRequest.cs" company="APIMatic">
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
    /// UpdateCustomerRequest.
    /// </summary>
    public class UpdateCustomerRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest"/> class.
        /// </summary>
        public UpdateCustomerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        public UpdateCustomerRequest(
            Models.UpdateCustomer customer)
        {
            this.Customer = customer;
        }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonProperty("customer")]
        public Models.UpdateCustomer Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateCustomerRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateCustomerRequest other &&
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