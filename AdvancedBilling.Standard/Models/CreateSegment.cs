// <copyright file="CreateSegment.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateSegment.
    /// </summary>
    public class CreateSegment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegment"/> class.
        /// </summary>
        public CreateSegment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSegment"/> class.
        /// </summary>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="segmentProperty1Value">segment_property_1_value.</param>
        /// <param name="segmentProperty2Value">segment_property_2_value.</param>
        /// <param name="segmentProperty3Value">segment_property_3_value.</param>
        /// <param name="segmentProperty4Value">segment_property_4_value.</param>
        /// <param name="prices">prices.</param>
        public CreateSegment(
            Models.PricingScheme pricingScheme,
            CreateSegmentSegmentProperty1Value segmentProperty1Value = null,
            CreateSegmentSegmentProperty2Value segmentProperty2Value = null,
            CreateSegmentSegmentProperty3Value segmentProperty3Value = null,
            CreateSegmentSegmentProperty4Value segmentProperty4Value = null,
            List<Models.CreateOrUpdateSegmentPrice> prices = null)
        {
            this.SegmentProperty1Value = segmentProperty1Value;
            this.SegmentProperty2Value = segmentProperty2Value;
            this.SegmentProperty3Value = segmentProperty3Value;
            this.SegmentProperty4Value = segmentProperty4Value;
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
        }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. The type of the value depends on the property type in the related event based billing metric.
        /// </summary>
        [JsonProperty("segment_property_1_value", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSegmentSegmentProperty1Value SegmentProperty1Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. The type of the value depends on the property type in the related event based billing metric.
        /// </summary>
        [JsonProperty("segment_property_2_value", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSegmentSegmentProperty2Value SegmentProperty2Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. The type of the value depends on the property type in the related event based billing metric.
        /// </summary>
        [JsonProperty("segment_property_3_value", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSegmentSegmentProperty3Value SegmentProperty3Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. The type of the value depends on the property type in the related event based billing metric.
        /// </summary>
        [JsonProperty("segment_property_4_value", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSegmentSegmentProperty4Value SegmentProperty4Value { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.PricingScheme PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateOrUpdateSegmentPrice> Prices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateSegment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateSegment other &&
                (this.SegmentProperty1Value == null && other.SegmentProperty1Value == null ||
                 this.SegmentProperty1Value?.Equals(other.SegmentProperty1Value) == true) &&
                (this.SegmentProperty2Value == null && other.SegmentProperty2Value == null ||
                 this.SegmentProperty2Value?.Equals(other.SegmentProperty2Value) == true) &&
                (this.SegmentProperty3Value == null && other.SegmentProperty3Value == null ||
                 this.SegmentProperty3Value?.Equals(other.SegmentProperty3Value) == true) &&
                (this.SegmentProperty4Value == null && other.SegmentProperty4Value == null ||
                 this.SegmentProperty4Value?.Equals(other.SegmentProperty4Value) == true) &&
                (this.PricingScheme.Equals(other.PricingScheme)) &&
                (this.Prices == null && other.Prices == null ||
                 this.Prices?.Equals(other.Prices) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SegmentProperty1Value = {(this.SegmentProperty1Value == null ? "null" : this.SegmentProperty1Value.ToString())}");
            toStringOutput.Add($"SegmentProperty2Value = {(this.SegmentProperty2Value == null ? "null" : this.SegmentProperty2Value.ToString())}");
            toStringOutput.Add($"SegmentProperty3Value = {(this.SegmentProperty3Value == null ? "null" : this.SegmentProperty3Value.ToString())}");
            toStringOutput.Add($"SegmentProperty4Value = {(this.SegmentProperty4Value == null ? "null" : this.SegmentProperty4Value.ToString())}");
            toStringOutput.Add($"PricingScheme = {this.PricingScheme}");
            toStringOutput.Add($"Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}