// <copyright file="IssueServiceCreditRequest.cs" company="APIMatic">
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
    /// IssueServiceCreditRequest.
    /// </summary>
    public class IssueServiceCreditRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueServiceCreditRequest"/> class.
        /// </summary>
        public IssueServiceCreditRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueServiceCreditRequest"/> class.
        /// </summary>
        /// <param name="serviceCredit">service_credit.</param>
        public IssueServiceCreditRequest(
            Models.IssueServiceCredit serviceCredit)
        {
            this.ServiceCredit = serviceCredit;
        }

        /// <summary>
        /// Gets or sets ServiceCredit.
        /// </summary>
        [JsonProperty("service_credit")]
        public Models.IssueServiceCredit ServiceCredit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IssueServiceCreditRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is IssueServiceCreditRequest other &&                ((this.ServiceCredit == null && other.ServiceCredit == null) || (this.ServiceCredit?.Equals(other.ServiceCredit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServiceCredit = {(this.ServiceCredit == null ? "null" : this.ServiceCredit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}