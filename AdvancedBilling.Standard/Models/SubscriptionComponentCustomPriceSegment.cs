// <copyright file="SubscriptionComponentCustomPriceSegment.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionComponentCustomPriceSegment.
    /// </summary>
    public class SubscriptionComponentCustomPriceSegment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentCustomPriceSegment"/> class.
        /// </summary>
        public SubscriptionComponentCustomPriceSegment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentCustomPriceSegment"/> class.
        /// </summary>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="prices">prices.</param>
        /// <param name="segmentProperty1Value">segment_property_1_value.</param>
        /// <param name="segmentProperty2Value">segment_property_2_value.</param>
        /// <param name="segmentProperty3Value">segment_property_3_value.</param>
        /// <param name="segmentProperty4Value">segment_property_4_value.</param>
        /// <param name="segmentProperty5Value">segment_property_5_value.</param>
        /// <param name="segmentProperty6Value">segment_property_6_value.</param>
        /// <param name="segmentProperty7Value">segment_property_7_value.</param>
        /// <param name="segmentProperty8Value">segment_property_8_value.</param>
        /// <param name="segmentProperty9Value">segment_property_9_value.</param>
        /// <param name="segmentProperty10Value">segment_property_10_value.</param>
        public SubscriptionComponentCustomPriceSegment(
            Models.PricingScheme pricingScheme,
            List<Models.CreateOrUpdateSegmentPrice> prices,
            SubscriptionComponentCustomPriceSegmentSegmentProperty1Value segmentProperty1Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty2Value segmentProperty2Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty3Value segmentProperty3Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty4Value segmentProperty4Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty5Value segmentProperty5Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty6Value segmentProperty6Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty7Value segmentProperty7Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty8Value segmentProperty8Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty9Value segmentProperty9Value = null,
            SubscriptionComponentCustomPriceSegmentSegmentProperty10Value segmentProperty10Value = null)
        {
            this.SegmentProperty1Value = segmentProperty1Value;
            this.SegmentProperty2Value = segmentProperty2Value;
            this.SegmentProperty3Value = segmentProperty3Value;
            this.SegmentProperty4Value = segmentProperty4Value;
            this.SegmentProperty5Value = segmentProperty5Value;
            this.SegmentProperty6Value = segmentProperty6Value;
            this.SegmentProperty7Value = segmentProperty7Value;
            this.SegmentProperty8Value = segmentProperty8Value;
            this.SegmentProperty9Value = segmentProperty9Value;
            this.SegmentProperty10Value = segmentProperty10Value;
            this.PricingScheme = pricingScheme;
            this.Prices = prices;
        }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_1_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty1Value SegmentProperty1Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_2_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty2Value SegmentProperty2Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_3_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty3Value SegmentProperty3Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_4_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty4Value SegmentProperty4Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_5_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty5Value SegmentProperty5Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_6_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty6Value SegmentProperty6Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_7_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty7Value SegmentProperty7Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_8_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty8Value SegmentProperty8Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_9_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty9Value SegmentProperty9Value { get; set; }

        /// <summary>
        /// A value that will occur in your events that you want to bill upon. For a boolean segmenting property, send the value as a string, `"true"` or `"false"`.
        /// </summary>
        [JsonProperty("segment_property_10_value", NullValueHandling = NullValueHandling.Ignore)]
        public SubscriptionComponentCustomPriceSegmentSegmentProperty10Value SegmentProperty10Value { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.PricingScheme PricingScheme { get; set; }

        /// <summary>
        /// The rates for this segment. Use one price for a flat rate, or several price brackets for a tiered, volume or stairstep scheme.
        /// </summary>
        [JsonProperty("prices")]
        public List<Models.CreateOrUpdateSegmentPrice> Prices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionComponentCustomPriceSegment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionComponentCustomPriceSegment other &&
                (this.SegmentProperty1Value == null && other.SegmentProperty1Value == null ||
                 this.SegmentProperty1Value?.Equals(other.SegmentProperty1Value) == true) &&
                (this.SegmentProperty2Value == null && other.SegmentProperty2Value == null ||
                 this.SegmentProperty2Value?.Equals(other.SegmentProperty2Value) == true) &&
                (this.SegmentProperty3Value == null && other.SegmentProperty3Value == null ||
                 this.SegmentProperty3Value?.Equals(other.SegmentProperty3Value) == true) &&
                (this.SegmentProperty4Value == null && other.SegmentProperty4Value == null ||
                 this.SegmentProperty4Value?.Equals(other.SegmentProperty4Value) == true) &&
                (this.SegmentProperty5Value == null && other.SegmentProperty5Value == null ||
                 this.SegmentProperty5Value?.Equals(other.SegmentProperty5Value) == true) &&
                (this.SegmentProperty6Value == null && other.SegmentProperty6Value == null ||
                 this.SegmentProperty6Value?.Equals(other.SegmentProperty6Value) == true) &&
                (this.SegmentProperty7Value == null && other.SegmentProperty7Value == null ||
                 this.SegmentProperty7Value?.Equals(other.SegmentProperty7Value) == true) &&
                (this.SegmentProperty8Value == null && other.SegmentProperty8Value == null ||
                 this.SegmentProperty8Value?.Equals(other.SegmentProperty8Value) == true) &&
                (this.SegmentProperty9Value == null && other.SegmentProperty9Value == null ||
                 this.SegmentProperty9Value?.Equals(other.SegmentProperty9Value) == true) &&
                (this.SegmentProperty10Value == null && other.SegmentProperty10Value == null ||
                 this.SegmentProperty10Value?.Equals(other.SegmentProperty10Value) == true) &&
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
            toStringOutput.Add($"SegmentProperty5Value = {(this.SegmentProperty5Value == null ? "null" : this.SegmentProperty5Value.ToString())}");
            toStringOutput.Add($"SegmentProperty6Value = {(this.SegmentProperty6Value == null ? "null" : this.SegmentProperty6Value.ToString())}");
            toStringOutput.Add($"SegmentProperty7Value = {(this.SegmentProperty7Value == null ? "null" : this.SegmentProperty7Value.ToString())}");
            toStringOutput.Add($"SegmentProperty8Value = {(this.SegmentProperty8Value == null ? "null" : this.SegmentProperty8Value.ToString())}");
            toStringOutput.Add($"SegmentProperty9Value = {(this.SegmentProperty9Value == null ? "null" : this.SegmentProperty9Value.ToString())}");
            toStringOutput.Add($"SegmentProperty10Value = {(this.SegmentProperty10Value == null ? "null" : this.SegmentProperty10Value.ToString())}");
            toStringOutput.Add($"PricingScheme = {this.PricingScheme}");
            toStringOutput.Add($"Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}