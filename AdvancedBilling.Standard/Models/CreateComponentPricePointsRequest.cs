// <copyright file="CreateComponentPricePointsRequest.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CreateComponentPricePointsRequest.
    /// </summary>
    public class CreateComponentPricePointsRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComponentPricePointsRequest"/> class.
        /// </summary>
        public CreateComponentPricePointsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateComponentPricePointsRequest"/> class.
        /// </summary>
        /// <param name="pricePoints">price_points.</param>
        public CreateComponentPricePointsRequest(
            List<CreateComponentPricePointsRequestPricePoints> pricePoints)
        {
            this.PricePoints = pricePoints;
        }

        /// <summary>
        /// Gets or sets PricePoints.
        /// </summary>
        [JsonProperty("price_points")]
        public List<CreateComponentPricePointsRequestPricePoints> PricePoints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateComponentPricePointsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateComponentPricePointsRequest other &&                ((this.PricePoints == null && other.PricePoints == null) || (this.PricePoints?.Equals(other.PricePoints) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PricePoints = {(this.PricePoints == null ? "null" : this.PricePoints.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}