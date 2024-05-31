// <copyright file="DeductServiceCreditRequest.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is DeductServiceCreditRequest other &&                ((this.Deduction == null && other.Deduction == null) || (this.Deduction?.Equals(other.Deduction) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Deduction = {(this.Deduction == null ? "null" : this.Deduction.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}