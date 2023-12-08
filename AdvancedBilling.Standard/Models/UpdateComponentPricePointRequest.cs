// <copyright file="UpdateComponentPricePointRequest.cs" company="APIMatic">
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
    /// UpdateComponentPricePointRequest.
    /// </summary>
    public class UpdateComponentPricePointRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentPricePointRequest"/> class.
        /// </summary>
        public UpdateComponentPricePointRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponentPricePointRequest"/> class.
        /// </summary>
        /// <param name="pricePoint">price_point.</param>
        public UpdateComponentPricePointRequest(
            Models.UpdateComponentPricePoint pricePoint = null)
        {
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpdateComponentPricePoint PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateComponentPricePointRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateComponentPricePointRequest other &&                ((this.PricePoint == null && other.PricePoint == null) || (this.PricePoint?.Equals(other.PricePoint) == true));
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