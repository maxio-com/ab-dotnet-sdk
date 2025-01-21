// <copyright file="Breakouts.cs" company="APIMatic">
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
    /// Breakouts.
    /// </summary>
    public class Breakouts : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Breakouts"/> class.
        /// </summary>
        public Breakouts()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Breakouts"/> class.
        /// </summary>
        /// <param name="planAmountInCents">plan_amount_in_cents.</param>
        /// <param name="planAmountFormatted">plan_amount_formatted.</param>
        /// <param name="usageAmountInCents">usage_amount_in_cents.</param>
        /// <param name="usageAmountFormatted">usage_amount_formatted.</param>
        public Breakouts(
            long? planAmountInCents = null,
            string planAmountFormatted = null,
            long? usageAmountInCents = null,
            string usageAmountFormatted = null)
        {
            this.PlanAmountInCents = planAmountInCents;
            this.PlanAmountFormatted = planAmountFormatted;
            this.UsageAmountInCents = usageAmountInCents;
            this.UsageAmountFormatted = usageAmountFormatted;
        }

        /// <summary>
        /// Gets or sets PlanAmountInCents.
        /// </summary>
        [JsonProperty("plan_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets PlanAmountFormatted.
        /// </summary>
        [JsonProperty("plan_amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanAmountFormatted { get; set; }

        /// <summary>
        /// Gets or sets UsageAmountInCents.
        /// </summary>
        [JsonProperty("usage_amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsageAmountInCents { get; set; }

        /// <summary>
        /// Gets or sets UsageAmountFormatted.
        /// </summary>
        [JsonProperty("usage_amount_formatted", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageAmountFormatted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Breakouts : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Breakouts other &&
                (this.PlanAmountInCents == null && other.PlanAmountInCents == null ||
                 this.PlanAmountInCents?.Equals(other.PlanAmountInCents) == true) &&
                (this.PlanAmountFormatted == null && other.PlanAmountFormatted == null ||
                 this.PlanAmountFormatted?.Equals(other.PlanAmountFormatted) == true) &&
                (this.UsageAmountInCents == null && other.UsageAmountInCents == null ||
                 this.UsageAmountInCents?.Equals(other.UsageAmountInCents) == true) &&
                (this.UsageAmountFormatted == null && other.UsageAmountFormatted == null ||
                 this.UsageAmountFormatted?.Equals(other.UsageAmountFormatted) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PlanAmountInCents = {(this.PlanAmountInCents == null ? "null" : this.PlanAmountInCents.ToString())}");
            toStringOutput.Add($"PlanAmountFormatted = {this.PlanAmountFormatted ?? "null"}");
            toStringOutput.Add($"UsageAmountInCents = {(this.UsageAmountInCents == null ? "null" : this.UsageAmountInCents.ToString())}");
            toStringOutput.Add($"UsageAmountFormatted = {this.UsageAmountFormatted ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}