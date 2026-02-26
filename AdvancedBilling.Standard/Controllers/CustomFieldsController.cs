// <copyright file="CustomFieldsController.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Http.Configuration;
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
    /// CustomFieldsController.
    /// </summary>
    public class CustomFieldsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldsController"/> class.
        /// </summary>
        internal CustomFieldsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates metafields on a Site for either the Subscriptions or Customers resource. .
        /// Metafields and their metadata are created in the Custom Fields configuration page on your Site. Metafields can be populated with metadata when you create them or later with the [Update Metafield]($e/Custom%20Fields/updateMetafield), [Create Metadata]($e/Custom%20Fields/createMetadata), or [Update Metadata]($e/Custom%20Fields/updateMetadata) endpoints. The Create Metadata and Update Metadata endpoints allow you to add metafields and metadata values to a specific subscription or customer.
        /// Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscriptions and another 100 for Customers.
        /// > Note: After creating a metafield, the resource type cannot be modified.
        /// In the UI and product documentation, metafields and metadata are called Custom Fields. .
        /// - Metafield is the custom field.
        /// - Metadata is the data populating the custom field.
        /// See [Custom Fields Reference](https://docs.maxio.com/hc/en-us/articles/24266140850573-Custom-Fields-Reference) and [Custom Fields Tab](https://maxio.zendesk.com/hc/en-us/articles/24251701302925-Subscription-Summary-Custom-Fields-Tab) for information on using Custom Fields in the Advanced Billing UI.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public List<Models.Metafield> CreateMetafields(
                Models.ResourceType resourceType,
                Models.CreateMetafieldsRequest body = null)
            => CoreHelper.RunTask(CreateMetafieldsAsync(resourceType, body));

        /// <summary>
        /// Creates metafields on a Site for either the Subscriptions or Customers resource. .
        /// Metafields and their metadata are created in the Custom Fields configuration page on your Site. Metafields can be populated with metadata when you create them or later with the [Update Metafield]($e/Custom%20Fields/updateMetafield), [Create Metadata]($e/Custom%20Fields/createMetadata), or [Update Metadata]($e/Custom%20Fields/updateMetadata) endpoints. The Create Metadata and Update Metadata endpoints allow you to add metafields and metadata values to a specific subscription or customer.
        /// Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscriptions and another 100 for Customers.
        /// > Note: After creating a metafield, the resource type cannot be modified.
        /// In the UI and product documentation, metafields and metadata are called Custom Fields. .
        /// - Metafield is the custom field.
        /// - Metadata is the data populating the custom field.
        /// See [Custom Fields Reference](https://docs.maxio.com/hc/en-us/articles/24266140850573-Custom-Fields-Reference) and [Custom Fields Tab](https://maxio.zendesk.com/hc/en-us/articles/24251701302925-Subscription-Summary-Custom-Fields-Tab) for information on using Custom Fields in the Advanced Billing UI.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public async Task<List<Models.Metafield>> CreateMetafieldsAsync(
                Models.ResourceType resourceType,
                Models.CreateMetafieldsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metafield>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the metafields and their associated details for a Site and resource type. You can filter the request to a specific metafield.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListMetafieldsResponse response from the API call.</returns>
        public Models.ListMetafieldsResponse ListMetafields(
                Models.ListMetafieldsInput input)
            => CoreHelper.RunTask(ListMetafieldsAsync(input));

        /// <summary>
        /// Lists the metafields and their associated details for a Site and resource type. You can filter the request to a specific metafield.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListMetafieldsResponse response from the API call.</returns>
        public async Task<Models.ListMetafieldsResponse> ListMetafieldsAsync(
                Models.ListMetafieldsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListMetafieldsResponse>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(input.ResourceType).Trim('\"')))
                      .Query(query => query.Setup("name", input.Name))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates metafields on your Site for a resource type.  Depending on the request structure, you can update or add metafields and metadata to the Subscriptions or Customers resource.
        /// With this endpoint, you can: .
        /// - Add metafields. If the metafield specified in current_name does not exist, a new metafield is added. .
        ///   >Note: Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscriptions and another 100 for Customers.
        /// - Change the name of a metafield. .
        ///   >Note: To keep the metafield name the same and only update the metadata for the metafield, you must use the current metafield name in both the `current_name` and `name` parameters.
        /// - Change the input type for the metafield. For example, you can change a metafield input type from text to a dropdown. If you change the input type from text to a dropdown or radio, you must update the specific subscriptions or customers where the metafield was used to reflect the updated metafield and metadata. .
        /// - Add metadata values to the existing metadata for a dropdown or radio metafield. .
        ///   >Note: Updates to metadata overwrite. To add one or more values, you must specify all metadata values including the new value you want to add.
        /// - Add new metadata to a dropdown or radio for a metafield that was created without metadata.
        /// - Remove  metadata for a dropdown or radio for a metafield.  .
        ///   >Note: Updates to metadata overwrite existing values. To remove one or more values, specify all metadata values except those you want to remove.
        /// - Add or update scope settings for a metafield.
        ///   >Note: Scope changes overwrite existing settings. You must specify the complete scope, including the changes you want to make.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public List<Models.Metafield> UpdateMetafield(
                Models.ResourceType resourceType,
                Models.UpdateMetafieldsRequest body = null)
            => CoreHelper.RunTask(UpdateMetafieldAsync(resourceType, body));

        /// <summary>
        /// Updates metafields on your Site for a resource type.  Depending on the request structure, you can update or add metafields and metadata to the Subscriptions or Customers resource.
        /// With this endpoint, you can: .
        /// - Add metafields. If the metafield specified in current_name does not exist, a new metafield is added. .
        ///   >Note: Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscriptions and another 100 for Customers.
        /// - Change the name of a metafield. .
        ///   >Note: To keep the metafield name the same and only update the metadata for the metafield, you must use the current metafield name in both the `current_name` and `name` parameters.
        /// - Change the input type for the metafield. For example, you can change a metafield input type from text to a dropdown. If you change the input type from text to a dropdown or radio, you must update the specific subscriptions or customers where the metafield was used to reflect the updated metafield and metadata. .
        /// - Add metadata values to the existing metadata for a dropdown or radio metafield. .
        ///   >Note: Updates to metadata overwrite. To add one or more values, you must specify all metadata values including the new value you want to add.
        /// - Add new metadata to a dropdown or radio for a metafield that was created without metadata.
        /// - Remove  metadata for a dropdown or radio for a metafield.  .
        ///   >Note: Updates to metadata overwrite existing values. To remove one or more values, specify all metadata values except those you want to remove.
        /// - Add or update scope settings for a metafield.
        ///   >Note: Scope changes overwrite existing settings. You must specify the complete scope, including the changes you want to make.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public async Task<List<Models.Metafield>> UpdateMetafieldAsync(
                Models.ResourceType resourceType,
                Models.UpdateMetafieldsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metafield>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes a metafield from your Site. Removes the metafield and associated metadata from all Subscriptions or Customers resources on the Site.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="name">Optional parameter: The name of the metafield to be deleted.</param>
        public void DeleteMetafield(
                Models.ResourceType resourceType,
                string name = null)
            => CoreHelper.RunVoidTask(DeleteMetafieldAsync(resourceType, name));

        /// <summary>
        /// Deletes a metafield from your Site. Removes the metafield and associated metadata from all Subscriptions or Customers resources on the Site.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="name">Optional parameter: The name of the metafield to be deleted.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteMetafieldAsync(
                Models.ResourceType resourceType,
                string name = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Query(query => query.Setup("name", name))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates metadata and metafields for a specific subscription or customer, or updates metadata values of existing metafields for a subscription or customer. Metadata values are limited to 2 KB in size.
        /// If you create metadata on a subscription or customer with a metafield that does not already exist, the metafield is created with the metadata you specify and it is always added as a text field. You can update the input_type for the metafield with the [Update Metafield]($e/Custom%20Fields/updateMetafield) endpoint. .
        /// >Note: Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscriptions and another 100 for Customers.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="resourceId">Required parameter: The Advanced Billing id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public List<Models.Metadata> CreateMetadata(
                Models.ResourceType resourceType,
                int resourceId,
                Models.CreateMetadataRequest body = null)
            => CoreHelper.RunTask(CreateMetadataAsync(resourceType, resourceId, body));

        /// <summary>
        /// Creates metadata and metafields for a specific subscription or customer, or updates metadata values of existing metafields for a subscription or customer. Metadata values are limited to 2 KB in size.
        /// If you create metadata on a subscription or customer with a metafield that does not already exist, the metafield is created with the metadata you specify and it is always added as a text field. You can update the input_type for the metafield with the [Update Metafield]($e/Custom%20Fields/updateMetafield) endpoint. .
        /// >Note: Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscriptions and another 100 for Customers.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="resourceId">Required parameter: The Advanced Billing id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public async Task<List<Models.Metadata>> CreateMetadataAsync(
                Models.ResourceType resourceType,
                int resourceId,
                Models.CreateMetadataRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metadata>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Post, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Template(template => template.Setup("resource_id", resourceId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists metadata and metafields for a specific customer or subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public Models.PaginatedMetadata ListMetadata(
                Models.ListMetadataInput input)
            => CoreHelper.RunTask(ListMetadataAsync(input));

        /// <summary>
        /// Lists metadata and metafields for a specific customer or subscription.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public async Task<Models.PaginatedMetadata> ListMetadataAsync(
                Models.ListMetadataInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaginatedMetadata>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(input.ResourceType).Trim('\"')))
                      .Template(template => template.Setup("resource_id", input.ResourceId))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates metadata and metafields on the Site and the customer or subscription specified, and updates the metadata value on a subscription or customer.
        /// If you update metadata on a subscription or customer with a metafield that does not already exist, the metafield is created with the metadata you specify and it is always added as a text field to the Site and to the subscription or customer you specify. You can update the input_type for the metafield with the Update Metafield endpoint. .
        /// Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscription and another 100 for Customer.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="resourceId">Required parameter: The Advanced Billing id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public List<Models.Metadata> UpdateMetadata(
                Models.ResourceType resourceType,
                int resourceId,
                Models.UpdateMetadataRequest body = null)
            => CoreHelper.RunTask(UpdateMetadataAsync(resourceType, resourceId, body));

        /// <summary>
        /// Updates metadata and metafields on the Site and the customer or subscription specified, and updates the metadata value on a subscription or customer.
        /// If you update metadata on a subscription or customer with a metafield that does not already exist, the metafield is created with the metadata you specify and it is always added as a text field to the Site and to the subscription or customer you specify. You can update the input_type for the metafield with the Update Metafield endpoint. .
        /// Each site is limited to 100 unique metafields per resource. This means you can have 100 metafields for Subscription and another 100 for Customer.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="resourceId">Required parameter: The Advanced Billing id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public async Task<List<Models.Metadata>> UpdateMetadataAsync(
                Models.ResourceType resourceType,
                int resourceId,
                Models.UpdateMetadataRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metadata>>()
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Put, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Body(b => b.Setup(body))
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Template(template => template.Setup("resource_id", resourceId))
                      .Header(header => header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (errorReason, context) => new SingleErrorResponseException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes one or more metafields (and associated metadata) from the specified subscription or customer.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="resourceId">Required parameter: The Advanced Billing id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="name">Optional parameter: Name of field to be removed..</param>
        /// <param name="names"><![CDATA[Optional parameter: Names of fields to be removed. Use in query: `names[]=field1&names[]=my-field&names[]=another-field`..]]></param>
        public void DeleteMetadata(
                Models.ResourceType resourceType,
                int resourceId,
                string name = null,
                List<string> names = null)
            => CoreHelper.RunVoidTask(DeleteMetadataAsync(resourceType, resourceId, name, names));

        /// <summary>
        /// Deletes one or more metafields (and associated metadata) from the specified subscription or customer.
        /// </summary>
        /// <param name="resourceType">Required parameter: The resource type to which the metafields belong..</param>
        /// <param name="resourceId">Required parameter: The Advanced Billing id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="name">Optional parameter: Name of field to be removed..</param>
        /// <param name="names"><![CDATA[Optional parameter: Names of fields to be removed. Use in query: `names[]=field1&names[]=my-field&names[]=another-field`..]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteMetadataAsync(
                Models.ResourceType resourceType,
                int resourceId,
                string name = null,
                List<string> names = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>(ArraySerialization.UnIndexed)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Delete, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Template(template => template.Setup("resource_id", resourceId))
                      .Query(query => query.Setup("name", name))
                      .Query(query => query.Setup("names", names))))
              .ResponseHandler(responseHandler => responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (errorReason, context) => new ApiException(errorReason, context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists  metadata for a specified array of subscriptions or customers.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public Models.PaginatedMetadata ListMetadataForResourceType(
                Models.ListMetadataForResourceTypeInput input)
            => CoreHelper.RunTask(ListMetadataForResourceTypeAsync(input));

        /// <summary>
        /// Lists  metadata for a specified array of subscriptions or customers.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public async Task<Models.PaginatedMetadata> ListMetadataForResourceTypeAsync(
                Models.ListMetadataForResourceTypeInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaginatedMetadata>(ArraySerialization.UnIndexed)
              .RequestBuilder(requestBuilder => requestBuilder
                  .Setup(HttpMethod.Get, "/{resource_type}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(parameters => parameters
                      .Template(template => template.Setup("resource_type", CoreHelper.JsonSerialize(input.ResourceType).Trim('\"')))
                      .Query(query => query.Setup("page", input.Page))
                      .Query(query => query.Setup("per_page", input.PerPage))
                      .Query(query => query.Setup("date_field", (input.DateField.HasValue) ? CoreHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(query => query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(query => query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(query => query.Setup("with_deleted", input.WithDeleted))
                      .Query(query => query.Setup("resource_ids", input.ResourceIds))
                      .Query(query => query.Setup("direction", (input.Direction.HasValue) ? CoreHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}