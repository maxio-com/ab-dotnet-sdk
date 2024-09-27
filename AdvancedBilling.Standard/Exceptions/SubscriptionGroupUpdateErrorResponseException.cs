// <copyright file="SubscriptionGroupUpdateErrorResponseException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace AdvancedBilling.Standard.Exceptions
{
    /// <summary>
    /// SubscriptionGroupUpdateErrorResponseException.
    /// </summary>
    public class SubscriptionGroupUpdateErrorResponseException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupUpdateErrorResponseException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public SubscriptionGroupUpdateErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionGroupUpdateError Errors { get; set; }
    }
}