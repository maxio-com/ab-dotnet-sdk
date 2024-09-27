// <copyright file="UpdateCurrencyPrice.cs" company="APIMatic">
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
    /// UpdateCurrencyPrice.
    /// </summary>
    public class UpdateCurrencyPrice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrencyPrice"/> class.
        /// </summary>
        public UpdateCurrencyPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCurrencyPrice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="price">price.</param>
        public UpdateCurrencyPrice(
            int id,
            int price)
        {
            this.Id = id;
            this.Price = price;
        }

        /// <summary>
        /// ID of the currency price record being updated
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// New price for the given currency
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateCurrencyPrice : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateCurrencyPrice other &&                this.Id.Equals(other.Id) &&
                this.Price.Equals(other.Price);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Price = {this.Price}");

            base.ToString(toStringOutput);
        }
    }
}