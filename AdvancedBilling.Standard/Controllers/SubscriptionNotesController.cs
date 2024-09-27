// <copyright file="SubscriptionNotesController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
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
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public async Task<Models.SubscriptionNoteResponse> CreateSubscriptionNoteAsync(
                int subscriptionId,
                Models.UpdateSubscriptionNoteRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionNoteResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/subscriptions/{subscription_id}/notes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
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
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/notes.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", input.SubscriptionId))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Once you have obtained the ID of the note you wish to read, use this method to show a particular note attached to a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public Models.SubscriptionNoteResponse ReadSubscriptionNote(
                int subscriptionId,
                int noteId)
            => CoreHelper.RunTask(ReadSubscriptionNoteAsync(subscriptionId, noteId));

        /// <summary>
        /// Once you have obtained the ID of the note you wish to read, use this method to show a particular note attached to a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public async Task<Models.SubscriptionNoteResponse> ReadSubscriptionNoteAsync(
                int subscriptionId,
                int noteId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionNoteResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{subscription_id}/notes/{note_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("note_id", noteId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use the following method to update a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public Models.SubscriptionNoteResponse UpdateSubscriptionNote(
                int subscriptionId,
                int noteId,
                Models.UpdateSubscriptionNoteRequest body = null)
            => CoreHelper.RunTask(UpdateSubscriptionNoteAsync(subscriptionId, noteId, body));

        /// <summary>
        /// Use the following method to update a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SubscriptionNoteResponse response from the API call.</returns>
        public async Task<Models.SubscriptionNoteResponse> UpdateSubscriptionNoteAsync(
                int subscriptionId,
                int noteId,
                Models.UpdateSubscriptionNoteRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SubscriptionNoteResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/subscriptions/{subscription_id}/notes/{note_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("note_id", noteId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use the following method to delete a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        public void DeleteSubscriptionNote(
                int subscriptionId,
                int noteId)
            => CoreHelper.RunVoidTask(DeleteSubscriptionNoteAsync(subscriptionId, noteId));

        /// <summary>
        /// Use the following method to delete a note for a Subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The Chargify id of the subscription.</param>
        /// <param name="noteId">Required parameter: The Advanced Billing id of the note.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteSubscriptionNoteAsync(
                int subscriptionId,
                int noteId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/subscriptions/{subscription_id}/notes/{note_id}.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("subscription_id", subscriptionId))
                      .Template(_template => _template.Setup("note_id", noteId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}