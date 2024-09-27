// <copyright file="Segment.cs" company="APIMatic">
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
    /// Segment.
    /// </summary>
    public class Segment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Segment"/> class.
        /// </summary>
        public Segment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="eventBasedBillingMetricId">event_based_billing_metric_id.</param>
        /// <param name="pricingScheme">pricing_scheme.</param>
        /// <param name="segmentProperty1Value">segment_property_1_value.</param>
        /// <param name="segmentProperty2Value">segment_property_2_value.</param>
        /// <param name="segmentProperty3Value">segment_property_3_value.</param>
        /// <param name="segmentProperty4Value">segment_property_4_value.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="prices">prices.</param>
        public Segment(
            int? id = null,
            int? componentId = null,
            int? pricePointId = null,
            int? eventBasedBillingMetricId = null,
            Models.PricingScheme? pricingScheme = null,
            SegmentSegmentProperty1Value segmentProperty1Value = null,
            SegmentSegmentProperty2Value segmentProperty2Value = null,
            SegmentSegmentProperty3Value segmentProperty3Value = null,
            SegmentSegmentProperty4Value segmentProperty4Value = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            List<Models.SegmentPrice> prices = null)
        {
            this.Id = id;
            this.ComponentId = componentId;
            this.PricePointId = pricePointId;
            this.EventBasedBillingMetricId = eventBasedBillingMetricId;
            this.PricingScheme = pricingScheme;
            this.SegmentProperty1Value = segmentProperty1Value;
            this.SegmentProperty2Value = segmentProperty2Value;
            this.SegmentProperty3Value = segmentProperty3Value;
            this.SegmentProperty4Value = segmentProperty4Value;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Prices = prices;
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
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets EventBasedBillingMetricId.
        /// </summary>
        [JsonProperty("event_based_billing_metric_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventBasedBillingMetricId { get; set; }

        /// <summary>
        /// The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes.
        /// </summary>
        [JsonProperty("pricing_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricingScheme? PricingScheme { get; set; }

        /// <summary>
        /// Gets or sets SegmentProperty1Value.
        /// </summary>
        [JsonProperty("segment_property_1_value", NullValueHandling = NullValueHandling.Ignore)]
        public SegmentSegmentProperty1Value SegmentProperty1Value { get; set; }

        /// <summary>
        /// Gets or sets SegmentProperty2Value.
        /// </summary>
        [JsonProperty("segment_property_2_value", NullValueHandling = NullValueHandling.Ignore)]
        public SegmentSegmentProperty2Value SegmentProperty2Value { get; set; }

        /// <summary>
        /// Gets or sets SegmentProperty3Value.
        /// </summary>
        [JsonProperty("segment_property_3_value", NullValueHandling = NullValueHandling.Ignore)]
        public SegmentSegmentProperty3Value SegmentProperty3Value { get; set; }

        /// <summary>
        /// Gets or sets SegmentProperty4Value.
        /// </summary>
        [JsonProperty("segment_property_4_value", NullValueHandling = NullValueHandling.Ignore)]
        public SegmentSegmentProperty4Value SegmentProperty4Value { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Prices.
        /// </summary>
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SegmentPrice> Prices { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Segment : ({string.Join(", ", toStringOutput)})";
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
            return obj is Segment other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.EventBasedBillingMetricId == null && other.EventBasedBillingMetricId == null) || (this.EventBasedBillingMetricId?.Equals(other.EventBasedBillingMetricId) == true)) &&
                ((this.PricingScheme == null && other.PricingScheme == null) || (this.PricingScheme?.Equals(other.PricingScheme) == true)) &&
                ((this.SegmentProperty1Value == null && other.SegmentProperty1Value == null) || (this.SegmentProperty1Value?.Equals(other.SegmentProperty1Value) == true)) &&
                ((this.SegmentProperty2Value == null && other.SegmentProperty2Value == null) || (this.SegmentProperty2Value?.Equals(other.SegmentProperty2Value) == true)) &&
                ((this.SegmentProperty3Value == null && other.SegmentProperty3Value == null) || (this.SegmentProperty3Value?.Equals(other.SegmentProperty3Value) == true)) &&
                ((this.SegmentProperty4Value == null && other.SegmentProperty4Value == null) || (this.SegmentProperty4Value?.Equals(other.SegmentProperty4Value) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Prices == null && other.Prices == null) || (this.Prices?.Equals(other.Prices) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.EventBasedBillingMetricId = {(this.EventBasedBillingMetricId == null ? "null" : this.EventBasedBillingMetricId.ToString())}");
            toStringOutput.Add($"this.PricingScheme = {(this.PricingScheme == null ? "null" : this.PricingScheme.ToString())}");
            toStringOutput.Add($"SegmentProperty1Value = {(this.SegmentProperty1Value == null ? "null" : this.SegmentProperty1Value.ToString())}");
            toStringOutput.Add($"SegmentProperty2Value = {(this.SegmentProperty2Value == null ? "null" : this.SegmentProperty2Value.ToString())}");
            toStringOutput.Add($"SegmentProperty3Value = {(this.SegmentProperty3Value == null ? "null" : this.SegmentProperty3Value.ToString())}");
            toStringOutput.Add($"SegmentProperty4Value = {(this.SegmentProperty4Value == null ? "null" : this.SegmentProperty4Value.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Prices = {(this.Prices == null ? "null" : $"[{string.Join(", ", this.Prices)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}