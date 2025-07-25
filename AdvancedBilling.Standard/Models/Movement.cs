// <copyright file="Movement.cs" company="APIMatic">
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
    /// Movement.
    /// </summary>
    public class Movement : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Movement"/> class.
        /// </summary>
        public Movement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Movement"/> class.
        /// </summary>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="amountFormatted">amount_formatted.</param>
        /// <param name="description">description.</param>
        /// <param name="category">category.</param>
        /// <param name="breakouts">breakouts.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="subscriberName">subscriber_name.</param>
        public Movement(
            DateTimeOffset? timestamp = null,
            long? amountInCents = null,
            string amountFormatted = null,
            string description = null,
            string category = null,
            Models.Breakouts breakouts = null,
            List<Models.MovementLineItem> lineItems = null,
            int? subscriptionId = null,
            string subscriberName = null)
        {
            this.Timestamp = timestamp;
            this.AmountInCents = amountInCents;
            this.AmountFormatted = amountFormatted;
            this.Description = description;
            this.Category = category;
            this.Breakouts = breakouts;
            this.LineItems = lineItems;
            this.SubscriptionId = subscriptionId;
            this.SubscriberName = subscriberName;
        }

        /// <summary>
        /// Gets or sets Timestamp.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets AmountFormatted.
        /// </summary>
        [JsonProperty("amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string AmountFormatted { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets Breakouts.
        /// </summary>
        [JsonProperty("breakouts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Breakouts Breakouts { get; set; }

        /// <summary>
        /// Gets or sets LineItems.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MovementLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets SubscriberName.
        /// </summary>
        [JsonProperty("subscriber_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriberName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Movement : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Movement other &&
                (this.Timestamp == null && other.Timestamp == null ||
                 this.Timestamp?.Equals(other.Timestamp) == true) &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.AmountFormatted == null && other.AmountFormatted == null ||
                 this.AmountFormatted?.Equals(other.AmountFormatted) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Category == null && other.Category == null ||
                 this.Category?.Equals(other.Category) == true) &&
                (this.Breakouts == null && other.Breakouts == null ||
                 this.Breakouts?.Equals(other.Breakouts) == true) &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.SubscriberName == null && other.SubscriberName == null ||
                 this.SubscriberName?.Equals(other.SubscriberName) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Timestamp = {(this.Timestamp == null ? "null" : this.Timestamp.ToString())}");
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"AmountFormatted = {this.AmountFormatted ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Category = {this.Category ?? "null"}");
            toStringOutput.Add($"Breakouts = {(this.Breakouts == null ? "null" : this.Breakouts.ToString())}");
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"SubscriberName = {this.SubscriberName ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}