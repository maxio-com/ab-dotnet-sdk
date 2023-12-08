// <copyright file="ApplyDebitNoteEventData.cs" company="APIMatic">
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
    /// ApplyDebitNoteEventData.
    /// </summary>
    public class ApplyDebitNoteEventData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyDebitNoteEventData"/> class.
        /// </summary>
        public ApplyDebitNoteEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyDebitNoteEventData"/> class.
        /// </summary>
        /// <param name="debitNoteNumber">debit_note_number.</param>
        /// <param name="debitNoteUid">debit_note_uid.</param>
        /// <param name="originalAmount">original_amount.</param>
        /// <param name="appliedAmount">applied_amount.</param>
        public ApplyDebitNoteEventData(
            string debitNoteNumber = null,
            string debitNoteUid = null,
            string originalAmount = null,
            string appliedAmount = null)
        {
            this.DebitNoteNumber = debitNoteNumber;
            this.DebitNoteUid = debitNoteUid;
            this.OriginalAmount = originalAmount;
            this.AppliedAmount = appliedAmount;
        }

        /// <summary>
        /// A unique, identifying string that appears on the debit note and in places it is referenced.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("debit_note_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitNoteNumber { get; set; }

        /// <summary>
        /// Unique identifier for the debit note. It is generated automatically by Chargify and has the prefix "db_" followed by alphanumeric characters.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("debit_note_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitNoteUid { get; set; }

        /// <summary>
        /// The full, original amount of the debit note.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The amount of the debit note applied to invoice.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("applied_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ApplyDebitNoteEventData : ({string.Join(", ", toStringOutput)})";
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
            return obj is ApplyDebitNoteEventData other &&                ((this.DebitNoteNumber == null && other.DebitNoteNumber == null) || (this.DebitNoteNumber?.Equals(other.DebitNoteNumber) == true)) &&
                ((this.DebitNoteUid == null && other.DebitNoteUid == null) || (this.DebitNoteUid?.Equals(other.DebitNoteUid) == true)) &&
                ((this.OriginalAmount == null && other.OriginalAmount == null) || (this.OriginalAmount?.Equals(other.OriginalAmount) == true)) &&
                ((this.AppliedAmount == null && other.AppliedAmount == null) || (this.AppliedAmount?.Equals(other.AppliedAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DebitNoteNumber = {(this.DebitNoteNumber == null ? "null" : this.DebitNoteNumber)}");
            toStringOutput.Add($"this.DebitNoteUid = {(this.DebitNoteUid == null ? "null" : this.DebitNoteUid)}");
            toStringOutput.Add($"this.OriginalAmount = {(this.OriginalAmount == null ? "null" : this.OriginalAmount)}");
            toStringOutput.Add($"this.AppliedAmount = {(this.AppliedAmount == null ? "null" : this.AppliedAmount)}");
        }
    }
}