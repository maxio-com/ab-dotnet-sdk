// <copyright file="DeductServiceCreditRequest.cs" company="APIMatic">
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
    /// DeductServiceCreditRequest.
    /// </summary>
    public class DeductServiceCreditRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeductServiceCreditRequest"/> class.
        /// </summary>
        public DeductServiceCreditRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeductServiceCreditRequest"/> class.
        /// </summary>
        /// <param name="deduction">deduction.</param>
        public DeductServiceCreditRequest(
            Models.DeductServiceCredit deduction)
        {
            this.Deduction = deduction;
        }

        /// <summary>
        /// Gets or sets Deduction.
        /// </summary>
        [JsonProperty("deduction")]
        public Models.DeductServiceCredit Deduction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DeductServiceCreditRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DeductServiceCreditRequest other &&
                (this.Deduction == null && other.Deduction == null ||
                 this.Deduction?.Equals(other.Deduction) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Deduction = {(this.Deduction == null ? "null" : this.Deduction.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}