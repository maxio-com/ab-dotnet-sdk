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
    using AdvancedBilling.Standard.Utilities;
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
            int? endingQuantity = null,
            int? unitPrice = null,
            string destroy = null,
            int? startingQuantity = null)
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
        public int? EndingQuantity { get; set; }

        /// <summary>
        /// Gets or sets UnitPrice.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets Destroy.
        /// </summary>
        [JsonProperty("_destroy", NullValueHandling = NullValueHandling.Ignore)]
        public string Destroy { get; set; }

        /// <summary>
        /// Gets or sets StartingQuantity.
        /// </summary>
        [JsonProperty("starting_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartingQuantity { get; set; }

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
            toStringOutput.Add($"this.EndingQuantity = {(this.EndingQuantity == null ? "null" : this.EndingQuantity.ToString())}");
            toStringOutput.Add($"this.UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"this.Destroy = {(this.Destroy == null ? "null" : this.Destroy)}");
            toStringOutput.Add($"this.StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity.ToString())}");
        }
    }
}