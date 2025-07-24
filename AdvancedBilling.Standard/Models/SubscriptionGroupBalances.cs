// <copyright file="SubscriptionGroupBalances.cs" company="APIMatic">
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
    /// SubscriptionGroupBalances.
    /// </summary>
    public class SubscriptionGroupBalances : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupBalances"/> class.
        /// </summary>
        public SubscriptionGroupBalances()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupBalances"/> class.
        /// </summary>
        /// <param name="prepayments">prepayments.</param>
        /// <param name="serviceCredits">service_credits.</param>
        /// <param name="openInvoices">open_invoices.</param>
        /// <param name="pendingDiscounts">pending_discounts.</param>
        public SubscriptionGroupBalances(
            Models.AccountBalance prepayments = null,
            Models.AccountBalance serviceCredits = null,
            Models.AccountBalance openInvoices = null,
            Models.AccountBalance pendingDiscounts = null)
        {
            this.Prepayments = prepayments;
            this.ServiceCredits = serviceCredits;
            this.OpenInvoices = openInvoices;
            this.PendingDiscounts = pendingDiscounts;
        }

        /// <summary>
        /// Gets or sets Prepayments.
        /// </summary>
        [JsonProperty("prepayments", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance Prepayments { get; set; }

        /// <summary>
        /// Gets or sets ServiceCredits.
        /// </summary>
        [JsonProperty("service_credits", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance ServiceCredits { get; set; }

        /// <summary>
        /// Gets or sets OpenInvoices.
        /// </summary>
        [JsonProperty("open_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance OpenInvoices { get; set; }

        /// <summary>
        /// Gets or sets PendingDiscounts.
        /// </summary>
        [JsonProperty("pending_discounts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance PendingDiscounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionGroupBalances : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionGroupBalances other &&
                (this.Prepayments == null && other.Prepayments == null ||
                 this.Prepayments?.Equals(other.Prepayments) == true) &&
                (this.ServiceCredits == null && other.ServiceCredits == null ||
                 this.ServiceCredits?.Equals(other.ServiceCredits) == true) &&
                (this.OpenInvoices == null && other.OpenInvoices == null ||
                 this.OpenInvoices?.Equals(other.OpenInvoices) == true) &&
                (this.PendingDiscounts == null && other.PendingDiscounts == null ||
                 this.PendingDiscounts?.Equals(other.PendingDiscounts) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Prepayments = {(this.Prepayments == null ? "null" : this.Prepayments.ToString())}");
            toStringOutput.Add($"ServiceCredits = {(this.ServiceCredits == null ? "null" : this.ServiceCredits.ToString())}");
            toStringOutput.Add($"OpenInvoices = {(this.OpenInvoices == null ? "null" : this.OpenInvoices.ToString())}");
            toStringOutput.Add($"PendingDiscounts = {(this.PendingDiscounts == null ? "null" : this.PendingDiscounts.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}