// <copyright file="InvoiceEvent.cs" company="APIMatic">
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
    /// InvoiceEvent.
    /// </summary>
    public class InvoiceEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEvent"/> class.
        /// </summary>
        public InvoiceEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEvent"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="eventType">event_type.</param>
        /// <param name="eventData">event_data.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="invoice">invoice.</param>
        public InvoiceEvent(
            int? id = null,
            Models.InvoiceEventType? eventType = null,
            InvoiceEventEventData eventData = null,
            string timestamp = null,
            Models.Invoice invoice = null)
        {
            this.Id = id;
            this.EventType = eventType;
            this.EventData = eventData;
            this.Timestamp = timestamp;
            this.Invoice = invoice;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Invoice Event Type
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceEventType? EventType { get; set; }

        /// <summary>
        /// The event data is the data that, when combined with the command, results in the output invoice found in the invoice field.
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public InvoiceEventEventData EventData { get; set; }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or sets Invoice.
        /// </summary>
        [JsonProperty("invoice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Invoice Invoice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceEvent : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceEvent other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.EventData == null && other.EventData == null) || (this.EventData?.Equals(other.EventData) == true)) &&
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.Invoice == null && other.Invoice == null) || (this.Invoice?.Equals(other.Invoice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType.ToString())}");
            toStringOutput.Add($"EventData = {(this.EventData == null ? "null" : this.EventData.ToString())}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp)}");
            toStringOutput.Add($"this.Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");
        }
    }
}