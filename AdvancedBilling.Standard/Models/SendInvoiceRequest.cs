// <copyright file="SendInvoiceRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// SendInvoiceRequest.
    /// </summary>
    public class SendInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendInvoiceRequest"/> class.
        /// </summary>
        public SendInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendInvoiceRequest"/> class.
        /// </summary>
        /// <param name="recipientEmails">recipient_emails.</param>
        /// <param name="ccRecipientEmails">cc_recipient_emails.</param>
        /// <param name="bccRecipientEmails">bcc_recipient_emails.</param>
        public SendInvoiceRequest(
            List<string> recipientEmails = null,
            List<string> ccRecipientEmails = null,
            List<string> bccRecipientEmails = null)
        {
            this.RecipientEmails = recipientEmails;
            this.CcRecipientEmails = ccRecipientEmails;
            this.BccRecipientEmails = bccRecipientEmails;
        }

        /// <summary>
        /// Gets or sets RecipientEmails.
        /// </summary>
        [JsonProperty("recipient_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RecipientEmails { get; set; }

        /// <summary>
        /// Gets or sets CcRecipientEmails.
        /// </summary>
        [JsonProperty("cc_recipient_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CcRecipientEmails { get; set; }

        /// <summary>
        /// Gets or sets BccRecipientEmails.
        /// </summary>
        [JsonProperty("bcc_recipient_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BccRecipientEmails { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SendInvoiceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SendInvoiceRequest other &&
                (this.RecipientEmails == null && other.RecipientEmails == null ||
                 this.RecipientEmails?.Equals(other.RecipientEmails) == true) &&
                (this.CcRecipientEmails == null && other.CcRecipientEmails == null ||
                 this.CcRecipientEmails?.Equals(other.CcRecipientEmails) == true) &&
                (this.BccRecipientEmails == null && other.BccRecipientEmails == null ||
                 this.BccRecipientEmails?.Equals(other.BccRecipientEmails) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RecipientEmails = {(this.RecipientEmails == null ? "null" : $"[{string.Join(", ", this.RecipientEmails)} ]")}");
            toStringOutput.Add($"CcRecipientEmails = {(this.CcRecipientEmails == null ? "null" : $"[{string.Join(", ", this.CcRecipientEmails)} ]")}");
            toStringOutput.Add($"BccRecipientEmails = {(this.BccRecipientEmails == null ? "null" : $"[{string.Join(", ", this.BccRecipientEmails)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}