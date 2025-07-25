// <copyright file="ProductPricePointErrors.cs" company="APIMatic">
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
    /// ProductPricePointErrors.
    /// </summary>
    public class ProductPricePointErrors : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPricePointErrors"/> class.
        /// </summary>
        public ProductPricePointErrors()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPricePointErrors"/> class.
        /// </summary>
        /// <param name="pricePoint">price_point.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="name">name.</param>
        /// <param name="price">price.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        public ProductPricePointErrors(
            string pricePoint = null,
            List<string> interval = null,
            List<string> intervalUnit = null,
            List<string> name = null,
            List<string> price = null,
            List<string> priceInCents = null)
        {
            this.PricePoint = pricePoint;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            this.Name = name;
            this.Price = price;
            this.PriceInCents = priceInCents;
        }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point", NullValueHandling = NullValueHandling.Ignore)]
        public string PricePoint { get; set; }

        /// <summary>
        /// Gets or sets Interval.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Interval { get; set; }

        /// <summary>
        /// Gets or sets IntervalUnit.
        /// </summary>
        [JsonProperty("interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IntervalUnit { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Price { get; set; }

        /// <summary>
        /// Gets or sets PriceInCents.
        /// </summary>
        [JsonProperty("price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PriceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProductPricePointErrors : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProductPricePointErrors other &&
                (this.PricePoint == null && other.PricePoint == null ||
                 this.PricePoint?.Equals(other.PricePoint) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalUnit == null && other.IntervalUnit == null ||
                 this.IntervalUnit?.Equals(other.IntervalUnit) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Price == null && other.Price == null ||
                 this.Price?.Equals(other.Price) == true) &&
                (this.PriceInCents == null && other.PriceInCents == null ||
                 this.PriceInCents?.Equals(other.PriceInCents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PricePoint = {this.PricePoint ?? "null"}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : $"[{string.Join(", ", this.Interval)} ]")}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : $"[{string.Join(", ", this.IntervalUnit)} ]")}");
            toStringOutput.Add($"Name = {(this.Name == null ? "null" : $"[{string.Join(", ", this.Name)} ]")}");
            toStringOutput.Add($"Price = {(this.Price == null ? "null" : $"[{string.Join(", ", this.Price)} ]")}");
            toStringOutput.Add($"PriceInCents = {(this.PriceInCents == null ? "null" : $"[{string.Join(", ", this.PriceInCents)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}