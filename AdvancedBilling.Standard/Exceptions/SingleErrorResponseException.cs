// <copyright file="SingleErrorResponseException.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Http.Client;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Exceptions
{
    /// <summary>
    /// SingleErrorResponseException.
    /// </summary>
    public class SingleErrorResponseException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleErrorResponseException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public SingleErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SingleErrorResponseException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Error = {this.Error ?? "null"}");
            toStringOutput.Add($"StackTrace = {(StackTrace != null ? $"\n{StackTrace}" : "null")}");
        }
    }
}