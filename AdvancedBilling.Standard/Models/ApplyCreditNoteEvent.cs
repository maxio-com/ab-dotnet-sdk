// <copyright file="ApplyCreditNoteEvent.cs" company="APIMatic">
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
    /// ApplyCreditNoteEvent.
    /// </summary>
    public class ApplyCreditNoteEvent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyCreditNoteEvent"/> class.
        /// </summary>
        public ApplyCreditNoteEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyCreditNoteEvent"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="invoice">invoice.</param>
        /// <param name="eventType">event_type.</param>
        /// <param name="eventData">event_data.</param>
        public ApplyCreditNoteEvent(
            long id,
            DateTimeOffset timestamp,
            Models.Invoice invoice,
            Models.InvoiceEventType eventType,
            Models.ApplyCreditNoteEventData eventData)
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
        [JsonProperty("id")]
        [JsonRequired]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp")]
        [JsonRequired]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Gets or sets Invoice.
        /// </summary>
        [JsonProperty("invoice")]
        [JsonRequired]
        public Models.Invoice Invoice { get; set; }

        /// <summary>
        /// Gets or sets EventType.
        /// </summary>
        [JsonProperty("event_type")]
        [JsonRequired]
        public Models.InvoiceEventType EventType { get; set; }

        /// <summary>
        /// Example schema for an `apply_credit_note` event
        /// </summary>
        [JsonProperty("event_data")]
        [JsonRequired]
        public Models.ApplyCreditNoteEventData EventData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplyCreditNoteEvent : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplyCreditNoteEvent other &&                this.Id.Equals(other.Id) &&
                this.Timestamp.Equals(other.Timestamp) &&
                ((this.Invoice == null && other.Invoice == null) || (this.Invoice?.Equals(other.Invoice) == true)) &&
                this.EventType.Equals(other.EventType) &&
                ((this.EventData == null && other.EventData == null) || (this.EventData?.Equals(other.EventData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Timestamp = {this.Timestamp}");
            toStringOutput.Add($"this.Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");
            toStringOutput.Add($"this.EventType = {this.EventType}");
            toStringOutput.Add($"this.EventData = {(this.EventData == null ? "null" : this.EventData.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}