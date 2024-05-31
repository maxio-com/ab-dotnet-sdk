// <copyright file="SubscriptionMRRBreakout.cs" company="APIMatic">
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
    /// SubscriptionMRRBreakout.
    /// </summary>
    public class SubscriptionMRRBreakout : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMRRBreakout"/> class.
        /// </summary>
        public SubscriptionMRRBreakout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMRRBreakout"/> class.
        /// </summary>
        /// <param name="planAmountInCents">plan_amount_in_cents.</param>
        /// <param name="usageAmountInCents">usage_amount_in_cents.</param>
        public SubscriptionMRRBreakout(
            long planAmountInCents,
            long usageAmountInCents)
        {
            this.PlanAmountInCents = planAmountInCents;
            this.UsageAmountInCents = usageAmountInCents;
        }

        /// <summary>
        /// Gets or sets PlanAmountInCents.
        /// </summary>
        [JsonProperty("plan_amount_in_cents")]
        public long PlanAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets UsageAmountInCents.
        /// </summary>
        [JsonProperty("usage_amount_in_cents")]
        public long UsageAmountInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionMRRBreakout : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionMRRBreakout other &&                this.PlanAmountInCents.Equals(other.PlanAmountInCents) &&
                this.UsageAmountInCents.Equals(other.UsageAmountInCents);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PlanAmountInCents = {this.PlanAmountInCents}");
            toStringOutput.Add($"this.UsageAmountInCents = {this.UsageAmountInCents}");

            base.ToString(toStringOutput);
        }
    }
}