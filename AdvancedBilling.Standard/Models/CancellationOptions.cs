// <copyright file="CancellationOptions.cs" company="APIMatic">
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
    /// CancellationOptions.
    /// </summary>
    public class CancellationOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationOptions"/> class.
        /// </summary>
        public CancellationOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationOptions"/> class.
        /// </summary>
        /// <param name="cancellationMessage">cancellation_message.</param>
        /// <param name="reasonCode">reason_code.</param>
        public CancellationOptions(
            string cancellationMessage = null,
            string reasonCode = null)
        {
            this.CancellationMessage = cancellationMessage;
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// For your internal use. An indication as to why the subscription is being canceled.
        /// </summary>
        [JsonProperty("cancellation_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CancellationMessage { get; set; }

        /// <summary>
        /// The reason code associated with the cancellation. See the list of reason codes associated with your site.
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CancellationOptions : ({string.Join(", ", toStringOutput)})";
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
            return obj is CancellationOptions other &&                ((this.CancellationMessage == null && other.CancellationMessage == null) || (this.CancellationMessage?.Equals(other.CancellationMessage) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CancellationMessage = {(this.CancellationMessage == null ? "null" : this.CancellationMessage)}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
        }
    }
}