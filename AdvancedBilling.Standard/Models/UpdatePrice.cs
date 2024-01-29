// <copyright file="UpdatePrice.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// UpdatePrice.
    /// </summary>
    public class UpdatePrice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrice"/> class.
        /// </summary>
        public UpdatePrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="endingQuantity">ending_quantity.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="destroy">_destroy.</param>
        /// <param name="startingQuantity">starting_quantity.</param>
        public UpdatePrice(
            int? id = null,
            UpdatePriceEndingQuantity endingQuantity = null,
            UpdatePriceUnitPrice unitPrice = null,
            bool? destroy = null,
            UpdatePriceStartingQuantity startingQuantity = null)
        {
            this.Id = id;
            this.EndingQuantity = endingQuantity;
            this.UnitPrice = unitPrice;
            this.Destroy = destroy;
            this.StartingQuantity = startingQuantity;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets EndingQuantity.
        /// </summary>
        [JsonProperty("ending_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatePriceEndingQuantity EndingQuantity { get; set; }

        /// <summary>
        /// The price can contain up to 8 decimal places. i.e. 1.00 or 0.0012 or 0.00000065
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatePriceUnitPrice UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets Destroy.
        /// </summary>
        [JsonProperty("_destroy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Destroy { get; set; }

        /// <summary>
        /// Gets or sets StartingQuantity.
        /// </summary>
        [JsonProperty("starting_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatePriceStartingQuantity StartingQuantity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdatePrice : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdatePrice other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.EndingQuantity == null && other.EndingQuantity == null) || (this.EndingQuantity?.Equals(other.EndingQuantity) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.Destroy == null && other.Destroy == null) || (this.Destroy?.Equals(other.Destroy) == true)) &&
                ((this.StartingQuantity == null && other.StartingQuantity == null) || (this.StartingQuantity?.Equals(other.StartingQuantity) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"EndingQuantity = {(this.EndingQuantity == null ? "null" : this.EndingQuantity.ToString())}");
            toStringOutput.Add($"UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"this.Destroy = {(this.Destroy == null ? "null" : this.Destroy.ToString())}");
            toStringOutput.Add($"StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity.ToString())}");
        }
    }
}