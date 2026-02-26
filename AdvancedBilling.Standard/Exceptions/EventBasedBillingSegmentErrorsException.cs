// <copyright file="EventBasedBillingSegmentErrorsException.cs" company="APIMatic">
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
    /// EventBasedBillingSegmentErrorsException.
    /// </summary>
    public class EventBasedBillingSegmentErrorsException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventBasedBillingSegmentErrorsException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public EventBasedBillingSegmentErrorsException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// The key of the object would be a number (an index in the request array) where the error occurred. In the value object, the key represents the field and the value is an array with error messages. In most cases, this object would contain just one key.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public object Errors { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EventBasedBillingSegmentErrorsException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : this.Errors.ToString())}");
            toStringOutput.Add($"StackTrace = {(StackTrace != null ? $"\n{StackTrace}" : "null")}");
        }
    }
}