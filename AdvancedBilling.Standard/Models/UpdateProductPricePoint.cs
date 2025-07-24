// <copyright file="UpdateProductPricePoint.cs" company="APIMatic">
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
    /// UpdateProductPricePoint.
    /// </summary>
    public class UpdateProductPricePoint : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductPricePoint"/> class.
        /// </summary>
        public UpdateProductPricePoint()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductPricePoint"/> class.
        /// </summary>
        /// <param name="handle">handle.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        public UpdateProductPricePoint(
            string handle = null,
            long? priceInCents = null)
        {
            this.Handle = handle;
            this.PriceInCents = priceInCents;
        }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets PriceInCents.
        /// </summary>
        [JsonProperty("price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? PriceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateProductPricePoint : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateProductPricePoint other &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
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
            toStringOutput.Add($"Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"PriceInCents = {(this.PriceInCents == null ? "null" : this.PriceInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}