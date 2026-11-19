// <copyright file="WalletGrant.cs" company="APIMatic">
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
    /// WalletGrant.
    /// </summary>
    public class WalletGrant : BaseModel
    {
        private DateTimeOffset? expiresAt;
        private DateTime? expiresOn;
        private DateTimeOffset? expiredAt;
        private DateTime? expiredOn;
        private DateTimeOffset? grantedForPeriodStart;
        private string invoiceUid;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "expires_at", false },
            { "expires_on", false },
            { "expired_at", false },
            { "expired_on", false },
            { "granted_for_period_start", false },
            { "invoice_uid", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletGrant"/> class.
        /// </summary>
        public WalletGrant()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletGrant"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="original">original.</param>
        /// <param name="remaining">remaining.</param>
        /// <param name="postedRemaining">posted_remaining.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="expiresOn">expires_on.</param>
        /// <param name="expiredAt">expired_at.</param>
        /// <param name="expiredOn">expired_on.</param>
        /// <param name="origin">origin.</param>
        /// <param name="grantedForPeriodStart">granted_for_period_start.</param>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="createdAt">created_at.</param>
        public WalletGrant(
            int? id = null,
            string name = null,
            string original = null,
            string remaining = null,
            string postedRemaining = null,
            DateTimeOffset? expiresAt = null,
            DateTime? expiresOn = null,
            DateTimeOffset? expiredAt = null,
            DateTime? expiredOn = null,
            Models.Origin? origin = null,
            DateTimeOffset? grantedForPeriodStart = null,
            string invoiceUid = null,
            DateTimeOffset? createdAt = null)
        {
            this.Id = id;
            this.Name = name;
            this.Original = original;
            this.Remaining = remaining;
            this.PostedRemaining = postedRemaining;

            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }

            if (expiresOn != null)
            {
                this.ExpiresOn = expiresOn;
            }

            if (expiredAt != null)
            {
                this.ExpiredAt = expiredAt;
            }

            if (expiredOn != null)
            {
                this.ExpiredOn = expiredOn;
            }
            this.Origin = origin;

            if (grantedForPeriodStart != null)
            {
                this.GrantedForPeriodStart = grantedForPeriodStart;
            }

            if (invoiceUid != null)
            {
                this.InvoiceUid = invoiceUid;
            }
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// The Advanced Billing id of the grant.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The memo the grant was created with, or `Grant
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The amount the grant was created with, encoded as a decimal string. Never changes after creation.
        /// </summary>
        [JsonProperty("original", NullValueHandling = NullValueHandling.Ignore)]
        public string Original { get; set; }

        /// <summary>
        /// What the grant can still spend, encoded as a decimal string. On [Read Wallet]($e/Wallets/readWallet) for a metered wallet whose `balance` is the live figure, this is `posted_remaining` less the pending usage drawn from this grant in drain order: usage past a grant spills to the next one, and usage past every grant is an overdraft that belongs to no grant. It never goes below zero, and the grants' `remaining` add up to the wallet's `balance` whenever `balance` is zero or more. Everywhere else it equals `posted_remaining`.
        /// </summary>
        [JsonProperty("remaining", NullValueHandling = NullValueHandling.Ignore)]
        public string Remaining { get; set; }

        /// <summary>
        /// The grant's remainder from written ledger entries alone, encoded as a decimal string. Always present. This is the figure an adjustment checks `expected_remaining` and its bounds against, so send it back, not `remaining`, when correcting a grant.
        /// </summary>
        [JsonProperty("posted_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public string PostedRemaining { get; set; }

        /// <summary>
        /// When this grant's unconsumed remainder is automatically written off. `null` for an evergreen grant.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTimeOffset? ExpiresAt
        {
            get
            {
                return this.expiresAt;
            }

            set
            {
                this.shouldSerialize["expires_at"] = true;
                this.expiresAt = value;
            }
        }

        /// <summary>
        /// The calendar day `expires_at` falls on, already resolved in the site's time zone.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("expires_on")]
        public DateTime? ExpiresOn
        {
            get
            {
                return this.expiresOn;
            }

            set
            {
                this.shouldSerialize["expires_on"] = true;
                this.expiresOn = value;
            }
        }

        /// <summary>
        /// When the expiry sweep actually wrote this grant's remainder off. Usually falls shortly after `expires_at`; use `expires_on` for the date the grant expired, not this field. `null` if the grant was never written off (including a grant simply spent to zero before its `expires_at`).
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expired_at")]
        public DateTimeOffset? ExpiredAt
        {
            get
            {
                return this.expiredAt;
            }

            set
            {
                this.shouldSerialize["expired_at"] = true;
                this.expiredAt = value;
            }
        }

        /// <summary>
        /// The calendar day `expired_at` falls on, resolved in the site's time zone.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("expired_on")]
        public DateTime? ExpiredOn
        {
            get
            {
                return this.expiredOn;
            }

            set
            {
                this.shouldSerialize["expired_on"] = true;
                this.expiredOn = value;
            }
        }

        /// <summary>
        /// How the grant was created. `recurring` comes from the wallet's automatic funding schedule (see the wallet's `recurring_funding` array). `manual` comes from a one-time grant posted to [Create Wallet Transaction]($e/Wallet%20Transactions/createWalletTransaction). `initial_balance` comes from a non-zero `initial_balance` at wallet creation. `allowance_increase` comes from raising a funding entitlement's allowance while it's already funding a wallet. `purchase` comes from [Create Wallet Purchase]($e/Wallet%20Purchases/createWalletPurchase).
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Origin? Origin { get; set; }

        /// <summary>
        /// For a `recurring` grant, the start of the funding cadence period this grant covers. `null` for every other origin. After a gap in funding (see `skipped_periods`), this is the period currently in progress, not the oldest period that was missed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("granted_for_period_start")]
        public DateTimeOffset? GrantedForPeriodStart
        {
            get
            {
                return this.grantedForPeriodStart;
            }

            set
            {
                this.shouldSerialize["granted_for_period_start"] = true;
                this.grantedForPeriodStart = value;
            }
        }

        /// <summary>
        /// The uid of the invoice that paid for this grant, for a grant with `origin` of `purchase`. `null` for every other origin.
        /// </summary>
        [JsonProperty("invoice_uid")]
        public string InvoiceUid
        {
            get
            {
                return this.invoiceUid;
            }

            set
            {
                this.shouldSerialize["invoice_uid"] = true;
                this.invoiceUid = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletGrant : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiresOn()
        {
            this.shouldSerialize["expires_on"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiredAt()
        {
            this.shouldSerialize["expired_at"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiredOn()
        {
            this.shouldSerialize["expired_on"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGrantedForPeriodStart()
        {
            this.shouldSerialize["granted_for_period_start"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInvoiceUid()
        {
            this.shouldSerialize["invoice_uid"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return this.shouldSerialize["expires_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiresOn()
        {
            return this.shouldSerialize["expires_on"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiredAt()
        {
            return this.shouldSerialize["expired_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiredOn()
        {
            return this.shouldSerialize["expired_on"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrantedForPeriodStart()
        {
            return this.shouldSerialize["granted_for_period_start"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceUid()
        {
            return this.shouldSerialize["invoice_uid"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletGrant other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Original == null && other.Original == null ||
                 this.Original?.Equals(other.Original) == true) &&
                (this.Remaining == null && other.Remaining == null ||
                 this.Remaining?.Equals(other.Remaining) == true) &&
                (this.PostedRemaining == null && other.PostedRemaining == null ||
                 this.PostedRemaining?.Equals(other.PostedRemaining) == true) &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                (this.ExpiresOn == null && other.ExpiresOn == null ||
                 this.ExpiresOn?.Equals(other.ExpiresOn) == true) &&
                (this.ExpiredAt == null && other.ExpiredAt == null ||
                 this.ExpiredAt?.Equals(other.ExpiredAt) == true) &&
                (this.ExpiredOn == null && other.ExpiredOn == null ||
                 this.ExpiredOn?.Equals(other.ExpiredOn) == true) &&
                (this.Origin == null && other.Origin == null ||
                 this.Origin?.Equals(other.Origin) == true) &&
                (this.GrantedForPeriodStart == null && other.GrantedForPeriodStart == null ||
                 this.GrantedForPeriodStart?.Equals(other.GrantedForPeriodStart) == true) &&
                (this.InvoiceUid == null && other.InvoiceUid == null ||
                 this.InvoiceUid?.Equals(other.InvoiceUid) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Original = {this.Original ?? "null"}");
            toStringOutput.Add($"Remaining = {this.Remaining ?? "null"}");
            toStringOutput.Add($"PostedRemaining = {this.PostedRemaining ?? "null"}");
            toStringOutput.Add($"ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"ExpiresOn = {(this.ExpiresOn == null ? "null" : this.ExpiresOn.ToString())}");
            toStringOutput.Add($"ExpiredAt = {(this.ExpiredAt == null ? "null" : this.ExpiredAt.ToString())}");
            toStringOutput.Add($"ExpiredOn = {(this.ExpiredOn == null ? "null" : this.ExpiredOn.ToString())}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
            toStringOutput.Add($"GrantedForPeriodStart = {(this.GrantedForPeriodStart == null ? "null" : this.GrantedForPeriodStart.ToString())}");
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}