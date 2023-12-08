// <copyright file="CreateOfferComponent.cs" company="APIMatic">
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
    /// CreateOfferComponent.
    /// </summary>
    public class CreateOfferComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOfferComponent"/> class.
        /// </summary>
        public CreateOfferComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOfferComponent"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="startingQuantity">starting_quantity.</param>
        public CreateOfferComponent(
            int? componentId = null,
            int? startingQuantity = null)
        {
            this.ComponentId = componentId;
            this.StartingQuantity = startingQuantity;
        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

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

            return $"CreateOfferComponent : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateOfferComponent other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.StartingQuantity == null && other.StartingQuantity == null) || (this.StartingQuantity?.Equals(other.StartingQuantity) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity.ToString())}");
        }
    }
}