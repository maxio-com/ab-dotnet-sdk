// <copyright file="SubscriptionGroupPrepayment.cs" company="APIMatic">
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
    /// SubscriptionGroupPrepayment.
    /// </summary>
    public class SubscriptionGroupPrepayment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupPrepayment"/> class.
        /// </summary>
        public SubscriptionGroupPrepayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupPrepayment"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="details">details.</param>
        /// <param name="memo">memo.</param>
        /// <param name="method">method.</param>
        public SubscriptionGroupPrepayment(
            int amount,
            string details,
            string memo,
            Models.SubscriptionGroupPrepaymentMethod method)
        {
            this.Amount = amount;
            this.Details = details;
            this.Memo = memo;
            this.Method = method;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

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
        /// Gets or sets Method.
        /// </summary>
        [JsonProperty("method")]
        public Models.SubscriptionGroupPrepaymentMethod Method { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupPrepayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupPrepayment other &&                this.Amount.Equals(other.Amount) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                this.Method.Equals(other.Method);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {this.Amount}");
            toStringOutput.Add($"this.Details = {(this.Details == null ? "null" : this.Details)}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.Method = {this.Method}");
        }
    }
}