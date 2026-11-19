// <copyright file="WalletRecurringFunding.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletRecurringFunding.
    /// </summary>
    public class WalletRecurringFunding : BaseModel
    {
        private string allowance;
        private DateTimeOffset? nextGrantAt;
        private DateTime? nextGrantOn;
        private Models.Reason? reason;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "allowance", false },
            { "next_grant_at", false },
            { "next_grant_on", false },
            { "reason", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletRecurringFunding"/> class.
        /// </summary>
        public WalletRecurringFunding()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletRecurringFunding"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entitlementId">entitlement_id.</param>
        /// <param name="allowance">allowance.</param>
        /// <param name="nextGrantAt">next_grant_at.</param>
        /// <param name="nextGrantOn">next_grant_on.</param>
        /// <param name="skippedPeriods">skipped_periods.</param>
        /// <param name="status">status.</param>
        /// <param name="reason">reason.</param>
        public WalletRecurringFunding(
            int? id = null,
            int? entitlementId = null,
            string allowance = null,
            DateTimeOffset? nextGrantAt = null,
            DateTime? nextGrantOn = null,
            int? skippedPeriods = null,
            Models.WalletRecurringFundingStatus? status = null,
            Models.Reason? reason = null)
        {
            this.Id = id;
            this.EntitlementId = entitlementId;

            if (allowance != null)
            {
                this.Allowance = allowance;
            }

            if (nextGrantAt != null)
            {
                this.NextGrantAt = nextGrantAt;
            }

            if (nextGrantOn != null)
            {
                this.NextGrantOn = nextGrantOn;
            }
            this.SkippedPeriods = skippedPeriods;
            this.Status = status;

            if (reason != null)
            {
                this.Reason = reason;
            }
        }

        /// <summary>
        /// The Advanced Billing id of the recurring funding schedule.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The usage-limit entitlement this schedule reads its allowance and cadence from.
        /// </summary>
        [JsonProperty("entitlement_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? EntitlementId { get; set; }

        /// <summary>
        /// The entitlement's current allowance, read fresh at request time rather than stored on the wallet. Editing the entitlement changes this immediately, with no separate sync step. `"0"` means the entitlement is configured to grant nothing, a valid, working configuration and not an error. `null` when `status` is `stopped`, since there is no longer an entitlement to read.
        /// </summary>
        [JsonProperty("allowance")]
        public string Allowance
        {
            get
            {
                return this.allowance;
            }

            set
            {
                this.shouldSerialize["allowance"] = true;
                this.allowance = value;
            }
        }

        /// <summary>
        /// When the next automatic grant is due. Grants are applied by a background process shortly after this moment passes, not exactly on it, so a wallet read taken in that window still shows the pre-grant balance. `null` when `status` is `stopped`, and also `null` once the owning subscription has terminated, even while `status` is still `active`: at its next due moment the schedule is stopped with reason `subscription_terminated`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_grant_at")]
        public DateTimeOffset? NextGrantAt
        {
            get
            {
                return this.nextGrantAt;
            }

            set
            {
                this.shouldSerialize["next_grant_at"] = true;
                this.nextGrantAt = value;
            }
        }

        /// <summary>
        /// The calendar day `next_grant_at` falls on, resolved in the site's time zone. `null` under the same conditions as `next_grant_at`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("next_grant_on")]
        public DateTime? NextGrantOn
        {
            get
            {
                return this.nextGrantOn;
            }

            set
            {
                this.shouldSerialize["next_grant_on"] = true;
                this.nextGrantOn = value;
            }
        }

        /// <summary>
        /// Cumulative count of due moments that passed without a grant being made (for example, during an outage). A gap in funding is visible here without cross-referencing the ledger.
        /// </summary>
        [JsonProperty("skipped_periods", NullValueHandling = NullValueHandling.Ignore)]
        public int? SkippedPeriods { get; set; }

        /// <summary>
        /// `active`: refilling normally. `erroring`: the schedule is still due and retrying, but the last attempt couldn't be written (see `reason`); correcting the underlying entitlement resumes funding on the next run with no action needed on the wallet itself. `stopped`: funding has ended for good (see `reason`); units already granted stay on the wallet and remain spendable, but no further automatic grants will be made.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WalletRecurringFundingStatus? Status { get; set; }

        /// <summary>
        /// Set whenever `status` isn't `active`. Accompanying `stopped`: `entitlement_missing` (an ordinary product or component change removed the entitlement), `wallet_archived` (the wallet was archived), `subscription_terminated` (the subscription reached a terminal state; funding resumes if the subscription returns to a granting state, for example on reactivation, without back-granting the periods it missed), `feature_removed` (the subscription no longer has this Feature), `wallet_behavior_disabled` (the Feature no longer has `wallet_behavior` configured), `superseded_by_replacement` (a later entitlement now funds this wallet instead), or `subscription_prepaid` (the subscription switched to prepaid, which cannot carry an active wallet). Accompanying `erroring`: `allowance_not_representable` (the entitlement's current allowance doesn't fit the wallet's amount encoding) or `balance_at_capacity` (granting it would push the balance past the maximum supported value).
        /// </summary>
        [JsonProperty("reason")]
        public Models.Reason? Reason
        {
            get
            {
                return this.reason;
            }

            set
            {
                this.shouldSerialize["reason"] = true;
                this.reason = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletRecurringFunding : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAllowance()
        {
            this.shouldSerialize["allowance"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNextGrantAt()
        {
            this.shouldSerialize["next_grant_at"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNextGrantOn()
        {
            this.shouldSerialize["next_grant_on"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReason()
        {
            this.shouldSerialize["reason"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowance()
        {
            return this.shouldSerialize["allowance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextGrantAt()
        {
            return this.shouldSerialize["next_grant_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextGrantOn()
        {
            return this.shouldSerialize["next_grant_on"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReason()
        {
            return this.shouldSerialize["reason"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletRecurringFunding other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.EntitlementId == null && other.EntitlementId == null ||
                 this.EntitlementId?.Equals(other.EntitlementId) == true) &&
                (this.Allowance == null && other.Allowance == null ||
                 this.Allowance?.Equals(other.Allowance) == true) &&
                (this.NextGrantAt == null && other.NextGrantAt == null ||
                 this.NextGrantAt?.Equals(other.NextGrantAt) == true) &&
                (this.NextGrantOn == null && other.NextGrantOn == null ||
                 this.NextGrantOn?.Equals(other.NextGrantOn) == true) &&
                (this.SkippedPeriods == null && other.SkippedPeriods == null ||
                 this.SkippedPeriods?.Equals(other.SkippedPeriods) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"EntitlementId = {(this.EntitlementId == null ? "null" : this.EntitlementId.ToString())}");
            toStringOutput.Add($"Allowance = {this.Allowance ?? "null"}");
            toStringOutput.Add($"NextGrantAt = {(this.NextGrantAt == null ? "null" : this.NextGrantAt.ToString())}");
            toStringOutput.Add($"NextGrantOn = {(this.NextGrantOn == null ? "null" : this.NextGrantOn.ToString())}");
            toStringOutput.Add($"SkippedPeriods = {(this.SkippedPeriods == null ? "null" : this.SkippedPeriods.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"Reason = {(this.Reason == null ? "null" : this.Reason.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}