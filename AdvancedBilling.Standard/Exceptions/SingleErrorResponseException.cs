// <copyright file="SingleErrorResponseException.cs" company="APIMatic">
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
    }
}