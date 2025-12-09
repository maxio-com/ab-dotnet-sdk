// <copyright file="PaymentProfilesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// PaymentProfilesController.
    /// </summary>
    public class PaymentProfilesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProfilesController"/> class.
        /// </summary>
        internal PaymentProfilesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// <![CDATA[
        /// Creates a payment profile for a customer.
        /// When you create a new payment profile for a customer via the API, it does not automatically make the profile current for any of the customer’s subscriptions. To use the payment profile as the default, you must set it explicitly for the subscription or subscription group.
        /// Select an option from the **Request Examples** drop-down on the right side of the portal to see examples of common scenarios for creating payment profiles. .
        /// Do not use real card information for testing. See the Sites articles that cover [testing your site setup](https://docs.maxio.com/hc/en-us/articles/24250712113165-Testing-Overview#testing-overview-0-0) for more details on testing in your sandbox.
        /// Note that collecting and sending raw card details in production requires [PCI compliance](https://docs.maxio.com/hc/en-us/articles/24183956938381-PCI-Compliance#pci-compliance-0-0) on your end. If your business is not PCI compliant, use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0) to collect credit card or bank account information.
        /// See the following articles to learn more about subscriptions and payments:.
        /// + [Subscriber Payment Details](https://maxio.zendesk.com/hc/en-us/articles/24251599929613-Subscription-Summary-Payment-Details-Tab).
        /// + [Self Service Pages](https://maxio.zendesk.com/hc/en-us/articles/24261425318541-Self-Service-Pages) (Allows credit card updates by Subscriber).
        /// + [Public Signup Pages payment settings](https://maxio.zendesk.com/hc/en-us/articles/24261368332557-Individual-Page-Settings).
        /// + [Taxes](https://developers.chargify.com/docs/developer-docs/d2e9e34db740e-signups#taxes).
        /// + [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview).
        ///     + [Chargify.js with GoCardless - minimal example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QQZKCER8CFK40MR6XJ).
        ///     + [Chargify.js with GoCardless - full example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QR09JVHWW0MCA7HVJV).
        ///     + [Chargify.js with Stripe Direct Debit - minimal example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QQFKKN8Z7B7DZ9AJS5).
        ///     + [Chargify.js with Stripe Direct Debit - full example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QRECQQ4ECS3ZA55GY7).
        ///     + [Chargify.js with Stripe BECS Direct Debit - minimal example](https://developers.chargify.com/docs/developer-docs/ZG9jOjE0NjAzNDIy-examples#minimal-example-with-sepa-or-becs-direct-debit-stripe-gateway).
        ///     + [Chargify.js with Stripe BECS Direct Debit - full example](https://developers.chargify.com/docs/developer-docs/ZG9jOjE0NjAzNDIy-examples#full-example-with-sepa-direct-debit-stripe-gateway).
        /// + [Full documentation on GoCardless](https://maxio.zendesk.com/hc/en-us/articles/24176159136909-GoCardless).
        /// + [Full documentation on Stripe SEPA Direct Debit](https://maxio.zendesk.com/hc/en-us/articles/24176170430093-Stripe-SEPA-and-BECS-Direct-Debit).
        /// + [Full documentation on Stripe BECS Direct Debit](https://maxio.zendesk.com/hc/en-us/articles/24176170430093-Stripe-SEPA-and-BECS-Direct-Debit).
        /// + [Full documentation on Stripe BACS Direct Debit](https://maxio.zendesk.com/hc/en-us/articles/24176170430093-Stripe-SEPA-and-BECS-Direct-Debit).
        /// ## 3D Secure Authentication during payment profile creation.
        /// When a payment requires 3D Secure Authentication to adhear to Strong Customer Authentication (SCA) during payment profile creation, the request enters a [post-authentication flow](https://maxio.zendesk.com/hc/en-us/articles/24176278996493-Testing-Implementing-3D-Secure#psd2-flows-pre-authentication-and-post-authentication). In this case, a 422 Unprocessable Entity status is returned with the following response:.
        /// ```json.
        /// {.
        ///     "jsonapi": {.
        ///         "version": "1.0".
        ///     },.
        ///     "errors": [.
        ///         {.
        ///             "title": "This card requires 3DSecure verification.",.
        ///             "detail": "This card requires 3D secure authentication. Redirect the customer to the URL from the action_link attribute to authenticate. Attach callback_url param to this URL if you want to be notified about the result of 3D Secure authentication. Attach redirect_url param to this URL if you want to redirect a customer back to your page after 3D Secure authentication. Example: https://checkout-test.chargifypay.test/3d-secure/checkout/pay_uerzhsxd5uhkbodx5jhvkg6yeu?one_time_token_id=93&callback_url=http://localhost:4000&redirect_url=https://yourpage.com will do a POST request to https://localhost:4000 after credit card is authenticated and will redirect a customer to https://yourpage.com after 3DS authentication.",.
        ///             "links": {.
        ///                 "action_link": "https://checkout-test.chargifypay.test/3d-secure/checkout/pay_uerzhsxd5uhkbodx5jhvkg6yeu?one_time_token_id=93".
        ///             }.
        ///         }.
        ///     ].
        /// }.
        /// ```.
        /// To let the customer go through 3D Secure Authentication, they need to be redirected to the URL specified in `action_link`.
        /// Optionally, you can specify the `callback_url` parameter in the `action_link` URL to receive notification about the result of 3D Secure Authentication.
        /// The `callback_url` will return the following information:.
        /// - whether the authentication was successful (`success`).
        /// - the payment profile ID (`payment_profile_id`).
        /// You can also specify a `redirect_url` parameter in the `action_link` URL to redirect the customer back to your site.
        /// You cannot use action_link in an iframe inside a custom application. You must redirect the customer directly to the `action_link` and use the `redirect_url` or `callback_url` to be notified of the result.
        /// The final URL that you send a customer to complete 3D Secure may resemble the following, where the first half is the `action_link` and the second half contains a `redirect_url` and `callback_url`:.
        ///  `https://checkout-test.chargifypay.test/3d-secure/checkout/pay_uerzhsxd5uhkbodx5jhvkg6yeu?one_time_token_id=93&callback_url=http://localhost:4000&redirect_url=https://yourpage.com`.
        /// ### Example Redirect Flow.
        /// Here's an example flow to redirect customers to different pages depending on whether SCA was performed successfully:.
        /// 1. Create a payment profile via the API; it requires 3DS.
        /// 2. You receive an `action_link` in the response.
        /// 3. Use this `action_link` to, for example, connect with your internal resources or generate a `session_id`.
        /// 4. Include one of those attributes inside the `callback_url` and `redirect_url` to be aware which “session” this applies to.
        /// 5. Redirect the customer to the `action_link` with `callback_url` and `redirect_url` applied.
        /// 6. After the customer completes 3DS authentication, we notify you of the result via the applied `callback_url`.
        /// 7. After that, we redirect the customer to the `redirect_url`; at this point the result of authentication is known.
        /// 8. Optionally, you can use the applied "msg" param in the `redirect_url` to determine if the redirect was successful.
        /// ]]>
        /// </summary>
        /// <param name="body">Optional parameter: When following the IBAN or the Local Bank details examples, a customer, bank account and mandate will be created in your current vault. If the customer, bank account, and mandate already exist in your vault, follow the Import example to link the payment profile into Advanced Billing..</param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public Models.PaymentProfileResponse CreatePaymentProfile(
                Models.CreatePaymentProfileRequest body = null)
            => CoreHelper.RunTask(CreatePaymentProfileAsync(body));

        /// <summary>
        /// <![CDATA[
        /// Creates a payment profile for a customer.
        /// When you create a new payment profile for a customer via the API, it does not automatically make the profile current for any of the customer’s subscriptions. To use the payment profile as the default, you must set it explicitly for the subscription or subscription group.
        /// Select an option from the **Request Examples** drop-down on the right side of the portal to see examples of common scenarios for creating payment profiles. .
        /// Do not use real card information for testing. See the Sites articles that cover [testing your site setup](https://docs.maxio.com/hc/en-us/articles/24250712113165-Testing-Overview#testing-overview-0-0) for more details on testing in your sandbox.
        /// Note that collecting and sending raw card details in production requires [PCI compliance](https://docs.maxio.com/hc/en-us/articles/24183956938381-PCI-Compliance#pci-compliance-0-0) on your end. If your business is not PCI compliant, use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0) to collect credit card or bank account information.
        /// See the following articles to learn more about subscriptions and payments:.
        /// + [Subscriber Payment Details](https://maxio.zendesk.com/hc/en-us/articles/24251599929613-Subscription-Summary-Payment-Details-Tab).
        /// + [Self Service Pages](https://maxio.zendesk.com/hc/en-us/articles/24261425318541-Self-Service-Pages) (Allows credit card updates by Subscriber).
        /// + [Public Signup Pages payment settings](https://maxio.zendesk.com/hc/en-us/articles/24261368332557-Individual-Page-Settings).
        /// + [Taxes](https://developers.chargify.com/docs/developer-docs/d2e9e34db740e-signups#taxes).
        /// + [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview).
        ///     + [Chargify.js with GoCardless - minimal example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QQZKCER8CFK40MR6XJ).
        ///     + [Chargify.js with GoCardless - full example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QR09JVHWW0MCA7HVJV).
        ///     + [Chargify.js with Stripe Direct Debit - minimal example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QQFKKN8Z7B7DZ9AJS5).
        ///     + [Chargify.js with Stripe Direct Debit - full example](https://docs.maxio.com/hc/en-us/articles/38206331271693-Examples#h_01K0PJ15QRECQQ4ECS3ZA55GY7).
        ///     + [Chargify.js with Stripe BECS Direct Debit - minimal example](https://developers.chargify.com/docs/developer-docs/ZG9jOjE0NjAzNDIy-examples#minimal-example-with-sepa-or-becs-direct-debit-stripe-gateway).
        ///     + [Chargify.js with Stripe BECS Direct Debit - full example](https://developers.chargify.com/docs/developer-docs/ZG9jOjE0NjAzNDIy-examples#full-example-with-sepa-direct-debit-stripe-gateway).
        /// + [Full documentation on GoCardless](https://maxio.zendesk.com/hc/en-us/articles/24176159136909-GoCardless).
        /// + [Full documentation on Stripe SEPA Direct Debit](https://maxio.zendesk.com/hc/en-us/articles/24176170430093-Stripe-SEPA-and-BECS-Direct-Debit).
        /// + [Full documentation on Stripe BECS Direct Debit](https://maxio.zendesk.com/hc/en-us/articles/24176170430093-Stripe-SEPA-and-BECS-Direct-Debit).
        /// + [Full documentation on Stripe BACS Direct Debit](https://maxio.zendesk.com/hc/en-us/articles/24176170430093-Stripe-SEPA-and-BECS-Direct-Debit).
        /// ## 3D Secure Authentication during payment profile creation.
        /// When a payment requires 3D Secure Authentication to adhear to Strong Customer Authentication (SCA) during payment profile creation, the request enters a [post-authentication flow](https://maxio.zendesk.com/hc/en-us/articles/24176278996493-Testing-Implementing-3D-Secure#psd2-flows-pre-authentication-and-post-authentication). In this case, a 422 Unprocessable Entity status is returned with the following response:.
        /// ```json.
        /// {.
        ///     "jsonapi": {.
        ///         "version": "1.0".
        ///     },.
        ///     "errors": [.
        ///         {.
        ///             "title": "This card requires 3DSecure verification.",.
        ///             "detail": "This card requires 3D secure authentication. Redirect the customer to the URL from the action_link attribute to authenticate. Attach callback_url param to this URL if you want to be notified about the result of 3D Secure authentication. Attach redirect_url param to this URL if you want to redirect a customer back to your page after 3D Secure authentication. Example: https://checkout-test.chargifypay.test/3d-secure/checkout/pay_uerzhsxd5uhkbodx5jhvkg6yeu?one_time_token_id=93&callback_url=http://localhost:4000&redirect_url=https://yourpage.com will do a POST request to https://localhost:4000 after credit card is authenticated and will redirect a customer to https://yourpage.com after 3DS authentication.",.
        ///             "links": {.
        ///                 "action_link": "https://checkout-test.chargifypay.test/3d-secure/checkout/pay_uerzhsxd5uhkbodx5jhvkg6yeu?one_time_token_id=93".
        ///             }.
        ///         }.
        ///     ].
        /// }.
        /// ```.
        /// To let the customer go through 3D Secure Authentication, they need to be redirected to the URL specified in `action_link`.
        /// Optionally, you can specify the `callback_url` parameter in the `action_link` URL to receive notification about the result of 3D Secure Authentication.
        /// The `callback_url` will return the following information:.
        /// - whether the authentication was successful (`success`).
        /// - the payment profile ID (`payment_profile_id`).
        /// You can also specify a `redirect_url` parameter in the `action_link` URL to redirect the customer back to your site.
        /// You cannot use action_link in an iframe inside a custom application. You must redirect the customer directly to the `action_link` and use the `redirect_url` or `callback_url` to be notified of the result.
        /// The final URL that you send a customer to complete 3D Secure may resemble the following, where the first half is the `action_link` and the second half contains a `redirect_url` and `callback_url`:.
        ///  `https://checkout-test.chargifypay.test/3d-secure/checkout/pay_uerzhsxd5uhkbodx5jhvkg6yeu?one_time_token_id=93&callback_url=http://localhost:4000&redirect_url=https://yourpage.com`.
        /// ### Example Redirect Flow.
        /// Here's an example flow to redirect customers to different pages depending on whether SCA was performed successfully:.
        /// 1. Create a payment profile via the API; it requires 3DS.
        /// 2. You receive an `action_link` in the response.
        /// 3. Use this `action_link` to, for example, connect with your internal resources or generate a `session_id`.
        /// 4. Include one of those attributes inside the `callback_url` and `redirect_url` to be aware which “session” this applies to.
        /// 5. Redirect the customer to the `action_link` with `callback_url` and `redirect_url` applied.
        /// 6. After the customer completes 3DS authentication, we notify you of the result via the applied `callback_url`.
        /// 7. After that, we redirect the customer to the `redirect_url`; at this point the result of authentication is known.
        /// 8. Optionally, you can use the applied "msg" param in the `redirect_url` to determine if the redirect was successful.
        /// ]]>
        /// </summary>
        /// <param name="body">Optional parameter: When following the IBAN or the Local Bank details examples, a customer, bank account and mandate will be created in your current vault. If the customer, bank account, and mandate already exist in your vault, follow the Import example to link the payment profile into Advanced Billing..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public async Task<Models.PaymentProfileResponse> CreatePaymentProfileAsync(
                Models.CreatePaymentProfileRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/payment_profiles.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method will return all of the active `payment_profiles` for a Site, or for one Customer within a site.  If no payment profiles are found, this endpoint will return an empty array, not a 404.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.PaymentProfileResponse response from the API call.</returns>
        public List<Models.PaymentProfileResponse> ListPaymentProfiles(
                Models.ListPaymentProfilesInput input)
            => CoreHelper.RunTask(ListPaymentProfilesAsync(input));

        /// <summary>
        /// This method will return all of the active `payment_profiles` for a Site, or for one Customer within a site.  If no payment profiles are found, this endpoint will return an empty array, not a 404.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.PaymentProfileResponse response from the API call.</returns>
        public async Task<List<Models.PaymentProfileResponse>> ListPaymentProfilesAsync(
                Models.ListPaymentProfilesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.PaymentProfileResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/payment_profiles.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("customer_id", input.CustomerId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Using the GET method you can retrieve a Payment Profile identified by its unique ID.
        /// Note that a different JSON object will be returned if the card method on file is a bank account.
        /// ### Response for Bank Account.
        /// Example response for Bank Account:.
        /// ```.
        /// {.
        ///   "payment_profile": {.
        ///     "id": 10089892,.
        ///     "first_name": "Chester",.
        ///     "last_name": "Tester",.
        ///     "created_at": "2025-01-01T00:00:00-05:00",.
        ///     "updated_at": "2025-01-01T00:00:00-05:00",.
        ///     "customer_id": 14543792,.
        ///     "current_vault": "bogus",.
        ///     "vault_token": "0011223344",.
        ///     "billing_address": "456 Juniper Court",.
        ///     "billing_city": "Boulder",.
        ///     "billing_state": "CO",.
        ///     "billing_zip": "80302",.
        ///     "billing_country": "US",.
        ///     "customer_vault_token": null,.
        ///     "billing_address_2": "",.
        ///     "bank_name": "Bank of Kansas City",.
        ///     "masked_bank_routing_number": "XXXX6789",.
        ///     "masked_bank_account_number": "XXXX3344",.
        ///     "bank_account_type": "checking",.
        ///     "bank_account_holder_type": "personal",.
        ///     "payment_type": "bank_account",.
        ///     "site_gateway_setting_id": 1,.
        ///     "gateway_handle": null.
        ///   }.
        /// }.
        /// ```.
        /// </summary>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public Models.PaymentProfileResponse ReadPaymentProfile(
                int paymentProfileId)
            => CoreHelper.RunTask(ReadPaymentProfileAsync(paymentProfileId));

        /// <summary>
        /// Using the GET method you can retrieve a Payment Profile identified by its unique ID.
        /// Note that a different JSON object will be returned if the card method on file is a bank account.
        /// ### Response for Bank Account.
        /// Example response for Bank Account:.
        /// ```.
        /// {.
        ///   "payment_profile": {.
        ///     "id": 10089892,.
        ///     "first_name": "Chester",.
        ///     "last_name": "Tester",.
        ///     "created_at": "2025-01-01T00:00:00-05:00",.
        ///     "updated_at": "2025-01-01T00:00:00-05:00",.
        ///     "customer_id": 14543792,.
        ///     "current_vault": "bogus",.
        ///     "vault_token": "0011223344",.
        ///     "billing_address": "456 Juniper Court",.
        ///     "billing_city": "Boulder",.
        ///     "billing_state": "CO",.
        ///     "billing_zip": "80302",.
        ///     "billing_country": "US",.
        ///     "customer_vault_token": null,.
        ///     "billing_address_2": "",.
        ///     "bank_name": "Bank of Kansas City",.
        ///     "masked_bank_routing_number": "XXXX6789",.
        ///     "masked_bank_account_number": "XXXX3344",.
        ///     "bank_account_type": "checking",.
        ///     "bank_account_holder_type": "personal",.
        ///     "payment_type": "bank_account",.
        ///     "site_gateway_setting_id": 1,.
        ///     "gateway_handle": null.
        ///   }.
        /// }.
        /// ```.
        /// </summary>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public async Task<Models.PaymentProfileResponse> ReadPaymentProfileAsync(
                int paymentProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/payment_profiles/{payment_profile_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("payment_profile_id", paymentProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Partial Card Updates.
        /// In the event that you are using the Authorize.net, Stripe, Cybersource, Forte or Braintree Blue payment gateways, you can update just the billing and contact information for a payment method. Note the lack of credit-card related data contained in the JSON payload.
        /// In this case, the following JSON is acceptable:.
        /// ```.
        /// {.
        ///   "payment_profile": {.
        ///     "first_name": "Kelly",.
        ///     "last_name": "Test",.
        ///     "billing_address": "789 Juniper Court",.
        ///     "billing_city": "Boulder",.
        ///     "billing_state": "CO",.
        ///     "billing_zip": "80302",.
        ///     "billing_country": "US",.
        ///     "billing_address_2": null.
        ///   }.
        /// }.
        /// ```.
        /// The result will be that you have updated the billing information for the card, yet retained the original card number data.
        /// ## Specific notes on updating payment profiles.
        /// - Merchants with **Authorize.net**, **Cybersource**, **Forte**, **Braintree Blue** or **Stripe** as their payment gateway can update their Customer’s credit cards without passing in the full credit card number and CVV.
        /// - If you are using **Authorize.net**, **Cybersource**, **Forte**, **Braintree Blue** or **Stripe**, Advanced Billing will ignore the credit card number and CVV when processing an update via the API, and attempt a partial update instead. If you wish to change the card number on a payment profile, you will need to create a new payment profile for the given customer.
        /// - A Payment Profile cannot be updated with the attributes of another type of Payment Profile. For example, if the payment profile you are attempting to update is a credit card, you cannot pass in bank account attributes (like `bank_account_number`), and vice versa.
        /// - Updating a payment profile directly will not trigger an attempt to capture a past-due balance. If this is the intent, update the card details via the Subscription instead.
        /// - If you are using Authorize.net or Stripe, you may elect to manually trigger a retry for a past due subscription after a partial update.
        /// </summary>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public Models.PaymentProfileResponse UpdatePaymentProfile(
                int paymentProfileId,
                Models.UpdatePaymentProfileRequest body = null)
            => CoreHelper.RunTask(UpdatePaymentProfileAsync(paymentProfileId, body));

        /// <summary>
        /// ## Partial Card Updates.
        /// In the event that you are using the Authorize.net, Stripe, Cybersource, Forte or Braintree Blue payment gateways, you can update just the billing and contact information for a payment method. Note the lack of credit-card related data contained in the JSON payload.
        /// In this case, the following JSON is acceptable:.
        /// ```.
        /// {.
        ///   "payment_profile": {.
        ///     "first_name": "Kelly",.
        ///     "last_name": "Test",.
        ///     "billing_address": "789 Juniper Court",.
        ///     "billing_city": "Boulder",.
        ///     "billing_state": "CO",.
        ///     "billing_zip": "80302",.
        ///     "billing_country": "US",.
        ///     "billing_address_2": null.
        ///   }.
        /// }.
        /// ```.
        /// The result will be that you have updated the billing information for the card, yet retained the original card number data.
        /// ## Specific notes on updating payment profiles.
        /// - Merchants with **Authorize.net**, **Cybersource**, **Forte**, **Braintree Blue** or **Stripe** as their payment gateway can update their Customer’s credit cards without passing in the full credit card number and CVV.
        /// - If you are using **Authorize.net**, **Cybersource**, **Forte**, **Braintree Blue** or **Stripe**, Advanced Billing will ignore the credit card number and CVV when processing an update via the API, and attempt a partial update instead. If you wish to change the card number on a payment profile, you will need to create a new payment profile for the given customer.
        /// - A Payment Profile cannot be updated with the attributes of another type of Payment Profile. For example, if the payment profile you are attempting to update is a credit card, you cannot pass in bank account attributes (like `bank_account_number`), and vice versa.
        /// - Updating a payment profile directly will not trigger an attempt to capture a past-due balance. If this is the intent, update the card details via the Subscription instead.
        /// - If you are using Authorize.net or Stripe, you may elect to manually trigger a retry for a past due subscription after a partial update.
        /// </summary>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public async Task<Models.PaymentProfileResponse> UpdatePaymentProfileAsync(
                int paymentProfileId,
                Models.UpdatePaymentProfileRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/payment_profiles/{payment_profile_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("payment_profile_id", paymentProfileId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorStringMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes an unused payment profile.
        /// If the payment profile is in use by one or more subscriptions or groups, a 422 and error message will be returned.
        /// </summary>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        public void DeleteUnusedPaymentProfile(
                int paymentProfileId)
            => CoreHelper.RunVoidTask(DeleteUnusedPaymentProfileAsync(paymentProfileId));

        /// <summary>
        /// Deletes an unused payment profile.
        /// If the payment profile is in use by one or more subscriptions or groups, a 422 and error message will be returned.
        /// </summary>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteUnusedPaymentProfileAsync(
                int paymentProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/payment_profiles/{payment_profile_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("payment_profile_id", paymentProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This will delete a payment profile belonging to the customer on the subscription.
        /// + If the customer has multiple subscriptions, the payment profile will be removed from all of them.
        /// + If you delete the default payment profile for a subscription, you will need to specify another payment profile to be the default through the api, or either prompt the user to enter a card in the billing portal or on the self-service page, or visit the Payment Details tab on the subscription in the Admin UI and use the “Add New Credit Card” or “Make Active Payment Method” link, (depending on whether there are other cards present).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        public void DeleteSubscriptionsPaymentProfile(
                int subscriptionId,
                int paymentProfileId)
            => CoreHelper.RunVoidTask(DeleteSubscriptionsPaymentProfileAsync(subscriptionId, paymentProfileId));

        /// <summary>
        /// This will delete a payment profile belonging to the customer on the subscription.
        /// + If the customer has multiple subscriptions, the payment profile will be removed from all of them.
        /// + If you delete the default payment profile for a subscription, you will need to specify another payment profile to be the default through the api, or either prompt the user to enter a card in the billing portal or on the self-service page, or visit the Payment Details tab on the subscription in the Admin UI and use the “Add New Credit Card” or “Make Active Payment Method” link, (depending on whether there are other cards present).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSubscriptionsPaymentProfileAsync(
                int subscriptionId,
                int paymentProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/payment_profiles/{payment_profile_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("payment_profile_id", paymentProfileId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Submit the two small deposit amounts the customer received in their bank account in order to verify the bank account. (Stripe only).
        /// </summary>
        /// <param name="bankAccountId">Required parameter: Identifier of the bank account in the system..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.BankAccountResponse response from the API call.</returns>
        public Models.BankAccountResponse VerifyBankAccount(
                int bankAccountId,
                Models.BankAccountVerificationRequest body = null)
            => CoreHelper.RunTask(VerifyBankAccountAsync(bankAccountId, body));

        /// <summary>
        /// Submit the two small deposit amounts the customer received in their bank account in order to verify the bank account. (Stripe only).
        /// </summary>
        /// <param name="bankAccountId">Required parameter: Identifier of the bank account in the system..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.BankAccountResponse response from the API call.</returns>
        public async Task<Models.BankAccountResponse> VerifyBankAccountAsync(
                int bankAccountId,
                Models.BankAccountVerificationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.BankAccountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/bank_accounts/{bank_account_id}/verification.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("bank_account_id", bankAccountId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This will delete a Payment Profile belonging to a Subscription Group.
        /// **Note**: If the Payment Profile belongs to multiple Subscription Groups and/or Subscriptions, it will be removed from all of them.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        public void DeleteSubscriptionGroupPaymentProfile(
                string uid,
                int paymentProfileId)
            => CoreHelper.RunVoidTask(DeleteSubscriptionGroupPaymentProfileAsync(uid, paymentProfileId));

        /// <summary>
        /// This will delete a Payment Profile belonging to a Subscription Group.
        /// **Note**: If the Payment Profile belongs to multiple Subscription Groups and/or Subscriptions, it will be removed from all of them.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSubscriptionGroupPaymentProfileAsync(
                string uid,
                int paymentProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscription_groups/{uid}/payment_profiles/{payment_profile_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Template(_template => _template.Setup("payment_profile_id", paymentProfileId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This will change the default payment profile on the subscription to the existing payment profile with the id specified.
        /// You must elect to change the existing payment profile to a new payment profile ID in order to receive a satisfactory response from this endpoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public Models.PaymentProfileResponse ChangeSubscriptionDefaultPaymentProfile(
                int subscriptionId,
                int paymentProfileId)
            => CoreHelper.RunTask(ChangeSubscriptionDefaultPaymentProfileAsync(subscriptionId, paymentProfileId));

        /// <summary>
        /// This will change the default payment profile on the subscription to the existing payment profile with the id specified.
        /// You must elect to change the existing payment profile to a new payment profile ID in order to receive a satisfactory response from this endpoint.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public async Task<Models.PaymentProfileResponse> ChangeSubscriptionDefaultPaymentProfileAsync(
                int subscriptionId,
                int paymentProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/payment_profiles/{payment_profile_id}/change_payment_profile.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("payment_profile_id", paymentProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This will change the default payment profile on the subscription group to the existing payment profile with the id specified.
        /// You must elect to change the existing payment profile to a new payment profile ID in order to receive a satisfactory response from this endpoint.
        /// The new payment profile must belong to the subscription group's customer, otherwise you will receive an error.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public Models.PaymentProfileResponse ChangeSubscriptionGroupDefaultPaymentProfile(
                string uid,
                int paymentProfileId)
            => CoreHelper.RunTask(ChangeSubscriptionGroupDefaultPaymentProfileAsync(uid, paymentProfileId));

        /// <summary>
        /// This will change the default payment profile on the subscription group to the existing payment profile with the id specified.
        /// You must elect to change the existing payment profile to a new payment profile ID in order to receive a satisfactory response from this endpoint.
        /// The new payment profile must belong to the subscription group's customer, otherwise you will receive an error.
        /// </summary>
        /// <param name="uid">Required parameter: The uid of the subscription group.</param>
        /// <param name="paymentProfileId">Required parameter: The Chargify id of the payment profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaymentProfileResponse response from the API call.</returns>
        public async Task<Models.PaymentProfileResponse> ChangeSubscriptionGroupDefaultPaymentProfileAsync(
                string uid,
                int paymentProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaymentProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscription_groups/{uid}/payment_profiles/{payment_profile_id}/change_payment_profile.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("uid", uid).Required())
                      .Template(_template => _template.Setup("payment_profile_id", paymentProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// One Time Tokens aka Advanced Billing Tokens house the credit card or ACH (Authorize.Net or Stripe only) data for a customer.
        /// You can use One Time Tokens while creating a subscription or payment profile instead of passing all bank account or credit card data directly to a given API endpoint.
        /// To obtain a One Time Token you have to use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0).
        /// </summary>
        /// <param name="chargifyToken">Required parameter: Advanced Billing Token.</param>
        /// <returns>Returns the Models.GetOneTimeTokenRequest response from the API call.</returns>
        public Models.GetOneTimeTokenRequest ReadOneTimeToken(
                string chargifyToken)
            => CoreHelper.RunTask(ReadOneTimeTokenAsync(chargifyToken));

        /// <summary>
        /// One Time Tokens aka Advanced Billing Tokens house the credit card or ACH (Authorize.Net or Stripe only) data for a customer.
        /// You can use One Time Tokens while creating a subscription or payment profile instead of passing all bank account or credit card data directly to a given API endpoint.
        /// To obtain a One Time Token you have to use [Chargify.js](https://docs.maxio.com/hc/en-us/articles/38163190843789-Chargify-js-Overview#chargify-js-overview-0-0).
        /// </summary>
        /// <param name="chargifyToken">Required parameter: Advanced Billing Token.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetOneTimeTokenRequest response from the API call.</returns>
        public async Task<Models.GetOneTimeTokenRequest> ReadOneTimeTokenAsync(
                string chargifyToken,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetOneTimeTokenRequest>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/one_time_tokens/{chargify_token}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("chargify_token", chargifyToken).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can send a "request payment update" email to the customer associated with the subscription.
        /// If you attempt to send a "request payment update" email more than five times within a 30-minute period, you will receive a `422` response with an error message in the body. This error message will indicate that the request has been rejected due to excessive attempts, and will provide instructions on how to resubmit the request.
        /// Additionally, if you attempt to send a "request payment update" email for a subscription that does not exist, you will receive a `404` error response. This error message will indicate that the subscription could not be found, and will provide instructions on how to correct the error and resubmit the request.
        /// These error responses are designed to prevent excessive or invalid requests, and to provide clear and helpful information to users who encounter errors during the request process.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        public void SendRequestUpdatePaymentEmail(
                int subscriptionId)
            => CoreHelper.RunVoidTask(SendRequestUpdatePaymentEmailAsync(subscriptionId));

        /// <summary>
        /// You can send a "request payment update" email to the customer associated with the subscription.
        /// If you attempt to send a "request payment update" email more than five times within a 30-minute period, you will receive a `422` response with an error message in the body. This error message will indicate that the request has been rejected due to excessive attempts, and will provide instructions on how to resubmit the request.
        /// Additionally, if you attempt to send a "request payment update" email for a subscription that does not exist, you will receive a `404` error response. This error message will indicate that the subscription could not be found, and will provide instructions on how to correct the error and resubmit the request.
        /// These error responses are designed to prevent excessive or invalid requests, and to provide clear and helpful information to users who encounter errors during the request process.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SendRequestUpdatePaymentEmailAsync(
                int subscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/request_payment_profiles_update.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}