// <copyright file="SendInvoiceRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

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
        /// <param name="attachmentUrls">attachment_urls.</param>
        public SendInvoiceRequest(
            List<string> recipientEmails = null,
            List<string> ccRecipientEmails = null,
            List<string> bccRecipientEmails = null,
            List<string> attachmentUrls = null)
        {
            this.RecipientEmails = recipientEmails;
            this.CcRecipientEmails = ccRecipientEmails;
            this.BccRecipientEmails = bccRecipientEmails;
            this.AttachmentUrls = attachmentUrls;
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

        /// <summary>
        /// Array of URLs to files to attach to the invoice email. Max 10 files, 10MB each.
        /// </summary>
        [JsonProperty("attachment_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AttachmentUrls { get; set; }

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
                (this.AttachmentUrls == null && other.AttachmentUrls == null ||
                 this.AttachmentUrls?.Equals(other.AttachmentUrls) == true) &&
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
            toStringOutput.Add($"AttachmentUrls = {(this.AttachmentUrls == null ? "null" : $"[{string.Join(", ", this.AttachmentUrls)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}