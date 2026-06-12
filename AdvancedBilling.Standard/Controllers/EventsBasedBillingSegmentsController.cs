// <copyright file="EventsBasedBillingSegmentsController.cs" company="APIMatic">
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
    /// EventsBasedBillingSegmentsController.
    /// </summary>
    public class EventsBasedBillingSegmentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsBasedBillingSegmentsController"/> class.
        /// </summary>
        internal EventsBasedBillingSegmentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a new segment for a component with a segmented metric. It allows you to specify properties to bill upon and prices for each Segment. You can only pass as many "property_values" as the related Metric has segmenting properties defined.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public Models.SegmentResponse CreateSegment(
                string componentId,
                string pricePointId,
                Models.CreateSegmentRequest body = null)
            => CoreHelper.RunTask(CreateSegmentAsync(componentId, pricePointId, body));

        /// <summary>
        /// Creates a new segment for a component with a segmented metric. It allows you to specify properties to bill upon and prices for each Segment. You can only pass as many "property_values" as the related Metric has segmenting properties defined.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public async Task<Models.SegmentResponse> CreateSegmentAsync(
                string componentId,
                string pricePointId,
                Models.CreateSegmentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SegmentResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/{price_point_id}/segments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new EventBasedBillingSegmentErrorsException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists segments created for a given price point, in order of creation.
        /// You can pass `page` and `per_page` parameters in order to access all of the segments. By default it will return `30` records. You can set `per_page` to `200` at most.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public Models.ListSegmentsResponse ListSegmentsForPricePoint(
                Models.ListSegmentsForPricePointInput input)
            => CoreHelper.RunTask(ListSegmentsForPricePointAsync(input));

        /// <summary>
        /// Lists segments created for a given price point, in order of creation.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/components/{component_id}/price_points/{price_point_id}/segments.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("component_id", input.ComponentId).Required())
                      .Template(template => template.Setup("price_point_id", input.PricePointId).Required())
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("filter", input.Filter))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new EventBasedBillingListSegmentsErrorsException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates a single segment for a component with a segmented metric. It allows you to update the pricing for the segment.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle of the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle of the Price Point belonging to the Component.</param>
        /// <param name="id">Required parameter: The ID of the Segment.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public Models.SegmentResponse UpdateSegment(
                string componentId,
                string pricePointId,
                double id,
                Models.UpdateSegmentRequest body = null)
            => CoreHelper.RunTask(UpdateSegmentAsync(componentId, pricePointId, id, body));

        /// <summary>
        /// Updates a single segment for a component with a segmented metric. It allows you to update the pricing for the segment.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle of the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle of the Price Point belonging to the Component.</param>
        /// <param name="id">Required parameter: The ID of the Segment.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SegmentResponse response from the API call.</returns>
        public async Task<Models.SegmentResponse> UpdateSegmentAsync(
                string componentId,
                string pricePointId,
                double id,
                Models.UpdateSegmentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SegmentResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/segments/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new EventBasedBillingSegmentErrorsException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a segment with the specified ID.
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
        /// Deletes a segment with the specified ID.
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
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/components/{component_id}/price_points/{price_point_id}/segments/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates multiple segments in one request. The array of segments can contain up to `2000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get created. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public Models.ListSegmentsResponse BulkCreateSegments(
                string componentId,
                string pricePointId,
                Models.BulkCreateSegments body = null)
            => CoreHelper.RunTask(BulkCreateSegmentsAsync(componentId, pricePointId, body));

        /// <summary>
        /// Creates multiple segments in one request. The array of segments can contain up to `2000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get created. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public async Task<Models.ListSegmentsResponse> BulkCreateSegmentsAsync(
                string componentId,
                string pricePointId,
                Models.BulkCreateSegments body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSegmentsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/components/{component_id}/price_points/{price_point_id}/segments/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new EventBasedBillingSegmentException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates multiple segments in one request. The array of segments can contain up to `1000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get updated. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public Models.ListSegmentsResponse BulkUpdateSegments(
                string componentId,
                string pricePointId,
                Models.BulkUpdateSegments body = null)
            => CoreHelper.RunTask(BulkUpdateSegmentsAsync(componentId, pricePointId, body));

        /// <summary>
        /// Updates multiple segments in one request. The array of segments can contain up to `1000` records.
        /// If any of the records contain an error the whole request would fail and none of the requested segments get updated. The error response contains a message for only the one segment that failed validation, with the corresponding index in the array.
        /// You may specify component and/or price point by using either the numeric ID or the `handle:gold` syntax.
        /// </summary>
        /// <param name="componentId">Required parameter: ID or Handle for the Component.</param>
        /// <param name="pricePointId">Required parameter: ID or Handle for the Price Point belonging to the Component.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListSegmentsResponse response from the API call.</returns>
        public async Task<Models.ListSegmentsResponse> BulkUpdateSegmentsAsync(
                string componentId,
                string pricePointId,
                Models.BulkUpdateSegments body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListSegmentsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/components/{component_id}/price_points/{price_point_id}/segments/bulk.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("component_id", componentId).Required())
                      .Template(template => template.Setup("price_point_id", pricePointId).Required())
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true))
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new EventBasedBillingSegmentException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}