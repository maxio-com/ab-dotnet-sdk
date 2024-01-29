// <copyright file="ReactivationBilling.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ReactivationBilling.
    /// </summary>
    public class ReactivationBilling
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivationBilling"/> class.
        /// </summary>
        public ReactivationBilling()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivationBilling"/> class.
        /// </summary>
        /// <param name="reactivationCharge">reactivation_charge.</param>
        public ReactivationBilling(
            Models.ReactivationCharge? reactivationCharge = Models.ReactivationCharge.Prorated)
        {
            this.ReactivationCharge = reactivationCharge;
        }

        /// <summary>
        /// You may choose how to handle the reactivation charge for that subscription: 1) `prorated` A prorated charge for the product price will be attempted for to complete the period 2) `immediate` A full-price charge for the product price will be attempted immediately 3) `delayed` A full-price charge for the product price will be attempted at the next renewal
        /// </summary>
        [JsonProperty("reactivation_charge", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReactivationCharge? ReactivationCharge { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReactivationBilling : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReactivationBilling other &&                ((this.ReactivationCharge == null && other.ReactivationCharge == null) || (this.ReactivationCharge?.Equals(other.ReactivationCharge) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReactivationCharge = {(this.ReactivationCharge == null ? "null" : this.ReactivationCharge.ToString())}");
        }
    }
}