// <copyright file="SitesController.cs" company="APIMatic">
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
    /// SitesController.
    /// </summary>
    public class SitesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitesController"/> class.
        /// </summary>
        internal SitesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint returns public keys used for Chargify.js.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListPublicKeysResponse response from the API call.</returns>
        public Models.ListPublicKeysResponse ListChargifyJsPublicKeys(
                Models.ListChargifyJsPublicKeysInput input)
            => CoreHelper.RunTask(ListChargifyJsPublicKeysAsync(input));

        /// <summary>
        /// This endpoint returns public keys used for Chargify.js.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListPublicKeysResponse response from the API call.</returns>
        public async Task<Models.ListPublicKeysResponse> ListChargifyJsPublicKeysAsync(
                Models.ListChargifyJsPublicKeysInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListPublicKeysResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/chargify_js_keys.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This call is asynchronous and there may be a delay before the site data is fully deleted. If you are clearing site data for an automated test, you will need to build in a delay and/or check that there are no products, etc., in the site before proceeding.
        /// **This functionality will only work on sites in TEST mode. Attempts to perform this on sites in “live” mode will result in a response of 403 FORBIDDEN.**.
        /// </summary>
        /// <param name="cleanupScope">Optional parameter: `all`: Will clear all products, customers, and related subscriptions from the site.  `customers`: Will clear only customers and related subscriptions (leaving the products untouched) for the site.  Revenue will also be reset to 0. Use in query `cleanup_scope=all`..</param>
        public void ClearSite(
                Models.CleanupScope? cleanupScope = Models.CleanupScope.All)
            => CoreHelper.RunVoidTask(ClearSiteAsync(cleanupScope));

        /// <summary>
        /// This call is asynchronous and there may be a delay before the site data is fully deleted. If you are clearing site data for an automated test, you will need to build in a delay and/or check that there are no products, etc., in the site before proceeding.
        /// **This functionality will only work on sites in TEST mode. Attempts to perform this on sites in “live” mode will result in a response of 403 FORBIDDEN.**.
        /// </summary>
        /// <param name="cleanupScope">Optional parameter: `all`: Will clear all products, customers, and related subscriptions from the site.  `customers`: Will clear only customers and related subscriptions (leaving the products untouched) for the site.  Revenue will also be reset to 0. Use in query `cleanup_scope=all`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ClearSiteAsync(
                Models.CleanupScope? cleanupScope = Models.CleanupScope.All,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/sites/clear_data.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("cleanup_scope", (cleanupScope.HasValue) ? ApiHelper.JsonSerialize(cleanupScope.Value).Trim('\"') : "all"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to fetch some site data.
        /// Full documentation on Sites in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407870738587).
        /// Specifically, the [Clearing Site Data](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405428327309) section is extremely relevant to this endpoint documentation.
        /// #### Relationship invoicing enabled.
        /// If site has RI enabled then you will see more settings like:.
        ///     "customer_hierarchy_enabled": true,.
        ///     "whopays_enabled": true,.
        ///     "whopays_default_payer": "self".
        /// You can read more about these settings here:.
        ///  [Who Pays & Customer Hierarchy](https://chargify.zendesk.com/hc/en-us/articles/4407746683291).
        /// </summary>
        /// <returns>Returns the Models.SiteResponse response from the API call.</returns>
        public Models.SiteResponse ReadSite()
            => CoreHelper.RunTask(ReadSiteAsync());

        /// <summary>
        /// This endpoint allows you to fetch some site data.
        /// Full documentation on Sites in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407870738587).
        /// Specifically, the [Clearing Site Data](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405428327309) section is extremely relevant to this endpoint documentation.
        /// #### Relationship invoicing enabled.
        /// If site has RI enabled then you will see more settings like:.
        ///     "customer_hierarchy_enabled": true,.
        ///     "whopays_enabled": true,.
        ///     "whopays_default_payer": "self".
        /// You can read more about these settings here:.
        ///  [Who Pays & Customer Hierarchy](https://chargify.zendesk.com/hc/en-us/articles/4407746683291).
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SiteResponse response from the API call.</returns>
        public async Task<Models.SiteResponse> ReadSiteAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SiteResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/site.json")
                  .WithAuth("global"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}