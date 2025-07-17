// <copyright file="InsightsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// InsightsController.
    /// </summary>
    public class InsightsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsightsController"/> class.
        /// </summary>
        internal InsightsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// The Stats API is a very basic view of some Site-level stats. This API call only answers with JSON responses. An XML version is not provided.
        /// ## Stats Documentation.
        /// There currently is not a complimentary matching set of documentation that compliments this endpoint. However, each Site's dashboard will reflect the summary of information provided in the Stats response.
        /// ```.
        /// https://subdomain.chargify.com/dashboard.
        /// ```.
        /// </summary>
        /// <returns>Returns the Models.SiteSummary response from the API call.</returns>
        public Models.SiteSummary ReadSiteStats()
            => CoreHelper.RunTask(ReadSiteStatsAsync());

        /// <summary>
        /// The Stats API is a very basic view of some Site-level stats. This API call only answers with JSON responses. An XML version is not provided.
        /// ## Stats Documentation.
        /// There currently is not a complimentary matching set of documentation that compliments this endpoint. However, each Site's dashboard will reflect the summary of information provided in the Stats response.
        /// ```.
        /// https://subdomain.chargify.com/dashboard.
        /// ```.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SiteSummary response from the API call.</returns>
        public async Task<Models.SiteSummary> ReadSiteStatsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SiteSummary>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/stats.json")
                  .WithAuth("BasicAuth"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint returns your site's current MRR, including plan and usage breakouts.
        /// </summary>
        /// <param name="atTime">Optional parameter: submit a timestamp in ISO8601 format to request MRR for a historic time.</param>
        /// <param name="subscriptionId">Optional parameter: submit the id of a subscription in order to limit results.</param>
        /// <returns>Returns the Models.MRRResponse response from the API call.</returns>
        [Obsolete]
        public Models.MRRResponse ReadMrr(
                DateTimeOffset? atTime = null,
                int? subscriptionId = null)
            => CoreHelper.RunTask(ReadMrrAsync(atTime, subscriptionId));

        /// <summary>
        /// This endpoint returns your site's current MRR, including plan and usage breakouts.
        /// </summary>
        /// <param name="atTime">Optional parameter: submit a timestamp in ISO8601 format to request MRR for a historic time.</param>
        /// <param name="subscriptionId">Optional parameter: submit the id of a subscription in order to limit results.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MRRResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.MRRResponse> ReadMrrAsync(
                DateTimeOffset? atTime = null,
                int? subscriptionId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MRRResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/mrr.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("at_time", atTime.HasValue ? atTime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("subscription_id", subscriptionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// This endpoint returns your site's MRR movements.
        /// ## Understanding MRR movements.
        /// This endpoint will aid in accessing your site's [MRR Report](https://maxio.zendesk.com/hc/en-us/articles/24285894587021-MRR-Analytics) data.
        /// Whenever a subscription event occurs that causes your site's MRR to change (such as a signup or upgrade), we record an MRR movement. These records are accessible via the MRR Movements endpoint.
        /// Each MRR Movement belongs to a subscription and contains a timestamp, category, and an amount. `line_items` represent the subscription's product configuration at the time of the movement.
        /// ### Plan & Usage Breakouts.
        /// In the MRR Report UI, we support a setting to [include or exclude](https://maxio.zendesk.com/hc/en-us/articles/24285894587021-MRR-Analytics#displaying-component-based-metered-usage-in-mrr) usage revenue. In the MRR APIs, responses include `plan` and `usage` breakouts.
        /// Plan includes revenue from:.
        /// * Products.
        /// * Quantity-Based Components.
        /// * On/Off Components.
        /// Usage includes revenue from:.
        /// * Metered Components.
        /// * Prepaid Usage Components.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListMRRResponse response from the API call.</returns>
        [Obsolete]
        public Models.ListMRRResponse ListMrrMovements(
                Models.ListMrrMovementsInput input)
            => CoreHelper.RunTask(ListMrrMovementsAsync(input));

        /// <summary>
        /// <![CDATA[
        /// This endpoint returns your site's MRR movements.
        /// ## Understanding MRR movements.
        /// This endpoint will aid in accessing your site's [MRR Report](https://maxio.zendesk.com/hc/en-us/articles/24285894587021-MRR-Analytics) data.
        /// Whenever a subscription event occurs that causes your site's MRR to change (such as a signup or upgrade), we record an MRR movement. These records are accessible via the MRR Movements endpoint.
        /// Each MRR Movement belongs to a subscription and contains a timestamp, category, and an amount. `line_items` represent the subscription's product configuration at the time of the movement.
        /// ### Plan & Usage Breakouts.
        /// In the MRR Report UI, we support a setting to [include or exclude](https://maxio.zendesk.com/hc/en-us/articles/24285894587021-MRR-Analytics#displaying-component-based-metered-usage-in-mrr) usage revenue. In the MRR APIs, responses include `plan` and `usage` breakouts.
        /// Plan includes revenue from:.
        /// * Products.
        /// * Quantity-Based Components.
        /// * On/Off Components.
        /// Usage includes revenue from:.
        /// * Metered Components.
        /// * Prepaid Usage Components.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListMRRResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.ListMRRResponse> ListMrrMovementsAsync(
                Models.ListMrrMovementsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListMRRResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/mrr_movements.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("subscription_id", input.SubscriptionId))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint returns your site's current MRR, including plan and usage breakouts split per subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.SubscriptionMRRResponse response from the API call.</returns>
        [Obsolete]
        public Models.SubscriptionMRRResponse ListMrrPerSubscription(
                Models.ListMrrPerSubscriptionInput input)
            => CoreHelper.RunTask(ListMrrPerSubscriptionAsync(input));

        /// <summary>
        /// This endpoint returns your site's current MRR, including plan and usage breakouts split per subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionMRRResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.SubscriptionMRRResponse> ListMrrPerSubscriptionAsync(
                Models.ListMrrPerSubscriptionInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionMRRResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions_mrr.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("filter", input.Filter))
                      .Query(_query => _query.Setup("at_time", input.AtTime))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SubscriptionsMrrErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}