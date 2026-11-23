// <copyright file="WalletTransaction.cs" company="APIMatic">
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
    /// WalletTransaction.
    /// </summary>
    public class WalletTransaction : BaseModel
    {
        private int? grantId;
        private int? sourceTransactionId;
        private string sourceCorrectionsTotal;
        private DateTimeOffset? meteredFromAt;
        private DateTimeOffset? meteredThroughAt;
        private string conversionRateApplied;
        private string invoiceUid;
        private string memo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "grant_id", false },
            { "source_transaction_id", false },
            { "source_corrections_total", false },
            { "metered_from_at", false },
            { "metered_through_at", false },
            { "conversion_rate_applied", false },
            { "invoice_uid", false },
            { "memo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransaction"/> class.
        /// </summary>
        public WalletTransaction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransaction"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="walletId">wallet_id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="amount">amount.</param>
        /// <param name="grantId">grant_id.</param>
        /// <param name="sourceTransactionId">source_transaction_id.</param>
        /// <param name="sourceCorrectionsTotal">source_corrections_total.</param>
        /// <param name="balanceAfter">balance_after.</param>
        /// <param name="meteredFromAt">metered_from_at.</param>
        /// <param name="meteredThroughAt">metered_through_at.</param>
        /// <param name="conversionRateApplied">conversion_rate_applied.</param>
        /// <param name="invoiceUid">invoice_uid.</param>
        /// <param name="memo">memo.</param>
        /// <param name="createdAt">created_at.</param>
        public WalletTransaction(
            int? id = null,
            int? walletId = null,
            string kind = null,
            string amount = null,
            int? grantId = null,
            int? sourceTransactionId = null,
            string sourceCorrectionsTotal = null,
            string balanceAfter = null,
            DateTimeOffset? meteredFromAt = null,
            DateTimeOffset? meteredThroughAt = null,
            string conversionRateApplied = null,
            string invoiceUid = null,
            string memo = null,
            DateTimeOffset? createdAt = null)
        {
            this.Id = id;
            this.WalletId = walletId;
            this.Kind = kind;
            this.Amount = amount;

            if (grantId != null)
            {
                this.GrantId = grantId;
            }

            if (sourceTransactionId != null)
            {
                this.SourceTransactionId = sourceTransactionId;
            }

            if (sourceCorrectionsTotal != null)
            {
                this.SourceCorrectionsTotal = sourceCorrectionsTotal;
            }
            this.BalanceAfter = balanceAfter;

            if (meteredFromAt != null)
            {
                this.MeteredFromAt = meteredFromAt;
            }

            if (meteredThroughAt != null)
            {
                this.MeteredThroughAt = meteredThroughAt;
            }

            if (conversionRateApplied != null)
            {
                this.ConversionRateApplied = conversionRateApplied;
            }

            if (invoiceUid != null)
            {
                this.InvoiceUid = invoiceUid;
            }

            if (memo != null)
            {
                this.Memo = memo;
            }
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// The Advanced Billing id of the ledger row.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets WalletId.
        /// </summary>
        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? WalletId { get; set; }

        /// <summary>
        /// The kind of ledger row. Known values: `grant`, `debit`, `adjustment`, `initial_balance`, and `expiration`. More kinds are expected over time, so treat this as an open string and don't fail on one you don't recognize. Only `grant` and `debit` are accepted on [Create Wallet Transaction]($e/Wallet%20Transactions/createWalletTransaction). `adjustment` rows are written by [Create Wallet Adjustment]($e/Wallet%20Adjustments/createWalletAdjustment), `initial_balance` rows only by a seeded [Create Wallet]($e/Wallets/createWallet), and `expiration` rows only by the automatic expiry sweep that writes off an unconsumed grant once its `expires_at` passes.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// A decimal string, **signed** on this resource. Non-negative for grants, negative for debits and expirations, either sign for adjustments. A grant row written after an overdraft repayment carries only what was left after the repayment (possibly `"0.0"`), not the grant's `original`.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// The grant this row is attributed to. `null` for an overdraft row (a `kind: debit` row draining the below-zero portion of a balance, attributed to no grant), for an overdraft-repayment row (the `kind: grant` row that pays an existing negative balance back to zero, written before any remainder becomes a new grant), and for an overdraft correction (a `kind: adjustment` row posted against an overdraft entry, which credits no grant).
        /// </summary>
        [JsonProperty("grant_id")]
        public int? GrantId
        {
            get
            {
                return this.grantId;
            }

            set
            {
                this.shouldSerialize["grant_id"] = true;
                this.grantId = value;
            }
        }

        /// <summary>
        /// For an `adjustment` row posted against a specific usage entry, the id of the `debit` row it corrects. `null` for every other kind, and for adjustments made against a grant's balance directly.
        /// </summary>
        [JsonProperty("source_transaction_id")]
        public int? SourceTransactionId
        {
            get
            {
                return this.sourceTransactionId;
            }

            set
            {
                this.shouldSerialize["source_transaction_id"] = true;
                this.sourceTransactionId = value;
            }
        }

        /// <summary>
        /// For a `debit` row only, the signed sum (as a decimal string) of every adjustment posted against it so far (`"0.0"` when none). `null` for every other kind. The row's own `amount` is never rewritten, so a caller deriving the entry's corrected quantity nets this out of `amount`, and sends this value back as `expected_source_corrections` on a further correction.
        /// </summary>
        [JsonProperty("source_corrections_total")]
        public string SourceCorrectionsTotal
        {
            get
            {
                return this.sourceCorrectionsTotal;
            }

            set
            {
                this.shouldSerialize["source_corrections_total"] = true;
                this.sourceCorrectionsTotal = value;
            }
        }

        /// <summary>
        /// The wallet's posted balance immediately after this row was applied, as a decimal string. Compare it with the wallet's `posted_balance`, not its `balance`.
        /// </summary>
        [JsonProperty("balance_after", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceAfter { get; set; }

        /// <summary>
        /// For a row that closed a metered usage window (an hourly close, a depletion, or an expiry write-off), the start of that window. `null` on every other row.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("metered_from_at")]
        public DateTimeOffset? MeteredFromAt
        {
            get
            {
                return this.meteredFromAt;
            }

            set
            {
                this.shouldSerialize["metered_from_at"] = true;
                this.meteredFromAt = value;
            }
        }

        /// <summary>
        /// The end of the usage window this row closed. `null` on every other row.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("metered_through_at")]
        public DateTimeOffset? MeteredThroughAt
        {
            get
            {
                return this.meteredThroughAt;
            }

            set
            {
                this.shouldSerialize["metered_through_at"] = true;
                this.meteredThroughAt = value;
            }
        }

        /// <summary>
        /// The meter-to-wallet-unit conversion rate applied to compute this row's `amount`, as a decimal string. `null` on every other row.
        /// </summary>
        [JsonProperty("conversion_rate_applied")]
        public string ConversionRateApplied
        {
            get
            {
                return this.conversionRateApplied;
            }

            set
            {
                this.shouldSerialize["conversion_rate_applied"] = true;
                this.conversionRateApplied = value;
            }
        }

        /// <summary>
        /// The uid of the invoice behind a purchase's rows: the grant-creating row and, when the purchase repaid an overdraft, the repayment row. `null` on every other row.
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
        /// Free-text note. For an `adjustment` row, carries the required `reason`.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo
        {
            get
            {
                return this.memo;
            }

            set
            {
                this.shouldSerialize["memo"] = true;
                this.memo = value;
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
            return $"WalletTransaction : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetGrantId()
        {
            this.shouldSerialize["grant_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSourceTransactionId()
        {
            this.shouldSerialize["source_transaction_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSourceCorrectionsTotal()
        {
            this.shouldSerialize["source_corrections_total"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMeteredFromAt()
        {
            this.shouldSerialize["metered_from_at"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMeteredThroughAt()
        {
            this.shouldSerialize["metered_through_at"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetConversionRateApplied()
        {
            this.shouldSerialize["conversion_rate_applied"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetInvoiceUid()
        {
            this.shouldSerialize["invoice_uid"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrantId()
        {
            return this.shouldSerialize["grant_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSourceTransactionId()
        {
            return this.shouldSerialize["source_transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSourceCorrectionsTotal()
        {
            return this.shouldSerialize["source_corrections_total"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMeteredFromAt()
        {
            return this.shouldSerialize["metered_from_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMeteredThroughAt()
        {
            return this.shouldSerialize["metered_through_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeConversionRateApplied()
        {
            return this.shouldSerialize["conversion_rate_applied"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceUid()
        {
            return this.shouldSerialize["invoice_uid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletTransaction other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.WalletId == null && other.WalletId == null ||
                 this.WalletId?.Equals(other.WalletId) == true) &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.GrantId == null && other.GrantId == null ||
                 this.GrantId?.Equals(other.GrantId) == true) &&
                (this.SourceTransactionId == null && other.SourceTransactionId == null ||
                 this.SourceTransactionId?.Equals(other.SourceTransactionId) == true) &&
                (this.SourceCorrectionsTotal == null && other.SourceCorrectionsTotal == null ||
                 this.SourceCorrectionsTotal?.Equals(other.SourceCorrectionsTotal) == true) &&
                (this.BalanceAfter == null && other.BalanceAfter == null ||
                 this.BalanceAfter?.Equals(other.BalanceAfter) == true) &&
                (this.MeteredFromAt == null && other.MeteredFromAt == null ||
                 this.MeteredFromAt?.Equals(other.MeteredFromAt) == true) &&
                (this.MeteredThroughAt == null && other.MeteredThroughAt == null ||
                 this.MeteredThroughAt?.Equals(other.MeteredThroughAt) == true) &&
                (this.ConversionRateApplied == null && other.ConversionRateApplied == null ||
                 this.ConversionRateApplied?.Equals(other.ConversionRateApplied) == true) &&
                (this.InvoiceUid == null && other.InvoiceUid == null ||
                 this.InvoiceUid?.Equals(other.InvoiceUid) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
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
            toStringOutput.Add($"WalletId = {(this.WalletId == null ? "null" : this.WalletId.ToString())}");
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Amount = {this.Amount ?? "null"}");
            toStringOutput.Add($"GrantId = {(this.GrantId == null ? "null" : this.GrantId.ToString())}");
            toStringOutput.Add($"SourceTransactionId = {(this.SourceTransactionId == null ? "null" : this.SourceTransactionId.ToString())}");
            toStringOutput.Add($"SourceCorrectionsTotal = {this.SourceCorrectionsTotal ?? "null"}");
            toStringOutput.Add($"BalanceAfter = {this.BalanceAfter ?? "null"}");
            toStringOutput.Add($"MeteredFromAt = {(this.MeteredFromAt == null ? "null" : this.MeteredFromAt.ToString())}");
            toStringOutput.Add($"MeteredThroughAt = {(this.MeteredThroughAt == null ? "null" : this.MeteredThroughAt.ToString())}");
            toStringOutput.Add($"ConversionRateApplied = {this.ConversionRateApplied ?? "null"}");
            toStringOutput.Add($"InvoiceUid = {this.InvoiceUid ?? "null"}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}