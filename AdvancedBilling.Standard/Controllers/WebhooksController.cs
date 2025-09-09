// <copyright file="WebhooksController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
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

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// WebhooksController.
    /// </summary>
    public class WebhooksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksController"/> class.
        /// </summary>
        internal WebhooksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Allows you to view a list of webhooks.  You can pass query parameters if you want to filter webhooks. See the [Webhooks](page:introduction/webhooks/webhooks) documentation for more information.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.WebhookResponse response from the API call.</returns>
        public List<Models.WebhookResponse> ListWebhooks(
                Models.ListWebhooksInput input)
            => CoreHelper.RunTask(ListWebhooksAsync(input));

        /// <summary>
        /// Allows you to view a list of webhooks.  You can pass query parameters if you want to filter webhooks. See the [Webhooks](page:introduction/webhooks/webhooks) documentation for more information.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.WebhookResponse response from the API call.</returns>
        public async Task<List<Models.WebhookResponse>> ListWebhooksAsync(
                Models.ListWebhooksInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.WebhookResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/webhooks.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("status", (input.Status.HasValue) ? ApiHelper.JsonSerialize(input.Status.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("since_date", input.SinceDate))
                      .Query(_query => _query.Setup("until_date", input.UntilDate))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("order", (input.Order.HasValue) ? ApiHelper.JsonSerialize(input.Order.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("subscription", input.Subscription))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Allows you to enable webhooks for your site.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.EnableWebhooksResponse response from the API call.</returns>
        public Models.EnableWebhooksResponse EnableWebhooks(
                Models.EnableWebhooksRequest body = null)
            => CoreHelper.RunTask(EnableWebhooksAsync(body));

        /// <summary>
        /// Allows you to enable webhooks for your site.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EnableWebhooksResponse response from the API call.</returns>
        public async Task<Models.EnableWebhooksResponse> EnableWebhooksAsync(
                Models.EnableWebhooksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EnableWebhooksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/webhooks/settings.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Replays webhooks. Posting to this endpoint does not immediately resend the webhooks. They are added to a queue and sent as soon as possible, depending on available system resources. You can submit an array of up to 1000 webhook IDs in the replay request.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ReplayWebhooksResponse response from the API call.</returns>
        public Models.ReplayWebhooksResponse ReplayWebhooks(
                Models.ReplayWebhooksRequest body = null)
            => CoreHelper.RunTask(ReplayWebhooksAsync(body));

        /// <summary>
        /// Replays webhooks. Posting to this endpoint does not immediately resend the webhooks. They are added to a queue and sent as soon as possible, depending on available system resources. You can submit an array of up to 1000 webhook IDs in the replay request.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ReplayWebhooksResponse response from the API call.</returns>
        public async Task<Models.ReplayWebhooksResponse> ReplayWebhooksAsync(
                Models.ReplayWebhooksRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ReplayWebhooksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/webhooks/replay.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates an endpoint and assigns a list of webhooks subscriptions (events) to it.
        /// See the [Webhooks Reference](page:introduction/webhooks/webhooks-reference#events) page for available events.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.EndpointResponse response from the API call.</returns>
        public Models.EndpointResponse CreateEndpoint(
                Models.CreateOrUpdateEndpointRequest body = null)
            => CoreHelper.RunTask(CreateEndpointAsync(body));

        /// <summary>
        /// Creates an endpoint and assigns a list of webhooks subscriptions (events) to it.
        /// See the [Webhooks Reference](page:introduction/webhooks/webhooks-reference#events) page for available events.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EndpointResponse response from the API call.</returns>
        public async Task<Models.EndpointResponse> CreateEndpointAsync(
                Models.CreateOrUpdateEndpointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EndpointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/endpoints.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns created endpoints for a site.
        /// </summary>
        /// <returns>Returns the List of Models.Endpoint response from the API call.</returns>
        public List<Models.Endpoint> ListEndpoints()
            => CoreHelper.RunTask(ListEndpointsAsync());

        /// <summary>
        /// Returns created endpoints for a site.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Endpoint response from the API call.</returns>
        public async Task<List<Models.Endpoint>> ListEndpointsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Endpoint>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/endpoints.json")
                  .WithAuth("BasicAuth"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an Endpoint. You can change the `url` of your endpoint or the list of `webhook_subscriptions` to which you are subscribed. See the [Webhooks Reference](page:introduction/webhooks/webhooks-reference#events) page for available events.
        /// Always send a complete list of events to which you want to subscribe. Sending a PUT request for an existing endpoint with an empty list of `webhook_subscriptions` will unsubscribe all events.
        /// If you want unsubscribe from a specific event, send a list of `webhook_subscriptions` without the specific event key.
        /// </summary>
        /// <param name="endpointId">Required parameter: The Advanced Billing id for the endpoint that should be updated.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.EndpointResponse response from the API call.</returns>
        public Models.EndpointResponse UpdateEndpoint(
                int endpointId,
                Models.CreateOrUpdateEndpointRequest body = null)
            => CoreHelper.RunTask(UpdateEndpointAsync(endpointId, body));

        /// <summary>
        /// Updates an Endpoint. You can change the `url` of your endpoint or the list of `webhook_subscriptions` to which you are subscribed. See the [Webhooks Reference](page:introduction/webhooks/webhooks-reference#events) page for available events.
        /// Always send a complete list of events to which you want to subscribe. Sending a PUT request for an existing endpoint with an empty list of `webhook_subscriptions` will unsubscribe all events.
        /// If you want unsubscribe from a specific event, send a list of `webhook_subscriptions` without the specific event key.
        /// </summary>
        /// <param name="endpointId">Required parameter: The Advanced Billing id for the endpoint that should be updated.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EndpointResponse response from the API call.</returns>
        public async Task<Models.EndpointResponse> UpdateEndpointAsync(
                int endpointId,
                Models.CreateOrUpdateEndpointRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EndpointResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/endpoints/{endpoint_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("endpoint_id", endpointId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}