// <copyright file="Price.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Price.
    /// </summary>
    public class Price : BaseModel
    {
        private PriceEndingQuantity endingQuantity;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ending_quantity", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Price"/> class.
        /// </summary>
        public Price()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Price"/> class.
        /// </summary>
        /// <param name="startingQuantity">starting_quantity.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="endingQuantity">ending_quantity.</param>
        public Price(
            PriceStartingQuantity startingQuantity,
            PriceUnitPrice unitPrice,
            PriceEndingQuantity endingQuantity = null)
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
        [JsonProperty("starting_quantity")]
        public PriceStartingQuantity StartingQuantity { get; set; }

        /// <summary>
        /// Gets or sets EndingQuantity.
        /// </summary>
        [JsonProperty("ending_quantity")]
        public PriceEndingQuantity EndingQuantity
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
        /// The price can contain up to 8 decimal places. i.e. 1.00 or 0.0012 or 0.00000065
        /// </summary>
        [JsonProperty("unit_price")]
        public PriceUnitPrice UnitPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Price : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Price other &&                ((this.StartingQuantity == null && other.StartingQuantity == null) || (this.StartingQuantity?.Equals(other.StartingQuantity) == true)) &&
                ((this.EndingQuantity == null && other.EndingQuantity == null) || (this.EndingQuantity?.Equals(other.EndingQuantity) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity.ToString())}");
            toStringOutput.Add($"EndingQuantity = {(this.EndingQuantity == null ? "null" : this.EndingQuantity.ToString())}");
            toStringOutput.Add($"UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}