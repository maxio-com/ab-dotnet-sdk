// <copyright file="Adjustment.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Adjustment.
    /// </summary>
    public class Adjustment : BaseModel
    {
        private int? grantId;
        private int? sourceTransactionId;
        private string expectedRemaining;
        private string expectedSourceCorrections;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "grant_id", false },
            { "source_transaction_id", false },
            { "expected_remaining", false },
            { "expected_source_corrections", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Adjustment"/> class.
        /// </summary>
        public Adjustment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Adjustment"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="reason">reason.</param>
        /// <param name="grantId">grant_id.</param>
        /// <param name="sourceTransactionId">source_transaction_id.</param>
        /// <param name="expectedRemaining">expected_remaining.</param>
        /// <param name="expectedSourceCorrections">expected_source_corrections.</param>
        public Adjustment(
            AdjustmentAmount amount,
            string reason,
            int? grantId = null,
            int? sourceTransactionId = null,
            string expectedRemaining = null,
            string expectedSourceCorrections = null)
        {
            this.Amount = amount;
            this.Reason = reason;

            if (grantId != null)
            {
                this.GrantId = grantId;
            }

            if (sourceTransactionId != null)
            {
                this.SourceTransactionId = sourceTransactionId;
            }

            if (expectedRemaining != null)
            {
                this.ExpectedRemaining = expectedRemaining;
            }

            if (expectedSourceCorrections != null)
            {
                this.ExpectedSourceCorrections = expectedSourceCorrections;
            }
        }

        /// <summary>
        /// Signed: positive adds units to the grant, negative removes them. Bounded below by the grant's `posted_remaining` (a correction can't drive it negative) and above by the grant's `original` (a correction can't credit past what was originally granted). An out-of-bounds value is rejected rather than clamped. Zero is rejected. Without a `grant_id` (an overdraft correction), the amount must be positive, can't exceed the usage the overdraft entry still records, and can't exceed the overdraft the wallet still owes. Encoded as a decimal string with at most 8 fractional digits. Send fractional values as strings: a JSON number with a decimal point is rejected with `422`, because a double-precision float may already have lost precision before the request arrives.
        /// </summary>
        [JsonProperty("amount")]
        public AdjustmentAmount Amount { get; set; }

        /// <summary>
        /// Required. Lands on the resulting ledger row's `memo`.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The grant to correct. Must belong to this wallet. Required unless `source_transaction_id` names an overdraft entry (a `debit` with no `grant_id`, written when an `allow_negative` wallet consumes past its grants). For an overdraft entry, omit it: sending one returns `422`, and the correction credits the wallet's outstanding overdraft instead of any grant.
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
        /// (Optional) The `debit` row this correction is fixing. Must belong to this wallet, and must name a row of kind `debit`; grant and adjustment rows are append-only history, corrected by posting a further adjustment rather than by pointing at them. For a grant-attributed debit, it's recorded on the resulting ledger row for audit only: it does not change how `amount` is applied, and more than one adjustment may name the same row. For an overdraft entry, it decides the path: omit `grant_id`, and the correction is credit-only, bounded by the usage the entry still records and by the overdraft the wallet still owes.
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
        /// (Optional) An optimistic-concurrency check for a caller whose `amount` was derived from the grant's own remainder. Send the grant's `posted_remaining`, not its `remaining`: on a metered wallet read through [Read Wallet]($e/Wallets/readWallet), `remaining` also subtracts usage not yet posted, so it can differ from what the adjustment checks. If given and the grant's current `posted_remaining` no longer matches, the request is rejected with `409` and nothing is written. Compared numerically, so `"100"` and `"100.00000000"` both match a `posted_remaining` of `100`. Omit the field entirely to skip the check; sending it as an empty string is treated as a malformed value (`422`), not as an omission.
        /// </summary>
        [JsonProperty("expected_remaining")]
        public string ExpectedRemaining
        {
            get
            {
                return this.expectedRemaining;
            }

            set
            {
                this.shouldSerialize["expected_remaining"] = true;
                this.expectedRemaining = value;
            }
        }

        /// <summary>
        /// (Optional) An optimistic-concurrency check for a caller whose `amount` was derived from a usage entry, sent together with `source_transaction_id`: the entry's `source_corrections_total` as the caller last read it (`"0"` if none). If the sum the server computes no longer matches, the request is rejected with `409` and nothing is written. This is what catches a correction posted between that read and this request. Ignored unless `source_transaction_id` is also given.
        /// </summary>
        [JsonProperty("expected_source_corrections")]
        public string ExpectedSourceCorrections
        {
            get
            {
                return this.expectedSourceCorrections;
            }

            set
            {
                this.shouldSerialize["expected_source_corrections"] = true;
                this.expectedSourceCorrections = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Adjustment : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetExpectedRemaining()
        {
            this.shouldSerialize["expected_remaining"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpectedSourceCorrections()
        {
            this.shouldSerialize["expected_source_corrections"] = false;
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
        public bool ShouldSerializeExpectedRemaining()
        {
            return this.shouldSerialize["expected_remaining"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpectedSourceCorrections()
        {
            return this.shouldSerialize["expected_source_corrections"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Adjustment other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Reason == null && other.Reason == null ||
                 this.Reason?.Equals(other.Reason) == true) &&
                (this.GrantId == null && other.GrantId == null ||
                 this.GrantId?.Equals(other.GrantId) == true) &&
                (this.SourceTransactionId == null && other.SourceTransactionId == null ||
                 this.SourceTransactionId?.Equals(other.SourceTransactionId) == true) &&
                (this.ExpectedRemaining == null && other.ExpectedRemaining == null ||
                 this.ExpectedRemaining?.Equals(other.ExpectedRemaining) == true) &&
                (this.ExpectedSourceCorrections == null && other.ExpectedSourceCorrections == null ||
                 this.ExpectedSourceCorrections?.Equals(other.ExpectedSourceCorrections) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Reason = {this.Reason ?? "null"}");
            toStringOutput.Add($"GrantId = {(this.GrantId == null ? "null" : this.GrantId.ToString())}");
            toStringOutput.Add($"SourceTransactionId = {(this.SourceTransactionId == null ? "null" : this.SourceTransactionId.ToString())}");
            toStringOutput.Add($"ExpectedRemaining = {this.ExpectedRemaining ?? "null"}");
            toStringOutput.Add($"ExpectedSourceCorrections = {this.ExpectedSourceCorrections ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}