// <copyright file="SendEmail.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SendEmail.
    /// </summary>
    public class SendEmail : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail"/> class.
        /// </summary>
        public SendEmail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail"/> class.
        /// </summary>
        /// <param name="canExecute">can_execute.</param>
        /// <param name="url">url.</param>
        public SendEmail(
            bool canExecute,
            string url)
        {
            this.CanExecute = canExecute;
            this.Url = url;
        }

        /// <summary>
        /// Gets or sets CanExecute.
        /// </summary>
        [JsonProperty("can_execute")]
        public bool CanExecute { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SendEmail : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SendEmail other &&
                (this.CanExecute.Equals(other.CanExecute)) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"CanExecute = {this.CanExecute}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}