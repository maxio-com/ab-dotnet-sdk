// <copyright file="PrepaymentAggregatedError.cs" company="APIMatic">
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
    /// PrepaymentAggregatedError.
    /// </summary>
    public class PrepaymentAggregatedError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaymentAggregatedError"/> class.
        /// </summary>
        public PrepaymentAggregatedError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaymentAggregatedError"/> class.
        /// </summary>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="mBase">base.</param>
        /// <param name="external">external.</param>
        public PrepaymentAggregatedError(
            List<string> amountInCents = null,
            List<string> mBase = null,
            List<string> external = null)
        {
            this.AmountInCents = amountInCents;
            this.MBase = mBase;
            this.External = external;
        }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets MBase.
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MBase { get; set; }

        /// <summary>
        /// Gets or sets External.
        /// </summary>
        [JsonProperty("external", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> External { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrepaymentAggregatedError : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrepaymentAggregatedError other &&                ((this.AmountInCents == null && other.AmountInCents == null) || (this.AmountInCents?.Equals(other.AmountInCents) == true)) &&
                ((this.MBase == null && other.MBase == null) || (this.MBase?.Equals(other.MBase) == true)) &&
                ((this.External == null && other.External == null) || (this.External?.Equals(other.External) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AmountInCents = {(this.AmountInCents == null ? "null" : $"[{string.Join(", ", this.AmountInCents)} ]")}");
            toStringOutput.Add($"this.MBase = {(this.MBase == null ? "null" : $"[{string.Join(", ", this.MBase)} ]")}");
            toStringOutput.Add($"this.External = {(this.External == null ? "null" : $"[{string.Join(", ", this.External)} ]")}");
        }
    }
}