// <copyright file="InsightsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

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
        /// Returns basic site-level stats. This API call only answers with JSON responses. An XML version is not provided.
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
        /// Returns basic site-level stats. This API call only answers with JSON responses. An XML version is not provided.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/stats.json")
                  .WithAuth("BasicAuth"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns your site's current MRR, including plan and usage breakouts.
        /// </summary>
        /// <param name="atTime">Optional parameter: submit a timestamp in ISO8601 format to request MRR for a historic time..</param>
        /// <param name="subscriptionId">Optional parameter: submit the id of a subscription in order to limit results..</param>
        /// <returns>Returns the Models.MRRResponse response from the API call.</returns>
        [Obsolete]
        public Models.MRRResponse ReadMrr(
                DateTimeOffset? atTime = null,
                int? subscriptionId = null)
            => CoreHelper.RunTask(ReadMrrAsync(atTime, subscriptionId));

        /// <summary>
        /// Returns your site's current MRR, including plan and usage breakouts.
        /// </summary>
        /// <param name="atTime">Optional parameter: submit a timestamp in ISO8601 format to request MRR for a historic time..</param>
        /// <param name="subscriptionId">Optional parameter: submit the id of a subscription in order to limit results..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MRRResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.MRRResponse> ReadMrrAsync(
                DateTimeOffset? atTime = null,
                int? subscriptionId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MRRResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/mrr.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("at_time", atTime.HasValue ? atTime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("subscription_id", subscriptionId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Lists your site's MRR movements.
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
        /// Lists your site's MRR movements.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/mrr_movements.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists your site's current MRR, including plan and usage breakouts split per subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.SubscriptionMRRResponse response from the API call.</returns>
        [Obsolete]
        public Models.SubscriptionMRRResponse ListMrrPerSubscription(
                Models.ListMrrPerSubscriptionInput input)
            => CoreHelper.RunTask(ListMrrPerSubscriptionAsync(input));

        /// <summary>
        /// Lists your site's current MRR, including plan and usage breakouts split per subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionMRRResponse response from the API call.</returns>
        [Obsolete]
        public async Task<Models.SubscriptionMRRResponse> ListMrrPerSubscriptionAsync(
                Models.ListMrrPerSubscriptionInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionMRRResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions_mrr.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("at_time", input.AtTime))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SubscriptionsMrrErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}