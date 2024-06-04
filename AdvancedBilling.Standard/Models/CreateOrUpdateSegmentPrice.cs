// <copyright file="CreateOrUpdateSegmentPrice.cs" company="APIMatic">
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
    /// CreateOrUpdateSegmentPrice.
    /// </summary>
    public class CreateOrUpdateSegmentPrice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateSegmentPrice"/> class.
        /// </summary>
        public CreateOrUpdateSegmentPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateSegmentPrice"/> class.
        /// </summary>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="startingQuantity">starting_quantity.</param>
        /// <param name="endingQuantity">ending_quantity.</param>
        public CreateOrUpdateSegmentPrice(
            CreateOrUpdateSegmentPriceUnitPrice unitPrice,
            int? startingQuantity = null,
            int? endingQuantity = null)
        {
            this.StartingQuantity = startingQuantity;
            this.EndingQuantity = endingQuantity;
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
        [JsonProperty("ending_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndingQuantity { get; set; }

        /// <summary>
        /// The price can contain up to 8 decimal places. i.e. 1.00 or 0.0012 or 0.00000065
        /// </summary>
        [JsonProperty("unit_price")]
        public CreateOrUpdateSegmentPriceUnitPrice UnitPrice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateOrUpdateSegmentPrice : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOrUpdateSegmentPrice other &&                ((this.StartingQuantity == null && other.StartingQuantity == null) || (this.StartingQuantity?.Equals(other.StartingQuantity) == true)) &&
                ((this.EndingQuantity == null && other.EndingQuantity == null) || (this.EndingQuantity?.Equals(other.EndingQuantity) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity.ToString())}");
            toStringOutput.Add($"this.EndingQuantity = {(this.EndingQuantity == null ? "null" : this.EndingQuantity.ToString())}");
            toStringOutput.Add($"UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}