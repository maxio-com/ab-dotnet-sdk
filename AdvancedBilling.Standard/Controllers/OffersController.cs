// <copyright file="OffersController.cs" company="APIMatic">
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
    /// OffersController.
    /// </summary>
    public class OffersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OffersController"/> class.
        /// </summary>
        internal OffersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create an offer within your Chargify site by sending a POST request.
        /// ## Documentation.
        /// Offers allow you to package complicated combinations of products, components and coupons into a convenient package which can then be subscribed to just like products.
        /// Once an offer is defined it can be used as an alternative to the product when creating subscriptions.
        /// Full documentation on how to use offers in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407753852059).
        /// ## Using a Product Price Point.
        /// You can optionally pass in a `product_price_point_id` that corresponds with the `product_id` and the offer will use that price point. If a `product_price_point_id` is not passed in, the product's default price point will be used.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public Models.OfferResponse CreateOffer(
                Models.CreateOfferRequest body = null)
            => CoreHelper.RunTask(CreateOfferAsync(body));

        /// <summary>
        /// Create an offer within your Chargify site by sending a POST request.
        /// ## Documentation.
        /// Offers allow you to package complicated combinations of products, components and coupons into a convenient package which can then be subscribed to just like products.
        /// Once an offer is defined it can be used as an alternative to the product when creating subscriptions.
        /// Full documentation on how to use offers in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407753852059).
        /// ## Using a Product Price Point.
        /// You can optionally pass in a `product_price_point_id` that corresponds with the `product_id` and the offer will use that price point. If a `product_price_point_id` is not passed in, the product's default price point will be used.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public async Task<Models.OfferResponse> CreateOfferAsync(
                Models.CreateOfferRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OfferResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/offers.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorArrayMapResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint will list offers for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListOffersResponse response from the API call.</returns>
        public Models.ListOffersResponse ListOffers(
                Models.ListOffersInput input)
            => CoreHelper.RunTask(ListOffersAsync(input));

        /// <summary>
        /// This endpoint will list offers for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListOffersResponse response from the API call.</returns>
        public async Task<Models.ListOffersResponse> ListOffersAsync(
                Models.ListOffersInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListOffersResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/offers.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("include_archived", input.IncludeArchived))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows you to list a specific offer's attributes. This is different than list all offers for a site, as it requires an `offer_id`.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public Models.OfferResponse ReadOffers(
                int offerId)
            => CoreHelper.RunTask(ReadOffersAsync(offerId));

        /// <summary>
        /// This method allows you to list a specific offer's attributes. This is different than list all offers for a site, as it requires an `offer_id`.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public async Task<Models.OfferResponse> ReadOffersAsync(
                int offerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OfferResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/offers/{offer_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("offer_id", offerId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archive an existing offer. Please provide an `offer_id` in order to archive the correct item.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        public void ArchiveOffer(
                int offerId)
            => CoreHelper.RunVoidTask(ArchiveOfferAsync(offerId));

        /// <summary>
        /// Archive an existing offer. Please provide an `offer_id` in order to archive the correct item.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ArchiveOfferAsync(
                int offerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/offers/{offer_id}/archive.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("offer_id", offerId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Unarchive a previously archived offer. Please provide an `offer_id` in order to un-archive the correct item.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        public void UnarchiveOffer(
                int offerId)
            => CoreHelper.RunVoidTask(UnarchiveOfferAsync(offerId));

        /// <summary>
        /// Unarchive a previously archived offer. Please provide an `offer_id` in order to un-archive the correct item.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UnarchiveOfferAsync(
                int offerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/offers/{offer_id}/unarchive.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("offer_id", offerId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}