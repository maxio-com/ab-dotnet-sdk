// <copyright file="SalesCommissionsController.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Authentication;
    using AdvancedBilling.Standard.Http.Client;
    using AdvancedBilling.Standard.Utilities;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// SalesCommissionsController.
    /// </summary>
    public class SalesCommissionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesCommissionsController"/> class.
        /// </summary>
        internal SalesCommissionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Endpoint returns sales rep list with details.
        /// ## Modified Authentication Process.
        /// The Sales Commission API differs from other Chargify API endpoints. This resource is associated with the seller itself. Up to now all available resources were at the level of the site, therefore creating the API Key per site was a sufficient solution. To share resources at the seller level, a new authentication method was introduced, which is user authentication. Creating an API Key for a user is a required step to correctly use the Sales Commission API, more details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication).
        /// Access to the Sales Commission API endpoints is available to users with financial access, where the seller has the Advanced Analytics component enabled. For further information on getting access to Advanced Analytics please contact Chargify support.
        /// > Note: The request is at seller level, it means `<<subdomain>>` variable will be replaced by `app`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ListSaleRepItem response from the API call.</returns>
        public List<Models.ListSaleRepItem> ListSalesReps(
                Models.ListSalesRepsInput input)
            => CoreHelper.RunTask(ListSalesRepsAsync(input));

        /// <summary>
        /// Endpoint returns sales rep list with details.
        /// ## Modified Authentication Process.
        /// The Sales Commission API differs from other Chargify API endpoints. This resource is associated with the seller itself. Up to now all available resources were at the level of the site, therefore creating the API Key per site was a sufficient solution. To share resources at the seller level, a new authentication method was introduced, which is user authentication. Creating an API Key for a user is a required step to correctly use the Sales Commission API, more details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication).
        /// Access to the Sales Commission API endpoints is available to users with financial access, where the seller has the Advanced Analytics component enabled. For further information on getting access to Advanced Analytics please contact Chargify support.
        /// > Note: The request is at seller level, it means `<<subdomain>>` variable will be replaced by `app`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ListSaleRepItem response from the API call.</returns>
        public async Task<List<Models.ListSaleRepItem>> ListSalesRepsAsync(
                Models.ListSalesRepsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ListSaleRepItem>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/sellers/{seller_id}/sales_reps.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("seller_id", input.SellerId).Required())
                      .Header(_header => _header.Setup("Authorization", input.Authorization))
                      .Query(_query => _query.Setup("live_mode", input.LiveMode))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Endpoint returns sales rep and attached subscriptions details.
        /// ## Modified Authentication Process.
        /// The Sales Commission API differs from other Chargify API endpoints. This resource is associated with the seller itself. Up to now all available resources were at the level of the site, therefore creating the API Key per site was a sufficient solution. To share resources at the seller level, a new authentication method was introduced, which is user authentication. Creating an API Key for a user is a required step to correctly use the Sales Commission API, more details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication).
        /// Access to the Sales Commission API endpoints is available to users with financial access, where the seller has the Advanced Analytics component enabled. For further information on getting access to Advanced Analytics please contact Chargify support.
        /// > Note: The request is at seller level, it means `<<subdomain>>` variable will be replaced by `app`.
        /// </summary>
        /// <param name="sellerId">Required parameter: The Chargify id of your seller account.</param>
        /// <param name="salesRepId">Required parameter: The Chargify id of sales rep..</param>
        /// <param name="authorization">Optional parameter: For authorization use user API key. See details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication)..</param>
        /// <param name="liveMode">Optional parameter: This parameter indicates if records should be fetched from live mode sites. Default value is true..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 100..</param>
        /// <returns>Returns the Models.SaleRep response from the API call.</returns>
        public Models.SaleRep ReadSalesRep(
                string sellerId,
                string salesRepId,
                string authorization = "Bearer <<apiKey>>",
                bool? liveMode = null,
                int? page = 1,
                int? perPage = 100)
            => CoreHelper.RunTask(ReadSalesRepAsync(sellerId, salesRepId, authorization, liveMode, page, perPage));

        /// <summary>
        /// Endpoint returns sales rep and attached subscriptions details.
        /// ## Modified Authentication Process.
        /// The Sales Commission API differs from other Chargify API endpoints. This resource is associated with the seller itself. Up to now all available resources were at the level of the site, therefore creating the API Key per site was a sufficient solution. To share resources at the seller level, a new authentication method was introduced, which is user authentication. Creating an API Key for a user is a required step to correctly use the Sales Commission API, more details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication).
        /// Access to the Sales Commission API endpoints is available to users with financial access, where the seller has the Advanced Analytics component enabled. For further information on getting access to Advanced Analytics please contact Chargify support.
        /// > Note: The request is at seller level, it means `<<subdomain>>` variable will be replaced by `app`.
        /// </summary>
        /// <param name="sellerId">Required parameter: The Chargify id of your seller account.</param>
        /// <param name="salesRepId">Required parameter: The Chargify id of sales rep..</param>
        /// <param name="authorization">Optional parameter: For authorization use user API key. See details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication)..</param>
        /// <param name="liveMode">Optional parameter: This parameter indicates if records should be fetched from live mode sites. Default value is true..</param>
        /// <param name="page">Optional parameter: Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned. Use in query `page=1`..</param>
        /// <param name="perPage">Optional parameter: This parameter indicates how many records to fetch in each request. Default value is 100..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SaleRep response from the API call.</returns>
        public async Task<Models.SaleRep> ReadSalesRepAsync(
                string sellerId,
                string salesRepId,
                string authorization = "Bearer <<apiKey>>",
                bool? liveMode = null,
                int? page = 1,
                int? perPage = 100,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SaleRep>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/sellers/{seller_id}/sales_reps/{sales_rep_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("seller_id", sellerId).Required())
                      .Template(_template => _template.Setup("sales_rep_id", salesRepId).Required())
                      .Header(_header => _header.Setup("Authorization", (authorization != null) ? authorization : "Bearer <<apiKey>>"))
                      .Query(_query => _query.Setup("live_mode", liveMode))
                      .Query(_query => _query.Setup("page", (page != null) ? page : 1))
                      .Query(_query => _query.Setup("per_page", (perPage != null) ? perPage : 100))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Endpoint returns subscriptions with associated sales reps.
        /// ## Modified Authentication Process.
        /// The Sales Commission API differs from other Chargify API endpoints. This resource is associated with the seller itself. Up to now all available resources were at the level of the site, therefore creating the API Key per site was a sufficient solution. To share resources at the seller level, a new authentication method was introduced, which is user authentication. Creating an API Key for a user is a required step to correctly use the Sales Commission API, more details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication).
        /// Access to the Sales Commission API endpoints is available to users with financial access, where the seller has the Advanced Analytics component enabled. For further information on getting access to Advanced Analytics please contact Chargify support.
        /// > Note: The request is at seller level, it means `<<subdomain>>` variable will be replaced by `app`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.SaleRepSettings response from the API call.</returns>
        public List<Models.SaleRepSettings> ListSalesCommissionSettings(
                Models.ListSalesCommissionSettingsInput input)
            => CoreHelper.RunTask(ListSalesCommissionSettingsAsync(input));

        /// <summary>
        /// Endpoint returns subscriptions with associated sales reps.
        /// ## Modified Authentication Process.
        /// The Sales Commission API differs from other Chargify API endpoints. This resource is associated with the seller itself. Up to now all available resources were at the level of the site, therefore creating the API Key per site was a sufficient solution. To share resources at the seller level, a new authentication method was introduced, which is user authentication. Creating an API Key for a user is a required step to correctly use the Sales Commission API, more details [here](https://developers.chargify.com/docs/developer-docs/ZG9jOjMyNzk5NTg0-2020-04-20-new-api-authentication).
        /// Access to the Sales Commission API endpoints is available to users with financial access, where the seller has the Advanced Analytics component enabled. For further information on getting access to Advanced Analytics please contact Chargify support.
        /// > Note: The request is at seller level, it means `<<subdomain>>` variable will be replaced by `app`.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.SaleRepSettings response from the API call.</returns>
        public async Task<List<Models.SaleRepSettings>> ListSalesCommissionSettingsAsync(
                Models.ListSalesCommissionSettingsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.SaleRepSettings>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/sellers/{seller_id}/sales_commission_settings.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("seller_id", input.SellerId).Required())
                      .Header(_header => _header.Setup("Authorization", input.Authorization))
                      .Query(_query => _query.Setup("live_mode", input.LiveMode))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}