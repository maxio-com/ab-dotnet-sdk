// <copyright file="ListCreditNotesResponse.cs" company="APIMatic">
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
    /// ListCreditNotesResponse.
    /// </summary>
    public class ListCreditNotesResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCreditNotesResponse"/> class.
        /// </summary>
        public ListCreditNotesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCreditNotesResponse"/> class.
        /// </summary>
        /// <param name="creditNotes">credit_notes.</param>
        public ListCreditNotesResponse(
            List<Models.CreditNote> creditNotes)
        {
            this.CreditNotes = creditNotes;
        }

        /// <summary>
        /// Gets or sets CreditNotes.
        /// </summary>
        [JsonProperty("credit_notes")]
        public List<Models.CreditNote> CreditNotes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListCreditNotesResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListCreditNotesResponse other &&
                (this.CreditNotes == null && other.CreditNotes == null ||
                 this.CreditNotes?.Equals(other.CreditNotes) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CreditNotes = {(this.CreditNotes == null ? "null" : $"[{string.Join(", ", this.CreditNotes)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}