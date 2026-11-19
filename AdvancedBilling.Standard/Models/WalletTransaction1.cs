// <copyright file="WalletTransaction1.cs" company="APIMatic">
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
    /// WalletTransaction1.
    /// </summary>
    public class WalletTransaction1 : BaseModel
    {
        private string memo;
        private string expiresAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
            { "expires_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransaction1"/> class.
        /// </summary>
        public WalletTransaction1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransaction1"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="amount">amount.</param>
        /// <param name="memo">memo.</param>
        /// <param name="expiresAt">expires_at.</param>
        public WalletTransaction1(
            Models.Kind1 kind,
            WalletTransaction1Amount amount,
            string memo = null,
            string expiresAt = null)
        {
            this.Kind = kind;
            this.Amount = amount;

            if (memo != null)
            {
                this.Memo = memo;
            }

            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }
        }

        /// <summary>
        /// Determines the direction of the movement. The amount itself is always sent positive.
        /// </summary>
        [JsonProperty("kind")]
        public Models.Kind1 Kind { get; set; }

        /// <summary>
        /// Always positive; `kind` determines the sign written to the ledger. Encoded as a decimal string with at most 8 fractional digits. Send fractional values as strings: a JSON number with a decimal point is rejected with `422`, because a double-precision float may already have lost precision before the request arrives.
        /// </summary>
        [JsonProperty("amount")]
        public WalletTransaction1Amount Amount { get; set; }

        /// <summary>
        /// Gets or sets Memo.
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
        /// An expiration for the grant this creates. Only accepted with `kind: grant`; sending it with `kind: debit` is rejected. Omit it for an evergreen grant. Accepts either a bare calendar date (`YYYY-MM-DD`), resolved to the end of that day in the site's time zone, or a full timestamp. A calendar day that doesn't exist, such as `2027-02-30`, is rejected with `422` rather than rolled into the next month.
        /// </summary>
        [JsonProperty("expires_at")]
        public string ExpiresAt
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletTransaction1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiresAt()
        {
            return this.shouldSerialize["expires_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletTransaction1 other &&
                (this.Kind.Equals(other.Kind)) &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Kind = {this.Kind}");
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");
            toStringOutput.Add($"ExpiresAt = {this.ExpiresAt ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}