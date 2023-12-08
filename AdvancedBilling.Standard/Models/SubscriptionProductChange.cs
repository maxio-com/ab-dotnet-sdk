// <copyright file="SubscriptionProductChange.cs" company="APIMatic">
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
    /// SubscriptionProductChange.
    /// </summary>
    public class SubscriptionProductChange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductChange"/> class.
        /// </summary>
        public SubscriptionProductChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductChange"/> class.
        /// </summary>
        /// <param name="previousProductId">previous_product_id.</param>
        /// <param name="newProductId">new_product_id.</param>
        public SubscriptionProductChange(
            int previousProductId,
            int newProductId)
        {
            this.PreviousProductId = previousProductId;
            this.NewProductId = newProductId;
        }

        /// <summary>
        /// Gets or sets PreviousProductId.
        /// </summary>
        [JsonProperty("previous_product_id")]
        [JsonRequired]
        public int PreviousProductId { get; set; }

        /// <summary>
        /// Gets or sets NewProductId.
        /// </summary>
        [JsonProperty("new_product_id")]
        [JsonRequired]
        public int NewProductId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionProductChange : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionProductChange other &&                this.PreviousProductId.Equals(other.PreviousProductId) &&
                this.NewProductId.Equals(other.NewProductId);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PreviousProductId = {this.PreviousProductId}");
            toStringOutput.Add($"this.NewProductId = {this.NewProductId}");
        }
    }
}