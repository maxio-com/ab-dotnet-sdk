// <copyright file="ResumeOptions.cs" company="APIMatic">
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
    /// ResumeOptions.
    /// </summary>
    public class ResumeOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeOptions"/> class.
        /// </summary>
        public ResumeOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeOptions"/> class.
        /// </summary>
        /// <param name="requireResume">require_resume.</param>
        /// <param name="forgiveBalance">forgive_balance.</param>
        public ResumeOptions(
            bool? requireResume = null,
            bool? forgiveBalance = null)
        {
            this.RequireResume = requireResume;
            this.ForgiveBalance = forgiveBalance;
        }

        /// <summary>
        /// Chargify will only attempt to resume the subscription's billing period. If not resumable, the subscription will be left in it's current state.
        /// </summary>
        [JsonProperty("require_resume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireResume { get; set; }

        /// <summary>
        /// Indicates whether or not Chargify should clear the subscription's existing balance before attempting to resume the subscription. If subscription cannot be resumed, the balance will remain as it was before the attempt to resume was made.
        /// </summary>
        [JsonProperty("forgive_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForgiveBalance { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResumeOptions : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResumeOptions other &&                ((this.RequireResume == null && other.RequireResume == null) || (this.RequireResume?.Equals(other.RequireResume) == true)) &&
                ((this.ForgiveBalance == null && other.ForgiveBalance == null) || (this.ForgiveBalance?.Equals(other.ForgiveBalance) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequireResume = {(this.RequireResume == null ? "null" : this.RequireResume.ToString())}");
            toStringOutput.Add($"this.ForgiveBalance = {(this.ForgiveBalance == null ? "null" : this.ForgiveBalance.ToString())}");
        }
    }
}