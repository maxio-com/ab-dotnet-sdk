// <copyright file="UpdateReasonCodeRequest.cs" company="APIMatic">
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
    /// UpdateReasonCodeRequest.
    /// </summary>
    public class UpdateReasonCodeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReasonCodeRequest"/> class.
        /// </summary>
        public UpdateReasonCodeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReasonCodeRequest"/> class.
        /// </summary>
        /// <param name="reasonCode">reason_code.</param>
        public UpdateReasonCodeRequest(
            Models.UpdateReasonCode reasonCode)
        {
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// Gets or sets ReasonCode.
        /// </summary>
        [JsonProperty("reason_code")]
        public Models.UpdateReasonCode ReasonCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateReasonCodeRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateReasonCodeRequest other &&                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode.ToString())}");
        }
    }
}