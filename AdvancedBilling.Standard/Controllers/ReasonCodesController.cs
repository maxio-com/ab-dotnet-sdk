// <copyright file="ReasonCodesController.cs" company="APIMatic">
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
    /// ReasonCodesController.
    /// </summary>
    public class ReasonCodesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReasonCodesController"/> class.
        /// </summary>
        internal ReasonCodesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// # Reason Codes Intro.
        /// ReasonCodes are a way to gain a high level view of why your customers are cancelling the subcription to your product or service.
        /// Add a set of churn reason codes to be displayed in-app and/or the Chargify Billing Portal. As your subscribers decide to cancel their subscription, learn why they decided to cancel.
        /// ## Reason Code Documentation.
        /// Full documentation on how Reason Codes operate within Chargify can be located under the following links.
        /// [Churn Reason Codes](https://chargify.zendesk.com/hc/en-us/articles/4407896775579#churn-reason-codes).
        /// ## Create Reason Code.
        /// This method gives a merchant the option to create a reason codes for a given Site.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public Models.ReasonCodeResponse CreateReasonCode(
                Models.CreateReasonCodeRequest body = null)
            => CoreHelper.RunTask(CreateReasonCodeAsync(body));

        /// <summary>
        /// # Reason Codes Intro.
        /// ReasonCodes are a way to gain a high level view of why your customers are cancelling the subcription to your product or service.
        /// Add a set of churn reason codes to be displayed in-app and/or the Chargify Billing Portal. As your subscribers decide to cancel their subscription, learn why they decided to cancel.
        /// ## Reason Code Documentation.
        /// Full documentation on how Reason Codes operate within Chargify can be located under the following links.
        /// [Churn Reason Codes](https://chargify.zendesk.com/hc/en-us/articles/4407896775579#churn-reason-codes).
        /// ## Create Reason Code.
        /// This method gives a merchant the option to create a reason codes for a given Site.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<Models.ReasonCodeResponse> CreateReasonCodeAsync(
                Models.CreateReasonCodeRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReasonCodeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/reason_codes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method gives a merchant the option to retrieve a list of all of the current churn codes for a given site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ReasonCodeResponse response from the API call.</returns>
        public List<Models.ReasonCodeResponse> ListReasonCodes(
                Models.ListReasonCodesInput input)
            => CoreHelper.RunTask(ListReasonCodesAsync(input));

        /// <summary>
        /// This method gives a merchant the option to retrieve a list of all of the current churn codes for a given site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<List<Models.ReasonCodeResponse>> ListReasonCodesAsync(
                Models.ListReasonCodesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ReasonCodeResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reason_codes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method gives a merchant the option to retrieve a list of a particular code for a given Site by providing the unique numerical ID of the code.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Chargify id of the reason code.</param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public Models.ReasonCodeResponse ReadReasonCode(
                int reasonCodeId)
            => CoreHelper.RunTask(ReadReasonCodeAsync(reasonCodeId));

        /// <summary>
        /// This method gives a merchant the option to retrieve a list of a particular code for a given Site by providing the unique numerical ID of the code.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Chargify id of the reason code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<Models.ReasonCodeResponse> ReadReasonCodeAsync(
                int reasonCodeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReasonCodeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/reason_codes/{reason_code_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("reason_code_id", reasonCodeId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method gives a merchant the option to update an existing reason code for a given site.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Chargify id of the reason code.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public Models.ReasonCodeResponse UpdateReasonCode(
                int reasonCodeId,
                Models.UpdateReasonCodeRequest body = null)
            => CoreHelper.RunTask(UpdateReasonCodeAsync(reasonCodeId, body));

        /// <summary>
        /// This method gives a merchant the option to update an existing reason code for a given site.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Chargify id of the reason code.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReasonCodeResponse response from the API call.</returns>
        public async Task<Models.ReasonCodeResponse> UpdateReasonCodeAsync(
                int reasonCodeId,
                Models.UpdateReasonCodeRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReasonCodeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/reason_codes/{reason_code_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("reason_code_id", reasonCodeId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method gives a merchant the option to delete one reason code from the Churn Reason Codes. This code will be immediately removed. This action is not reversable.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Chargify id of the reason code.</param>
        /// <returns>Returns the Models.ReasonCodesJsonResponse response from the API call.</returns>
        public Models.ReasonCodesJsonResponse DeleteReasonCode(
                int reasonCodeId)
            => CoreHelper.RunTask(DeleteReasonCodeAsync(reasonCodeId));

        /// <summary>
        /// This method gives a merchant the option to delete one reason code from the Churn Reason Codes. This code will be immediately removed. This action is not reversable.
        /// </summary>
        /// <param name="reasonCodeId">Required parameter: The Chargify id of the reason code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReasonCodesJsonResponse response from the API call.</returns>
        public async Task<Models.ReasonCodesJsonResponse> DeleteReasonCodeAsync(
                int reasonCodeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReasonCodesJsonResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/reason_codes/{reason_code_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("reason_code_id", reasonCodeId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}