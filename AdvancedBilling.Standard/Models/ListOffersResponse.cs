// <copyright file="ListOffersResponse.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ListOffersResponse other &&                ((this.Offers == null && other.Offers == null) || (this.Offers?.Equals(other.Offers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Offers = {(this.Offers == null ? "null" : $"[{string.Join(", ", this.Offers)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}