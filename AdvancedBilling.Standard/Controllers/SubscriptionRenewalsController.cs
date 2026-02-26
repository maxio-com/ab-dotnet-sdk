// <copyright file="SubscriptionRenewalsController.cs" company="APIMatic">
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
    /// SubscriptionRenewalsController.
    /// </summary>
    public class SubscriptionRenewalsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRenewalsController"/> class.
        /// </summary>
        internal SubscriptionRenewalsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a scheduled renewal configuration for a subscription. The scheduled renewal is based on the subscription’s current product and component setup.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationResponse CreateScheduledRenewalConfiguration(
                int subscriptionId,
                Models.ScheduledRenewalConfigurationRequest body = null)
            => CoreHelper.RunTask(CreateScheduledRenewalConfigurationAsync(subscriptionId, body));

        /// <summary>
        /// Creates a scheduled renewal configuration for a subscription. The scheduled renewal is based on the subscription’s current product and component setup.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationResponse> CreateScheduledRenewalConfigurationAsync(
                int subscriptionId,
                Models.ScheduledRenewalConfigurationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/scheduled_renewals.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists scheduled renewal configurations for the subscription and permits an optional status query filter.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="status">Optional parameter: (Optional) Status filter for scheduled renewal configurations..</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationsResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationsResponse ListScheduledRenewalConfigurations(
                int subscriptionId,
                Models.Status? status = null)
            => CoreHelper.RunTask(ListScheduledRenewalConfigurationsAsync(subscriptionId, status));

        /// <summary>
        /// Lists scheduled renewal configurations for the subscription and permits an optional status query filter.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="status">Optional parameter: (Optional) Status filter for scheduled renewal configurations..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationsResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationsResponse> ListScheduledRenewalConfigurationsAsync(
                int subscriptionId,
                Models.Status? status = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/scheduled_renewals.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Query(query => query.Setup("status", (status.HasValue) ? CoreHelper.JsonSerialize(status.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves the configuration settings for the scheduled renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationResponse ReadScheduledRenewalConfiguration(
                int subscriptionId,
                int id)
            => CoreHelper.RunTask(ReadScheduledRenewalConfigurationAsync(subscriptionId, id));

        /// <summary>
        /// Retrieves the configuration settings for the scheduled renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationResponse> ReadScheduledRenewalConfigurationAsync(
                int subscriptionId,
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/scheduled_renewals/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("id", id))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an existing configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationResponse UpdateScheduledRenewalConfiguration(
                int subscriptionId,
                int id,
                Models.ScheduledRenewalConfigurationRequest body = null)
            => CoreHelper.RunTask(UpdateScheduledRenewalConfigurationAsync(subscriptionId, id, body));

        /// <summary>
        /// Updates an existing configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationResponse> UpdateScheduledRenewalConfigurationAsync(
                int subscriptionId,
                int id,
                Models.ScheduledRenewalConfigurationRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/scheduled_renewals/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Schedules a future lock-in date for the renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationResponse ScheduleScheduledRenewalLockIn(
                int subscriptionId,
                int id,
                Models.ScheduledRenewalLockInRequest body = null)
            => CoreHelper.RunTask(ScheduleScheduledRenewalLockInAsync(subscriptionId, id, body));

        /// <summary>
        /// Schedules a future lock-in date for the renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationResponse> ScheduleScheduledRenewalLockInAsync(
                int subscriptionId,
                int id,
                Models.ScheduledRenewalLockInRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/scheduled_renewals/{id}/schedule_lock_in.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Locks in the renewal immediately.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationResponse LockInScheduledRenewalImmediately(
                int subscriptionId,
                int id)
            => CoreHelper.RunTask(LockInScheduledRenewalImmediatelyAsync(subscriptionId, id));

        /// <summary>
        /// Locks in the renewal immediately.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationResponse> LockInScheduledRenewalImmediatelyAsync(
                int subscriptionId,
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/scheduled_renewals/{id}/immediate_lock_in.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a scheduled renewal configuration to an editable state.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationResponse UnpublishScheduledRenewalConfiguration(
                int subscriptionId,
                int id)
            => CoreHelper.RunTask(UnpublishScheduledRenewalConfigurationAsync(subscriptionId, id));

        /// <summary>
        /// Returns a scheduled renewal configuration to an editable state.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationResponse> UnpublishScheduledRenewalConfigurationAsync(
                int subscriptionId,
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/scheduled_renewals/{id}/unpublish.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancels a scheduled renewal configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationResponse CancelScheduledRenewalConfiguration(
                int subscriptionId,
                int id)
            => CoreHelper.RunTask(CancelScheduledRenewalConfigurationAsync(subscriptionId, id));

        /// <summary>
        /// Cancels a scheduled renewal configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="id">Required parameter: The renewal id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationResponse> CancelScheduledRenewalConfigurationAsync(
                int subscriptionId,
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/scheduled_renewals/{id}/cancel.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Adds product and component line items to the scheduled renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="scheduledRenewalsConfigurationId">Required parameter: The scheduled renewal configuration id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationItemResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationItemResponse CreateScheduledRenewalConfigurationItem(
                int subscriptionId,
                int scheduledRenewalsConfigurationId,
                Models.ScheduledRenewalConfigurationItemRequest body = null)
            => CoreHelper.RunTask(CreateScheduledRenewalConfigurationItemAsync(subscriptionId, scheduledRenewalsConfigurationId, body));

        /// <summary>
        /// Adds product and component line items to the scheduled renewal.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="scheduledRenewalsConfigurationId">Required parameter: The scheduled renewal configuration id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationItemResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationItemResponse> CreateScheduledRenewalConfigurationItemAsync(
                int subscriptionId,
                int scheduledRenewalsConfigurationId,
                Models.ScheduledRenewalConfigurationItemRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationItemResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/scheduled_renewals/{scheduled_renewals_configuration_id}/configuration_items.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("scheduled_renewals_configuration_id", scheduledRenewalsConfigurationId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates an existing configuration item’s pricing and quantity.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="scheduledRenewalsConfigurationId">Required parameter: The scheduled renewal configuration id..</param>
        /// <param name="id">Required parameter: The scheduled renewal configuration item id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationItemResponse response from the API call.</returns>
        public Models.ScheduledRenewalConfigurationItemResponse UpdateScheduledRenewalConfigurationItem(
                int subscriptionId,
                int scheduledRenewalsConfigurationId,
                int id,
                Models.ScheduledRenewalUpdateRequest body = null)
            => CoreHelper.RunTask(UpdateScheduledRenewalConfigurationItemAsync(subscriptionId, scheduledRenewalsConfigurationId, id, body));

        /// <summary>
        /// Updates an existing configuration item’s pricing and quantity.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="scheduledRenewalsConfigurationId">Required parameter: The scheduled renewal configuration id..</param>
        /// <param name="id">Required parameter: The scheduled renewal configuration item id..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ScheduledRenewalConfigurationItemResponse response from the API call.</returns>
        public async Task<Models.ScheduledRenewalConfigurationItemResponse> UpdateScheduledRenewalConfigurationItemAsync(
                int subscriptionId,
                int scheduledRenewalsConfigurationId,
                int id,
                Models.ScheduledRenewalUpdateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ScheduledRenewalConfigurationItemResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/scheduled_renewals/{scheduled_renewals_configuration_id}/configuration_items/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("scheduled_renewals_configuration_id", scheduledRenewalsConfigurationId))
                      .Template(template => template.Setup("id", id))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Removes an item from the pending renewal configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="scheduledRenewalsConfigurationId">Required parameter: The scheduled renewal configuration id..</param>
        /// <param name="id">Required parameter: The scheduled renewal configuration item id..</param>
        public void DeleteScheduledRenewalConfigurationItem(
                int subscriptionId,
                int scheduledRenewalsConfigurationId,
                int id)
            => CoreHelper.RunVoidTask(DeleteScheduledRenewalConfigurationItemAsync(subscriptionId, scheduledRenewalsConfigurationId, id));

        /// <summary>
        /// Removes an item from the pending renewal configuration.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="scheduledRenewalsConfigurationId">Required parameter: The scheduled renewal configuration id..</param>
        /// <param name="id">Required parameter: The scheduled renewal configuration item id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteScheduledRenewalConfigurationItemAsync(
                int subscriptionId,
                int scheduledRenewalsConfigurationId,
                int id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/scheduled_renewals/{scheduled_renewals_configuration_id}/configuration_items/{id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("scheduled_renewals_configuration_id", scheduledRenewalsConfigurationId))
                      .Template(template => template.Setup("id", id))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity (WebDAV)", (errorReason, context) => new ErrorListResponseException(errorReason, context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}