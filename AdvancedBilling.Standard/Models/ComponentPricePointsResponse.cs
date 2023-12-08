// <copyright file="ComponentPricePointsResponse.cs" company="APIMatic">
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
    /// ComponentPricePointsResponse.
    /// </summary>
    public class ComponentPricePointsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointsResponse"/> class.
        /// </summary>
        public ComponentPricePointsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointsResponse"/> class.
        /// </summary>
        /// <param name="pricePoints">price_points.</param>
        public ComponentPricePointsResponse(
            List<Models.ComponentPricePoint> pricePoints = null)
        {
            this.PricePoints = pricePoints;
        }

        /// <summary>
        /// Gets or sets PricePoints.
        /// </summary>
        [JsonProperty("price_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentPricePoint> PricePoints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComponentPricePointsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ComponentPricePointsResponse other &&                ((this.PricePoints == null && other.PricePoints == null) || (this.PricePoints?.Equals(other.PricePoints) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PricePoints = {(this.PricePoints == null ? "null" : $"[{string.Join(", ", this.PricePoints)} ]")}");
        }
    }
}