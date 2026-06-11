// <copyright file="EventsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedBilling.Standard.Controllers
{
    /// <summary>
    /// EventsController.
    /// </summary>
    public class EventsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsController"/> class.
        /// </summary>
        internal EventsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists events for a site.
        /// ## Events Intro.
        /// Advanced Billing Events include various activity that happens around a Site. This information is **especially** useful to track down issues that arise when subscriptions are not created due to errors.
        /// Within the Advanced Billing UI, "Events" are referred to as "Site Activity".  Full documentation on how to view Events / Site Activity in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24250671733517-Site-Activity).
        /// ## List Events for a Site.
        /// This method will retrieve a list of events for a site. Use query string filters to narrow down results. You may use the `key` filter as part of your query string to narrow down results.
        /// ### Legacy Filters.
        /// The following keys are no longer supported.
        /// + `payment_failure_recreated`.
        /// + `payment_success_recreated`.
        /// + `renewal_failure_recreated`.
        /// + `renewal_success_recreated`.
        /// + `zferral_revenue_post_failure` - (Specific to the deprecated Zferral integration).
        /// + `zferral_revenue_post_success` - (Specific to the deprecated Zferral integration).
        /// ## Event Key.
        /// The event type is identified by the key property. You can check supported keys [here]($m/Event%20Key).
        /// ## Event Specific Data.
        /// Different event types may include additional data in `event_specific_data` property.
        /// While some events share the same schema for `event_specific_data`, others may not include it at all.
        /// For precise mappings from key to event_specific_data, refer to [Event]($m/Event).
        /// ### Example.
        /// Here’s an example event for the `subscription_product_change` event:.
        /// ```.
        /// {.
        ///     "event": {.
        ///         "id": 351,.
        ///         "key": "subscription_product_change",.
        ///         "message": "Product changed on Marky Mark's subscription from 'Basic' to 'Pro'",.
        ///         "subscription_id": 205,.
        ///         "event_specific_data": {.
        ///             "new_product_id": 3,.
        ///             "previous_product_id": 2.
        ///         },.
        ///         "created_at": "2012-01-30T10:43:31-05:00".
        ///     }.
        /// }.
        /// ```.
        /// Here’s an example event for the `subscription_state_change` event:.
        /// ```.
        ///  {.
        ///      "event": {.
        ///          "id": 353,.
        ///          "key": "subscription_state_change",.
        ///          "message": "State changed on Marky Mark's subscription to Pro from trialing to active",.
        ///          "subscription_id": 205,.
        ///          "event_specific_data": {.
        ///              "new_subscription_state": "active",.
        ///              "previous_subscription_state": "trialing".
        ///          },.
        ///          "created_at": "2012-01-30T10:43:33-05:00".
        ///      }.
        ///  }.
        /// ```.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.EventResponse response from the API call.</returns>
        public List<Models.EventResponse> ListEvents(
                Models.ListEventsInput input)
            => CoreHelper.RunTask(ListEventsAsync(input));

        /// <summary>
        /// Lists events for a site.
        /// ## Events Intro.
        /// Advanced Billing Events include various activity that happens around a Site. This information is **especially** useful to track down issues that arise when subscriptions are not created due to errors.
        /// Within the Advanced Billing UI, "Events" are referred to as "Site Activity".  Full documentation on how to view Events / Site Activity in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24250671733517-Site-Activity).
        /// ## List Events for a Site.
        /// This method will retrieve a list of events for a site. Use query string filters to narrow down results. You may use the `key` filter as part of your query string to narrow down results.
        /// ### Legacy Filters.
        /// The following keys are no longer supported.
        /// + `payment_failure_recreated`.
        /// + `payment_success_recreated`.
        /// + `renewal_failure_recreated`.
        /// + `renewal_success_recreated`.
        /// + `zferral_revenue_post_failure` - (Specific to the deprecated Zferral integration).
        /// + `zferral_revenue_post_success` - (Specific to the deprecated Zferral integration).
        /// ## Event Key.
        /// The event type is identified by the key property. You can check supported keys [here]($m/Event%20Key).
        /// ## Event Specific Data.
        /// Different event types may include additional data in `event_specific_data` property.
        /// While some events share the same schema for `event_specific_data`, others may not include it at all.
        /// For precise mappings from key to event_specific_data, refer to [Event]($m/Event).
        /// ### Example.
        /// Here’s an example event for the `subscription_product_change` event:.
        /// ```.
        /// {.
        ///     "event": {.
        ///         "id": 351,.
        ///         "key": "subscription_product_change",.
        ///         "message": "Product changed on Marky Mark's subscription from 'Basic' to 'Pro'",.
        ///         "subscription_id": 205,.
        ///         "event_specific_data": {.
        ///             "new_product_id": 3,.
        ///             "previous_product_id": 2.
        ///         },.
        ///         "created_at": "2012-01-30T10:43:31-05:00".
        ///     }.
        /// }.
        /// ```.
        /// Here’s an example event for the `subscription_state_change` event:.
        /// ```.
        ///  {.
        ///      "event": {.
        ///          "id": 353,.
        ///          "key": "subscription_state_change",.
        ///          "message": "State changed on Marky Mark's subscription to Pro from trialing to active",.
        ///          "subscription_id": 205,.
        ///          "event_specific_data": {.
        ///              "new_subscription_state": "active",.
        ///              "previous_subscription_state": "trialing".
        ///          },.
        ///          "created_at": "2012-01-30T10:43:33-05:00".
        ///      }.
        ///  }.
        /// ```.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.EventResponse response from the API call.</returns>
        public async Task<List<Models.EventResponse>> ListEventsAsync(
                Models.ListEventsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.EventResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/events.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("since_id", input.SinceId))
                      .Query(query => query.Setup("max_id", input.MaxId))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("filter", input.Filter?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("start_date", input.StartDate))
                      .Query(query => query.Setup("end_date", input.EndDate))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists events for a subscription.
        /// ## Event Key.
        /// The event type is identified by the key property. You can check supported keys [here]($m/Event%20Key).
        /// ## Event Specific Data.
        /// Different event types may include additional data in `event_specific_data` property.
        /// While some events share the same schema for `event_specific_data`, others may not include it at all.
        /// For precise mappings from key to event_specific_data, refer to [Event]($m/Event).
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.EventResponse response from the API call.</returns>
        public List<Models.EventResponse> ListSubscriptionEvents(
                Models.ListSubscriptionEventsInput input)
            => CoreHelper.RunTask(ListSubscriptionEventsAsync(input));

        /// <summary>
        /// Lists events for a subscription.
        /// ## Event Key.
        /// The event type is identified by the key property. You can check supported keys [here]($m/Event%20Key).
        /// ## Event Specific Data.
        /// Different event types may include additional data in `event_specific_data` property.
        /// While some events share the same schema for `event_specific_data`, others may not include it at all.
        /// For precise mappings from key to event_specific_data, refer to [Event]($m/Event).
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.EventResponse response from the API call.</returns>
        public async Task<List<Models.EventResponse>> ListSubscriptionEventsAsync(
                Models.ListSubscriptionEventsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.EventResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/events.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("since_id", input.SinceId))
                      .Query(query => query.Setup("max_id", input.MaxId))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("filter", input.Filter?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns the total count of events for a given site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.CountResponse response from the API call.</returns>
        public Models.CountResponse ReadEventsCount(
                Models.ReadEventsCountInput input)
            => CoreHelper.RunTask(ReadEventsCountAsync(input));

        /// <summary>
        /// Returns the total count of events for a given site.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CountResponse response from the API call.</returns>
        public async Task<Models.CountResponse> ReadEventsCountAsync(
                Models.ReadEventsCountInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CountResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/events/count.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("since_id", input.SinceId))
                      .Query(query => query.Setup("max_id", input.MaxId))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(query => query.Setup("filter", input.Filter?.Select(a => CoreHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}