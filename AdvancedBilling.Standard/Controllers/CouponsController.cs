// <copyright file="CouponsController.cs" company="APIMatic">
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
    /// CouponsController.
    /// </summary>
    public class CouponsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponsController"/> class.
        /// </summary>
        internal CouponsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// ## Coupons Documentation.
        /// Coupons can be administered in the Chargify application or created via API. Please view our section on [creating coupons](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404742830733) for more information.
        /// Additionally, for documentation on how to apply a coupon to a subscription within the Chargify UI, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404761012877).
        /// ## Create Coupon.
        /// This request will create a coupon, based on the provided information.
        /// When creating a coupon, you must specify a product family using the `product_family_id`. If no `product_family_id` is passed, the first product family available is used. You will also need to formulate your URL to cite the Product Family ID in your request.
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in hashes of `restricted_products` and/or `restricted_components` in the format:.
        /// `{ "<product/component_id>": boolean_value }`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse CreateCoupon(
                int productFamilyId,
                Models.CreateOrUpdateCoupon body = null)
            => CoreHelper.RunTask(CreateCouponAsync(productFamilyId, body));

        /// <summary>
        /// ## Coupons Documentation.
        /// Coupons can be administered in the Chargify application or created via API. Please view our section on [creating coupons](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404742830733) for more information.
        /// Additionally, for documentation on how to apply a coupon to a subscription within the Chargify UI, please see our documentation [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404761012877).
        /// ## Create Coupon.
        /// This request will create a coupon, based on the provided information.
        /// When creating a coupon, you must specify a product family using the `product_family_id`. If no `product_family_id` is passed, the first product family available is used. You will also need to formulate your URL to cite the Product Family ID in your request.
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in hashes of `restricted_products` and/or `restricted_components` in the format:.
        /// `{ "<product/component_id>": boolean_value }`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> CreateCouponAsync(
                int productFamilyId,
                Models.CreateOrUpdateCoupon body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/product_families/{product_family_id}/coupons.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ErrorListResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// List coupons for a specific Product Family in a Site.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public List<Models.CouponResponse> ListCouponsForProductFamily(
                Models.ListCouponsForProductFamilyInput input)
            => CoreHelper.RunTask(ListCouponsForProductFamilyAsync(input));

        /// <summary>
        /// List coupons for a specific Product Family in a Site.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public async Task<List<Models.CouponResponse>> ListCouponsForProductFamilyAsync(
                Models.ListCouponsForProductFamilyInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CouponResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/coupons.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", input.ProductFamilyId))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter[date_field]", (input.FilterDateField.HasValue) ? ApiHelper.JsonSerialize(input.FilterDateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[end_date]", input.FilterEndDate.HasValue ? input.FilterEndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[end_datetime]", input.FilterEndDatetime.HasValue ? input.FilterEndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[start_date]", input.FilterStartDate.HasValue ? input.FilterStartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[start_datetime]", input.FilterStartDatetime.HasValue ? input.FilterStartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[ids]", input.FilterIds))
                      .Query(_query => _query.Setup("filter[codes]", input.FilterCodes))
                      .Query(_query => _query.Setup("currency_prices", input.CurrencyPrices))
                      .Query(_query => _query.Setup("filter[use_site_exchange_rate]", input.FilterUseSiteExchangeRate))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can search for a coupon via the API with the find method. By passing a code parameter, the find will attempt to locate a coupon that matches that code. If no coupon is found, a 404 is returned.
        /// If you have more than one product family and if the coupon you are trying to find does not belong to the default product family in your site, then you will need to specify (either in the url or as a query string param) the product family id.
        /// </summary>
        /// <param name="productFamilyId">Optional parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="code">Optional parameter: The code of the coupon.</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse ReadCouponByCode(
                int? productFamilyId = null,
                string code = null)
            => CoreHelper.RunTask(ReadCouponByCodeAsync(productFamilyId, code));

        /// <summary>
        /// You can search for a coupon via the API with the find method. By passing a code parameter, the find will attempt to locate a coupon that matches that code. If no coupon is found, a 404 is returned.
        /// If you have more than one product family and if the coupon you are trying to find does not belong to the default product family in your site, then you will need to specify (either in the url or as a query string param) the product family id.
        /// </summary>
        /// <param name="productFamilyId">Optional parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="code">Optional parameter: The code of the coupon.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> ReadCouponByCodeAsync(
                int? productFamilyId = null,
                string code = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/coupons/find.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("product_family_id", productFamilyId))
                      .Query(_query => _query.Setup("code", code))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can retrieve the Coupon via the API with the Show method. You must identify the Coupon in this call by the ID parameter that Chargify assigns.
        /// If instead you would like to find a Coupon using a Coupon code, see the Coupon Find method.
        /// When fetching a coupon, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse ReadCoupon(
                int productFamilyId,
                int couponId)
            => CoreHelper.RunTask(ReadCouponAsync(productFamilyId, couponId));

        /// <summary>
        /// You can retrieve the Coupon via the API with the Show method. You must identify the Coupon in this call by the ID parameter that Chargify assigns.
        /// If instead you would like to find a Coupon using a Coupon code, see the Coupon Find method.
        /// When fetching a coupon, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> ReadCouponAsync(
                int productFamilyId,
                int couponId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/coupons/{coupon_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("coupon_id", couponId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Update Coupon.
        /// You can update a Coupon via the API with a PUT request to the resource endpoint.
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in hashes of `restricted_products` and/or `restricted_components` in the format:.
        /// `{ "<product/component_id>": boolean_value }`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse UpdateCoupon(
                int productFamilyId,
                int couponId,
                Models.CreateOrUpdateCoupon body = null)
            => CoreHelper.RunTask(UpdateCouponAsync(productFamilyId, couponId, body));

        /// <summary>
        /// ## Update Coupon.
        /// You can update a Coupon via the API with a PUT request to the resource endpoint.
        /// You can restrict a coupon to only apply to specific products / components by optionally passing in hashes of `restricted_products` and/or `restricted_components` in the format:.
        /// `{ "<product/component_id>": boolean_value }`.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> UpdateCouponAsync(
                int productFamilyId,
                int couponId,
                Models.CreateOrUpdateCoupon body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/product_families/{product_family_id}/coupons/{coupon_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("coupon_id", couponId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can archive a Coupon via the API with the archive method.
        /// Archiving makes that Coupon unavailable for future use, but allows it to remain attached and functional on existing Subscriptions that are using it.
        /// The `archived_at` date and time will be assigned.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse ArchiveCoupon(
                int productFamilyId,
                int couponId)
            => CoreHelper.RunTask(ArchiveCouponAsync(productFamilyId, couponId));

        /// <summary>
        /// You can archive a Coupon via the API with the archive method.
        /// Archiving makes that Coupon unavailable for future use, but allows it to remain attached and functional on existing Subscriptions that are using it.
        /// The `archived_at` date and time will be assigned.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> ArchiveCouponAsync(
                int productFamilyId,
                int couponId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/product_families/{product_family_id}/coupons/{coupon_id}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("coupon_id", couponId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can retrieve a list of coupons.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public List<Models.CouponResponse> ListCoupons(
                Models.ListCouponsInput input)
            => CoreHelper.RunTask(ListCouponsAsync(input));

        /// <summary>
        /// You can retrieve a list of coupons.
        /// If the coupon is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CouponResponse response from the API call.</returns>
        public async Task<List<Models.CouponResponse>> ListCouponsAsync(
                Models.ListCouponsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CouponResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/coupons.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[ids]", input.FilterIds))
                      .Query(_query => _query.Setup("filter[codes]", input.FilterCodes))
                      .Query(_query => _query.Setup("currency_prices", input.CurrencyPrices))
                      .Query(_query => _query.Setup("filter[end_date]", input.FilterEndDate.HasValue ? input.FilterEndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[end_datetime]", input.FilterEndDatetime.HasValue ? input.FilterEndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[start_date]", input.FilterStartDate.HasValue ? input.FilterStartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("filter[start_datetime]", input.FilterStartDatetime.HasValue ? input.FilterStartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("filter[date_field]", (input.FilterDateField.HasValue) ? ApiHelper.JsonSerialize(input.FilterDateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("filter[use_site_exchange_rate]", input.FilterUseSiteExchangeRate))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will provide details about the coupon usage as an array of data hashes, one per product.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <returns>Returns the List of Models.CouponUsage response from the API call.</returns>
        public List<Models.CouponUsage> ReadCouponUsage(
                int productFamilyId,
                int couponId)
            => CoreHelper.RunTask(ReadCouponUsageAsync(productFamilyId, couponId));

        /// <summary>
        /// This request will provide details about the coupon usage as an array of data hashes, one per product.
        /// </summary>
        /// <param name="productFamilyId">Required parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.CouponUsage response from the API call.</returns>
        public async Task<List<Models.CouponUsage>> ReadCouponUsageAsync(
                int productFamilyId,
                int couponId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CouponUsage>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/product_families/{product_family_id}/coupons/{coupon_id}/usage.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("product_family_id", productFamilyId))
                      .Template(_template => _template.Setup("coupon_id", couponId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can verify if a specific coupon code is valid using the `validate` method. This method is useful for validating coupon codes that are entered by a customer. If the coupon is found and is valid, the coupon will be returned with a 200 status code.
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
        /// </summary>
        /// <param name="code">Required parameter: The code of the coupon.</param>
        /// <param name="productFamilyId">Optional parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public Models.CouponResponse ValidateCoupon(
                string code,
                int? productFamilyId = null)
            => CoreHelper.RunTask(ValidateCouponAsync(code, productFamilyId));

        /// <summary>
        /// You can verify if a specific coupon code is valid using the `validate` method. This method is useful for validating coupon codes that are entered by a customer. If the coupon is found and is valid, the coupon will be returned with a 200 status code.
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
        /// </summary>
        /// <param name="code">Required parameter: The code of the coupon.</param>
        /// <param name="productFamilyId">Optional parameter: The Chargify id of the product family to which the coupon belongs.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponResponse response from the API call.</returns>
        public async Task<Models.CouponResponse> ValidateCouponAsync(
                string code,
                int? productFamilyId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/coupons/validate.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("code", code).Required())
                      .Query(_query => _query.Setup("product_family_id", productFamilyId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new SingleStringErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to create and/or update currency prices for an existing coupon. Multiple prices can be created or updated in a single request but each of the currencies must be defined on the site level already and the coupon must be an amount-based coupon, not percentage.
        /// Currency pricing for coupons must mirror the setup of the primary coupon pricing - if the primary coupon is percentage based, you will not be able to define pricing in non-primary currencies.
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CouponCurrencyResponse response from the API call.</returns>
        public Models.CouponCurrencyResponse UpdateCouponCurrencyPrices(
                int couponId,
                Models.CouponCurrencyRequest body = null)
            => CoreHelper.RunTask(UpdateCouponCurrencyPricesAsync(couponId, body));

        /// <summary>
        /// This endpoint allows you to create and/or update currency prices for an existing coupon. Multiple prices can be created or updated in a single request but each of the currencies must be defined on the site level already and the coupon must be an amount-based coupon, not percentage.
        /// Currency pricing for coupons must mirror the setup of the primary coupon pricing - if the primary coupon is percentage based, you will not be able to define pricing in non-primary currencies.
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponCurrencyResponse response from the API call.</returns>
        public async Task<Models.CouponCurrencyResponse> UpdateCouponCurrencyPricesAsync(
                int couponId,
                Models.CouponCurrencyRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponCurrencyResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/coupons/{coupon_id}/currency_prices.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("coupon_id", couponId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
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
        /// Full documentation on how to create coupon subcodes in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407755909531#coupon-codes).
        /// Additionally, for documentation on how to apply a coupon to a Subscription within the Chargify UI, please see our documentation [here](https://chargify.zendesk.com/hc/en-us/articles/4407884887835#coupon).
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
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public Models.CouponSubcodesResponse CreateCouponSubcodes(
                int couponId,
                Models.CouponSubcodes body = null)
            => CoreHelper.RunTask(CreateCouponSubcodesAsync(couponId, body));

        /// <summary>
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
        /// Full documentation on how to create coupon subcodes in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407755909531#coupon-codes).
        /// Additionally, for documentation on how to apply a coupon to a Subscription within the Chargify UI, please see our documentation [here](https://chargify.zendesk.com/hc/en-us/articles/4407884887835#coupon).
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
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public async Task<Models.CouponSubcodesResponse> CreateCouponSubcodesAsync(
                int couponId,
                Models.CouponSubcodes body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponSubcodesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/coupons/{coupon_id}/codes.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("coupon_id", couponId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request allows you to request the subcodes that are attached to a coupon.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.CouponSubcodes response from the API call.</returns>
        public Models.CouponSubcodes ListCouponSubcodes(
                Models.ListCouponSubcodesInput input)
            => CoreHelper.RunTask(ListCouponSubcodesAsync(input));

        /// <summary>
        /// This request allows you to request the subcodes that are attached to a coupon.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponSubcodes response from the API call.</returns>
        public async Task<Models.CouponSubcodes> ListCouponSubcodesAsync(
                Models.ListCouponSubcodesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponSubcodes>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/coupons/{coupon_id}/codes.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("coupon_id", input.CouponId))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can update the subcodes for the given Coupon via the API with a PUT request to the resource endpoint.
        /// Send an array of new coupon subcodes.
        /// **Note**: All current subcodes for that Coupon will be deleted first, and replaced with the list of subcodes sent to this endpoint.
        /// The response will contain:.
        /// + The created subcodes,.
        /// + Subcodes that were not created because they already exist,.
        /// + Any subcodes not created because they are invalid.
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public Models.CouponSubcodesResponse UpdateCouponSubcodes(
                int couponId,
                Models.CouponSubcodes body = null)
            => CoreHelper.RunTask(UpdateCouponSubcodesAsync(couponId, body));

        /// <summary>
        /// You can update the subcodes for the given Coupon via the API with a PUT request to the resource endpoint.
        /// Send an array of new coupon subcodes.
        /// **Note**: All current subcodes for that Coupon will be deleted first, and replaced with the list of subcodes sent to this endpoint.
        /// The response will contain:.
        /// + The created subcodes,.
        /// + Subcodes that were not created because they already exist,.
        /// + Any subcodes not created because they are invalid.
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CouponSubcodesResponse response from the API call.</returns>
        public async Task<Models.CouponSubcodesResponse> UpdateCouponSubcodesAsync(
                int couponId,
                Models.CouponSubcodes body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CouponSubcodesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/coupons/{coupon_id}/codes.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("coupon_id", couponId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
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
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon to which the subcode belongs.</param>
        /// <param name="subcode">Required parameter: The subcode of the coupon.</param>
        public void DeleteCouponSubcode(
                int couponId,
                string subcode)
            => CoreHelper.RunVoidTask(DeleteCouponSubcodeAsync(couponId, subcode));

        /// <summary>
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
        /// </summary>
        /// <param name="couponId">Required parameter: The Chargify id of the coupon to which the subcode belongs.</param>
        /// <param name="subcode">Required parameter: The subcode of the coupon.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteCouponSubcodeAsync(
                int couponId,
                string subcode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/coupons/{coupon_id}/codes/{subcode}.json")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("coupon_id", couponId))
                      .Template(_template => _template.Setup("subcode", subcode).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}