// <copyright file="ScheduledRenewalConfigurationRequestBody.cs" company="APIMatic">
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
    /// ScheduledRenewalConfigurationRequestBody.
    /// </summary>
    public class ScheduledRenewalConfigurationRequestBody : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationRequestBody"/> class.
        /// </summary>
        public ScheduledRenewalConfigurationRequestBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalConfigurationRequestBody"/> class.
        /// </summary>
        /// <param name="startsAt">starts_at.</param>
        /// <param name="endsAt">ends_at.</param>
        /// <param name="lockInAt">lock_in_at.</param>
        /// <param name="contractId">contract_id.</param>
        /// <param name="createNewContract">create_new_contract.</param>
        public ScheduledRenewalConfigurationRequestBody(
            DateTimeOffset? startsAt = null,
            DateTimeOffset? endsAt = null,
            DateTimeOffset? lockInAt = null,
            int? contractId = null,
            bool? createNewContract = null)
        {
            this.StartsAt = startsAt;
            this.EndsAt = endsAt;
            this.LockInAt = lockInAt;
            this.ContractId = contractId;
            this.CreateNewContract = createNewContract;
        }

        /// <summary>
        /// (Optional) Start of the renewal term.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartsAt { get; set; }

        /// <summary>
        /// (Optional) End of the renewal term.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndsAt { get; set; }

        /// <summary>
        /// (Optional) Lock-in date for the renewal.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lock_in_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LockInAt { get; set; }

        /// <summary>
        /// (Optional) Existing contract to associate with the scheduled renewal. Contracts must be enabled for your site.
        /// </summary>
        [JsonProperty("contract_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractId { get; set; }

        /// <summary>
        /// (Optional) Set to true to create a new contract when contracts are enabled. Contracts must be enabled for your site.
        /// </summary>
        [JsonProperty("create_new_contract", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateNewContract { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalConfigurationRequestBody : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalConfigurationRequestBody other &&
                (this.StartsAt == null && other.StartsAt == null ||
                 this.StartsAt?.Equals(other.StartsAt) == true) &&
                (this.EndsAt == null && other.EndsAt == null ||
                 this.EndsAt?.Equals(other.EndsAt) == true) &&
                (this.LockInAt == null && other.LockInAt == null ||
                 this.LockInAt?.Equals(other.LockInAt) == true) &&
                (this.ContractId == null && other.ContractId == null ||
                 this.ContractId?.Equals(other.ContractId) == true) &&
                (this.CreateNewContract == null && other.CreateNewContract == null ||
                 this.CreateNewContract?.Equals(other.CreateNewContract) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"StartsAt = {(this.StartsAt == null ? "null" : this.StartsAt.ToString())}");
            toStringOutput.Add($"EndsAt = {(this.EndsAt == null ? "null" : this.EndsAt.ToString())}");
            toStringOutput.Add($"LockInAt = {(this.LockInAt == null ? "null" : this.LockInAt.ToString())}");
            toStringOutput.Add($"ContractId = {(this.ContractId == null ? "null" : this.ContractId.ToString())}");
            toStringOutput.Add($"CreateNewContract = {(this.CreateNewContract == null ? "null" : this.CreateNewContract.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}