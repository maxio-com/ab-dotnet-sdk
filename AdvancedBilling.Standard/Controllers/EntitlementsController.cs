// <copyright file="EntitlementsController.cs" company="APIMatic">
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
    /// EntitlementsController.
    /// </summary>
    public class EntitlementsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitlementsController"/> class.
        /// </summary>
        internal EntitlementsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns every feature a subscription is entitled to, collapsed into one entry per feature key and periodicity window across all products and components on the subscription. A `usage_limit` feature granted with two different periodicities comes back as two entries sharing one `feature_key`, each identified by its own `periodicity_key`.
        /// When more than one product or component grants the same feature key and periodicity, the values are combined:.
        /// - **`access_right`** features are combined with a boolean OR. If any contributor grants access, the aggregate is `true`. `source_products` only lists the contributors that granted `true`.
        /// - **`usage_limit`** features are summed across every contributor sharing the same periodicity window. `source_products` lists every contributor. Grants with different periodicities are not summed together. Each periodicity is returned as a separate entry.
        /// - **`service_right`** features are not combined: one contributor's value wins. Do not rely on which one when several grant the same feature key.
        /// `enabled` reflects both the aggregated value and the subscription's state. The field is `false` whenever the subscription is not in a live state (`active`, `trialing`, `assessing`, `past_due`, `soft_failure`), regardless of the aggregated value. Entitlements deliberately stay enabled through dunning.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <returns>Returns the Models.AggregatedEntitlementsResponse response from the API call.</returns>
        public Models.AggregatedEntitlementsResponse ReadSubscriptionEntitlements(
                int subscriptionId)
            => CoreHelper.RunTask(ReadSubscriptionEntitlementsAsync(subscriptionId));

        /// <summary>
        /// Returns every feature a subscription is entitled to, collapsed into one entry per feature key and periodicity window across all products and components on the subscription. A `usage_limit` feature granted with two different periodicities comes back as two entries sharing one `feature_key`, each identified by its own `periodicity_key`.
        /// When more than one product or component grants the same feature key and periodicity, the values are combined:.
        /// - **`access_right`** features are combined with a boolean OR. If any contributor grants access, the aggregate is `true`. `source_products` only lists the contributors that granted `true`.
        /// - **`usage_limit`** features are summed across every contributor sharing the same periodicity window. `source_products` lists every contributor. Grants with different periodicities are not summed together. Each periodicity is returned as a separate entry.
        /// - **`service_right`** features are not combined: one contributor's value wins. Do not rely on which one when several grant the same feature key.
        /// `enabled` reflects both the aggregated value and the subscription's state. The field is `false` whenever the subscription is not in a live state (`active`, `trialing`, `assessing`, `past_due`, `soft_failure`), regardless of the aggregated value. Entitlements deliberately stay enabled through dunning.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AggregatedEntitlementsResponse response from the API call.</returns>
        public async Task<Models.AggregatedEntitlementsResponse> ReadSubscriptionEntitlementsAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AggregatedEntitlementsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/entitlements.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (errorReason, context) => new ErrorListResponseException(errorReason, context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (errorReason, context) => new ApiException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}