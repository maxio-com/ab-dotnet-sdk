// <copyright file="PrepaidProductPricePointFilter.cs" company="APIMatic">
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
    /// PrepaidProductPricePointFilter.
    /// </summary>
    public class PrepaidProductPricePointFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidProductPricePointFilter"/> class.
        /// </summary>
        public PrepaidProductPricePointFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidProductPricePointFilter"/> class.
        /// </summary>
        /// <param name="productPricePointId">product_price_point_id.</param>
        public PrepaidProductPricePointFilter(
            string productPricePointId)
        {
            this.ProductPricePointId = productPricePointId;
        }

        /// <summary>
        /// Passed as a parameter to list methods to return only non null values.
        /// </summary>
        [JsonProperty("product_price_point_id")]
        public string ProductPricePointId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaidProductPricePointFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidProductPricePointFilter other &&
                (this.ProductPricePointId == null && other.ProductPricePointId == null ||
                 this.ProductPricePointId?.Equals(other.ProductPricePointId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProductPricePointId = {this.ProductPricePointId ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}