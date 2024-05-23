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
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// InvoiceEvent.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "event_type")]
    public class InvoiceEvent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEvent"/> class.
        /// </summary>
        public InvoiceEvent()
        {
            this.EventType = "Invoice Event";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceEvent"/> class.
        /// </summary>
        /// <param name="eventType">event_type.</param>
        /// <param name="id">id.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="invoice">invoice.</param>
        /// <param name="eventData">event_data.</param>
        public InvoiceEvent(
            string eventType = "Invoice Event",
            long? id = null,
            DateTimeOffset? timestamp = null,
            Models.Invoice1 invoice = null,
            Models.ApplyCreditNoteEventData1 eventData = null)
        {
            this.Id = id;
            this.Timestamp = timestamp;
            this.Invoice = invoice;
            this.EventType = eventType;
            this.EventData = eventData;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets Invoice.
        /// </summary>
        [JsonProperty("invoice", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Invoice1 Invoice { get; set; }

        /// <summary>
        /// Gets or sets EventType.
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// Example schema for an `apply_credit_note` event
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ApplyCreditNoteEventData1 EventData { get; set; }

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
                ((this.Timestamp == null && other.Timestamp == null) || (this.Timestamp?.Equals(other.Timestamp) == true)) &&
                ((this.Invoice == null && other.Invoice == null) || (this.Invoice?.Equals(other.Invoice) == true)) &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.EventData == null && other.EventData == null) || (this.EventData?.Equals(other.EventData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
            toStringOutput.Add($"this.Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType)}");
            toStringOutput.Add($"this.EventData = {(this.EventData == null ? "null" : this.EventData.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}