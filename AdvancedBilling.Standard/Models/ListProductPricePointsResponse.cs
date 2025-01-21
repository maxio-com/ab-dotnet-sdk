// <copyright file="ListProductPricePointsResponse.cs" company="APIMatic">
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
    /// ListProductPricePointsResponse.
    /// </summary>
    public class ListProductPricePointsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductPricePointsResponse"/> class.
        /// </summary>
        public ListProductPricePointsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductPricePointsResponse"/> class.
        /// </summary>
        /// <param name="pricePoints">price_points.</param>
        public ListProductPricePointsResponse(
            List<Models.ProductPricePoint> pricePoints)
        {
            this.PricePoints = pricePoints;
        }

        /// <summary>
        /// Gets or sets PricePoints.
        /// </summary>
        [JsonProperty("price_points")]
        public List<Models.ProductPricePoint> PricePoints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListProductPricePointsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListProductPricePointsResponse other &&
                (this.PricePoints == null && other.PricePoints == null ||
                 this.PricePoints?.Equals(other.PricePoints) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PricePoints = {(this.PricePoints == null ? "null" : $"[{string.Join(", ", this.PricePoints)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}