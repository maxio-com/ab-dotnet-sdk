// <copyright file="CustomersController.cs" company="APIMatic">
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
    /// CustomersController.
    /// </summary>
    public class CustomersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        internal CustomersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This request will by default list all customers associated with your Site.
        /// ## Find Customer.
        /// Use the search feature with the `q` query parameter to retrieve an array of customers that matches the search query.
        /// Common use cases are:.
        /// + Search by an email.
        /// + Search by a Chargify ID.
        /// + Search by an organization.
        /// + Search by a reference value from your application.
        /// + Search by a first or last name.
        /// To retrieve a single, exact match by reference, please use the [lookup endpoint](https://developers.chargify.com/docs/api-docs/b710d8fbef104-read-customer-by-reference).
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.CustomerResponse response from the API call.</returns>
        public List<Models.CustomerResponse> ListCustomers(
                Models.ListCustomersInput input)
            => CoreHelper.RunTask(ListCustomersAsync(input));

        /// <summary>
        /// This request will by default list all customers associated with your Site.
        /// ## Find Customer.
        /// Use the search feature with the `q` query parameter to retrieve an array of customers that matches the search query.
        /// Common use cases are:.
        /// + Search by an email.
        /// + Search by a Chargify ID.
        /// + Search by an organization.
        /// + Search by a reference value from your application.
        /// + Search by a first or last name.
        /// To retrieve a single, exact match by reference, please use the [lookup endpoint](https://developers.chargify.com/docs/api-docs/b710d8fbef104-read-customer-by-reference).
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CustomerResponse response from the API call.</returns>
        public async Task<List<Models.CustomerResponse>> ListCustomersAsync(
                Models.ListCustomersInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CustomerResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))
                      .Query(_query => _query.Setup("q", input.Q))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this method to return the customer object if you have the unique **Reference ID (Your App)** value handy. It will return a single match.
        /// </summary>
        /// <param name="reference">Required parameter: Customer reference.</param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public Models.CustomerResponse ReadCustomerByReference(
                string reference)
            => CoreHelper.RunTask(ReadCustomerByReferenceAsync(reference));

        /// <summary>
        /// Use this method to return the customer object if you have the unique **Reference ID (Your App)** value handy. It will return a single match.
        /// </summary>
        /// <param name="reference">Required parameter: Customer reference.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public async Task<Models.CustomerResponse> ReadCustomerByReferenceAsync(
                string reference,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/lookup.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("reference", reference).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You may create a new Customer at any time, or you may create a Customer at the same time you create a Subscription. The only validation restriction is that you may only create one customer for a given reference value.
        /// If provided, the `reference` value must be unique. It represents a unique identifier for the customer from your own app, i.e. the customer’s ID. This allows you to retrieve a given customer via a piece of shared information. Alternatively, you may choose to leave `reference` blank, and store Chargify’s unique ID for the customer, which is in the `id` attribute.
        /// Full documentation on how to locate, create and edit Customers in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407659914267).
        /// ## Required Country Format.
        /// Chargify requires that you use the ISO Standard Country codes when formatting country attribute of the customer.
        /// Countries should be formatted as 2 characters. For more information, please see the following wikipedia article on [ISO_3166-1.](http://en.wikipedia.org/wiki/ISO_3166-1#Current_codes).
        /// ## Required State Format.
        /// Chargify requires that you use the ISO Standard State codes when formatting state attribute of the customer.
        /// + US States (2 characters): [ISO_3166-2](https://en.wikipedia.org/wiki/ISO_3166-2:US).
        /// + States Outside the US (2-3 characters): To find the correct state codes outside of the US, please go to [ISO_3166-1](http://en.wikipedia.org/wiki/ISO_3166-1#Current_codes) and click on the link in the “ISO 3166-2 codes” column next to country you wish to populate.
        /// ## Locale.
        /// Chargify allows you to attribute a language/region to your customer to deliver invoices in any required language.
        /// For more: [Customer Locale](https://chargify.zendesk.com/hc/en-us/articles/4407870384283#customer-locale).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public Models.CustomerResponse CreateCustomer(
                Models.CreateCustomerRequest body = null)
            => CoreHelper.RunTask(CreateCustomerAsync(body));

        /// <summary>
        /// You may create a new Customer at any time, or you may create a Customer at the same time you create a Subscription. The only validation restriction is that you may only create one customer for a given reference value.
        /// If provided, the `reference` value must be unique. It represents a unique identifier for the customer from your own app, i.e. the customer’s ID. This allows you to retrieve a given customer via a piece of shared information. Alternatively, you may choose to leave `reference` blank, and store Chargify’s unique ID for the customer, which is in the `id` attribute.
        /// Full documentation on how to locate, create and edit Customers in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407659914267).
        /// ## Required Country Format.
        /// Chargify requires that you use the ISO Standard Country codes when formatting country attribute of the customer.
        /// Countries should be formatted as 2 characters. For more information, please see the following wikipedia article on [ISO_3166-1.](http://en.wikipedia.org/wiki/ISO_3166-1#Current_codes).
        /// ## Required State Format.
        /// Chargify requires that you use the ISO Standard State codes when formatting state attribute of the customer.
        /// + US States (2 characters): [ISO_3166-2](https://en.wikipedia.org/wiki/ISO_3166-2:US).
        /// + States Outside the US (2-3 characters): To find the correct state codes outside of the US, please go to [ISO_3166-1](http://en.wikipedia.org/wiki/ISO_3166-1#Current_codes) and click on the link in the “ISO 3166-2 codes” column next to country you wish to populate.
        /// ## Locale.
        /// Chargify allows you to attribute a language/region to your customer to deliver invoices in any required language.
        /// For more: [Customer Locale](https://chargify.zendesk.com/hc/en-us/articles/4407870384283#customer-locale).
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public async Task<Models.CustomerResponse> CreateCustomerAsync(
                Models.CreateCustomerRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/customers.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new CustomerErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows to update the Customer.
        /// </summary>
        /// <param name="id">Required parameter: The Chargify id of the customer.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public Models.CustomerResponse UpdateCustomer(
                int id,
                Models.UpdateCustomerRequest body = null)
            => CoreHelper.RunTask(UpdateCustomerAsync(id, body));

        /// <summary>
        /// This method allows to update the Customer.
        /// </summary>
        /// <param name="id">Required parameter: The Chargify id of the customer.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public async Task<Models.CustomerResponse> UpdateCustomerAsync(
                int id,
                Models.UpdateCustomerRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/customers/{id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (_reason, _context) => new CustomerErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows to retrieve the Customer properties by Chargify-generated Customer ID.
        /// </summary>
        /// <param name="id">Required parameter: The Chargify id of the customer.</param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public Models.CustomerResponse ReadCustomer(
                int id)
            => CoreHelper.RunTask(ReadCustomerAsync(id));

        /// <summary>
        /// This method allows to retrieve the Customer properties by Chargify-generated Customer ID.
        /// </summary>
        /// <param name="id">Required parameter: The Chargify id of the customer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerResponse response from the API call.</returns>
        public async Task<Models.CustomerResponse> ReadCustomerAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method lists all subscriptions that belong to a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <returns>Returns the List of Models.SubscriptionResponse response from the API call.</returns>
        public List<Models.SubscriptionResponse> ListCustomerSubscriptions(
                int customerId)
            => CoreHelper.RunTask(ListCustomerSubscriptionsAsync(customerId));

        /// <summary>
        /// This method lists all subscriptions that belong to a customer.
        /// </summary>
        /// <param name="customerId">Required parameter: The Chargify id of the customer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.SubscriptionResponse response from the API call.</returns>
        public async Task<List<Models.SubscriptionResponse>> ListCustomerSubscriptionsAsync(
                int customerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.SubscriptionResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/customers/{customer_id}/subscriptions.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("customer_id", customerId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows you to delete the Customer.
        /// </summary>
        /// <param name="id">Required parameter: The Chargify id of the customer.</param>
        public void DeleteCustomer(
                int id)
            => CoreHelper.RunVoidTask(DeleteCustomerAsync(id));

        /// <summary>
        /// This method allows you to delete the Customer.
        /// </summary>
        /// <param name="id">Required parameter: The Chargify id of the customer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCustomerAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/customers/{id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}