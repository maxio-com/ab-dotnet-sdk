// <copyright file="BaseController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Controllers
{
    using APIMatic.Core;
    using APIMatic.Core.Http.Configuration;
    using APIMatic.Core.Response;
    using AdvancedBilling.Standard.Exceptions;
    using AdvancedBilling.Standard.Http.Client;
    using AdvancedBilling.Standard.Http.Request;
    using AdvancedBilling.Standard.Http.Response;
    using AdvancedBilling.Standard.Utilities;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The base class for all controller classes.
    /// </summary>
    public class BaseController
    {
        private readonly GlobalConfiguration globalConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        internal BaseController(GlobalConfiguration config) => globalConfiguration = config;

        protected static ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException> CreateErrorCase(string reason, Func<string, HttpContext, ApiException> error, bool isErrorTemplate = false)
            => new ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>(reason, error, isErrorTemplate);

        protected ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T> CreateApiCall<T>(ArraySerialization arraySerialization = ArraySerialization.CSV)
            => new ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T>(
                globalConfiguration,
                compatibilityFactory,
                serialization: arraySerialization,
                globalErrors: globalErrors
            );

        private static readonly CompatibilityFactory compatibilityFactory = new CompatibilityFactory();
        private static readonly Dictionary<string, ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>> globalErrors = new Dictionary<string, ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>>
        {
            { "404", CreateErrorCase("Not Found:'{$response.body}'", (reason, context) => new ApiException(reason, context), true) },
            { "0", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (reason, context) => new ApiException(reason, context), true) }
        };
    }
}