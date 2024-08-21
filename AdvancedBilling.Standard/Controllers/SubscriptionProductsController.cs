// <copyright file="SubscriptionProductsController.cs" company="APIMatic">
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
    /// SubscriptionProductsController.
    /// </summary>
    public class SubscriptionProductsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductsController"/> class.
        /// </summary>
        internal SubscriptionProductsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// <![CDATA[
        /// In order to create a migration, you must pass the `product_id` or `product_handle` in the object when you send a POST request. You may also pass either a `product_price_point_id` or `product_price_point_handle` to choose which price point the subscription is moved to. If no price point identifier is passed the subscription will be moved to the products default price point. The response will be the updated subscription.
        /// ## Valid Subscriptions.
        /// Subscriptions should be in the `active` or `trialing` state in order to be migrated.
        /// (For backwards compatibility reasons, it is possible to migrate a subscription that is in the `trial_ended` state via the API, however this is not recommended.  Since `trial_ended` is an end-of-life state, the subscription should be canceled, the product changed, and then the subscription can be reactivated.).
        /// ## Migrations Documentation.
        /// Full documentation on how to record Migrations in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24181589372429-Data-Migration-to-Advanced-Billing).
        /// ## Failed Migrations.
        /// One of the most common ways that a migration can fail is when the attempt is made to migrate a subscription to it's current product. Please be aware of this issue!.
        /// ## Migration 3D Secure - Stripe.
        /// It may happen that a payment needs 3D Secure Authentication when the subscription is migrated to a new product; this is referred to in our help docs as a [post-authentication flow](https://maxio.zendesk.com/hc/en-us/articles/24176278996493-Testing-Implementing-3D-Secure#psd2-flows-pre-authentication-and-post-authentication). The server returns `422 Unprocessable Entity` in this case with the following response:.
        /// ```json.
        /// {.
        ///   "errors": [.
        ///     "Your card was declined. This transaction requires 3D secure authentication.".
        ///   ],.
        ///   "gateway_payment_id": "pi_1F0aGoJ2UDb3Q4av7zU3sHPh",.
        ///   "description": "This card requires 3D secure authentication. Redirect the customer to the URL from the action_link attribute to authenticate. Attach callback_url param to this URL if you want to be notified about the result of 3D Secure authentication. Attach redirect_url param to this URL if you want to redirect a customer back to your page after 3D Secure authentication. Example: https://mysite.chargify.com/3d-secure/pi_1FCm4RKDeye4C0XfbqquXRYm?one_time_token_id=128&callback_url=https://localhost:4000&redirect_url=https://yourpage.com will do a POST request to https://localhost:4000 after payment is authenticated and will redirect a customer to https://yourpage.com after 3DS authentication.",.
        ///   "action_link": "http://acme.chargify.com/3d-secure/pi_1F0aGoJ2UDb3Q4av7zU3sHPh?one_time_token_id=242".
        /// }.
        /// ```.
        /// To let the customer go through 3D Secure Authentication, they need to be redirected to the URL specified in `action_link`.
        /// Optionally, you can specify `callback_url` parameter in the `action_link` URL if you’d like to be notified about the result of 3D Secure Authentication. The `callback_url` will return the following information:.
        /// - whether the authentication was successful (`success`).
        /// - the gateway ID for the payment (`gateway_payment_id`).
        /// - the subscription ID (`subscription_id`).
        /// Lastly, you can also specify a `redirect_url` within the `action_link` URL if you’d like to redirect a customer back to your site.
        /// It is not possible to use `action_link` in an iframe inside a custom application. You have to redirect the customer directly to the `action_link`, then, to be notified about the result, use `redirect_url` or `callback_url`.
        /// The final URL that you send a customer to to complete 3D Secure may resemble the following, where the first half is the `action_link` and the second half contains a `redirect_url` and `callback_url`: `https://mysite.chargify.com/3d-secure/pi_1FCm4RKDeye4C0XfbqquXRYm?one_time_token_id=128&callback_url=https://localhost:4000&redirect_url=https://yourpage.com`.
        /// ### Example Redirect Flow.
        /// You may wish to redirect customers to different pages depending on whether their SCA was performed successfully. Here's an example flow to use as a reference:.
        /// 1. Create a migration via API; it requires 3DS.
        /// 2. You receive a `gateway_payment_id` in the `action_link` along other params in the response.
        /// 3. Use this `gateway_payment_id` to, for example, connect with your internal resources or generate a session_id.
        /// 4. Include 1 of those attributes inside the `callback_url` and `redirect_url` to be aware which “session” this applies to.
        /// 5. Redirect the customer to the `action_link` with `callback_url` and `redirect_url` applied.
        /// 6. After the customer finishes 3DS authentication, we let you know the result by making a request to applied `callback_url`.
        /// 7. After that, we redirect the customer to the `redirect_url`; at this point the result of authentication is known.
        /// 8. Optionally, you can use the applied "msg" param in the `redirect_url` to determine whether it was successful or not.
        /// ]]>
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse MigrateSubscriptionProduct(
                int subscriptionId,
                Models.SubscriptionProductMigrationRequest body = null)
            => CoreHelper.RunTask(MigrateSubscriptionProductAsync(subscriptionId, body));

        /// <summary>
        /// <![CDATA[
        /// In order to create a migration, you must pass the `product_id` or `product_handle` in the object when you send a POST request. You may also pass either a `product_price_point_id` or `product_price_point_handle` to choose which price point the subscription is moved to. If no price point identifier is passed the subscription will be moved to the products default price point. The response will be the updated subscription.
        /// ## Valid Subscriptions.
        /// Subscriptions should be in the `active` or `trialing` state in order to be migrated.
        /// (For backwards compatibility reasons, it is possible to migrate a subscription that is in the `trial_ended` state via the API, however this is not recommended.  Since `trial_ended` is an end-of-life state, the subscription should be canceled, the product changed, and then the subscription can be reactivated.).
        /// ## Migrations Documentation.
        /// Full documentation on how to record Migrations in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24181589372429-Data-Migration-to-Advanced-Billing).
        /// ## Failed Migrations.
        /// One of the most common ways that a migration can fail is when the attempt is made to migrate a subscription to it's current product. Please be aware of this issue!.
        /// ## Migration 3D Secure - Stripe.
        /// It may happen that a payment needs 3D Secure Authentication when the subscription is migrated to a new product; this is referred to in our help docs as a [post-authentication flow](https://maxio.zendesk.com/hc/en-us/articles/24176278996493-Testing-Implementing-3D-Secure#psd2-flows-pre-authentication-and-post-authentication). The server returns `422 Unprocessable Entity` in this case with the following response:.
        /// ```json.
        /// {.
        ///   "errors": [.
        ///     "Your card was declined. This transaction requires 3D secure authentication.".
        ///   ],.
        ///   "gateway_payment_id": "pi_1F0aGoJ2UDb3Q4av7zU3sHPh",.
        ///   "description": "This card requires 3D secure authentication. Redirect the customer to the URL from the action_link attribute to authenticate. Attach callback_url param to this URL if you want to be notified about the result of 3D Secure authentication. Attach redirect_url param to this URL if you want to redirect a customer back to your page after 3D Secure authentication. Example: https://mysite.chargify.com/3d-secure/pi_1FCm4RKDeye4C0XfbqquXRYm?one_time_token_id=128&callback_url=https://localhost:4000&redirect_url=https://yourpage.com will do a POST request to https://localhost:4000 after payment is authenticated and will redirect a customer to https://yourpage.com after 3DS authentication.",.
        ///   "action_link": "http://acme.chargify.com/3d-secure/pi_1F0aGoJ2UDb3Q4av7zU3sHPh?one_time_token_id=242".
        /// }.
        /// ```.
        /// To let the customer go through 3D Secure Authentication, they need to be redirected to the URL specified in `action_link`.
        /// Optionally, you can specify `callback_url` parameter in the `action_link` URL if you’d like to be notified about the result of 3D Secure Authentication. The `callback_url` will return the following information:.
        /// - whether the authentication was successful (`success`).
        /// - the gateway ID for the payment (`gateway_payment_id`).
        /// - the subscription ID (`subscription_id`).
        /// Lastly, you can also specify a `redirect_url` within the `action_link` URL if you’d like to redirect a customer back to your site.
        /// It is not possible to use `action_link` in an iframe inside a custom application. You have to redirect the customer directly to the `action_link`, then, to be notified about the result, use `redirect_url` or `callback_url`.
        /// The final URL that you send a customer to to complete 3D Secure may resemble the following, where the first half is the `action_link` and the second half contains a `redirect_url` and `callback_url`: `https://mysite.chargify.com/3d-secure/pi_1FCm4RKDeye4C0XfbqquXRYm?one_time_token_id=128&callback_url=https://localhost:4000&redirect_url=https://yourpage.com`.
        /// ### Example Redirect Flow.
        /// You may wish to redirect customers to different pages depending on whether their SCA was performed successfully. Here's an example flow to use as a reference:.
        /// 1. Create a migration via API; it requires 3DS.
        /// 2. You receive a `gateway_payment_id` in the `action_link` along other params in the response.
        /// 3. Use this `gateway_payment_id` to, for example, connect with your internal resources or generate a session_id.
        /// 4. Include 1 of those attributes inside the `callback_url` and `redirect_url` to be aware which “session” this applies to.
        /// 5. Redirect the customer to the `action_link` with `callback_url` and `redirect_url` applied.
        /// 6. After the customer finishes 3DS authentication, we let you know the result by making a request to applied `callback_url`.
        /// 7. After that, we redirect the customer to the `redirect_url`; at this point the result of authentication is known.
        /// 8. Optionally, you can use the applied "msg" param in the `redirect_url` to determine whether it was successful or not.
        /// ]]>
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> MigrateSubscriptionProductAsync(
                int subscriptionId,
                Models.SubscriptionProductMigrationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/migrations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Previewing a future date.
        /// It is also possible to preview the migration for a date in the future, as long as it's still within the subscription's current billing period, by passing a `proration_date` along with the request (eg: `"proration_date": "2020-12-18T18:25:43.511Z"`).
        /// This will calculate the prorated adjustment, charge, payment and credit applied values assuming the migration is done at that date in the future as opposed to right now.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionMigrationPreviewResponse response from the API call.</returns>
        public Models.SubscriptionMigrationPreviewResponse PreviewSubscriptionProductMigration(
                int subscriptionId,
                Models.SubscriptionMigrationPreviewRequest body = null)
            => CoreHelper.RunTask(PreviewSubscriptionProductMigrationAsync(subscriptionId, body));

        /// <summary>
        /// ## Previewing a future date.
        /// It is also possible to preview the migration for a date in the future, as long as it's still within the subscription's current billing period, by passing a `proration_date` along with the request (eg: `"proration_date": "2020-12-18T18:25:43.511Z"`).
        /// This will calculate the prorated adjustment, charge, payment and credit applied values assuming the migration is done at that date in the future as opposed to right now.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionMigrationPreviewResponse response from the API call.</returns>
        public async Task<Models.SubscriptionMigrationPreviewResponse> PreviewSubscriptionProductMigrationAsync(
                int subscriptionId,
                Models.SubscriptionMigrationPreviewRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionMigrationPreviewResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/migrations/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}