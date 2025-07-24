// <copyright file="ListSegmentsFilter.cs" company="APIMatic">
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
    /// ListSegmentsFilter.
    /// </summary>
    public class ListSegmentsFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentsFilter"/> class.
        /// </summary>
        public ListSegmentsFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSegmentsFilter"/> class.
        /// </summary>
        /// <param name="segmentProperty1Value">segment_property_1_value.</param>
        /// <param name="segmentProperty2Value">segment_property_2_value.</param>
        /// <param name="segmentProperty3Value">segment_property_3_value.</param>
        /// <param name="segmentProperty4Value">segment_property_4_value.</param>
        public ListSegmentsFilter(
            string segmentProperty1Value = null,
            string segmentProperty2Value = null,
            string segmentProperty3Value = null,
            string segmentProperty4Value = null)
        {
            this.SegmentProperty1Value = segmentProperty1Value;
            this.SegmentProperty2Value = segmentProperty2Value;
            this.SegmentProperty3Value = segmentProperty3Value;
            this.SegmentProperty4Value = segmentProperty4Value;
        }

        /// <summary>
        /// The value passed here would be used to filter segments. Pass a value related to `segment_property_1` on attached Metric. If empty string is passed, this filter would be rejected. Use in query `filter[segment_property_1_value]=EU`.
        /// </summary>
        [JsonProperty("segment_property_1_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SegmentProperty1Value { get; set; }

        /// <summary>
        /// The value passed here would be used to filter segments. Pass a value related to `segment_property_2` on attached Metric. If empty string is passed, this filter would be rejected.
        /// </summary>
        [JsonProperty("segment_property_2_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SegmentProperty2Value { get; set; }

        /// <summary>
        /// The value passed here would be used to filter segments. Pass a value related to `segment_property_3` on attached Metric. If empty string is passed, this filter would be rejected.
        /// </summary>
        [JsonProperty("segment_property_3_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SegmentProperty3Value { get; set; }

        /// <summary>
        /// The value passed here would be used to filter segments. Pass a value related to `segment_property_4` on attached Metric. If empty string is passed, this filter would be rejected.
        /// </summary>
        [JsonProperty("segment_property_4_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SegmentProperty4Value { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSegmentsFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSegmentsFilter other &&
                (this.SegmentProperty1Value == null && other.SegmentProperty1Value == null ||
                 this.SegmentProperty1Value?.Equals(other.SegmentProperty1Value) == true) &&
                (this.SegmentProperty2Value == null && other.SegmentProperty2Value == null ||
                 this.SegmentProperty2Value?.Equals(other.SegmentProperty2Value) == true) &&
                (this.SegmentProperty3Value == null && other.SegmentProperty3Value == null ||
                 this.SegmentProperty3Value?.Equals(other.SegmentProperty3Value) == true) &&
                (this.SegmentProperty4Value == null && other.SegmentProperty4Value == null ||
                 this.SegmentProperty4Value?.Equals(other.SegmentProperty4Value) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SegmentProperty1Value = {this.SegmentProperty1Value ?? "null"}");
            toStringOutput.Add($"SegmentProperty2Value = {this.SegmentProperty2Value ?? "null"}");
            toStringOutput.Add($"SegmentProperty3Value = {this.SegmentProperty3Value ?? "null"}");
            toStringOutput.Add($"SegmentProperty4Value = {this.SegmentProperty4Value ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}