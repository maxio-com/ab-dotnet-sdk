// <copyright file="ListSubscriptionGroupPrepaymentResponse.cs" company="APIMatic">
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
    /// ListSubscriptionGroupPrepaymentResponse.
    /// </summary>
    public class ListSubscriptionGroupPrepaymentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupPrepaymentResponse"/> class.
        /// </summary>
        public ListSubscriptionGroupPrepaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupPrepaymentResponse"/> class.
        /// </summary>
        /// <param name="prepayments">prepayments.</param>
        public ListSubscriptionGroupPrepaymentResponse(
            List<Models.ListSubscriptionGroupPrepayment> prepayments)
        {
            this.Prepayments = prepayments;
        }

        /// <summary>
        /// Gets or sets Prepayments.
        /// </summary>
        [JsonProperty("prepayments")]
        public List<Models.ListSubscriptionGroupPrepayment> Prepayments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSubscriptionGroupPrepaymentResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSubscriptionGroupPrepaymentResponse other &&                ((this.Prepayments == null && other.Prepayments == null) || (this.Prepayments?.Equals(other.Prepayments) == true));
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