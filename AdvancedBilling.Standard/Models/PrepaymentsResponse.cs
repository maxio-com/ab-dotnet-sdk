// <copyright file="PrepaymentsResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// PrepaymentsResponse.
    /// </summary>
    public class PrepaymentsResponse : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PrepaymentsResponse other &&
                (this.Prepayments == null && other.Prepayments == null ||
                 this.Prepayments?.Equals(other.Prepayments) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Prepayments = {(this.Prepayments == null ? "null" : $"[{string.Join(", ", this.Prepayments)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}