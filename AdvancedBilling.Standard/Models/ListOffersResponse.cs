// <copyright file="ListOffersResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListOffersResponse.
    /// </summary>
    public class ListOffersResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListOffersResponse"/> class.
        /// </summary>
        public ListOffersResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOffersResponse"/> class.
        /// </summary>
        /// <param name="offers">offers.</param>
        public ListOffersResponse(
            List<Models.Offer> offers = null)
        {
            this.Offers = offers;
        }

        /// <summary>
        /// Gets or sets Offers.
        /// </summary>
        [JsonProperty("offers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Offer> Offers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListOffersResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListOffersResponse other &&
                (this.Offers == null && other.Offers == null ||
                 this.Offers?.Equals(other.Offers) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Offers = {(this.Offers == null ? "null" : $"[{string.Join(", ", this.Offers)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}