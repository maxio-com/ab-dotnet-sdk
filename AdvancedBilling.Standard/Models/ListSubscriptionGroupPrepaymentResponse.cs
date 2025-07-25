// <copyright file="ListSubscriptionGroupPrepaymentResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
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

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListSubscriptionGroupPrepaymentResponse.
    /// </summary>
    public class ListSubscriptionGroupPrepaymentResponse : BaseModel
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSubscriptionGroupPrepaymentResponse other &&
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