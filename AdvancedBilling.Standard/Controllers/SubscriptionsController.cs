// <copyright file="SubscriptionsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Http.Configuration;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// SubscriptionsController.
    /// </summary>
    public class SubscriptionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsController"/> class.
        /// </summary>
        internal SubscriptionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a Subscription for a customer and product.
        /// Specify the product with `product_id` or `product_handle`. To set a specific product pricepPoint, use `product_price_point_handle` or `product_price_point_id`.
        /// Identify an existing customer with `customer_id` or `customer_reference`. Optionally, include an existing payment profile using `payment_profile_id`. To create a new customer, pass customer_attributes. .
        /// Select an option from the **Request Examples** drop-down on the right side of the portal to see examples of common scenarios for creating subscriptions. .
        /// Payment information may be required to create a subscription, depending on the options for the Product being subscribed. See [product options](https://docs.maxio.com/hc/en-us/articles/24261076617869-Edit-Products) for more information. See the [Payments Profile]($e/Payment%20Profiles/createPaymentProfile) endpoint for details on payment parameters.
        /// Do not use real card information for testing. See the Sites articles that cover [testing your site setup](https://docs.maxio.com/hc/en-us/articles/24250712113165-Testing-Overview#testing-overview-0-0) for more details on testing in your sandbox.
        /// Note that collecting and sending raw card details in production requires [PCI compliance](https://docs.maxio.com/hc/en-us/articles/24183956938381-PCI-Compliance#pci-compliance-0-0) on your end. If your business is not PCI compliant, use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0) to collect credit card or bank account information.
        /// See the [Subscription Signups](page:introduction/basic-concepts/subscription-signup) article for more information on working with subscriptions in Advanced Billing.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse CreateSubscription(
                Models.CreateSubscriptionRequest body = null)
            => CoreHelper.RunTask(CreateSubscriptionAsync(body));

        /// <summary>
        /// Creates a Subscription for a customer and product.
        /// Specify the product with `product_id` or `product_handle`. To set a specific product pricepPoint, use `product_price_point_handle` or `product_price_point_id`.
        /// Identify an existing customer with `customer_id` or `customer_reference`. Optionally, include an existing payment profile using `payment_profile_id`. To create a new customer, pass customer_attributes. .
        /// Select an option from the **Request Examples** drop-down on the right side of the portal to see examples of common scenarios for creating subscriptions. .
        /// Payment information may be required to create a subscription, depending on the options for the Product being subscribed. See [product options](https://docs.maxio.com/hc/en-us/articles/24261076617869-Edit-Products) for more information. See the [Payments Profile]($e/Payment%20Profiles/createPaymentProfile) endpoint for details on payment parameters.
        /// Do not use real card information for testing. See the Sites articles that cover [testing your site setup](https://docs.maxio.com/hc/en-us/articles/24250712113165-Testing-Overview#testing-overview-0-0) for more details on testing in your sandbox.
        /// Note that collecting and sending raw card details in production requires [PCI compliance](https://docs.maxio.com/hc/en-us/articles/24183956938381-PCI-Compliance#pci-compliance-0-0) on your end. If your business is not PCI compliant, use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0) to collect credit card or bank account information.
        /// See the [Subscription Signups](page:introduction/basic-concepts/subscription-signup) article for more information on working with subscriptions in Advanced Billing.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> CreateSubscriptionAsync(
                Models.CreateSubscriptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// returns an array of subscriptions from a Site. Pay close attention to query string filters and pagination in order to control responses from the server.
        /// ## Search for a subscription.
        /// Use the query strings below to search for a subscription using the criteria available. The return value will be an array.
        /// ## Self-Service Page token.
        /// Self-Service Page token for the subscriptions is not returned by default. If this information is desired, the include[]=self_service_page_token parameter must be provided with the request.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.SubscriptionResponse response from the API call.</returns>
        public List<Models.SubscriptionResponse> ListSubscriptions(
                Models.ListSubscriptionsInput input)
            => CoreHelper.RunTask(ListSubscriptionsAsync(input));

        /// <summary>
        /// returns an array of subscriptions from a Site. Pay close attention to query string filters and pagination in order to control responses from the server.
        /// ## Search for a subscription.
        /// Use the query strings below to search for a subscription using the criteria available. The return value will be an array.
        /// ## Self-Service Page token.
        /// Self-Service Page token for the subscriptions is not returned by default. If this information is desired, the include[]=self_service_page_token parameter must be provided with the request.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.SubscriptionResponse response from the API call.</returns>
        public async Task<List<Models.SubscriptionResponse>> ListSubscriptionsAsync(
                Models.ListSubscriptionsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.SubscriptionResponse>>(ArraySerialization.UnIndexed)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("state", (input.State.HasValue) ? CoreHelper.JsonSerialize(input.State.Value).Trim('\"') : null))
                      .Query(query => query.Setup("product", input.Product))
                      .Query(query => query.Setup("product_price_point_id", input.ProductPricePointId))
                      .Query(query => query.Setup("coupon", input.Coupon))
                      .Query(query => query.Setup("coupon_code", input.CouponCode))
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("metadata", input.Metadata))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(query => query.Setup("sort", (input.Sort.HasValue) ? CoreHelper.JsonSerialize(input.Sort.Value).Trim('\"') : "signup_date"))
                      .Query(query => query.Setup("include", input.Include?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates one or more attributes of a subscription.
        /// ## Update Subscription Payment Method.
        /// Change the card that your subscriber uses for their subscription. You can also use this method to change the expiration date of the card **if your gateway allows**.
        /// Do not use real card information for testing. See the Sites articles that cover [testing your site setup](https://docs.maxio.com/hc/en-us/articles/24250712113165-Testing-Overview#testing-overview-0-0) for more details on testing in your sandbox.
        /// Note that collecting and sending raw card details in production requires [PCI compliance](https://docs.maxio.com/hc/en-us/articles/24183956938381-PCI-Compliance#pci-compliance-0-0) on your end. If your business is not PCI compliant, use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0) to collect credit card or bank account information.
        /// > Note: Partial card updates for **Authorize.Net** are not allowed via this endpoint. The existing Payment Profile must be directly updated instead.
        /// ## Update Product.
        /// You also use this method to change the subscription to a different product by setting a new value for product_handle. A product change can be done in two different ways, **product change** or **delayed product change**.
        /// ### Product Change.
        /// You can change a subscription's product. The new payment amount is calculated and charged at the normal start of the next period. If you require complex product changes or prorated upgrades and downgrades instead, please see the documentation on [Migrating Subscription Products](https://docs.maxio.com/hc/en-us/articles/24252069837581-Product-Changes-and-Migrations#product-changes-and-migrations-0-0).
        /// To perform a product change, set either the `product_handle` or `product_id` attribute to that of a different product from the same site as the subscription. You can also change the price point by passing in either `product_price_point_id` or `product_price_point_handle` - otherwise the new product's default price point is used.
        /// ### Delayed Product Change.
        /// This method also changes the product and/or price point, and the new payment amount is calculated and charged at the normal start of the next period.
        /// This method schedules the product change to happen automatically at the subscription’s next renewal date. To perform a delayed product change, set the `product_handle` attribute as you would in a regular product change, but also set the `product_change_delayed` attribute to `true`. No proration applies in this case.
        /// You can also perform a delayed change to the price point by passing in either `product_price_point_id` or `product_price_point_handle`.
        /// > **Note:** To cancel a delayed product change, set `next_product_id` to an empty string.
        /// ## Billing Date Changes.
        /// You can update dates for a subscrption. .
        /// ### Regular Billing Date Changes.
        /// Send the `next_billing_at` to set the next billing date for the subscription. After that date passes and the subscription is processed, the following billing date will be set according to the subscription's product period.
        /// > Note: If you pass an invalid date, the correct date is automatically set to he correct date. For example, if February 30 is passed, the next billing would be set to March 2nd in a non-leap year.
        /// The server response will not return data under the key/value pair of `next_billing_at`. View the key/value pair of `current_period_ends_at` to verify that the `next_billing_at` date has been changed successfully.
        /// ### Calendar Billing  and Snap Day Changes.
        /// For a subscription using Calendar Billing, setting the next billing date is a bit different. Send the `snap_day` attribute to change the calendar billing date for **a subscription using a product eligible for calendar billing**.
        /// > Note: If you change the product associated with a subscription that contains a `snap_day` and immediately `READ/GET` the subscription data, it will still contain original `snap_day`. The `snap_day`will will reset to 'null on the next billing cycle. This is because  a product change is instantanous and only affects the product associated with a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse UpdateSubscription(
                int subscriptionId,
                Models.UpdateSubscriptionRequest body = null)
            => CoreHelper.RunTask(UpdateSubscriptionAsync(subscriptionId, body));

        /// <summary>
        /// Updates one or more attributes of a subscription.
        /// ## Update Subscription Payment Method.
        /// Change the card that your subscriber uses for their subscription. You can also use this method to change the expiration date of the card **if your gateway allows**.
        /// Do not use real card information for testing. See the Sites articles that cover [testing your site setup](https://docs.maxio.com/hc/en-us/articles/24250712113165-Testing-Overview#testing-overview-0-0) for more details on testing in your sandbox.
        /// Note that collecting and sending raw card details in production requires [PCI compliance](https://docs.maxio.com/hc/en-us/articles/24183956938381-PCI-Compliance#pci-compliance-0-0) on your end. If your business is not PCI compliant, use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0) to collect credit card or bank account information.
        /// > Note: Partial card updates for **Authorize.Net** are not allowed via this endpoint. The existing Payment Profile must be directly updated instead.
        /// ## Update Product.
        /// You also use this method to change the subscription to a different product by setting a new value for product_handle. A product change can be done in two different ways, **product change** or **delayed product change**.
        /// ### Product Change.
        /// You can change a subscription's product. The new payment amount is calculated and charged at the normal start of the next period. If you require complex product changes or prorated upgrades and downgrades instead, please see the documentation on [Migrating Subscription Products](https://docs.maxio.com/hc/en-us/articles/24252069837581-Product-Changes-and-Migrations#product-changes-and-migrations-0-0).
        /// To perform a product change, set either the `product_handle` or `product_id` attribute to that of a different product from the same site as the subscription. You can also change the price point by passing in either `product_price_point_id` or `product_price_point_handle` - otherwise the new product's default price point is used.
        /// ### Delayed Product Change.
        /// This method also changes the product and/or price point, and the new payment amount is calculated and charged at the normal start of the next period.
        /// This method schedules the product change to happen automatically at the subscription’s next renewal date. To perform a delayed product change, set the `product_handle` attribute as you would in a regular product change, but also set the `product_change_delayed` attribute to `true`. No proration applies in this case.
        /// You can also perform a delayed change to the price point by passing in either `product_price_point_id` or `product_price_point_handle`.
        /// > **Note:** To cancel a delayed product change, set `next_product_id` to an empty string.
        /// ## Billing Date Changes.
        /// You can update dates for a subscrption. .
        /// ### Regular Billing Date Changes.
        /// Send the `next_billing_at` to set the next billing date for the subscription. After that date passes and the subscription is processed, the following billing date will be set according to the subscription's product period.
        /// > Note: If you pass an invalid date, the correct date is automatically set to he correct date. For example, if February 30 is passed, the next billing would be set to March 2nd in a non-leap year.
        /// The server response will not return data under the key/value pair of `next_billing_at`. View the key/value pair of `current_period_ends_at` to verify that the `next_billing_at` date has been changed successfully.
        /// ### Calendar Billing  and Snap Day Changes.
        /// For a subscription using Calendar Billing, setting the next billing date is a bit different. Send the `snap_day` attribute to change the calendar billing date for **a subscription using a product eligible for calendar billing**.
        /// > Note: If you change the product associated with a subscription that contains a `snap_day` and immediately `READ/GET` the subscription data, it will still contain original `snap_day`. The `snap_day`will will reset to 'null on the next billing cycle. This is because  a product change is instantanous and only affects the product associated with a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> UpdateSubscriptionAsync(
                int subscriptionId,
                Models.UpdateSubscriptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves subscription details.
        /// ## Self-Service Page token.
        /// Self-Service Page token for the subscription is not returned by default. If this information is desired, the include[]=self_service_page_token parameter must be provided with the request.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="include"><![CDATA[Optional parameter: Allows including additional data in the response. Use in query: `include[]=coupons&include[]=self_service_page_token`..]]></param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse ReadSubscription(
                int subscriptionId,
                List<Models.SubscriptionInclude> include = null)
            => CoreHelper.RunTask(ReadSubscriptionAsync(subscriptionId, include));

        /// <summary>
        /// Retrieves subscription details.
        /// ## Self-Service Page token.
        /// Self-Service Page token for the subscription is not returned by default. If this information is desired, the include[]=self_service_page_token parameter must be provided with the request.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="include"><![CDATA[Optional parameter: Allows including additional data in the response. Use in query: `include[]=coupons&include[]=self_service_page_token`..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> ReadSubscriptionAsync(
                int subscriptionId,
                List<Models.SubscriptionInclude> include = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>(ArraySerialization.UnIndexed)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Query(query => query.Setup("include", include?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API endpoint allows you to set certain subscription fields that are usually managed for you automatically. Some of the fields can be set via the normal Subscriptions Update API, but others can only be set using this endpoint.
        /// This endpoint is provided for cases where you need to “align” Advanced Billing data with data that happened in your system, perhaps before you started using Advanced Billing. For example, you may choose to import your historical subscription data, and would like the activation and cancellation dates in Advanced Billing to match your existing historical dates. Advanced Billing does not backfill historical events (i.e. from the Events API), but some static data can be changed via this API.
        /// Why are some fields only settable from this endpoint, and not the normal subscription create and update endpoints? Because we want users of this endpoint to be aware that these fields are usually managed by Advanced Billing, and using this API means **you are stepping out on your own.**.
        /// Changing these fields will not affect any other attributes. For example, adding an expiration date will not affect the next assessment date on the subscription.
        /// If you regularly need to override the current_period_starts_at for new subscriptions, this can also be accomplished by setting both `previous_billing_at` and `next_billing_at` at subscription creation. See the documentation on [Importing Subscriptions](./b3A6MTQxMDgzODg-create-subscription#subscriptions-import) for more information.
        /// ## Limitations.
        /// When passing `current_period_starts_at` some validations are made:.
        /// 1. The subscription needs to be unbilled (no statements or invoices).
        /// 2. The value passed must be a valid date/time. We recommend using the iso 8601 format.
        /// 3. The value passed must be before the current date/time.
        /// If unpermitted parameters are sent, a 400 HTTP response is sent along with a string giving the reason for the problem.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: Only these fields are available to be set..</param>
        public void OverrideSubscription(
                int subscriptionId,
                Models.OverrideSubscriptionRequest body = null)
            => CoreHelper.RunVoidTask(OverrideSubscriptionAsync(subscriptionId, body));

        /// <summary>
        /// This API endpoint allows you to set certain subscription fields that are usually managed for you automatically. Some of the fields can be set via the normal Subscriptions Update API, but others can only be set using this endpoint.
        /// This endpoint is provided for cases where you need to “align” Advanced Billing data with data that happened in your system, perhaps before you started using Advanced Billing. For example, you may choose to import your historical subscription data, and would like the activation and cancellation dates in Advanced Billing to match your existing historical dates. Advanced Billing does not backfill historical events (i.e. from the Events API), but some static data can be changed via this API.
        /// Why are some fields only settable from this endpoint, and not the normal subscription create and update endpoints? Because we want users of this endpoint to be aware that these fields are usually managed by Advanced Billing, and using this API means **you are stepping out on your own.**.
        /// Changing these fields will not affect any other attributes. For example, adding an expiration date will not affect the next assessment date on the subscription.
        /// If you regularly need to override the current_period_starts_at for new subscriptions, this can also be accomplished by setting both `previous_billing_at` and `next_billing_at` at subscription creation. See the documentation on [Importing Subscriptions](./b3A6MTQxMDgzODg-create-subscription#subscriptions-import) for more information.
        /// ## Limitations.
        /// When passing `current_period_starts_at` some validations are made:.
        /// 1. The subscription needs to be unbilled (no statements or invoices).
        /// 2. The value passed must be a valid date/time. We recommend using the iso 8601 format.
        /// 3. The value passed must be before the current date/time.
        /// If unpermitted parameters are sent, a 400 HTTP response is sent along with a string giving the reason for the problem.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: Only these fields are available to be set..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task OverrideSubscriptionAsync(
                int subscriptionId,
                Models.OverrideSubscriptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/override.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to find a subscription by its reference.
        /// </summary>
        /// <param name="reference">Optional parameter: Subscription reference.</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse FindSubscription(
                string reference = null)
            => CoreHelper.RunTask(FindSubscriptionAsync(reference));

        /// <summary>
        /// Use this endpoint to find a subscription by its reference.
        /// </summary>
        /// <param name="reference">Optional parameter: Subscription reference.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> FindSubscriptionAsync(
                string reference = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/lookup.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("reference", reference))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// For sites in test mode, you may purge individual subscriptions.
        /// Provide the subscription ID in the url.  To confirm, supply the customer ID in the query string `ack` parameter. You may also delete the customer record and/or payment profiles by passing `cascade` parameters. For example, to delete just the customer record, the query params would be: `?ack={customer_id}&cascade[]=customer`.
        /// If you need to remove subscriptions from a live site, contact support to discuss your use case.
        /// ### Delete customer and payment profile.
        /// The query params will be: `?ack={customer_id}&cascade[]=customer&cascade[]=payment_profile`.
        /// ]]>
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="ack">Required parameter: id of the customer..</param>
        /// <param name="cascade"><![CDATA[Optional parameter: Options are "customer" or "payment_profile". Use in query: `cascade[]=customer&cascade[]=payment_profile`..]]></param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse PurgeSubscription(
                int subscriptionId,
                int ack,
                List<Models.SubscriptionPurgeType> cascade = null)
            => CoreHelper.RunTask(PurgeSubscriptionAsync(subscriptionId, ack, cascade));

        /// <summary>
        /// <![CDATA[
        /// For sites in test mode, you may purge individual subscriptions.
        /// Provide the subscription ID in the url.  To confirm, supply the customer ID in the query string `ack` parameter. You may also delete the customer record and/or payment profiles by passing `cascade` parameters. For example, to delete just the customer record, the query params would be: `?ack={customer_id}&cascade[]=customer`.
        /// If you need to remove subscriptions from a live site, contact support to discuss your use case.
        /// ### Delete customer and payment profile.
        /// The query params will be: `?ack={customer_id}&cascade[]=customer&cascade[]=payment_profile`.
        /// ]]>
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="ack">Required parameter: id of the customer..</param>
        /// <param name="cascade"><![CDATA[Optional parameter: Options are "customer" or "payment_profile". Use in query: `cascade[]=customer&cascade[]=payment_profile`..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> PurgeSubscriptionAsync(
                int subscriptionId,
                int ack,
                List<Models.SubscriptionPurgeType> cascade = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>(ArraySerialization.UnIndexed)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/purge.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Query(query => query.Setup("ack", ack))
                      .Query(query => query.Setup("cascade", cascade?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SubscriptionResponseErrorException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to update a subscription's prepaid configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PrepaidConfigurationResponse response from the API call.</returns>
        public Models.PrepaidConfigurationResponse UpdatePrepaidSubscriptionConfiguration(
                int subscriptionId,
                Models.UpsertPrepaidConfigurationRequest body = null)
            => CoreHelper.RunTask(UpdatePrepaidSubscriptionConfigurationAsync(subscriptionId, body));

        /// <summary>
        /// Use this endpoint to update a subscription's prepaid configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PrepaidConfigurationResponse response from the API call.</returns>
        public async Task<Models.PrepaidConfigurationResponse> UpdatePrepaidSubscriptionConfigurationAsync(
                int subscriptionId,
                Models.UpsertPrepaidConfigurationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PrepaidConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/prepaid_configurations.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The Chargify API allows you to preview a subscription by POSTing the same JSON or XML as for a subscription creation.
        /// The "Next Billing" amount and "Next Billing" date are represented in each Subscriber's Summary.
        /// A subscription will not be created by utilizing this endpoint; it is meant to serve as a prediction.
        /// For more information, see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24252493695757-Subscriber-Interface-Overview).
        /// ## Taxable Subscriptions.
        /// This endpoint will preview taxes applicable to a purchase. In order for taxes to be previewed, the following conditions must be met:.
        /// + Taxes must be configured on the subscription.
        /// + The preview must be for the purchase of a taxable product or component, or combination of the two.
        /// + The subscription payload must contain a full billing or shipping address in order to calculate tax.
        /// For more information about creating taxable previews, see our documentation guide on how to create [taxable subscriptions.](https://maxio.zendesk.com/hc/en-us/sections/24287012349325-Taxes).
        /// You do **not** need to include a card number to generate tax information when you are previewing a subscription. However, when you actually want to create the subscription, you must include the credit card information if you want the billing address to be stored in Advanced Billing. The billing address and the credit card information are stored together within the payment profile object. Also, you may not send a billing address to Advanced Billing without payment profile information, as the address is stored on the card.
        /// You can pass shipping and billing addresses and still decide not to calculate taxes. To do that, pass `skip_billing_manifest_taxes: true` attribute.
        /// ## Non-taxable Subscriptions.
        /// If you'd like to calculate subscriptions that do not include tax you may leave off the billing information.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionPreviewResponse response from the API call.</returns>
        public Models.SubscriptionPreviewResponse PreviewSubscription(
                Models.CreateSubscriptionRequest body = null)
            => CoreHelper.RunTask(PreviewSubscriptionAsync(body));

        /// <summary>
        /// The Chargify API allows you to preview a subscription by POSTing the same JSON or XML as for a subscription creation.
        /// The "Next Billing" amount and "Next Billing" date are represented in each Subscriber's Summary.
        /// A subscription will not be created by utilizing this endpoint; it is meant to serve as a prediction.
        /// For more information, see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24252493695757-Subscriber-Interface-Overview).
        /// ## Taxable Subscriptions.
        /// This endpoint will preview taxes applicable to a purchase. In order for taxes to be previewed, the following conditions must be met:.
        /// + Taxes must be configured on the subscription.
        /// + The preview must be for the purchase of a taxable product or component, or combination of the two.
        /// + The subscription payload must contain a full billing or shipping address in order to calculate tax.
        /// For more information about creating taxable previews, see our documentation guide on how to create [taxable subscriptions.](https://maxio.zendesk.com/hc/en-us/sections/24287012349325-Taxes).
        /// You do **not** need to include a card number to generate tax information when you are previewing a subscription. However, when you actually want to create the subscription, you must include the credit card information if you want the billing address to be stored in Advanced Billing. The billing address and the credit card information are stored together within the payment profile object. Also, you may not send a billing address to Advanced Billing without payment profile information, as the address is stored on the card.
        /// You can pass shipping and billing addresses and still decide not to calculate taxes. To do that, pass `skip_billing_manifest_taxes: true` attribute.
        /// ## Non-taxable Subscriptions.
        /// If you'd like to calculate subscriptions that do not include tax you may leave off the billing information.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionPreviewResponse response from the API call.</returns>
        public async Task<Models.SubscriptionPreviewResponse> PreviewSubscriptionAsync(
                Models.CreateSubscriptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionPreviewResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/preview.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// An existing subscription can accommodate multiple discounts/coupon codes. This is only applicable if each coupon is stackable. For more information on stackable coupons, we recommend reviewing our [coupon documentation.](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions#stackability-rules).
        /// ## Query Parameters vs Request Body Parameters.
        /// Passing in a coupon code as a query parameter will add the code to the subscription, completely replacing all existing coupon codes on the subscription.
        /// For this reason, using this query parameter on this endpoint has been deprecated in favor of using the request body parameters as described below. When passing in request body parameters, the list of coupon codes will simply be added to any existing list of codes on the subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="code">Optional parameter: A code for the coupon that would be applied to a subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse ApplyCouponsToSubscription(
                int subscriptionId,
                string code = null,
                Models.AddCouponsRequest body = null)
            => CoreHelper.RunTask(ApplyCouponsToSubscriptionAsync(subscriptionId, code, body));

        /// <summary>
        /// An existing subscription can accommodate multiple discounts/coupon codes. This is only applicable if each coupon is stackable. For more information on stackable coupons, we recommend reviewing our [coupon documentation.](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions#stackability-rules).
        /// ## Query Parameters vs Request Body Parameters.
        /// Passing in a coupon code as a query parameter will add the code to the subscription, completely replacing all existing coupon codes on the subscription.
        /// For this reason, using this query parameter on this endpoint has been deprecated in favor of using the request body parameters as described below. When passing in request body parameters, the list of coupon codes will simply be added to any existing list of codes on the subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="code">Optional parameter: A code for the coupon that would be applied to a subscription.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> ApplyCouponsToSubscriptionAsync(
                int subscriptionId,
                string code = null,
                Models.AddCouponsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/add_coupon.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))
                      .Query(query => query.Setup("code", code))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SubscriptionAddCouponErrorException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this endpoint to remove a coupon from an existing subscription.
        /// For more information on the expected behaviour of removing a coupon from a subscription, See our documentation [here.](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions#removing-a-coupon).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="couponCode">Optional parameter: The coupon code.</param>
        /// <returns>Returns the string response from the API call.</returns>
        public string RemoveCouponFromSubscription(
                int subscriptionId,
                string couponCode = null)
            => CoreHelper.RunTask(RemoveCouponFromSubscriptionAsync(subscriptionId, couponCode));

        /// <summary>
        /// Use this endpoint to remove a coupon from an existing subscription.
        /// For more information on the expected behaviour of removing a coupon from a subscription, See our documentation [here.](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions#removing-a-coupon).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="couponCode">Optional parameter: The coupon code.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> RemoveCouponFromSubscriptionAsync(
                int subscriptionId,
                string couponCode = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/remove_coupon.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Query(query => query.Setup("coupon_code", couponCode))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SubscriptionRemoveCouponErrorsException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Advanced Billing offers the ability to activate awaiting signup and trialing subscriptions. This feature is only available on the Relationship Invoicing architecture. Subscriptions in a group may not be activated immediately.
        /// For details on how the activation works, and how to activate subscriptions through the application, see [activation](#).
        /// The `revert_on_failure` parameter controls the behavior upon activation failure.
        /// - If set to `true` and something goes wrong i.e. payment fails, then Advanced Billing will not change the subscription's state. The subscription’s billing period will also remain the same.
        /// - If set to `false` and something goes wrong i.e. payment fails, then Advanced Billing will continue through with the activation and enter an end of life state. For trialing subscriptions, that will either be trial ended (if the trial is no obligation), past due (if the trial has an obligation), or canceled (if the site has no dunning strategy, or has a strategy that says to cancel immediately). For awaiting signup subscriptions, that will always be canceled.
        /// The default activation failure behavior can be configured per activation attempt, or you may set a default value under Config > Settings > Subscription Activation Settings.
        /// ## Activation Scenarios.
        /// ### Activate Awaiting Signup subscription.
        /// - Given you have a product without trial.
        /// - Given you have a site without dunning strategy.
        /// ```mermaid.
        ///   flowchart LR.
        ///     AS[Awaiting Signup] --> A{Activate}.
        ///     A -->|Success| Active.
        ///     A -->|Failure| ROF{revert_on_failure}.
        ///     ROF -->|true| AS.
        ///     ROF -->|false| Canceled.
        /// ```.
        /// - Given you have a product with trial.
        /// - Given you have a site with dunning strategy.
        /// ```mermaid.
        ///   flowchart LR.
        ///     AS[Awaiting Signup] --> A{Activate}.
        ///     A -->|Success| Trialing.
        ///     A -->|Failure| ROF{revert_on_failure}.
        ///     ROF -->|true| AS.
        ///     ROF -->|false| PD[Past Due].
        /// ```.
        /// ### Activate Trialing subscription.
        /// You can read more about the behavior of trialing subscriptions [here](https://maxio.zendesk.com/hc/en-us/articles/24252155721869-Trialing-Subscriptions).
        /// When the `revert_on_failure` parameter is set to `true`, the subscription's state will remain as Trialing, we will void the invoice from activation and return any prepayments and credits applied to the invoice back to the subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public Models.SubscriptionResponse ActivateSubscription(
                int subscriptionId,
                Models.ActivateSubscriptionRequest body = null)
            => CoreHelper.RunTask(ActivateSubscriptionAsync(subscriptionId, body));

        /// <summary>
        /// Advanced Billing offers the ability to activate awaiting signup and trialing subscriptions. This feature is only available on the Relationship Invoicing architecture. Subscriptions in a group may not be activated immediately.
        /// For details on how the activation works, and how to activate subscriptions through the application, see [activation](#).
        /// The `revert_on_failure` parameter controls the behavior upon activation failure.
        /// - If set to `true` and something goes wrong i.e. payment fails, then Advanced Billing will not change the subscription's state. The subscription’s billing period will also remain the same.
        /// - If set to `false` and something goes wrong i.e. payment fails, then Advanced Billing will continue through with the activation and enter an end of life state. For trialing subscriptions, that will either be trial ended (if the trial is no obligation), past due (if the trial has an obligation), or canceled (if the site has no dunning strategy, or has a strategy that says to cancel immediately). For awaiting signup subscriptions, that will always be canceled.
        /// The default activation failure behavior can be configured per activation attempt, or you may set a default value under Config > Settings > Subscription Activation Settings.
        /// ## Activation Scenarios.
        /// ### Activate Awaiting Signup subscription.
        /// - Given you have a product without trial.
        /// - Given you have a site without dunning strategy.
        /// ```mermaid.
        ///   flowchart LR.
        ///     AS[Awaiting Signup] --> A{Activate}.
        ///     A -->|Success| Active.
        ///     A -->|Failure| ROF{revert_on_failure}.
        ///     ROF -->|true| AS.
        ///     ROF -->|false| Canceled.
        /// ```.
        /// - Given you have a product with trial.
        /// - Given you have a site with dunning strategy.
        /// ```mermaid.
        ///   flowchart LR.
        ///     AS[Awaiting Signup] --> A{Activate}.
        ///     A -->|Success| Trialing.
        ///     A -->|Failure| ROF{revert_on_failure}.
        ///     ROF -->|true| AS.
        ///     ROF -->|false| PD[Past Due].
        /// ```.
        /// ### Activate Trialing subscription.
        /// You can read more about the behavior of trialing subscriptions [here](https://maxio.zendesk.com/hc/en-us/articles/24252155721869-Trialing-Subscriptions).
        /// When the `revert_on_failure` parameter is set to `true`, the subscription's state will remain as Trialing, we will void the invoice from activation and return any prepayments and credits applied to the invoice back to the subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionResponse response from the API call.</returns>
        public async Task<Models.SubscriptionResponse> ActivateSubscriptionAsync(
                int subscriptionId,
                Models.ActivateSubscriptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/activate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}