// <copyright file="SubscriptionNotesController.cs" company="APIMatic">
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
    /// SubscriptionNotesController.
    /// </summary>
    public class SubscriptionNotesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionNotesController"/> class.
        /// </summary>
        internal SubscriptionNotesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Use the following method to create a note for a subscription.
        /// ## How to Use Subscription Notes.
        /// Notes allow you to record information about a particular Subscription in a free text format.
        /// If you have structured data such as birth date, color, etc., consider using Metadata instead.
        /// Full documentation on how to use Notes in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24251712214413-Subscription-Summary-Overview).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public Models.SubscriptionNoteResponse CreateSubscriptionNote(
                int subscriptionId,
                Models.UpdateSubscriptionNoteRequest body = null)
            => CoreHelper.RunTask(CreateSubscriptionNoteAsync(subscriptionId, body));

        /// <summary>
        /// Use the following method to create a note for a subscription.
        /// ## How to Use Subscription Notes.
        /// Notes allow you to record information about a particular Subscription in a free text format.
        /// If you have structured data such as birth date, color, etc., consider using Metadata instead.
        /// Full documentation on how to use Notes in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24251712214413-Subscription-Summary-Overview).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public async Task<Models.SubscriptionNoteResponse> CreateSubscriptionNoteAsync(
                int subscriptionId,
                Models.UpdateSubscriptionNoteRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionNoteResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/notes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use this method to retrieve a list of Notes associated with a Subscription. The response will be an array of Notes.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the List of Models.SubscriptionNoteResponse response from the API call.</returns>
        public List<Models.SubscriptionNoteResponse> ListSubscriptionNotes(
                Models.ListSubscriptionNotesInput input)
            => CoreHelper.RunTask(ListSubscriptionNotesAsync(input));

        /// <summary>
        /// Use this method to retrieve a list of Notes associated with a Subscription. The response will be an array of Notes.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.SubscriptionNoteResponse response from the API call.</returns>
        public async Task<List<Models.SubscriptionNoteResponse>> ListSubscriptionNotesAsync(
                Models.ListSubscriptionNotesInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.SubscriptionNoteResponse>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/notes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", input.SubscriptionId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Once you have obtained the ID of the note you wish to read, use this method to show a particular note attached to a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public Models.SubscriptionNoteResponse ReadSubscriptionNote(
                int subscriptionId,
                int noteId)
            => CoreHelper.RunTask(ReadSubscriptionNoteAsync(subscriptionId, noteId));

        /// <summary>
        /// Once you have obtained the ID of the note you wish to read, use this method to show a particular note attached to a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public async Task<Models.SubscriptionNoteResponse> ReadSubscriptionNoteAsync(
                int subscriptionId,
                int noteId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionNoteResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/notes/{note_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("note_id", noteId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use the following method to update a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public Models.SubscriptionNoteResponse UpdateSubscriptionNote(
                int subscriptionId,
                int noteId,
                Models.UpdateSubscriptionNoteRequest body = null)
            => CoreHelper.RunTask(UpdateSubscriptionNoteAsync(subscriptionId, noteId, body));

        /// <summary>
        /// Use the following method to update a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public async Task<Models.SubscriptionNoteResponse> UpdateSubscriptionNoteAsync(
                int subscriptionId,
                int noteId,
                Models.UpdateSubscriptionNoteRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionNoteResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/notes/{note_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("note_id", noteId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new ErrorListResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        public void DeleteSubscriptionNote(
                int subscriptionId,
                int noteId)
            => CoreHelper.RunVoidTask(DeleteSubscriptionNoteAsync(subscriptionId, noteId));

        /// <summary>
        /// Deletes a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription..</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSubscriptionNoteAsync(
                int subscriptionId,
                int noteId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/notes/{note_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("subscription_id", subscriptionId))
                      .Template(template => template.Setup("note_id", noteId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}