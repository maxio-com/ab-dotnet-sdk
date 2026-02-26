// <copyright file="ProductFamiliesController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// ProductFamiliesController.
    /// </summary>
    public class ProductFamiliesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductFamiliesController"/> class.
        /// </summary>
        internal ProductFamiliesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves a list of Products belonging to a Product Family.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public List<Models.ProductResponse> ListProductsForProductFamily(
                Models.ListProductsForProductFamilyInput input)
            => CoreHelper.RunTask(ListProductsForProductFamilyAsync(input));

        /// <summary>
        /// Retrieves a list of Products belonging to a Product Family.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProductResponse response from the API call.</returns>
        public async Task<List<Models.ProductResponse>> ListProductsForProductFamilyAsync(
                Models.ListProductsForProductFamilyInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProductResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/products.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_family_id", input.ProductFamilyId).Required())
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("include_archived", input.IncludeArchived))
                      .Query(query => query.Setup("include", (input.Include.HasValue) ? CoreHelper.JsonSerialize(input.Include.Value).Trim('\"') : null))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a Product Family within your Advanced Billing site. Create a Product Family to act as a container for your products, components and coupons.
        /// Full documentation on how Product Families operate within the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261098936205-Product-Families).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public Models.ProductFamilyResponse CreateProductFamily(
                Models.CreateProductFamilyRequest body = null)
            => CoreHelper.RunTask(CreateProductFamilyAsync(body));

        /// <summary>
        /// Creates a Product Family within your Advanced Billing site. Create a Product Family to act as a container for your products, components and coupons.
        /// Full documentation on how Product Families operate within the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261098936205-Product-Families).
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public async Task<Models.ProductFamilyResponse> CreateProductFamilyAsync(
                Models.CreateProductFamilyRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductFamilyResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/product_families.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve a list of Product Families for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.ProductFamilyResponse response from the API call.</returns>
        public List<Models.ProductFamilyResponse> ListProductFamilies(
                Models.ListProductFamiliesInput input)
            => CoreHelper.RunTask(ListProductFamiliesAsync(input));

        /// <summary>
        /// Retrieve a list of Product Families for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.ProductFamilyResponse response from the API call.</returns>
        public async Task<List<Models.ProductFamilyResponse>> ListProductFamiliesAsync(
                Models.ListProductFamiliesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ProductFamilyResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/product_families.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves a Product Family via the `product_family_id`. The response will contain a Product Family object.
        /// The product family can be specified either with the id number, or with the `handle:my-family` format.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the product family.</param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public Models.ProductFamilyResponse ReadProductFamily(
                int id)
            => CoreHelper.RunTask(ReadProductFamilyAsync(id));

        /// <summary>
        /// Retrieves a Product Family via the `product_family_id`. The response will contain a Product Family object.
        /// The product family can be specified either with the id number, or with the `handle:my-family` format.
        /// </summary>
        /// <param name="id">Required parameter: The Advanced Billing id of the product family.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProductFamilyResponse response from the API call.</returns>
        public async Task<Models.ProductFamilyResponse> ReadProductFamilyAsync(
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProductFamilyResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}