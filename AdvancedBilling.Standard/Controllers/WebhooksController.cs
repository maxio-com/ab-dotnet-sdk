// <copyright file="WebhooksController.cs" company="APIMatic">
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
    /// WebhooksController.
    /// </summary>
    public class WebhooksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksController"/> class.
        /// </summary>
        internal WebhooksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// ## Webhooks Intro.
        /// The Webhooks API allows you to view a list of all webhooks and to selectively resend individual or groups of webhooks. Webhooks will be sent on endpoints specified by you. Endpoints can be added via API or Web UI. There is also an option to enable / disable webhooks via API request.
        /// We recommend that you review Advanced Billing's webhook documentation located in our help site. The following resources will help guide you on how to use webhooks in Advanced Billing, in addition to these webhook endpoints:.
        /// + [Adding/editing new webhooks](https://maxio.zendesk.com/hc/en-us/articles/24286723085197-Webhooks#configure-webhook-url).
        /// + [Webhooks introduction and delivery information](https://maxio.zendesk.com/hc/en-us/articles/24266143173901-Webhooks-Overview).
        /// + [Main webhook reference](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference).
        /// + [Available webhooks and payloads](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference#events).
        /// ## List Webhooks for a Site.
        /// This method allows you to fetch data about webhooks. You can pass query parameters if you want to filter webhooks.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.WebhookResponse response from the API call.</returns>
        public List<Models.WebhookResponse> ListWebhooks(
                Models.ListWebhooksInput input)
            => CoreHelper.RunTask(ListWebhooksAsync(input));

        /// <summary>
        /// ## Webhooks Intro.
        /// The Webhooks API allows you to view a list of all webhooks and to selectively resend individual or groups of webhooks. Webhooks will be sent on endpoints specified by you. Endpoints can be added via API or Web UI. There is also an option to enable / disable webhooks via API request.
        /// We recommend that you review Advanced Billing's webhook documentation located in our help site. The following resources will help guide you on how to use webhooks in Advanced Billing, in addition to these webhook endpoints:.
        /// + [Adding/editing new webhooks](https://maxio.zendesk.com/hc/en-us/articles/24286723085197-Webhooks#configure-webhook-url).
        /// + [Webhooks introduction and delivery information](https://maxio.zendesk.com/hc/en-us/articles/24266143173901-Webhooks-Overview).
        /// + [Main webhook reference](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference).
        /// + [Available webhooks and payloads](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference#events).
        /// ## List Webhooks for a Site.
        /// This method allows you to fetch data about webhooks. You can pass query parameters if you want to filter webhooks.
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
        /// This method allows you to enable webhooks via API for your site.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.EnableWebhooksResponse response from the API call.</returns>
        public Models.EnableWebhooksResponse EnableWebhooks(
                Models.EnableWebhooksRequest body = null)
            => CoreHelper.RunTask(EnableWebhooksAsync(body));

        /// <summary>
        /// This method allows you to enable webhooks via API for your site.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
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
        /// Posting to the replay endpoint does not immediately resend the webhooks. They are added to a queue and will be sent as soon as possible, depending on available system resources.
        /// You may submit an array of up to 1000 webhook IDs to replay in the request.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ReplayWebhooksResponse response from the API call.</returns>
        public Models.ReplayWebhooksResponse ReplayWebhooks(
                Models.ReplayWebhooksRequest body = null)
            => CoreHelper.RunTask(ReplayWebhooksAsync(body));

        /// <summary>
        /// Posting to the replay endpoint does not immediately resend the webhooks. They are added to a queue and will be sent as soon as possible, depending on available system resources.
        /// You may submit an array of up to 1000 webhook IDs to replay in the request.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
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
        /// The Chargify API allows you to create an endpoint and assign a list of webhooks subscriptions (events) to it.
        /// You can check available events here.
        /// [Event keys](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference#events).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.EndpointResponse response from the API call.</returns>
        public Models.EndpointResponse CreateEndpoint(
                Models.CreateOrUpdateEndpointRequest body = null)
            => CoreHelper.RunTask(CreateEndpointAsync(body));

        /// <summary>
        /// The Chargify API allows you to create an endpoint and assign a list of webhooks subscriptions (events) to it.
        /// You can check available events here.
        /// [Event keys](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference#events).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
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
        /// This method returns created endpoints for site.
        /// </summary>
        /// <returns>Returns the List of Models.Endpoint response from the API call.</returns>
        public List<Models.Endpoint> ListEndpoints()
            => CoreHelper.RunTask(ListEndpointsAsync());

        /// <summary>
        /// This method returns created endpoints for site.
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
        /// You can update an Endpoint via the API with a PUT request to the resource endpoint.
        /// You can change the `url` of your endpoint which consumes webhooks or list of `webhook_subscriptions`.
        /// Check available [Event keys](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference#events).
        /// Always send a complete list of events which you want subscribe/watch.
        /// Sending an PUT request for existing endpoint with empty list of `webhook_subscriptions` will end with unsubscribe from all events.
        /// If you want unsubscribe from specific event, just send a list of `webhook_subscriptions` without the specific event key.
        /// </summary>
        /// <param name="endpointId">Required parameter: The Advanced Billing id for the endpoint that should be updated.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.EndpointResponse response from the API call.</returns>
        public Models.EndpointResponse UpdateEndpoint(
                int endpointId,
                Models.CreateOrUpdateEndpointRequest body = null)
            => CoreHelper.RunTask(UpdateEndpointAsync(endpointId, body));

        /// <summary>
        /// You can update an Endpoint via the API with a PUT request to the resource endpoint.
        /// You can change the `url` of your endpoint which consumes webhooks or list of `webhook_subscriptions`.
        /// Check available [Event keys](https://maxio.zendesk.com/hc/en-us/articles/24266136649869-Webhooks-Reference#events).
        /// Always send a complete list of events which you want subscribe/watch.
        /// Sending an PUT request for existing endpoint with empty list of `webhook_subscriptions` will end with unsubscribe from all events.
        /// If you want unsubscribe from specific event, just send a list of `webhook_subscriptions` without the specific event key.
        /// </summary>
        /// <param name="endpointId">Required parameter: The Advanced Billing id for the endpoint that should be updated.</param>
        /// <param name="body">Optional parameter: Example: .</param>
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