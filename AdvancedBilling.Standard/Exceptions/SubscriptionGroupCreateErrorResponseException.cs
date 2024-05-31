// <copyright file="SubscriptionGroupCreateErrorResponseException.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionGroupCreateErrorResponseException.
    /// </summary>
    public class SubscriptionGroupCreateErrorResponseException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupCreateErrorResponseException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public SubscriptionGroupCreateErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors")]
        public SubscriptionGroupCreateErrorResponseErrors Errors { get; set; }
    }
}