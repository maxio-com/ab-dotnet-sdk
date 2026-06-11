// <copyright file="CouponsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using AdvancedBilling.Standard.Exceptions;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// CouponsController.
    /// </summary>
    public class CouponsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponsController"/> class.
        /// </summary>
        internal CouponsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// <![CDATA[
        /// Creates a coupon under the specified product family.
        /// You can create either a flat amount coupon by specifying amount_in_cents, or a percentage coupon by specifying percentage.
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in `restricted_products` and/or `restricted_components` objects in the format:.
        /// `{ "<product_id/component_id>": boolean_value }` .
        /// Coupons can be administered in the Advanced Billing application or created via API. See [creating coupons](https://maxio.zendesk.com/hc/en-us/articles/24261212433165-Creating-Editing-Deleting-Coupons) for more information.
        /// See [Apply Coupons to Subscriptions](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions) for information on applying a coupon to a subscription in the Advanced Billing UI.
        /// ]]>
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse CreateCoupon(
                int productFamilyId,
                Models.CouponRequest body = null)
            => CoreHelper.RunTask(CreateCouponAsync(productFamilyId, body));

        /// <summary>
        /// <![CDATA[
        /// Creates a coupon under the specified product family.
        /// You can create either a flat amount coupon by specifying amount_in_cents, or a percentage coupon by specifying percentage.
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in `restricted_products` and/or `restricted_components` objects in the format:.
        /// `{ "<product_id/component_id>": boolean_value }` .
        /// Coupons can be administered in the Advanced Billing application or created via API. See [creating coupons](https://maxio.zendesk.com/hc/en-us/articles/24261212433165-Creating-Editing-Deleting-Coupons) for more information.
        /// See [Apply Coupons to Subscriptions](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions) for information on applying a coupon to a subscription in the Advanced Billing UI.
        /// ]]>
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> CreateCouponAsync(
                int productFamilyId,
                Models.CouponRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/coupons.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_family_id", productFamilyId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists coupons for a specific product family in a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public List<Models.CouponResponse> ListCouponsForProductFamily(
                Models.ListCouponsForProductFamilyInput input)
            => CoreHelper.RunTask(ListCouponsForProductFamilyAsync(input));

        /// <summary>
        /// Lists coupons for a specific product family in a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public async Task<List<Models.CouponResponse>> ListCouponsForProductFamilyAsync(
                Models.ListCouponsForProductFamilyInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CouponResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/coupons.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_family_id", input.ProductFamilyId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("currency_prices", input.CurrencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Searches for a coupon by code, returning a 404 if no coupon is found. By passing a code parameter, the find will attempt to locate a coupon that matches that code.
        /// If you have more than one product family and if the coupon you are trying to find does not belong to the default product family in your site, then you will need to specify (either in the url or as a query string param) the product family id.
        /// </summary>
        /// <param name="productFamilyId">Optional parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="code">Optional parameter: The code of the coupon.</param>
        /// <param name="currencyPrices">Optional parameter: When fetching coupons, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response..</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse FindCoupon(
                int? productFamilyId = null,
                string code = null,
                bool? currencyPrices = null)
            => CoreHelper.RunTask(FindCouponAsync(productFamilyId, code, currencyPrices));

        /// <summary>
        /// Searches for a coupon by code, returning a 404 if no coupon is found. By passing a code parameter, the find will attempt to locate a coupon that matches that code.
        /// If you have more than one product family and if the coupon you are trying to find does not belong to the default product family in your site, then you will need to specify (either in the url or as a query string param) the product family id.
        /// </summary>
        /// <param name="productFamilyId">Optional parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="code">Optional parameter: The code of the coupon.</param>
        /// <param name="currencyPrices">Optional parameter: When fetching coupons, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> FindCouponAsync(
                int? productFamilyId = null,
                string code = null,
                bool? currencyPrices = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/coupons/find.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("product_family_id", productFamilyId))
                      .Query(query => query.Setup("code", code))
                      .Query(query => query.Setup("currency_prices", currencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a coupon by its Advanced Billing-assigned ID. You must identify the Coupon in this call by the ID parameter that Advanced Billing assigns.
        /// If instead you would like to find a Coupon using a Coupon code, see the Coupon Find method.
        /// When fetching a coupon, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="currencyPrices">Optional parameter: When fetching coupons, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response..</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse ReadCoupon(
                int productFamilyId,
                int couponId,
                bool? currencyPrices = null)
            => CoreHelper.RunTask(ReadCouponAsync(productFamilyId, couponId, currencyPrices));

        /// <summary>
        /// Returns a coupon by its Advanced Billing-assigned ID. You must identify the Coupon in this call by the ID parameter that Advanced Billing assigns.
        /// If instead you would like to find a Coupon using a Coupon code, see the Coupon Find method.
        /// When fetching a coupon, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="currencyPrices">Optional parameter: When fetching coupons, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> ReadCouponAsync(
                int productFamilyId,
                int couponId,
                bool? currencyPrices = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/coupons/{coupon_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_family_id", productFamilyId))
                      .Template(template => template.Setup("coupon_id", couponId))
                      .Query(query => query.Setup("currency_prices", currencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Updates a coupon. .
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in hashes of `restricted_products` and/or `restricted_components` in the format:.
        /// `{ "<product/component_id>": boolean_value }`.
        /// ]]>
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse UpdateCoupon(
                int productFamilyId,
                int couponId,
                Models.CouponRequest body = null)
            => CoreHelper.RunTask(UpdateCouponAsync(productFamilyId, couponId, body));

        /// <summary>
        /// <![CDATA[
        /// Updates a coupon. .
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in hashes of `restricted_products` and/or `restricted_components` in the format:.
        /// `{ "<product/component_id>": boolean_value }`.
        /// ]]>
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> UpdateCouponAsync(
                int productFamilyId,
                int couponId,
                Models.CouponRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/product_families/{product_family_id}/coupons/{coupon_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("product_family_id", productFamilyId))
                      .Template(template => template.Setup("coupon_id", couponId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Archives a coupon, making it unavailable for future use while remaining active on existing subscriptions.
        /// Archiving makes that Coupon unavailable for future use, but allows it to remain attached and functional on existing Subscriptions that are using it.
        /// The `archived_at` date and time will be assigned.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse ArchiveCoupon(
                int productFamilyId,
                int couponId)
            => CoreHelper.RunTask(ArchiveCouponAsync(productFamilyId, couponId));

        /// <summary>
        /// Archives a coupon, making it unavailable for future use while remaining active on existing subscriptions.
        /// Archiving makes that Coupon unavailable for future use, but allows it to remain attached and functional on existing Subscriptions that are using it.
        /// The `archived_at` date and time will be assigned.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> ArchiveCouponAsync(
                int productFamilyId,
                int couponId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/product_families/{product_family_id}/coupons/{coupon_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_family_id", productFamilyId))
                      .Template(template => template.Setup("coupon_id", couponId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists coupons for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public List<Models.CouponResponse> ListCoupons(
                Models.ListCouponsInput input)
            => CoreHelper.RunTask(ListCouponsAsync(input));

        /// <summary>
        /// Lists coupons for a site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public async Task<List<Models.CouponResponse>> ListCouponsAsync(
                Models.ListCouponsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CouponResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/coupons.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("filter", input.Filter))
                      .Query(query => query.Setup("currency_prices", input.CurrencyPrices))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists coupon usage details, one entry per product.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs..</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon..</param>
        /// <returns>Returns the List of Models.CouponUsage response from the API call.</returns>
        public List<Models.CouponUsage> ReadCouponUsage(
                int productFamilyId,
                int couponId)
            => CoreHelper.RunTask(ReadCouponUsageAsync(productFamilyId, couponId));

        /// <summary>
        /// Lists coupon usage details, one entry per product.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Advanced Billing id of the product family to which the coupon belongs..</param>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CouponUsage response from the API call.</returns>
        public async Task<List<Models.CouponUsage>> ReadCouponUsageAsync(
                int productFamilyId,
                int couponId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CouponUsage>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/coupons/{coupon_id}/usage.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("product_family_id", productFamilyId))
                      .Template(template => template.Setup("coupon_id", couponId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Verifies whether a specific coupon code is valid. This method is useful for validating coupon codes that are entered by a customer. If the coupon is found and is valid, the coupon will be returned with a 200 status code.
        /// If the coupon is invalid, the status code will be 404 and the response will say why it is invalid. If the coupon is valid, the status code will be 200 and the coupon will be returned. The following reasons for invalidity are supported:.
        /// + Coupon not found.
        /// + Coupon is invalid.
        /// + Coupon expired.
        /// If you have more than one product family and if the coupon you are validating does not belong to the first product family in your site, then you will need to specify the product family, either in the url or as a query string param. This can be done by supplying the id or the handle in the `handle:my-family` format.
        /// Eg.
        /// ```.
        /// https://<subdomain>.chargify.com/product_families/handle:<product_family_handle>/coupons/validate.<format>?code=<coupon_code>.
        /// ```.
        /// Or:.
        /// ```.
        /// https://<subdomain>.chargify.com/coupons/validate.<format>?code=<coupon_code>&product_family_id=<id>.
        /// ```.
        /// ]]>
        /// </summary>
        /// <param name="code">Required parameter: The code of the coupon.</param>
        /// <param name="productFamilyId">Optional parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse ValidateCoupon(
                string code,
                int? productFamilyId = null)
            => CoreHelper.RunTask(ValidateCouponAsync(code, productFamilyId));

        /// <summary>
        /// <![CDATA[
        /// Verifies whether a specific coupon code is valid. This method is useful for validating coupon codes that are entered by a customer. If the coupon is found and is valid, the coupon will be returned with a 200 status code.
        /// If the coupon is invalid, the status code will be 404 and the response will say why it is invalid. If the coupon is valid, the status code will be 200 and the coupon will be returned. The following reasons for invalidity are supported:.
        /// + Coupon not found.
        /// + Coupon is invalid.
        /// + Coupon expired.
        /// If you have more than one product family and if the coupon you are validating does not belong to the first product family in your site, then you will need to specify the product family, either in the url or as a query string param. This can be done by supplying the id or the handle in the `handle:my-family` format.
        /// Eg.
        /// ```.
        /// https://<subdomain>.chargify.com/product_families/handle:<product_family_handle>/coupons/validate.<format>?code=<coupon_code>.
        /// ```.
        /// Or:.
        /// ```.
        /// https://<subdomain>.chargify.com/coupons/validate.<format>?code=<coupon_code>&product_family_id=<id>.
        /// ```.
        /// ]]>
        /// </summary>
        /// <param name="code">Required parameter: The code of the coupon.</param>
        /// <param name="productFamilyId">Optional parameter: The Advanced Billing id of the product family to which the coupon belongs.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> ValidateCouponAsync(
                string code,
                int? productFamilyId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/coupons/validate.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("code", code).Required())
                      .Query(query => query.Setup("product_family_id", productFamilyId))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found: '{$response.body}'", (errorReason, context) => new SingleStringErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates and/or updates currency prices for an existing coupon. Multiple prices can be created or updated in a single request but each of the currencies must be defined on the site level already and the coupon must be an amount-based coupon, not percentage.
        /// Currency pricing for coupons must mirror the setup of the primary coupon pricing - if the primary coupon is percentage based, you will not be able to define pricing in non-primary currencies.
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CouponCurrencyResponse response from the API call.</returns>
        public Models.CouponCurrencyResponse CreateOrUpdateCouponCurrencyPrices(
                int couponId,
                Models.CouponCurrencyRequest body = null)
            => CoreHelper.RunTask(CreateOrUpdateCouponCurrencyPricesAsync(couponId, body));

        /// <summary>
        /// Creates and/or updates currency prices for an existing coupon. Multiple prices can be created or updated in a single request but each of the currencies must be defined on the site level already and the coupon must be an amount-based coupon, not percentage.
        /// Currency pricing for coupons must mirror the setup of the primary coupon pricing - if the primary coupon is percentage based, you will not be able to define pricing in non-primary currencies.
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponCurrencyResponse response from the API call.</returns>
        public async Task<Models.CouponCurrencyResponse> CreateOrUpdateCouponCurrencyPricesAsync(
                int couponId,
                Models.CouponCurrencyRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponCurrencyResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/coupons/{coupon_id}/currency_prices.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("coupon_id", couponId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorStringMapResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Creates subcodes for an existing coupon.
        /// ## Coupon Subcodes Intro.
        /// Coupon Subcodes allow you to create a set of unique codes that allow you to expand the use of one coupon.
        /// For example:.
        /// Master Coupon Code:.
        /// + SPRING2020.
        /// Coupon Subcodes:.
        /// + SPRING90210.
        /// + DP80302.
        /// + SPRINGBALTIMORE.
        /// Coupon subcodes can be administered in the Admin Interface or via the API.
        /// When creating a coupon subcode, you must specify a coupon to attach it to using the coupon_id. Valid coupon subcodes are all capital letters, contain only letters and numbers, and do not have any spaces. Lowercase letters will be capitalized before the subcode is created.
        /// ## Coupon Subcodes Documentation.
        /// Full documentation on how to create coupon subcodes in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261208729229-Coupon-Codes).
        /// Additionally, for documentation on how to apply a coupon to a Subscription within the Advanced Billing UI, see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions).
        /// ## Create Coupon Subcode.
        /// This request allows you to create specific subcodes underneath an existing coupon code.
        /// *Note*: If you are using any of the allowed special characters ("%", "@", "+", "-", "_", and "."), you must encode them for use in the URL.
        ///     % to %25.
        ///     @ to %40.
        ///     + to %2B.
        ///     - to %2D.
        ///     _ to %5F.
        ///     . to %2E.
        /// So, if the coupon subcode is `20%OFF`, the URL to delete this coupon subcode would be: `https://<subdomain>.chargify.com/coupons/567/codes/20%25OFF.<format>`.
        /// ]]>
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public Models.CouponSubcodesResponse CreateCouponSubcodes(
                int couponId,
                Models.CouponSubcodes body = null)
            => CoreHelper.RunTask(CreateCouponSubcodesAsync(couponId, body));

        /// <summary>
        /// <![CDATA[
        /// Creates subcodes for an existing coupon.
        /// ## Coupon Subcodes Intro.
        /// Coupon Subcodes allow you to create a set of unique codes that allow you to expand the use of one coupon.
        /// For example:.
        /// Master Coupon Code:.
        /// + SPRING2020.
        /// Coupon Subcodes:.
        /// + SPRING90210.
        /// + DP80302.
        /// + SPRINGBALTIMORE.
        /// Coupon subcodes can be administered in the Admin Interface or via the API.
        /// When creating a coupon subcode, you must specify a coupon to attach it to using the coupon_id. Valid coupon subcodes are all capital letters, contain only letters and numbers, and do not have any spaces. Lowercase letters will be capitalized before the subcode is created.
        /// ## Coupon Subcodes Documentation.
        /// Full documentation on how to create coupon subcodes in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261208729229-Coupon-Codes).
        /// Additionally, for documentation on how to apply a coupon to a Subscription within the Advanced Billing UI, see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261259337101-Coupons-and-Subscriptions).
        /// ## Create Coupon Subcode.
        /// This request allows you to create specific subcodes underneath an existing coupon code.
        /// *Note*: If you are using any of the allowed special characters ("%", "@", "+", "-", "_", and "."), you must encode them for use in the URL.
        ///     % to %25.
        ///     @ to %40.
        ///     + to %2B.
        ///     - to %2D.
        ///     _ to %5F.
        ///     . to %2E.
        /// So, if the coupon subcode is `20%OFF`, the URL to delete this coupon subcode would be: `https://<subdomain>.chargify.com/coupons/567/codes/20%25OFF.<format>`.
        /// ]]>
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public async Task<Models.CouponSubcodesResponse> CreateCouponSubcodesAsync(
                int couponId,
                Models.CouponSubcodes body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponSubcodesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/coupons/{coupon_id}/codes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("coupon_id", couponId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the subcodes attached to a coupon.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.CouponSubcodes response from the API call.</returns>
        public Models.CouponSubcodes ListCouponSubcodes(
                Models.ListCouponSubcodesInput input)
            => CoreHelper.RunTask(ListCouponSubcodesAsync(input));

        /// <summary>
        /// Lists the subcodes attached to a coupon.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponSubcodes response from the API call.</returns>
        public async Task<Models.CouponSubcodes> ListCouponSubcodesAsync(
                Models.ListCouponSubcodesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponSubcodes>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/coupons/{coupon_id}/codes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("coupon_id", input.CouponId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the subcodes for a coupon, replacing all existing subcodes with the new list.
        /// Send an array of new coupon subcodes.
        /// **Note**: All current subcodes for that Coupon will be deleted first, and replaced with the list of subcodes sent to this endpoint.
        /// The response will contain:.
        /// + The created subcodes,.
        /// + Subcodes that were not created because they already exist,.
        /// + Any subcodes not created because they are invalid.
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public Models.CouponSubcodesResponse UpdateCouponSubcodes(
                int couponId,
                Models.CouponSubcodes body = null)
            => CoreHelper.RunTask(UpdateCouponSubcodesAsync(couponId, body));

        /// <summary>
        /// Updates the subcodes for a coupon, replacing all existing subcodes with the new list.
        /// Send an array of new coupon subcodes.
        /// **Note**: All current subcodes for that Coupon will be deleted first, and replaced with the list of subcodes sent to this endpoint.
        /// The response will contain:.
        /// + The created subcodes,.
        /// + Subcodes that were not created because they already exist,.
        /// + Any subcodes not created because they are invalid.
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public async Task<Models.CouponSubcodesResponse> UpdateCouponSubcodesAsync(
                int couponId,
                Models.CouponSubcodes body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponSubcodesResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/coupons/{coupon_id}/codes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("coupon_id", couponId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// Deletes a specific subcode from a coupon.
        /// ## Example.
        /// Given a coupon with an ID of 567, and a coupon subcode of 20OFF, the URL to `DELETE` this coupon subcode would be:.
        /// ```.
        /// http://subdomain.chargify.com/coupons/567/codes/20OFF.<format>.
        /// ```.
        /// Note: If you are using any of the allowed special characters (“%”, “@”, “+”, “-”, “_”, and “.”), you must encode them for use in the URL.
        /// | Special character | Encoding |.
        /// |-------------------|----------|.
        /// | %                 | %25      |.
        /// | @                 | %40      |.
        /// | +                 | %2B      |.
        /// | –                 | %2D      |.
        /// | _                 | %5F      |.
        /// | .                 | %2E      |.
        /// ## Percent Encoding Example.
        /// Or if the coupon subcode is 20%OFF, the URL to delete this coupon subcode would be: @https://<subdomain>.chargify.com/coupons/567/codes/20%25OFF.<format>.
        /// ]]>
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon to which the subcode belongs.</param>
        /// <param name="subcode">Required parameter: The subcode of the coupon.</param>
        public void DeleteCouponSubcode(
                int couponId,
                string subcode)
            => CoreHelper.RunVoidTask(DeleteCouponSubcodeAsync(couponId, subcode));

        /// <summary>
        /// <![CDATA[
        /// Deletes a specific subcode from a coupon.
        /// ## Example.
        /// Given a coupon with an ID of 567, and a coupon subcode of 20OFF, the URL to `DELETE` this coupon subcode would be:.
        /// ```.
        /// http://subdomain.chargify.com/coupons/567/codes/20OFF.<format>.
        /// ```.
        /// Note: If you are using any of the allowed special characters (“%”, “@”, “+”, “-”, “_”, and “.”), you must encode them for use in the URL.
        /// | Special character | Encoding |.
        /// |-------------------|----------|.
        /// | %                 | %25      |.
        /// | @                 | %40      |.
        /// | +                 | %2B      |.
        /// | –                 | %2D      |.
        /// | _                 | %5F      |.
        /// | .                 | %2E      |.
        /// ## Percent Encoding Example.
        /// Or if the coupon subcode is 20%OFF, the URL to delete this coupon subcode would be: @https://<subdomain>.chargify.com/coupons/567/codes/20%25OFF.<format>.
        /// ]]>
        /// </summary>
        /// <param name="couponId">Required parameter: The Advanced Billing id of the coupon to which the subcode belongs.</param>
        /// <param name="subcode">Required parameter: The subcode of the coupon.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCouponSubcodeAsync(
                int couponId,
                string subcode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/coupons/{coupon_id}/codes/{subcode}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("coupon_id", couponId))
                      .Template(template => template.Setup("subcode", subcode).Required())))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}