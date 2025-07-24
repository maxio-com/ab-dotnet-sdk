// <copyright file="EventsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
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
using AdvancedBilling.Standard.Http.Client;
using AdvancedBilling.Standard.Utilities;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using System.Net.Http;

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
        /// ## Events Intro.
        /// Advanced Billing Events include various activity that happens around a Site. This information is **especially** useful to track down issues that arise when subscriptions are not created due to errors.
        /// Within the Advanced Billing UI, "Events" are referred to as "Site Activity".  Full documentation on how to record view Events / Site Activty in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24250671733517-Site-Activity).
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
        /// ## Events Intro.
        /// Advanced Billing Events include various activity that happens around a Site. This information is **especially** useful to track down issues that arise when subscriptions are not created due to errors.
        /// Within the Advanced Billing UI, "Events" are referred to as "Site Activity".  Full documentation on how to record view Events / Site Activty in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24250671733517-Site-Activity).
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
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/events.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("since_id", input.SinceId))
                      .Query(_query => _query.Setup("max_id", input.MaxId))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(_query => _query.Setup("filter", input.Filter?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate))
                      .Query(_query => _query.Setup("end_date", input.EndDate))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// The following request will return a list of events for a subscription.
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
        /// The following request will return a list of events for a subscription.
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
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/events.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", input.SubscriptionId))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("since_id", input.SinceId))
                      .Query(_query => _query.Setup("max_id", input.MaxId))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(_query => _query.Setup("filter", input.Filter?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a count of all the events for a given site by using this method.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.CountResponse response from the API call.</returns>
        public Models.CountResponse ReadEventsCount(
                Models.ReadEventsCountInput input)
            => CoreHelper.RunTask(ReadEventsCountAsync(input));

        /// <summary>
        /// Get a count of all the events for a given site by using this method.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CountResponse response from the API call.</returns>
        public async Task<Models.CountResponse> ReadEventsCountAsync(
                Models.ReadEventsCountInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/events/count.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("since_id", input.SinceId))
                      .Query(_query => _query.Setup("max_id", input.MaxId))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : "desc"))
                      .Query(_query => _query.Setup("filter", input.Filter?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}