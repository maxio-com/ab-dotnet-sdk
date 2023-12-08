// <copyright file="ComponentPricePointPrice.cs" company="APIMatic">
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
    /// ComponentPricePointPrice.
    /// </summary>
    public class ComponentPricePointPrice
    {
        private int? endingQuantity;
        private int? segmentId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ending_quantity", false },
            { "segment_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointPrice"/> class.
        /// </summary>
        public ComponentPricePointPrice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentPricePointPrice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="startingQuantity">starting_quantity.</param>
        /// <param name="endingQuantity">ending_quantity.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="formattedUnitPrice">formatted_unit_price.</param>
        /// <param name="segmentId">segment_id.</param>
        public ComponentPricePointPrice(
            int? id = null,
            int? componentId = null,
            int? startingQuantity = null,
            int? endingQuantity = null,
            string unitPrice = null,
            int? pricePointId = null,
            string formattedUnitPrice = null,
            int? segmentId = null)
        {
            this.Id = id;
            this.ComponentId = componentId;
            this.StartingQuantity = startingQuantity;
            if (endingQuantity != null)
            {
                this.EndingQuantity = endingQuantity;
            }

            this.UnitPrice = unitPrice;
            this.PricePointId = pricePointId;
            this.FormattedUnitPrice = formattedUnitPrice;
            if (segmentId != null)
            {
                this.SegmentId = segmentId;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

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

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets FormattedUnitPrice.
        /// </summary>
        [JsonProperty("formatted_unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public string FormattedUnitPrice { get; set; }

        /// <summary>
        /// Gets or sets SegmentId.
        /// </summary>
        [JsonProperty("segment_id")]
        public int? SegmentId
        {
            get
            {
                return this.segmentId;
            }

            set
            {
                this.shouldSerialize["segment_id"] = true;
                this.segmentId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComponentPricePointPrice : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEndingQuantity()
        {
            this.shouldSerialize["ending_quantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSegmentId()
        {
            this.shouldSerialize["segment_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndingQuantity()
        {
            return this.shouldSerialize["ending_quantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSegmentId()
        {
            return this.shouldSerialize["segment_id"];
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
            return obj is ComponentPricePointPrice other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.StartingQuantity == null && other.StartingQuantity == null) || (this.StartingQuantity?.Equals(other.StartingQuantity) == true)) &&
                ((this.EndingQuantity == null && other.EndingQuantity == null) || (this.EndingQuantity?.Equals(other.EndingQuantity) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.FormattedUnitPrice == null && other.FormattedUnitPrice == null) || (this.FormattedUnitPrice?.Equals(other.FormattedUnitPrice) == true)) &&
                ((this.SegmentId == null && other.SegmentId == null) || (this.SegmentId?.Equals(other.SegmentId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.StartingQuantity = {(this.StartingQuantity == null ? "null" : this.StartingQuantity.ToString())}");
            toStringOutput.Add($"this.EndingQuantity = {(this.EndingQuantity == null ? "null" : this.EndingQuantity.ToString())}");
            toStringOutput.Add($"this.UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice)}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.FormattedUnitPrice = {(this.FormattedUnitPrice == null ? "null" : this.FormattedUnitPrice)}");
            toStringOutput.Add($"this.SegmentId = {(this.SegmentId == null ? "null" : this.SegmentId.ToString())}");
        }
    }
}