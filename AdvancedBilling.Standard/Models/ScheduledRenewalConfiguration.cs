// <copyright file="ScheduledRenewalConfiguration.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalConfiguration.
    /// </summary>
    public class ScheduledRenewalConfiguration : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfiguration"/> class.
        /// </summary>
        public ScheduledRenewalConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfiguration"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="startsAt">starts_at.</param>
        /// <param name="endsAt">ends_at.</param>
        /// <param name="lockInAt">lock_in_at.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="status">status.</param>
        /// <param name="scheduledRenewalConfigurationItems">scheduled_renewal_configuration_items.</param>
        /// <param name="contract">contract.</param>
        public ScheduledRenewalConfiguration(
            int? id = null,
            int? siteId = null,
            int? subscriptionId = null,
            DateTimeOffset? startsAt = null,
            DateTimeOffset? endsAt = null,
            DateTimeOffset? lockInAt = null,
            DateTimeOffset? createdAt = null,
            string status = null,
            List<Models.ScheduledRenewalConfigurationItem> scheduledRenewalConfigurationItems = null,
            Models.Contract contract = null)
        {
            this.Id = id;
            this.SiteId = siteId;
            this.SubscriptionId = subscriptionId;
            this.StartsAt = startsAt;
            this.EndsAt = endsAt;
            this.LockInAt = lockInAt;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.ScheduledRenewalConfigurationItems = scheduledRenewalConfigurationItems;
            this.Contract = contract;
        }

        /// <summary>
        /// ID of the renewal.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// ID of the site to which the renewal belongs.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// The id of the subscription.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets StartsAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartsAt { get; set; }

        /// <summary>
        /// Gets or sets EndsAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndsAt { get; set; }

        /// <summary>
        /// Gets or sets LockInAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lock_in_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LockInAt { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets ScheduledRenewalConfigurationItems.
        /// </summary>
        [JsonProperty("scheduled_renewal_configuration_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ScheduledRenewalConfigurationItem> ScheduledRenewalConfigurationItems { get; set; }

        /// <summary>
        /// Contract linked to the scheduled renewal configuration.
        /// </summary>
        [JsonProperty("contract", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Contract Contract { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalConfiguration other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.SiteId == null && other.SiteId == null ||
                 this.SiteId?.Equals(other.SiteId) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.StartsAt == null && other.StartsAt == null ||
                 this.StartsAt?.Equals(other.StartsAt) == true) &&
                (this.EndsAt == null && other.EndsAt == null ||
                 this.EndsAt?.Equals(other.EndsAt) == true) &&
                (this.LockInAt == null && other.LockInAt == null ||
                 this.LockInAt?.Equals(other.LockInAt) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.ScheduledRenewalConfigurationItems == null && other.ScheduledRenewalConfigurationItems == null ||
                 this.ScheduledRenewalConfigurationItems?.Equals(other.ScheduledRenewalConfigurationItems) == true) &&
                (this.Contract == null && other.Contract == null ||
                 this.Contract?.Equals(other.Contract) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"StartsAt = {(this.StartsAt == null ? "null" : this.StartsAt.ToString())}");
            toStringOutput.Add($"EndsAt = {(this.EndsAt == null ? "null" : this.EndsAt.ToString())}");
            toStringOutput.Add($"LockInAt = {(this.LockInAt == null ? "null" : this.LockInAt.ToString())}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"Status = {this.Status ?? "null"}");
            toStringOutput.Add($"ScheduledRenewalConfigurationItems = {(this.ScheduledRenewalConfigurationItems == null ? "null" : $"[{string.Join(", ", this.ScheduledRenewalConfigurationItems)} ]")}");
            toStringOutput.Add($"Contract = {(this.Contract == null ? "null" : this.Contract.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}