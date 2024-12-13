// <copyright file="PrepaidConfiguration.cs" company="APIMatic">
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
    /// PrepaidConfiguration.
    /// </summary>
    public class PrepaidConfiguration : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidConfiguration"/> class.
        /// </summary>
        public PrepaidConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaidConfiguration"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="initialFundingAmountInCents">initial_funding_amount_in_cents.</param>
        /// <param name="replenishToAmountInCents">replenish_to_amount_in_cents.</param>
        /// <param name="autoReplenish">auto_replenish.</param>
        /// <param name="replenishThresholdAmountInCents">replenish_threshold_amount_in_cents.</param>
        public PrepaidConfiguration(
            int? id = null,
            long? initialFundingAmountInCents = null,
            long? replenishToAmountInCents = null,
            bool? autoReplenish = null,
            long? replenishThresholdAmountInCents = null)
        {
            this.Id = id;
            this.InitialFundingAmountInCents = initialFundingAmountInCents;
            this.ReplenishToAmountInCents = replenishToAmountInCents;
            this.AutoReplenish = autoReplenish;
            this.ReplenishThresholdAmountInCents = replenishThresholdAmountInCents;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets InitialFundingAmountInCents.
        /// </summary>
        [JsonProperty("initial_funding_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? InitialFundingAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets ReplenishToAmountInCents.
        /// </summary>
        [JsonProperty("replenish_to_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplenishToAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets AutoReplenish.
        /// </summary>
        [JsonProperty("auto_replenish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoReplenish { get; set; }

        /// <summary>
        /// Gets or sets ReplenishThresholdAmountInCents.
        /// </summary>
        [JsonProperty("replenish_threshold_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplenishThresholdAmountInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PrepaidConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaidConfiguration other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.InitialFundingAmountInCents == null && other.InitialFundingAmountInCents == null ||
                 this.InitialFundingAmountInCents?.Equals(other.InitialFundingAmountInCents) == true) &&
                (this.ReplenishToAmountInCents == null && other.ReplenishToAmountInCents == null ||
                 this.ReplenishToAmountInCents?.Equals(other.ReplenishToAmountInCents) == true) &&
                (this.AutoReplenish == null && other.AutoReplenish == null ||
                 this.AutoReplenish?.Equals(other.AutoReplenish) == true) &&
                (this.ReplenishThresholdAmountInCents == null && other.ReplenishThresholdAmountInCents == null ||
                 this.ReplenishThresholdAmountInCents?.Equals(other.ReplenishThresholdAmountInCents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.InitialFundingAmountInCents = {(this.InitialFundingAmountInCents == null ? "null" : this.InitialFundingAmountInCents.ToString())}");
            toStringOutput.Add($"this.ReplenishToAmountInCents = {(this.ReplenishToAmountInCents == null ? "null" : this.ReplenishToAmountInCents.ToString())}");
            toStringOutput.Add($"this.AutoReplenish = {(this.AutoReplenish == null ? "null" : this.AutoReplenish.ToString())}");
            toStringOutput.Add($"this.ReplenishThresholdAmountInCents = {(this.ReplenishThresholdAmountInCents == null ? "null" : this.ReplenishThresholdAmountInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}