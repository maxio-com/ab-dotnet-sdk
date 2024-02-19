// <copyright file="EventsBasedBillingSegmentsController.cs" company="APIMatic">
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
    /// EventsBasedBillingSegmentsController.
    /// </summary>
    public class EventsBasedBillingSegmentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsBasedBillingSegmentsController"/> class.
        /// </summary>
        internal EventsBasedBillingSegmentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint creates a new Segment for a Component with segmented Metric. It allows you to specify properties to bill upon and prices for each Segment. You can only pass as many "property_values" as the related Metric has segmenting properties defined.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public Models.SegmentResponse CreateSegment(
                string componentId,
                string pricePointId,
                Models.CreateSegmentRequest body = null)
            => CoreHelper.RunTask(CreateSegmentAsync(componentId, pricePointId, body));

        /// <summary>
        /// This endpoint creates a new Segment for a Component with segmented Metric. It allows you to specify properties to bill upon and prices for each Segment. You can only pass as many "property_values" as the related Metric has segmenting properties defined.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public async Task<Models.SegmentResponse> CreateSegmentAsync(
                string componentId,
                string pricePointId,
                Models.CreateSegmentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SegmentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/{price_point_id}/segments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new EventBasedBillingSegmentErrorsException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to fetch Segments created for a given Price Point. They will be returned in the order of creation.
        /// You can pass `page` and `per_page` parameters in order to access all of the segments. By default it will return `30` records. You can set `per_page` to `200` at most.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public Models.ListSegmentsResponse ListSegmentsForPricePoint(
                Models.ListSegmentsForPricePointInput input)
            => CoreHelper.RunTask(ListSegmentsForPricePointAsync(input));

        /// <summary>
        /// This endpoint allows you to fetch Segments created for a given Price Point. They will be returned in the order of creation.
        /// You can pass `page` and `per_page` parameters in order to access all of the segments. By default it will return `30` records. You can set `per_page` to `200` at most.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public async Task<Models.ListSegmentsResponse> ListSegmentsForPricePointAsync(
                Models.ListSegmentsForPricePointInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSegmentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/components/{component_id}/price_points/{price_point_id}/segments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", input.ComponentId).Required())
                      .Template(_template => _template.Setup("price_point_id", input.PricePointId).Required())
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("filter[segment_property_1_value]", input.FilterSegmentProperty1Value))
                      .Query(_query => _query.Setup("filter[segment_property_2_value]", input.FilterSegmentProperty2Value))
                      .Query(_query => _query.Setup("filter[segment_property_3_value]", input.FilterSegmentProperty3Value))
                      .Query(_query => _query.Setup("filter[segment_property_4_value]", input.FilterSegmentProperty4Value))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new EventBasedBillingListSegmentsErrorsException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint updates a single Segment for a Component with a segmented Metric. It allows you to update the pricing for the segment.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle of the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle of the Price Point belonging to the Component.</param>
        /// <param name="id">Required parameter: The ID of the Segment.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public Models.SegmentResponse UpdateSegment(
                string componentId,
                string pricePointId,
                double id,
                Models.UpdateSegmentRequest body = null)
            => CoreHelper.RunTask(UpdateSegmentAsync(componentId, pricePointId, id, body));

        /// <summary>
        /// This endpoint updates a single Segment for a Component with a segmented Metric. It allows you to update the pricing for the segment.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle of the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle of the Price Point belonging to the Component.</param>
        /// <param name="id">Required parameter: The ID of the Segment.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public async Task<Models.SegmentResponse> UpdateSegmentAsync(
                string componentId,
                string pricePointId,
                double id,
                Models.UpdateSegmentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SegmentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/segments/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Template(_template => _template.Setup("id", id))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new EventBasedBillingSegmentErrorsException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to delete a Segment with specified ID.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle of the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle of the Price Point belonging to the Component.</param>
        /// <param name="id">Required parameter: The ID of the Segment.</param>
        public void DeleteSegment(
                string componentId,
                string pricePointId,
                double id)
            => CoreHelper.RunVoidTask(DeleteSegmentAsync(componentId, pricePointId, id));

        /// <summary>
        /// This endpoint allows you to delete a Segment with specified ID.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle of the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle of the Price Point belonging to the Component.</param>
        /// <param name="id">Required parameter: The ID of the Segment.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSegmentAsync(
                string componentId,
                string pricePointId,
                double id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/components/{component_id}/price_points/{price_point_id}/segments/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Template(_template => _template.Setup("id", id))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to create multiple segments in one request. The array of segments can contain up to `2000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get created. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public Models.ListSegmentsResponse BulkCreateSegments(
                string componentId,
                string pricePointId,
                Models.BulkCreateSegments body = null)
            => CoreHelper.RunTask(BulkCreateSegmentsAsync(componentId, pricePointId, body));

        /// <summary>
        /// This endpoint allows you to create multiple segments in one request. The array of segments can contain up to `2000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get created. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public async Task<Models.ListSegmentsResponse> BulkCreateSegmentsAsync(
                string componentId,
                string pricePointId,
                Models.BulkCreateSegments body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSegmentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/{price_point_id}/segments/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new EventBasedBillingSegmentException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows you to update multiple segments in one request. The array of segments can contain up to `1000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get updated. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public Models.ListSegmentsResponse BulkUpdateSegments(
                string componentId,
                string pricePointId,
                Models.BulkUpdateSegments body = null)
            => CoreHelper.RunTask(BulkUpdateSegmentsAsync(componentId, pricePointId, body));

        /// <summary>
        /// This endpoint allows you to update multiple segments in one request. The array of segments can contain up to `1000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get updated. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public async Task<Models.ListSegmentsResponse> BulkUpdateSegmentsAsync(
                string componentId,
                string pricePointId,
                Models.BulkUpdateSegments body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSegmentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/segments/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("component_id", componentId).Required())
                      .Template(_template => _template.Setup("price_point_id", pricePointId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new EventBasedBillingSegmentException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}