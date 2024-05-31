// <copyright file="IssueInvoiceRequest.cs" company="APIMatic">
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
    /// IssueInvoiceRequest.
    /// </summary>
    public class IssueInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueInvoiceRequest"/> class.
        /// </summary>
        public IssueInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueInvoiceRequest"/> class.
        /// </summary>
        /// <param name="onFailedPayment">on_failed_payment.</param>
        public IssueInvoiceRequest(
            Models.FailedPaymentAction? onFailedPayment = Models.FailedPaymentAction.LeaveOpenInvoice)
        {
            this.OnFailedPayment = onFailedPayment;
        }

        /// <summary>
        /// Action taken when payment for an invoice fails:
        /// - `leave_open_invoice` - prepayments and credits applied to invoice; invoice status set to "open"; email sent to the customer for the issued invoice (if setting applies); payment failure recorded in the invoice history. This is the default option.
        /// - `rollback_to_pending` - prepayments and credits not applied; invoice remains in "pending" status; no email sent to the customer; payment failure recorded in the invoice history.
        /// - `initiate_dunning` - prepayments and credits applied to the invoice; invoice status set to "open"; email sent to the customer for the issued invoice (if setting applies); payment failure recorded in the invoice history; subscription will  most likely go into "past_due" or "canceled" state (depending upon net terms and dunning settings).
        /// </summary>
        [JsonProperty("on_failed_payment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FailedPaymentAction? OnFailedPayment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IssueInvoiceRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is IssueInvoiceRequest other &&                ((this.OnFailedPayment == null && other.OnFailedPayment == null) || (this.OnFailedPayment?.Equals(other.OnFailedPayment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OnFailedPayment = {(this.OnFailedPayment == null ? "null" : this.OnFailedPayment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}