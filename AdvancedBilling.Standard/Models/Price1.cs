// <copyright file="Price1.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Price1.
    /// </summary>
    public class Price1 : BaseModel
    {
        private int? endingQuantity;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ending_quantity", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Price1"/> class.
        /// </summary>
        public Price1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Price1"/> class.
        /// </summary>
        /// <param name="startingQuantity">starting_quantity.</param>
        /// <param name="endingQuantity">ending_quantity.</param>
        /// <param name="unitPrice">unit_price.</param>
        public Price1(
            int? startingQuantity = null,
            int? endingQuantity = null,
            string unitPrice = null)
        {
            this.StartingQuantity = startingQuantity;

            if (endingQuantity != null)
            {
                this.EndingQuantity = endingQuantity;
            }
            this.UnitPrice = unitPrice;
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
        /// Gets or sets UnitPrice.
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Price1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is Price1 other &&
                (this.StartingQuantity == null && other.StartingQuantity == null ||
                 this.StartingQuantity?.Equals(other.StartingQuantity) == true) &&
                (this.EndingQuantity == null && other.EndingQuantity == null ||
                 this.EndingQuantity?.Equals(other.EndingQuantity) == true) &&
                (this.UnitPrice == null && other.UnitPrice == null ||
                 this.UnitPrice?.Equals(other.UnitPrice) == true) &&
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
            toStringOutput.Add($"UnitPrice = {this.UnitPrice ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}