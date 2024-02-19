// <copyright file="ReferralCodesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Exceptions;
    using AdvancedBilling.Standard.Http.Client;
    using AdvancedBilling.Standard.Utilities;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// ReferralCodesController.
    /// </summary>
    public class ReferralCodesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralCodesController"/> class.
        /// </summary>
        internal ReferralCodesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Use this method to determine if the referral code is valid and applicable within your Site. This method is useful for validating referral codes that are entered by a customer.
        /// ## Referrals Documentation.
        /// Full documentation on how to use the referrals feature in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407802831643).
        /// ## Server Response.
        /// If the referral code is valid the status code will be `200` and the referral code will be returned. If the referral code is invalid, a `404` response will be returned.
        /// </summary>
        /// <param name="code">Required parameter: The referral code you are trying to validate.</param>
        /// <returns>Returns the Models.ReferralValidationResponse response from the API call.</returns>
        public Models.ReferralValidationResponse ValidateReferralCode(
                string code)
            => CoreHelper.RunTask(ValidateReferralCodeAsync(code));

        /// <summary>
        /// Use this method to determine if the referral code is valid and applicable within your Site. This method is useful for validating referral codes that are entered by a customer.
        /// ## Referrals Documentation.
        /// Full documentation on how to use the referrals feature in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407802831643).
        /// ## Server Response.
        /// If the referral code is valid the status code will be `200` and the referral code will be returned. If the referral code is invalid, a `404` response will be returned.
        /// </summary>
        /// <param name="code">Required parameter: The referral code you are trying to validate.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReferralValidationResponse response from the API call.</returns>
        public async Task<Models.ReferralValidationResponse> ValidateReferralCodeAsync(
                string code,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReferralValidationResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/referral_codes/validate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("code", code).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Invalid referral code.", (_reason, _context) => new SingleStringErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}