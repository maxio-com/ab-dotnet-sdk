// <copyright file="ListSubscriptionGroupPrepayment.cs" company="APIMatic">
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
    /// ListSubscriptionGroupPrepayment.
    /// </summary>
    public class ListSubscriptionGroupPrepayment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupPrepayment"/> class.
        /// </summary>
        public ListSubscriptionGroupPrepayment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupPrepayment"/> class.
        /// </summary>
        /// <param name="prepayment">prepayment.</param>
        public ListSubscriptionGroupPrepayment(
            Models.ListSubcriptionGroupPrepaymentItem prepayment)
        {
            this.Prepayment = prepayment;
        }

        /// <summary>
        /// Gets or sets Prepayment.
        /// </summary>
        [JsonProperty("prepayment")]
        public Models.ListSubcriptionGroupPrepaymentItem Prepayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSubscriptionGroupPrepayment : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSubscriptionGroupPrepayment other &&                ((this.Prepayment == null && other.Prepayment == null) || (this.Prepayment?.Equals(other.Prepayment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Prepayment = {(this.Prepayment == null ? "null" : this.Prepayment.ToString())}");
        }
    }
}