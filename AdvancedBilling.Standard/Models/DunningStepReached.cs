// <copyright file="DunningStepReached.cs" company="APIMatic">
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
    /// DunningStepReached.
    /// </summary>
    public class DunningStepReached
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DunningStepReached"/> class.
        /// </summary>
        public DunningStepReached()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DunningStepReached"/> class.
        /// </summary>
        /// <param name="dunner">dunner.</param>
        /// <param name="currentStep">current_step.</param>
        /// <param name="nextStep">next_step.</param>
        public DunningStepReached(
            Models.DunnerData dunner,
            Models.DunningStepData currentStep,
            Models.DunningStepData nextStep)
        {
            this.Dunner = dunner;
            this.CurrentStep = currentStep;
            this.NextStep = nextStep;
        }

        /// <summary>
        /// Gets or sets Dunner.
        /// </summary>
        [JsonProperty("dunner")]
        [JsonRequired]
        public Models.DunnerData Dunner { get; set; }

        /// <summary>
        /// Gets or sets CurrentStep.
        /// </summary>
        [JsonProperty("current_step")]
        [JsonRequired]
        public Models.DunningStepData CurrentStep { get; set; }

        /// <summary>
        /// Gets or sets NextStep.
        /// </summary>
        [JsonProperty("next_step")]
        [JsonRequired]
        public Models.DunningStepData NextStep { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DunningStepReached : ({string.Join(", ", toStringOutput)})";
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
            return obj is DunningStepReached other &&                ((this.Dunner == null && other.Dunner == null) || (this.Dunner?.Equals(other.Dunner) == true)) &&
                ((this.CurrentStep == null && other.CurrentStep == null) || (this.CurrentStep?.Equals(other.CurrentStep) == true)) &&
                ((this.NextStep == null && other.NextStep == null) || (this.NextStep?.Equals(other.NextStep) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Dunner = {(this.Dunner == null ? "null" : this.Dunner.ToString())}");
            toStringOutput.Add($"this.CurrentStep = {(this.CurrentStep == null ? "null" : this.CurrentStep.ToString())}");
            toStringOutput.Add($"this.NextStep = {(this.NextStep == null ? "null" : this.NextStep.ToString())}");
        }
    }
}