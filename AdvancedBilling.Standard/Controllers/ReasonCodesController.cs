// <copyright file="ReasonCodesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// ReasonCodesController.
    /// </summary>
    public class ReasonCodesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReasonCodesController"/> class.
        /// </summary>
        internal ReasonCodesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a reason code for a given site.
        /// Reason Codes are a way to gain a high-level view of why your customers are cancelling the subscription to your product or service.
        /// Add a set of churn reason codes to be displayed in-app and/or the Maxio Billing Portal. As your subscribers decide to cancel their subscription, learn why they decided to cancel.
        /// For more information, see [Churn Reason Codes](https://maxio.zendesk.com/hc/en-us/articles/24286647554701-Churn-Reason-Codes).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public Models.ReasonCodeResponse CreateReasonCode(
                Models.CreateReasonCodeRequest body = null)
            => CoreHelper.RunTask(CreateReasonCodeAsync(body));

        /// <summary>
        /// Creates a reason code for a given site.
        /// Reason Codes are a way to gain a high-level view of why your customers are cancelling the subscription to your product or service.
        /// Add a set of churn reason codes to be displayed in-app and/or the Maxio Billing Portal. As your subscribers decide to cancel their subscription, learn why they decided to cancel.
        /// For more information, see [Churn Reason Codes](https://maxio.zendesk.com/hc/en-us/articles/24286647554701-Churn-Reason-Codes).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<Models.ReasonCodeResponse> CreateReasonCodeAsync(
                Models.CreateReasonCodeRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReasonCodeResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/reason_codes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists all current churn codes for a given site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ReasonCodeResponse response from the API call.</returns>
        public List<Models.ReasonCodeResponse> ListReasonCodes(
                Models.ListReasonCodesInput input)
            => CoreHelper.RunTask(ListReasonCodesAsync(input));

        /// <summary>
        /// Lists all current churn codes for a given site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<List<Models.ReasonCodeResponse>> ListReasonCodesAsync(
                Models.ListReasonCodesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ReasonCodeResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/reason_codes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a particular churn reason code for a given site by its unique ID.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Advanced Billing id of the reason code.</param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public Models.ReasonCodeResponse ReadReasonCode(
                int reasonCodeId)
            => CoreHelper.RunTask(ReadReasonCodeAsync(reasonCodeId));

        /// <summary>
        /// Returns a particular churn reason code for a given site by its unique ID.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Advanced Billing id of the reason code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<Models.ReasonCodeResponse> ReadReasonCodeAsync(
                int reasonCodeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReasonCodeResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/reason_codes/{reason_code_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("reason_code_id", reasonCodeId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an existing reason code for a given site.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Advanced Billing id of the reason code.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public Models.ReasonCodeResponse UpdateReasonCode(
                int reasonCodeId,
                Models.UpdateReasonCodeRequest body = null)
            => CoreHelper.RunTask(UpdateReasonCodeAsync(reasonCodeId, body));

        /// <summary>
        /// Updates an existing reason code for a given site.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Advanced Billing id of the reason code.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<Models.ReasonCodeResponse> UpdateReasonCodeAsync(
                int reasonCodeId,
                Models.UpdateReasonCodeRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReasonCodeResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/reason_codes/{reason_code_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("reason_code_id", reasonCodeId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a reason code from the Churn Reason Codes. This code will be immediately removed. This action is not reversible.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Advanced Billing id of the reason code.</param>
        /// <returns>Returns the Models.OkResponse response from the API call.</returns>
        public Models.OkResponse DeleteReasonCode(
                int reasonCodeId)
            => CoreHelper.RunTask(DeleteReasonCodeAsync(reasonCodeId));

        /// <summary>
        /// Deletes a reason code from the Churn Reason Codes. This code will be immediately removed. This action is not reversible.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Advanced Billing id of the reason code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OkResponse response from the API call.</returns>
        public async Task<Models.OkResponse> DeleteReasonCodeAsync(
                int reasonCodeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OkResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/reason_codes/{reason_code_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("reason_code_id", reasonCodeId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}