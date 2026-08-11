// <copyright file="SitesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
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
        /// <![CDATA[
        /// Retrieves site data.
        /// Full documentation on Sites in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/sections/24250550707085-Sites).
        /// Specifically, the [Clearing Site Data](https://maxio.zendesk.com/hc/en-us/articles/24250617028365-Clearing-Site-Data) section is relevant to this endpoint documentation.
        /// #### Relationship invoicing enabled.
        /// If the site has RI enabled then you will see more settings like:.
        ///     "customer_hierarchy_enabled": true,.
        ///     "whopays_enabled": true,.
        ///     "whopays_default_payer": "self".
        /// You can read more about these settings here:.
        ///  [Who Pays & Customer Hierarchy](https://maxio.zendesk.com/hc/en-us/articles/24252185211533-Customer-Hierarchies-WhoPays).
        /// ]]>
        /// </summary>
        /// <returns>Returns the Models.SiteResponse response from the API call.</returns>
        public Models.SiteResponse ReadSite()
            => CoreHelper.RunTask(ReadSiteAsync());

        /// <summary>
        /// <![CDATA[
        /// Retrieves site data.
        /// Full documentation on Sites in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/sections/24250550707085-Sites).
        /// Specifically, the [Clearing Site Data](https://maxio.zendesk.com/hc/en-us/articles/24250617028365-Clearing-Site-Data) section is relevant to this endpoint documentation.
        /// #### Relationship invoicing enabled.
        /// If the site has RI enabled then you will see more settings like:.
        ///     "customer_hierarchy_enabled": true,.
        ///     "whopays_enabled": true,.
        ///     "whopays_default_payer": "self".
        /// You can read more about these settings here:.
        ///  [Who Pays & Customer Hierarchy](https://maxio.zendesk.com/hc/en-us/articles/24252185211533-Customer-Hierarchies-WhoPays).
        /// ]]>
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SiteResponse response from the API call.</returns>
        public async Task<Models.SiteResponse> ReadSiteAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SiteResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/site.json")
                  .WithAuth("BasicAuth"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Clears all data from a test site asynchronously. This call is asynchronous and there may be a delay before the site data is fully deleted. If you are clearing site data for an automated test, you will need to build in a delay and/or check that there are no products, etc., in the site before proceeding.
        /// **This functionality will only work on sites in TEST mode. Attempts to perform this on sites in “live” mode will result in a response of 403 FORBIDDEN.**.
        /// </summary>
        /// <param name="cleanupScope">Optional parameter: `all`: Will clear all products, customers, and related subscriptions from the site.  `customers`: Will clear only customers and related subscriptions (leaving the products untouched) for the site.  Revenue will also be reset to 0. Use in query `cleanup_scope=all`..</param>
        public void ClearSite(
                Models.CleanupScope? cleanupScope = Models.CleanupScope.All)
            => CoreHelper.RunVoidTask(ClearSiteAsync(cleanupScope));

        /// <summary>
        /// Clears all data from a test site asynchronously. This call is asynchronous and there may be a delay before the site data is fully deleted. If you are clearing site data for an automated test, you will need to build in a delay and/or check that there are no products, etc., in the site before proceeding.
        /// **This functionality will only work on sites in TEST mode. Attempts to perform this on sites in “live” mode will result in a response of 403 FORBIDDEN.**.
        /// </summary>
        /// <param name="cleanupScope">Optional parameter: `all`: Will clear all products, customers, and related subscriptions from the site.  `customers`: Will clear only customers and related subscriptions (leaving the products untouched) for the site.  Revenue will also be reset to 0. Use in query `cleanup_scope=all`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ClearSiteAsync(
                Models.CleanupScope? cleanupScope = Models.CleanupScope.All,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/sites/clear_data.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("cleanup_scope", (cleanupScope.HasValue) ? CoreHelper.JsonSerialize(cleanupScope.Value).Trim('\"') : "all"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists public keys used for Maxio.js (formerly Chargify.js).
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListPublicKeysResponse response from the API call.</returns>
        public Models.ListPublicKeysResponse ListChargifyJsPublicKeys(
                Models.ListChargifyJsPublicKeysInput input)
            => CoreHelper.RunTask(ListChargifyJsPublicKeysAsync(input));

        /// <summary>
        /// Lists public keys used for Maxio.js (formerly Chargify.js).
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListPublicKeysResponse response from the API call.</returns>
        public async Task<Models.ListPublicKeysResponse> ListChargifyJsPublicKeysAsync(
                Models.ListChargifyJsPublicKeysInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListPublicKeysResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/chargify_js_keys.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}