// <copyright file="CreatedPrepayment.cs" company="APIMatic">
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
    /// CreatedPrepayment.
    /// </summary>
    public class CreatedPrepayment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedPrepayment"/> class.
        /// </summary>
        public CreatedPrepayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedPrepayment"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="memo">memo.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="startingBalanceInCents">starting_balance_in_cents.</param>
        /// <param name="endingBalanceInCents">ending_balance_in_cents.</param>
        public CreatedPrepayment(
            long? id = null,
            int? subscriptionId = null,
            long? amountInCents = null,
            string memo = null,
            DateTimeOffset? createdAt = null,
            long? startingBalanceInCents = null,
            long? endingBalanceInCents = null)
        {
            this.Id = id;
            this.SubscriptionId = subscriptionId;
            this.AmountInCents = amountInCents;
            this.Memo = memo;
            this.CreatedAt = createdAt;
            this.StartingBalanceInCents = startingBalanceInCents;
            this.EndingBalanceInCents = endingBalanceInCents;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets StartingBalanceInCents.
        /// </summary>
        [JsonProperty("starting_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartingBalanceInCents { get; set; }

        /// <summary>
        /// Gets or sets EndingBalanceInCents.
        /// </summary>
        [JsonProperty("ending_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndingBalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatedPrepayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatedPrepayment other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.StartingBalanceInCents == null && other.StartingBalanceInCents == null) || (this.StartingBalanceInCents?.Equals(other.StartingBalanceInCents) == true)) &&
                ((this.EndingBalanceInCents == null && other.EndingBalanceInCents == null) || (this.EndingBalanceInCents?.Equals(other.EndingBalanceInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.StartingBalanceInCents = {(this.StartingBalanceInCents == null ? "null" : this.StartingBalanceInCents.ToString())}");
            toStringOutput.Add($"this.EndingBalanceInCents = {(this.EndingBalanceInCents == null ? "null" : this.EndingBalanceInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}