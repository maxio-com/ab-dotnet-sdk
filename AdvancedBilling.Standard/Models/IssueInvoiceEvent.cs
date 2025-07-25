// <copyright file="IssueInvoiceEvent.cs" company="APIMatic">
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
    /// IssueInvoiceEvent.
    /// </summary>
    public class IssueInvoiceEvent : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueInvoiceEvent"/> class.
        /// </summary>
        public IssueInvoiceEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueInvoiceEvent"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="invoice">invoice.</param>
        /// <param name="eventType">event_type.</param>
        /// <param name="eventData">event_data.</param>
        public IssueInvoiceEvent(
            long id,
            DateTimeOffset timestamp,
            Models.Invoice invoice,
            Models.InvoiceEventType eventType,
            Models.IssueInvoiceEventData eventData)
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
        /// Example schema for an `issue_invoice` event
        /// </summary>
        [JsonProperty("event_data")]
        [JsonRequired]
        public Models.IssueInvoiceEventData EventData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IssueInvoiceEvent : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IssueInvoiceEvent other &&
                (this.Id.Equals(other.Id)) &&
                (this.Timestamp.Equals(other.Timestamp)) &&
                (this.Invoice == null && other.Invoice == null ||
                 this.Invoice?.Equals(other.Invoice) == true) &&
                (this.EventType.Equals(other.EventType)) &&
                (this.EventData == null && other.EventData == null ||
                 this.EventData?.Equals(other.EventData) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {this.Id}");
            toStringOutput.Add($"Timestamp = {this.Timestamp}");
            toStringOutput.Add($"Invoice = {(this.Invoice == null ? "null" : this.Invoice.ToString())}");
            toStringOutput.Add($"EventType = {this.EventType}");
            toStringOutput.Add($"EventData = {(this.EventData == null ? "null" : this.EventData.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}