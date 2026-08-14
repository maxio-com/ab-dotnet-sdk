// <copyright file="ReferralCodesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
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
        /// Validates whether a referral code is valid and applicable within your site. This method is useful for validating referral codes that are entered by a customer.
        /// For more information, see [Understanding Referrals](https://docs.maxio.com/hc/en-us/articles/24286981223693-Understanding-Referrals) in the product documentation.
        /// </summary>
        /// <param name="code">Required parameter: The referral code you are trying to validate.</param>
        /// <returns>Returns the Models.ReferralValidationResponse response from the API call.</returns>
        public Models.ReferralValidationResponse ValidateReferralCode(
                string code)
            => CoreHelper.RunTask(ValidateReferralCodeAsync(code));

        /// <summary>
        /// Validates whether a referral code is valid and applicable within your site. This method is useful for validating referral codes that are entered by a customer.
        /// For more information, see [Understanding Referrals](https://docs.maxio.com/hc/en-us/articles/24286981223693-Understanding-Referrals) in the product documentation.
        /// </summary>
        /// <param name="code">Required parameter: The referral code you are trying to validate.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReferralValidationResponse response from the API call.</returns>
        public async Task<Models.ReferralValidationResponse> ValidateReferralCodeAsync(
                string code,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReferralValidationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/referral_codes/validate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("code", code).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Invalid referral code.", (errorReason, context) => new SingleStringErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}