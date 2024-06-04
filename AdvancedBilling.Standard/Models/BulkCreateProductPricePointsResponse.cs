// <copyright file="BulkCreateProductPricePointsResponse.cs" company="APIMatic">
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
    /// BulkCreateProductPricePointsResponse.
    /// </summary>
    public class BulkCreateProductPricePointsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateProductPricePointsResponse"/> class.
        /// </summary>
        public BulkCreateProductPricePointsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateProductPricePointsResponse"/> class.
        /// </summary>
        /// <param name="pricePoints">price_points.</param>
        public BulkCreateProductPricePointsResponse(
            List<Models.ProductPricePoint> pricePoints = null)
        {
            this.PricePoints = pricePoints;
        }

        /// <summary>
        /// Gets or sets PricePoints.
        /// </summary>
        [JsonProperty("price_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ProductPricePoint> PricePoints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BulkCreateProductPricePointsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is BulkCreateProductPricePointsResponse other &&                ((this.PricePoints == null && other.PricePoints == null) || (this.PricePoints?.Equals(other.PricePoints) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PricePoints = {(this.PricePoints == null ? "null" : $"[{string.Join(", ", this.PricePoints)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}