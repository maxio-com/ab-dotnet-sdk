// <copyright file="NetTerms.cs" company="APIMatic">
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
    /// NetTerms.
    /// </summary>
    public class NetTerms : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetTerms"/> class.
        /// </summary>
        public NetTerms()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetTerms"/> class.
        /// </summary>
        /// <param name="defaultNetTerms">default_net_terms.</param>
        /// <param name="automaticNetTerms">automatic_net_terms.</param>
        /// <param name="remittanceNetTerms">remittance_net_terms.</param>
        /// <param name="netTermsOnRemittanceSignupsEnabled">net_terms_on_remittance_signups_enabled.</param>
        /// <param name="customNetTermsEnabled">custom_net_terms_enabled.</param>
        public NetTerms(
            int? defaultNetTerms = 0,
            int? automaticNetTerms = 0,
            int? remittanceNetTerms = 0,
            bool? netTermsOnRemittanceSignupsEnabled = false,
            bool? customNetTermsEnabled = false)
        {
            this.DefaultNetTerms = defaultNetTerms;
            this.AutomaticNetTerms = automaticNetTerms;
            this.RemittanceNetTerms = remittanceNetTerms;
            this.NetTermsOnRemittanceSignupsEnabled = netTermsOnRemittanceSignupsEnabled;
            this.CustomNetTermsEnabled = customNetTermsEnabled;
        }

        /// <summary>
        /// Gets or sets DefaultNetTerms.
        /// </summary>
        [JsonProperty("default_net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultNetTerms { get; set; }

        /// <summary>
        /// Gets or sets AutomaticNetTerms.
        /// </summary>
        [JsonProperty("automatic_net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomaticNetTerms { get; set; }

        /// <summary>
        /// Gets or sets RemittanceNetTerms.
        /// </summary>
        [JsonProperty("remittance_net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemittanceNetTerms { get; set; }

        /// <summary>
        /// Gets or sets NetTermsOnRemittanceSignupsEnabled.
        /// </summary>
        [JsonProperty("net_terms_on_remittance_signups_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NetTermsOnRemittanceSignupsEnabled { get; set; }

        /// <summary>
        /// Gets or sets CustomNetTermsEnabled.
        /// </summary>
        [JsonProperty("custom_net_terms_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomNetTermsEnabled { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"NetTerms : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is NetTerms other &&
                (this.DefaultNetTerms == null && other.DefaultNetTerms == null ||
                 this.DefaultNetTerms?.Equals(other.DefaultNetTerms) == true) &&
                (this.AutomaticNetTerms == null && other.AutomaticNetTerms == null ||
                 this.AutomaticNetTerms?.Equals(other.AutomaticNetTerms) == true) &&
                (this.RemittanceNetTerms == null && other.RemittanceNetTerms == null ||
                 this.RemittanceNetTerms?.Equals(other.RemittanceNetTerms) == true) &&
                (this.NetTermsOnRemittanceSignupsEnabled == null && other.NetTermsOnRemittanceSignupsEnabled == null ||
                 this.NetTermsOnRemittanceSignupsEnabled?.Equals(other.NetTermsOnRemittanceSignupsEnabled) == true) &&
                (this.CustomNetTermsEnabled == null && other.CustomNetTermsEnabled == null ||
                 this.CustomNetTermsEnabled?.Equals(other.CustomNetTermsEnabled) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DefaultNetTerms = {(this.DefaultNetTerms == null ? "null" : this.DefaultNetTerms.ToString())}");
            toStringOutput.Add($"AutomaticNetTerms = {(this.AutomaticNetTerms == null ? "null" : this.AutomaticNetTerms.ToString())}");
            toStringOutput.Add($"RemittanceNetTerms = {(this.RemittanceNetTerms == null ? "null" : this.RemittanceNetTerms.ToString())}");
            toStringOutput.Add($"NetTermsOnRemittanceSignupsEnabled = {(this.NetTermsOnRemittanceSignupsEnabled == null ? "null" : this.NetTermsOnRemittanceSignupsEnabled.ToString())}");
            toStringOutput.Add($"CustomNetTermsEnabled = {(this.CustomNetTermsEnabled == null ? "null" : this.CustomNetTermsEnabled.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}