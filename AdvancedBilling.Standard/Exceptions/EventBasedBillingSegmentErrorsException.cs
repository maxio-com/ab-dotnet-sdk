// <copyright file="EventBasedBillingSegmentErrorsException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Exceptions
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
    using AdvancedBilling.Standard.Http.Client;
    using AdvancedBilling.Standard.Models;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

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
    }
}