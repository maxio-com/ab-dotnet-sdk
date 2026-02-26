// <copyright file="AvailableActions.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// AvailableActions.
    /// </summary>
    public class AvailableActions : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableActions"/> class.
        /// </summary>
        public AvailableActions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableActions"/> class.
        /// </summary>
        /// <param name="sendEmail">send_email.</param>
        public AvailableActions(
            Models.SendEmail sendEmail = null)
        {
            this.SendEmail = sendEmail;
        }

        /// <summary>
        /// Gets or sets SendEmail.
        /// </summary>
        [JsonProperty("send_email", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SendEmail SendEmail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AvailableActions : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AvailableActions other &&
                (this.SendEmail == null && other.SendEmail == null ||
                 this.SendEmail?.Equals(other.SendEmail) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SendEmail = {(this.SendEmail == null ? "null" : this.SendEmail.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}