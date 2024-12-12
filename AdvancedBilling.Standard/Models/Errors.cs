// <copyright file="Errors.cs" company="APIMatic">
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
    /// Errors.
    /// </summary>
    public class Errors : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Errors"/> class.
        /// </summary>
        public Errors()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Errors"/> class.
        /// </summary>
        /// <param name="perPage">per_page.</param>
        /// <param name="pricePoint">price_point.</param>
        public Errors(
            List<string> perPage = null,
            List<string> pricePoint = null)
        {
            this.PerPage = perPage;
            this.PricePoint = pricePoint;
        }

        /// <summary>
        /// Gets or sets PerPage.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PerPage { get; set; }

        /// <summary>
        /// Gets or sets PricePoint.
        /// </summary>
        [JsonProperty("price_point", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PricePoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Errors : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Errors other &&
                (this.PerPage == null && other.PerPage == null ||
                 this.PerPage?.Equals(other.PerPage) == true) &&
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
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : $"[{string.Join(", ", this.PerPage)} ]")}");
            toStringOutput.Add($"this.PricePoint = {(this.PricePoint == null ? "null" : $"[{string.Join(", ", this.PricePoint)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}