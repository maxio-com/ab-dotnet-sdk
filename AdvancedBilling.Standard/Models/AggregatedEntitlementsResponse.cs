// <copyright file="AggregatedEntitlementsResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// AggregatedEntitlementsResponse.
    /// </summary>
    public class AggregatedEntitlementsResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedEntitlementsResponse"/> class.
        /// </summary>
        public AggregatedEntitlementsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedEntitlementsResponse"/> class.
        /// </summary>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="status">status.</param>
        /// <param name="entitlements">entitlements.</param>
        public AggregatedEntitlementsResponse(
            int subscriptionId,
            int customerId,
            string status,
            List<Models.AggregatedEntitlement> entitlements)
        {
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.Status = status;
            this.Entitlements = entitlements;
        }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id")]
        public int SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        /// <summary>
        /// The subscription's current state, e.g. `active`, `trialing`, `canceled`.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Entitlements.
        /// </summary>
        [JsonProperty("entitlements")]
        public List<Models.AggregatedEntitlement> Entitlements { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AggregatedEntitlementsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AggregatedEntitlementsResponse other &&
                (this.SubscriptionId.Equals(other.SubscriptionId)) &&
                (this.CustomerId.Equals(other.CustomerId)) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Entitlements == null && other.Entitlements == null ||
                 this.Entitlements?.Equals(other.Entitlements) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SubscriptionId = {this.SubscriptionId}");
            toStringOutput.Add($"CustomerId = {this.CustomerId}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"Entitlements = {(this.Entitlements == null ? "null" : $"[{string.Join(", ", this.Entitlements)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}