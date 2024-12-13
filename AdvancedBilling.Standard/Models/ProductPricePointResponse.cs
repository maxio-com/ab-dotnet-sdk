// <copyright file="ProductPricePointResponse.cs" company="APIMatic">
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
    /// ProductPricePointResponse.
    /// </summary>
    public class ProductPricePointResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPricePointResponse"/> class.
        /// </summary>
        public ProductPricePointResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPricePointResponse"/> class.
        /// </summary>
        /// <param name="pricePoint">price_point.</param>
        public ProductPricePointResponse(
            Models.ProductPricePoint pricePoint)
        {
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point")]
        public Models.ProductPricePoint PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ProductPricePointResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ProductPricePointResponse other &&
                (this.PricePoint == null && other.PricePoint == null ||
                 this.PricePoint?.Equals(other.PricePoint) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PricePoint = {(this.PricePoint == null ? "null" : this.PricePoint.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}