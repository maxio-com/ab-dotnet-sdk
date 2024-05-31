// <copyright file="CustomerError.cs" company="APIMatic">
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
    /// CustomerError.
    /// </summary>
    public class CustomerError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerError"/> class.
        /// </summary>
        public CustomerError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerError"/> class.
        /// </summary>
        /// <param name="customer">customer.</param>
        public CustomerError(
            string customer = null)
        {
            this.Customer = customer;
        }

        /// <summary>
        /// Gets or sets Customer.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public string Customer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerError : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerError other &&                ((this.Customer == null && other.Customer == null) || (this.Customer?.Equals(other.Customer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Customer = {(this.Customer == null ? "null" : this.Customer)}");

            base.ToString(toStringOutput);
        }
    }
}