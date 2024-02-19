// <copyright file="RecordPaymentResponse.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// RecordPaymentResponse.
    /// </summary>
    public class RecordPaymentResponse
    {
        private RecordPaymentResponsePrepayment prepayment;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "prepayment", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordPaymentResponse"/> class.
        /// </summary>
        public RecordPaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordPaymentResponse"/> class.
        /// </summary>
        /// <param name="paidInvoices">paid_invoices.</param>
        /// <param name="prepayment">prepayment.</param>
        public RecordPaymentResponse(
            List<Models.PaidInvoice> paidInvoices = null,
            RecordPaymentResponsePrepayment prepayment = null)
        {
            this.PaidInvoices = paidInvoices;
            if (prepayment != null)
            {
                this.Prepayment = prepayment;
            }

        }

        /// <summary>
        /// Gets or sets PaidInvoices.
        /// </summary>
        [JsonProperty("paid_invoices", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PaidInvoice> PaidInvoices { get; set; }

        /// <summary>
        /// Gets or sets Prepayment.
        /// </summary>
        [JsonProperty("prepayment")]
        public RecordPaymentResponsePrepayment Prepayment
        {
            get
            {
                return this.prepayment;
            }

            set
            {
                this.shouldSerialize["prepayment"] = true;
                this.prepayment = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RecordPaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPrepayment()
        {
            this.shouldSerialize["prepayment"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrepayment()
        {
            return this.shouldSerialize["prepayment"];
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
            return obj is RecordPaymentResponse other &&                ((this.PaidInvoices == null && other.PaidInvoices == null) || (this.PaidInvoices?.Equals(other.PaidInvoices) == true)) &&
                ((this.Prepayment == null && other.Prepayment == null) || (this.Prepayment?.Equals(other.Prepayment) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaidInvoices = {(this.PaidInvoices == null ? "null" : $"[{string.Join(", ", this.PaidInvoices)} ]")}");
            toStringOutput.Add($"Prepayment = {(this.Prepayment == null ? "null" : this.Prepayment.ToString())}");
        }
    }
}