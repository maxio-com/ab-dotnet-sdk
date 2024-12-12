// <copyright file="ComponentPricePointsResponse.cs" company="APIMatic">
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
    /// ComponentPricePointsResponse.
    /// </summary>
    public class ComponentPricePointsResponse : BaseModel
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
        /// <param name="meta">meta.</param>
        public ComponentPricePointsResponse(
            List<Models.ComponentPricePoint> pricePoints = null,
            Models.ListPublicKeysMeta meta = null)
        {
            this.PricePoints = pricePoints;
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or sets PricePoints.
        /// </summary>
        [JsonProperty("price_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentPricePoint> PricePoints { get; set; }

        /// <summary>
        /// Gets or sets Meta.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListPublicKeysMeta Meta { get; set; }

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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComponentPricePointsResponse other &&
                (this.PricePoints == null && other.PricePoints == null ||
                 this.PricePoints?.Equals(other.PricePoints) == true) &&
                (this.Meta == null && other.Meta == null ||
                 this.Meta?.Equals(other.Meta) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PricePoints = {(this.PricePoints == null ? "null" : $"[{string.Join(", ", this.PricePoints)} ]")}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}