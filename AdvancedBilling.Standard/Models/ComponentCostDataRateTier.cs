// <copyright file="ComponentCostDataRateTier.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// ComponentCostDataRateTier.
    /// </summary>
    public class ComponentCostDataRateTier : BaseModel
    {
        private int? endingQuantity;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ending_quantity", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCostDataRateTier"/> class.
        /// </summary>
        public ComponentCostDataRateTier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCostDataRateTier"/> class.
        /// </summary>
        /// <param name="startingQuantity">starting_quantity.</param>
        /// <param name="endingQuantity">ending_quantity.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="amount">amount.</param>
        public ComponentCostDataRateTier(
            int? startingQuantity = null,
            int? endingQuantity = null,
            string quantity = null,
            string unitPrice = null,
            string amount = null)
        {
            this.StartingQuantity = startingQuantity;

            if (endingQuantity != null)
            {
                this.EndingQuantity = endingQuantity;
            }
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or sets StartingQuantity.
        /// </summary>
        [JsonProperty("starting_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartingQuantity { get; set; }

        /// <summary>
        /// Gets or sets EndingQuantity.
        /// </summary>
        [JsonProperty("ending_quantity")]
        public int? EndingQuantity
        {
            get
            {
                return this.endingQuantity;
            }

            set
            {
                this.shouldSerialize["ending_quantity"] = true;
                this.endingQuantity = value;
            }
        }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets UnitPrice.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ComponentCostDataRateTier : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEndingQuantity()
        {
            this.shouldSerialize["ending_quantity"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndingQuantity()
        {
            return this.shouldSerialize["ending_quantity"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ComponentCostDataRateTier other &&
                (this.StartingQuantity == null && other.StartingQuantity == null ||
                 this.StartingQuantity?.Equals(other.StartingQuantity) == true) &&
                (this.EndingQuantity == null && other.EndingQuantity == null ||
                 this.EndingQuantity?.Equals(other.EndingQuantity) == true) &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.UnitPrice == null && other.UnitPrice == null ||
                 this.UnitPrice?.Equals(other.UnitPrice) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity.ToString())}");
            toStringOutput.Add($"EndingQuantity = {(this.EndingQuantity == null ? "null" : this.EndingQuantity.ToString())}");
            toStringOutput.Add($"Quantity = {this.Quantity ?? "null"}");
            toStringOutput.Add($"UnitPrice = {this.UnitPrice ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}