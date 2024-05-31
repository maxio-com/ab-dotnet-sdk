// <copyright file="AccountBalances.cs" company="APIMatic">
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
    /// AccountBalances.
    /// </summary>
    public class AccountBalances : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBalances"/> class.
        /// </summary>
        public AccountBalances()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBalances"/> class.
        /// </summary>
        /// <param name="openInvoices">open_invoices.</param>
        /// <param name="pendingInvoices">pending_invoices.</param>
        /// <param name="pendingDiscounts">pending_discounts.</param>
        /// <param name="serviceCredits">service_credits.</param>
        /// <param name="prepayments">prepayments.</param>
        public AccountBalances(
            Models.AccountBalance openInvoices = null,
            Models.AccountBalance pendingInvoices = null,
            Models.AccountBalance pendingDiscounts = null,
            Models.AccountBalance serviceCredits = null,
            Models.AccountBalance prepayments = null)
        {
            this.OpenInvoices = openInvoices;
            this.PendingInvoices = pendingInvoices;
            this.PendingDiscounts = pendingDiscounts;
            this.ServiceCredits = serviceCredits;
            this.Prepayments = prepayments;
        }

        /// <summary>
        /// The balance, in cents, of the sum of the subscription's  open, payable invoices.
        /// </summary>
        [JsonProperty("open_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance OpenInvoices { get; set; }

        /// <summary>
        /// The balance, in cents, of the sum of the subscription's  pending, payable invoices.
        /// </summary>
        [JsonProperty("pending_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance PendingInvoices { get; set; }

        /// <summary>
        /// The balance, in cents, of the subscription's Pending Discount account.
        /// </summary>
        [JsonProperty("pending_discounts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance PendingDiscounts { get; set; }

        /// <summary>
        /// The balance, in cents, of the subscription's Service Credit account.
        /// </summary>
        [JsonProperty("service_credits", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance ServiceCredits { get; set; }

        /// <summary>
        /// The balance, in cents, of the subscription's Prepayment account.
        /// </summary>
        [JsonProperty("prepayments", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AccountBalance Prepayments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountBalances : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountBalances other &&                ((this.OpenInvoices == null && other.OpenInvoices == null) || (this.OpenInvoices?.Equals(other.OpenInvoices) == true)) &&
                ((this.PendingInvoices == null && other.PendingInvoices == null) || (this.PendingInvoices?.Equals(other.PendingInvoices) == true)) &&
                ((this.PendingDiscounts == null && other.PendingDiscounts == null) || (this.PendingDiscounts?.Equals(other.PendingDiscounts) == true)) &&
                ((this.ServiceCredits == null && other.ServiceCredits == null) || (this.ServiceCredits?.Equals(other.ServiceCredits) == true)) &&
                ((this.Prepayments == null && other.Prepayments == null) || (this.Prepayments?.Equals(other.Prepayments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OpenInvoices = {(this.OpenInvoices == null ? "null" : this.OpenInvoices.ToString())}");
            toStringOutput.Add($"this.PendingInvoices = {(this.PendingInvoices == null ? "null" : this.PendingInvoices.ToString())}");
            toStringOutput.Add($"this.PendingDiscounts = {(this.PendingDiscounts == null ? "null" : this.PendingDiscounts.ToString())}");
            toStringOutput.Add($"this.ServiceCredits = {(this.ServiceCredits == null ? "null" : this.ServiceCredits.ToString())}");
            toStringOutput.Add($"this.Prepayments = {(this.Prepayments == null ? "null" : this.Prepayments.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}