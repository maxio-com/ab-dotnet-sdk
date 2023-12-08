// <copyright file="BillingPortalController.cs" company="APIMatic">
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
    /// BillingPortalController.
    /// </summary>
    public class BillingPortalController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPortalController"/> class.
        /// </summary>
        internal BillingPortalController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// ## Billing Portal Documentation.
        /// Full documentation on how the Billing Portal operates within the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407648972443).
        /// This documentation is focused on how the to configure the Billing Portal Settings, as well as Subscriber Interaction and Merchant Management of the Billing Portal.
        /// You can use this endpoint to enable Billing Portal access for a Customer, with the option of sending the Customer an Invitation email at the same time.
        /// ## Billing Portal Security.
        /// If your customer has been invited to the Billing Portal, then they will receive a link to manage their subscription (the “Management URL”) automatically at the bottom of their statements, invoices, and receipts. **This link changes periodically for security and is only valid for 65 days.**.
        /// If you need to provide your customer their Management URL through other means, you can retrieve it via the API. Because the URL is cryptographically signed with a timestamp, it is not possible for merchants to generate the URL without requesting it from Chargify.
        /// In order to prevent abuse & overuse, we ask that you request a new URL only when absolutely necessary. Management URLs are good for 65 days, so you should re-use a previously generated one as much as possible. If you use the URL frequently (such as to display on your website), please **do not** make an API request to Chargify every time.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <param name="autoInvite">Optional parameter: When set to 1, an Invitation email will be sent to the Customer. When set to 0, or not sent, an email will not be sent. Use in query: `auto_invite=1`..</param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public Models.CustomerResponse EnableBillingPortalForCustomer(
                int customerId,
                Models.AutoInvite? autoInvite = null)
            => CoreHelper.RunTask(EnableBillingPortalForCustomerAsync(customerId, autoInvite));

        /// <summary>
        /// ## Billing Portal Documentation.
        /// Full documentation on how the Billing Portal operates within the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407648972443).
        /// This documentation is focused on how the to configure the Billing Portal Settings, as well as Subscriber Interaction and Merchant Management of the Billing Portal.
        /// You can use this endpoint to enable Billing Portal access for a Customer, with the option of sending the Customer an Invitation email at the same time.
        /// ## Billing Portal Security.
        /// If your customer has been invited to the Billing Portal, then they will receive a link to manage their subscription (the “Management URL”) automatically at the bottom of their statements, invoices, and receipts. **This link changes periodically for security and is only valid for 65 days.**.
        /// If you need to provide your customer their Management URL through other means, you can retrieve it via the API. Because the URL is cryptographically signed with a timestamp, it is not possible for merchants to generate the URL without requesting it from Chargify.
        /// In order to prevent abuse & overuse, we ask that you request a new URL only when absolutely necessary. Management URLs are good for 65 days, so you should re-use a previously generated one as much as possible. If you use the URL frequently (such as to display on your website), please **do not** make an API request to Chargify every time.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <param name="autoInvite">Optional parameter: When set to 1, an Invitation email will be sent to the Customer. When set to 0, or not sent, an email will not be sent. Use in query: `auto_invite=1`..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public async Task<Models.CustomerResponse> EnableBillingPortalForCustomerAsync(
                int customerId,
                Models.AutoInvite? autoInvite = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/portal/customers/{customer_id}/enable.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))
                      .Query(_query => _query.Setup("auto_invite", (autoInvite.HasValue) ? (int?)autoInvite.Value : null))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// This method will provide to the API user the exact URL required for a subscriber to access the Billing Portal.
        /// ## Rules for Management Link API.
        /// + When retrieving a management URL, multiple requests for the same customer in a short period will return the **same** URL.
        /// + We will not generate a new URL for 15 days.
        /// + You must cache and remember this URL if you are going to need it again within 15 days.
        /// + Only request a new URL after the `new_link_available_at` date.
        /// + You are limited to 15 requests for the same URL. If you make more than 15 requests before `new_link_available_at`, you will be blocked from further Management URL requests (with a response code `429`).
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <returns>Returns the Models.PortalManagementLink response from the API call.</returns>
        public Models.PortalManagementLink ReadBillingPortalLink(
                int customerId)
            => CoreHelper.RunTask(ReadBillingPortalLinkAsync(customerId));

        /// <summary>
        /// This method will provide to the API user the exact URL required for a subscriber to access the Billing Portal.
        /// ## Rules for Management Link API.
        /// + When retrieving a management URL, multiple requests for the same customer in a short period will return the **same** URL.
        /// + We will not generate a new URL for 15 days.
        /// + You must cache and remember this URL if you are going to need it again within 15 days.
        /// + Only request a new URL after the `new_link_available_at` date.
        /// + You are limited to 15 requests for the same URL. If you make more than 15 requests before `new_link_available_at`, you will be blocked from further Management URL requests (with a response code `429`).
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PortalManagementLink response from the API call.</returns>
        public async Task<Models.PortalManagementLink> ReadBillingPortalLinkAsync(
                int customerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PortalManagementLink>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/portal/customers/{customer_id}/management_link.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new TooManyManagementLinkRequestsErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// You can resend a customer's Billing Portal invitation.
        /// If you attempt to resend an invitation 5 times within 30 minutes, you will receive a `422` response with `error` message in the body.
        /// If you attempt to resend an invitation when the Billing Portal is already disabled for a Customer, you will receive a `422` error response.
        /// If you attempt to resend an invitation when the Billing Portal is already disabled for a Customer, you will receive a `422` error response.
        /// If you attempt to resend an invitation when the Customer does not exist a Customer, you will receive a `404` error response.
        /// ## Limitations.
        /// This endpoint will only return a JSON response.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <returns>Returns the Models.ResentInvitation response from the API call.</returns>
        public Models.ResentInvitation ResendBillingPortalInvitation(
                int customerId)
            => CoreHelper.RunTask(ResendBillingPortalInvitationAsync(customerId));

        /// <summary>
        /// You can resend a customer's Billing Portal invitation.
        /// If you attempt to resend an invitation 5 times within 30 minutes, you will receive a `422` response with `error` message in the body.
        /// If you attempt to resend an invitation when the Billing Portal is already disabled for a Customer, you will receive a `422` error response.
        /// If you attempt to resend an invitation when the Billing Portal is already disabled for a Customer, you will receive a `422` error response.
        /// If you attempt to resend an invitation when the Customer does not exist a Customer, you will receive a `404` error response.
        /// ## Limitations.
        /// This endpoint will only return a JSON response.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResentInvitation response from the API call.</returns>
        public async Task<Models.ResentInvitation> ResendBillingPortalInvitationAsync(
                int customerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ResentInvitation>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/portal/customers/{customer_id}/invitations/invite.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ErrorListResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// You can revoke a customer's Billing Portal invitation.
        /// If you attempt to revoke an invitation when the Billing Portal is already disabled for a Customer, you will receive a 422 error response.
        /// ## Limitations.
        /// This endpoint will only return a JSON response.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <returns>Returns the Models.RevokedInvitation response from the API call.</returns>
        public Models.RevokedInvitation RevokeBillingPortalAccess(
                int customerId)
            => CoreHelper.RunTask(RevokeBillingPortalAccessAsync(customerId));

        /// <summary>
        /// You can revoke a customer's Billing Portal invitation.
        /// If you attempt to revoke an invitation when the Billing Portal is already disabled for a Customer, you will receive a 422 error response.
        /// ## Limitations.
        /// This endpoint will only return a JSON response.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RevokedInvitation response from the API call.</returns>
        public async Task<Models.RevokedInvitation> RevokeBillingPortalAccessAsync(
                int customerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RevokedInvitation>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/portal/customers/{customer_id}/invitations/revoke.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken);
    }
}