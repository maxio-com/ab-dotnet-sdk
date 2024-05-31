// <copyright file="OfferResponse.cs" company="APIMatic">
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
    /// OfferResponse.
    /// </summary>
    public class OfferResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferResponse"/> class.
        /// </summary>
        public OfferResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferResponse"/> class.
        /// </summary>
        /// <param name="offer">offer.</param>
        public OfferResponse(
            Models.Offer offer = null)
        {
            this.Offer = offer;
        }

        /// <summary>
        /// Gets or sets Offer.
        /// </summary>
        [JsonProperty("offer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Offer Offer { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OfferResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is OfferResponse other &&                ((this.Offer == null && other.Offer == null) || (this.Offer?.Equals(other.Offer) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Offer = {(this.Offer == null ? "null" : this.Offer.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}