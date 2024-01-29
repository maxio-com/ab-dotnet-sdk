// <copyright file="SubscriptionIncludedCoupon.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionIncludedCoupon.
    /// </summary>
    public class SubscriptionIncludedCoupon
    {
        private string expiresAt;
        private long? amountInCents;
        private string percentage;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "expires_at", false },
            { "amount_in_cents", false },
            { "percentage", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIncludedCoupon"/> class.
        /// </summary>
        public SubscriptionIncludedCoupon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIncludedCoupon"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="useCount">use_count.</param>
        /// <param name="usesAllowed">uses_allowed.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="percentage">percentage.</param>
        public SubscriptionIncludedCoupon(
            string code = null,
            int? useCount = null,
            int? usesAllowed = null,
            string expiresAt = null,
            bool? recurring = null,
            long? amountInCents = null,
            string percentage = null)
        {
            this.Code = code;
            this.UseCount = useCount;
            this.UsesAllowed = usesAllowed;
            if (expiresAt != null)
            {
                this.ExpiresAt = expiresAt;
            }

            this.Recurring = recurring;
            if (amountInCents != null)
            {
                this.AmountInCents = amountInCents;
            }

            if (percentage != null)
            {
                this.Percentage = percentage;
            }

        }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets UseCount.
        /// </summary>
        [JsonProperty("use_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? UseCount { get; set; }

        /// <summary>
        /// Gets or sets UsesAllowed.
        /// </summary>
        [JsonProperty("uses_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsesAllowed { get; set; }

        /// <summary>
        /// Gets or sets ExpiresAt.
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

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents")]
        public long? AmountInCents
        {
            get
            {
                return this.amountInCents;
            }

            set
            {
                this.shouldSerialize["amount_in_cents"] = true;
                this.amountInCents = value;
            }
        }

        /// <summary>
        /// Gets or sets Percentage.
        /// </summary>
        [JsonProperty("percentage")]
        public string Percentage
        {
            get
            {
                return this.percentage;
            }

            set
            {
                this.shouldSerialize["percentage"] = true;
                this.percentage = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionIncludedCoupon : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpiresAt()
        {
            this.shouldSerialize["expires_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountInCents()
        {
            this.shouldSerialize["amount_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPercentage()
        {
            this.shouldSerialize["percentage"] = false;
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
        public bool ShouldSerializeAmountInCents()
        {
            return this.shouldSerialize["amount_in_cents"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePercentage()
        {
            return this.shouldSerialize["percentage"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is SubscriptionIncludedCoupon other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.UseCount == null && other.UseCount == null) || (this.UseCount?.Equals(other.UseCount) == true)) &&
                ((this.UsesAllowed == null && other.UsesAllowed == null) || (this.UsesAllowed?.Equals(other.UsesAllowed) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.Percentage == null && other.Percentage == null) || (this.Percentage?.Equals(other.Percentage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.UseCount = {(this.UseCount == null ? "null" : this.UseCount.ToString())}");
            toStringOutput.Add($"this.UsesAllowed = {(this.UsesAllowed == null ? "null" : this.UsesAllowed.ToString())}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"this.Percentage = {(this.Percentage == null ? "null" : this.Percentage)}");
        }
    }
}