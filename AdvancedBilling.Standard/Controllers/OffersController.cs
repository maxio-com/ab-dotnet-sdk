// <copyright file="OffersController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
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
        /// Create an offer within your Advanced Billing site by sending a POST request.
        /// ## Documentation.
        /// Offers allow you to package complicated combinations of products, components and coupons into a convenient package which can then be subscribed to just like products.
        /// Once an offer is defined it can be used as an alternative to the product when creating subscriptions.
        /// Full documentation on how to use offers in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261295098637-Offers-Overview).
        /// ## Using a Product Price Point.
        /// You can optionally pass in a `product_price_point_id` that corresponds with the `product_id` and the offer will use that price point. If a `product_price_point_id` is not passed in, the product's default price point will be used.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public Models.OfferResponse CreateOffer(
                Models.CreateOfferRequest body = null)
            => CoreHelper.RunTask(CreateOfferAsync(body));

        /// <summary>
        /// Create an offer within your Advanced Billing site by sending a POST request.
        /// ## Documentation.
        /// Offers allow you to package complicated combinations of products, components and coupons into a convenient package which can then be subscribed to just like products.
        /// Once an offer is defined it can be used as an alternative to the product when creating subscriptions.
        /// Full documentation on how to use offers in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261295098637-Offers-Overview).
        /// ## Using a Product Price Point.
        /// You can optionally pass in a `product_price_point_id` that corresponds with the `product_id` and the offer will use that price point. If a `product_price_point_id` is not passed in, the product's default price point will be used.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public async Task<Models.OfferResponse> CreateOfferAsync(
                Models.CreateOfferRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OfferResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/offers.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorArrayMapResponseException(errorReason, context), true)))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/offers.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("include_archived", input.IncludeArchived))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows you to list a specific offer's attributes. This is different than list all offers for a site, as it requires an `offer_id`.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public Models.OfferResponse ReadOffer(
                int offerId)
            => CoreHelper.RunTask(ReadOfferAsync(offerId));

        /// <summary>
        /// This method allows you to list a specific offer's attributes. This is different than list all offers for a site, as it requires an `offer_id`.
        /// </summary>
        /// <param name="offerId">Required parameter: The Chargify id of the offer.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.OfferResponse response from the API call.</returns>
        public async Task<Models.OfferResponse> ReadOfferAsync(
                int offerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.OfferResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/offers/{offer_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("offer_id", offerId))))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/offers/{offer_id}/archive.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("offer_id", offerId))))
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/offers/{offer_id}/unarchive.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("offer_id", offerId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}