// <copyright file="SubscriptionProductsController.cs" company="APIMatic">
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
    /// SubscriptionProductsController.
    /// </summary>
    public class SubscriptionProductsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductsController"/> class.
        /// </summary>
        internal SubscriptionProductsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Migrates a subscription to a different product.
        /// To create a migration, you must pass the `product_id` or `product_handle` in the object when you send a POST request. You can also pass either a `product_price_point_id` or `product_price_point_handle` to choose which price point the subscription is moved to. If no price point identifier is passed, the subscription is moved to the product's default price point. The response is the updated subscription.
        /// ## Valid Subscriptions.
        /// Subscriptions should be in the `active` or `trialing` state to be migrated.
        /// (For backwards compatibility reasons, it is possible to migrate a subscription that is in the `trial_ended` state via the API, however this is not recommended.  Since `trial_ended` is an end-of-life state, the subscription should be canceled, the product changed, and then the subscription can be reactivated.).
        /// For more information, see [Product Changes and Migrations](https://docs.maxio.com/hc/en-us/articles/24252069837581-Product-Changes-and-Migrations).
        /// ## Failed Migrations.
        /// Important note: One of the most common ways that a migration can fail is when the attempt is made to migrate a subscription to its current product. .
        /// ## 3D Secure (3DS) Authentication post-authentication flow.
        /// When a payment requires 3DS Authentication to adhere to Strong Customer Authentication (SCA), the request enters a post-authentication flow where a 422 Unprocessable Entity status is returned with an action_link that will direct the customer through 3DS Authentication. .
        /// See the [3D Secure Post-Authentication Flow](https://docs.maxio.com/hc/en-us/articles/44277749524365-3D-Secure-Post-Authentication-Flow) article in the product documentation to learn how to manage the redirect flow.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse MigrateSubscriptionProduct(
                int subscriptionId,
                Models.SubscriptionProductMigrationRequest body = null)
            => CoreHelper.RunTask(MigrateSubscriptionProductAsync(subscriptionId, body));

        /// <summary>
        /// Migrates a subscription to a different product.
        /// To create a migration, you must pass the `product_id` or `product_handle` in the object when you send a POST request. You can also pass either a `product_price_point_id` or `product_price_point_handle` to choose which price point the subscription is moved to. If no price point identifier is passed, the subscription is moved to the product's default price point. The response is the updated subscription.
        /// ## Valid Subscriptions.
        /// Subscriptions should be in the `active` or `trialing` state to be migrated.
        /// (For backwards compatibility reasons, it is possible to migrate a subscription that is in the `trial_ended` state via the API, however this is not recommended.  Since `trial_ended` is an end-of-life state, the subscription should be canceled, the product changed, and then the subscription can be reactivated.).
        /// For more information, see [Product Changes and Migrations](https://docs.maxio.com/hc/en-us/articles/24252069837581-Product-Changes-and-Migrations).
        /// ## Failed Migrations.
        /// Important note: One of the most common ways that a migration can fail is when the attempt is made to migrate a subscription to its current product. .
        /// ## 3D Secure (3DS) Authentication post-authentication flow.
        /// When a payment requires 3DS Authentication to adhere to Strong Customer Authentication (SCA), the request enters a post-authentication flow where a 422 Unprocessable Entity status is returned with an action_link that will direct the customer through 3DS Authentication. .
        /// See the [3D Secure Post-Authentication Flow](https://docs.maxio.com/hc/en-us/articles/44277749524365-3D-Secure-Post-Authentication-Flow) article in the product documentation to learn how to manage the redirect flow.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> MigrateSubscriptionProductAsync(
                int subscriptionId,
                Models.SubscriptionProductMigrationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/migrations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Previews the charges resulting from migrating a subscription to a different product.
        /// ## Previewing a future date.
        /// It is also possible to preview the migration for a date in the future, as long as it's still within the subscription's current billing period, by passing a `proration_date` along with the request (e.g., `"proration_date": "2020-12-18T18:25:43.511Z"`).
        /// This will calculate the prorated adjustment, charge, payment and credit applied values assuming the migration is done at that date in the future as opposed to right now.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionMigrationPreviewResponse response from the API call.</returns>
        public Models.SubscriptionMigrationPreviewResponse PreviewSubscriptionProductMigration(
                int subscriptionId,
                Models.SubscriptionMigrationPreviewRequest body = null)
            => CoreHelper.RunTask(PreviewSubscriptionProductMigrationAsync(subscriptionId, body));

        /// <summary>
        /// Previews the charges resulting from migrating a subscription to a different product.
        /// ## Previewing a future date.
        /// It is also possible to preview the migration for a date in the future, as long as it's still within the subscription's current billing period, by passing a `proration_date` along with the request (e.g., `"proration_date": "2020-12-18T18:25:43.511Z"`).
        /// This will calculate the prorated adjustment, charge, payment and credit applied values assuming the migration is done at that date in the future as opposed to right now.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionMigrationPreviewResponse response from the API call.</returns>
        public async Task<Models.SubscriptionMigrationPreviewResponse> PreviewSubscriptionProductMigrationAsync(
                int subscriptionId,
                Models.SubscriptionMigrationPreviewRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionMigrationPreviewResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/migrations/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}