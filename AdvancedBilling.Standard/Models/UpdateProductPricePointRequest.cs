// <copyright file="UpdateProductPricePointRequest.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UpdateProductPricePointRequest.
    /// </summary>
    public class UpdateProductPricePointRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductPricePointRequest"/> class.
        /// </summary>
        public UpdateProductPricePointRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductPricePointRequest"/> class.
        /// </summary>
        /// <param name="pricePoint">price_point.</param>
        public UpdateProductPricePointRequest(
            Models.UpdateProductPricePoint pricePoint)
        {
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point")]
        public Models.UpdateProductPricePoint PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateProductPricePointRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateProductPricePointRequest other &&                ((this.PricePoint == null && other.PricePoint == null) || (this.PricePoint?.Equals(other.PricePoint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PricePoint = {(this.PricePoint == null ? "null" : this.PricePoint.ToString())}");
        }
    }
}