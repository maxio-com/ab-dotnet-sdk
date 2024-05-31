// <copyright file="RefundPrepaymentBaseErrorsResponseException.cs" company="APIMatic">
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
    /// RefundPrepaymentBaseErrorsResponseException.
    /// </summary>
    public class RefundPrepaymentBaseErrorsResponseException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPrepaymentBaseErrorsResponseException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public RefundPrepaymentBaseErrorsResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RefundPrepaymentBaseRefundError Errors { get; set; }
    }
}