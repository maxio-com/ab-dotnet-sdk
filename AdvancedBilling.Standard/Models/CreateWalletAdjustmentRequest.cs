// <copyright file="CreateWalletAdjustmentRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CreateWalletAdjustmentRequest.
    /// </summary>
    public class CreateWalletAdjustmentRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletAdjustmentRequest"/> class.
        /// </summary>
        public CreateWalletAdjustmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWalletAdjustmentRequest"/> class.
        /// </summary>
        /// <param name="adjustment">adjustment.</param>
        public CreateWalletAdjustmentRequest(
            Models.Adjustment adjustment)
        {
            this.Adjustment = adjustment;
        }

        /// <summary>
        /// Gets or sets Adjustment.
        /// </summary>
        [JsonProperty("adjustment")]
        public Models.Adjustment Adjustment { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CreateWalletAdjustmentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CreateWalletAdjustmentRequest other &&
                (this.Adjustment == null && other.Adjustment == null ||
                 this.Adjustment?.Equals(other.Adjustment) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Adjustment = {(this.Adjustment == null ? "null" : this.Adjustment.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}