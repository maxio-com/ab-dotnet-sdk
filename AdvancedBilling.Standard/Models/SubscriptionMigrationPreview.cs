// <copyright file="SubscriptionMigrationPreview.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// SubscriptionMigrationPreview.
    /// </summary>
    public class SubscriptionMigrationPreview : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMigrationPreview"/> class.
        /// </summary>
        public SubscriptionMigrationPreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMigrationPreview"/> class.
        /// </summary>
        /// <param name="proratedAdjustmentInCents">prorated_adjustment_in_cents.</param>
        /// <param name="chargeInCents">charge_in_cents.</param>
        /// <param name="paymentDueInCents">payment_due_in_cents.</param>
        /// <param name="creditAppliedInCents">credit_applied_in_cents.</param>
        public SubscriptionMigrationPreview(
            long? proratedAdjustmentInCents = null,
            long? chargeInCents = null,
            long? paymentDueInCents = null,
            long? creditAppliedInCents = null)
        {
            this.ProratedAdjustmentInCents = proratedAdjustmentInCents;
            this.ChargeInCents = chargeInCents;
            this.PaymentDueInCents = paymentDueInCents;
            this.CreditAppliedInCents = creditAppliedInCents;
        }

        /// <summary>
        /// The amount of the prorated adjustment that would be issued for the current subscription.
        /// </summary>
        [JsonProperty("prorated_adjustment_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProratedAdjustmentInCents { get; set; }

        /// <summary>
        /// The amount of the charge that would be created for the new product.
        /// </summary>
        [JsonProperty("charge_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ChargeInCents { get; set; }

        /// <summary>
        /// The amount of the payment due in the case of an upgrade.
        /// </summary>
        [JsonProperty("payment_due_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? PaymentDueInCents { get; set; }

        /// <summary>
        /// Represents a credit in cents that is applied to your subscription as part of a migration process for a specific product, which reduces the amount owed for the subscription.
        /// </summary>
        [JsonProperty("credit_applied_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreditAppliedInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionMigrationPreview : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionMigrationPreview other &&
                (this.ProratedAdjustmentInCents == null && other.ProratedAdjustmentInCents == null ||
                 this.ProratedAdjustmentInCents?.Equals(other.ProratedAdjustmentInCents) == true) &&
                (this.ChargeInCents == null && other.ChargeInCents == null ||
                 this.ChargeInCents?.Equals(other.ChargeInCents) == true) &&
                (this.PaymentDueInCents == null && other.PaymentDueInCents == null ||
                 this.PaymentDueInCents?.Equals(other.PaymentDueInCents) == true) &&
                (this.CreditAppliedInCents == null && other.CreditAppliedInCents == null ||
                 this.CreditAppliedInCents?.Equals(other.CreditAppliedInCents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ProratedAdjustmentInCents = {(this.ProratedAdjustmentInCents == null ? "null" : this.ProratedAdjustmentInCents.ToString())}");
            toStringOutput.Add($"ChargeInCents = {(this.ChargeInCents == null ? "null" : this.ChargeInCents.ToString())}");
            toStringOutput.Add($"PaymentDueInCents = {(this.PaymentDueInCents == null ? "null" : this.PaymentDueInCents.ToString())}");
            toStringOutput.Add($"CreditAppliedInCents = {(this.CreditAppliedInCents == null ? "null" : this.CreditAppliedInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}