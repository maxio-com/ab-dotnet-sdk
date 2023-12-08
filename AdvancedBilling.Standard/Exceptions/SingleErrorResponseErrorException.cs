// <copyright file="SingleErrorResponseErrorException.cs" company="APIMatic">
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
    /// SingleErrorResponseErrorException.
    /// </summary>
    public class SingleErrorResponseErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleErrorResponseErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public SingleErrorResponseErrorException(string reason, HttpContext context)
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