// <copyright file="CustomFieldValueChange.cs" company="APIMatic">
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
    /// CustomFieldValueChange.
    /// </summary>
    public class CustomFieldValueChange : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldValueChange"/> class.
        /// </summary>
        public CustomFieldValueChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldValueChange"/> class.
        /// </summary>
        /// <param name="eventType">event_type.</param>
        /// <param name="metafieldName">metafield_name.</param>
        /// <param name="metafieldId">metafield_id.</param>
        /// <param name="resourceType">resource_type.</param>
        /// <param name="resourceId">resource_id.</param>
        /// <param name="oldValue">old_value.</param>
        /// <param name="newValue">new_value.</param>
        public CustomFieldValueChange(
            string eventType,
            string metafieldName,
            int metafieldId,
            string resourceType,
            int resourceId,
            string oldValue = null,
            string newValue = null)
        {
            this.EventType = eventType;
            this.MetafieldName = metafieldName;
            this.MetafieldId = metafieldId;
            this.OldValue = oldValue;
            this.NewValue = newValue;
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Gets or sets EventType.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("event_type")]
        [JsonRequired]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets MetafieldName.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("metafield_name")]
        [JsonRequired]
        public string MetafieldName { get; set; }

        /// <summary>
        /// Gets or sets MetafieldId.
        /// </summary>
        [JsonProperty("metafield_id")]
        [JsonRequired]
        public int MetafieldId { get; set; }

        /// <summary>
        /// Gets or sets OldValue.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Include)]
        public string OldValue { get; set; }

        /// <summary>
        /// Gets or sets NewValue.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Include)]
        public string NewValue { get; set; }

        /// <summary>
        /// Gets or sets ResourceType.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("resource_type")]
        [JsonRequired]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets ResourceId.
        /// </summary>
        [JsonProperty("resource_id")]
        [JsonRequired]
        public int ResourceId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomFieldValueChange : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CustomFieldValueChange other &&
                (this.EventType == null && other.EventType == null ||
                 this.EventType?.Equals(other.EventType) == true) &&
                (this.MetafieldName == null && other.MetafieldName == null ||
                 this.MetafieldName?.Equals(other.MetafieldName) == true) &&
                (this.MetafieldId.Equals(other.MetafieldId)) &&
                (this.OldValue == null && other.OldValue == null ||
                 this.OldValue?.Equals(other.OldValue) == true) &&
                (this.NewValue == null && other.NewValue == null ||
                 this.NewValue?.Equals(other.NewValue) == true) &&
                (this.ResourceType == null && other.ResourceType == null ||
                 this.ResourceType?.Equals(other.ResourceType) == true) &&
                (this.ResourceId.Equals(other.ResourceId)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"EventType = {this.EventType ?? "null"}");
            toStringOutput.Add($"MetafieldName = {this.MetafieldName ?? "null"}");
            toStringOutput.Add($"MetafieldId = {this.MetafieldId}");
            toStringOutput.Add($"OldValue = {this.OldValue ?? "null"}");
            toStringOutput.Add($"NewValue = {this.NewValue ?? "null"}");
            toStringOutput.Add($"ResourceType = {this.ResourceType ?? "null"}");
            toStringOutput.Add($"ResourceId = {this.ResourceId}");

            base.ToString(toStringOutput);
        }
    }
}