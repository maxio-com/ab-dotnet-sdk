// <copyright file="CreatePrepayment.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreatePrepayment.
    /// </summary>
    public class CreatePrepayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrepayment"/> class.
        /// </summary>
        public CreatePrepayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrepayment"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="details">details.</param>
        /// <param name="memo">memo.</param>
        /// <param name="method">method.</param>
        /// <param name="paymentProfileId">payment_profile_id.</param>
        public CreatePrepayment(
            double amount,
            string details,
            string memo,
            Models.CreatePrepaymentMethod method,
            int? paymentProfileId = null)
        {
            this.Amount = amount;
            this.Details = details;
            this.Memo = memo;
            this.Method = method;
            this.PaymentProfileId = paymentProfileId;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// :- When the `method` specified is `"credit_card_on_file"`, the prepayment amount will be collected using the default credit card payment profile and applied to the prepayment account balance. This is especially useful for manual replenishment of prepaid subscriptions.
        /// </summary>
        [JsonProperty("method")]
        public Models.CreatePrepaymentMethod Method { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileId.
        /// </summary>
        [JsonProperty("payment_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentProfileId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatePrepayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatePrepayment other &&                this.Amount.Equals(other.Amount) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                this.Method.Equals(other.Method) &&
                ((this.PaymentProfileId == null && other.PaymentProfileId == null) || (this.PaymentProfileId?.Equals(other.PaymentProfileId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Method = {this.Method}");
            toStringOutput.Add($"this.PaymentProfileId = {(this.PaymentProfileId == null ? "null" : this.PaymentProfileId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}