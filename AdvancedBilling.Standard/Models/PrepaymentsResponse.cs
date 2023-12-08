// <copyright file="PrepaymentsResponse.cs" company="APIMatic">
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
    /// PrepaymentsResponse.
    /// </summary>
    public class PrepaymentsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaymentsResponse"/> class.
        /// </summary>
        public PrepaymentsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrepaymentsResponse"/> class.
        /// </summary>
        /// <param name="prepayments">prepayments.</param>
        public PrepaymentsResponse(
            List<Models.Prepayment> prepayments = null)
        {
            this.Prepayments = prepayments;
        }

        /// <summary>
        /// Gets or sets Prepayments.
        /// </summary>
        [JsonProperty("prepayments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Prepayment> Prepayments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PrepaymentsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PrepaymentsResponse other &&                ((this.Prepayments == null && other.Prepayments == null) || (this.Prepayments?.Equals(other.Prepayments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Prepayments = {(this.Prepayments == null ? "null" : $"[{string.Join(", ", this.Prepayments)} ]")}");
        }
    }
}