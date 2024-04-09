// <copyright file="CustomFieldsController.cs" company="APIMatic">
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
    using APIMatic.Core.Http.Configuration;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

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
        /// ## Custom Fields: Metafield Intro.
        /// **Chargify refers to Custom Fields in the API documentation as metafields and metadata.** Within the Chargify UI, metadata and metafields are grouped together under the umbrella of "Custom Fields." All of our UI-based documentation that references custom fields will not cite the terminology metafields or metadata.
        /// + **Metafield is the custom field**.
        /// + **Metadata is the data populating the custom field.**.
        /// Chargify Metafields are used to add meaningful attributes to subscription and customer resources. Full documentation on how to create Custom Fields in the Chargify UI can be located [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405332553613-Custom-Fields-Reference). For additional documentation on how to record data within custom fields, please see our subscription-based documentation [here.](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404434903181-Subscription-Summary#custom-fields).
        /// Metafield are the place where you will set up your resource to accept additional data. It is scoped to the site instead of a specific customer or subscription. Think of it as the key, and Metadata as the value on every record.
        /// ## Create Metafields.
        /// Use this endpoint to create metafields for your Site. Metafields can be populated with metadata after the fact.
        /// Each site is limited to 100 unique Metafields (i.e. keys, or names) per resource. This means you can have 100 Metafields for Subscription and another 100 for Customer.
        /// ### Metafields "On-the-Fly".
        /// It is possible to create Metafields “on the fly” when you create your Metadata – if a non-existant name is passed when creating Metadata, a Metafield for that key will be automatically created. The Metafield API, however, gives you more control over your “keys”.
        /// ### Metafield Scope Warning.
        /// If configuring metafields in the Admin UI or via the API, be careful sending updates to metafields with the scope attribute – **if a partial update is sent it will overwrite the current configuration**.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public List<Models.Metafield> CreateMetafields(
                Models.ResourceType resourceType,
                Models.CreateMetafieldsRequest body = null)
            => CoreHelper.RunTask(CreateMetafieldsAsync(resourceType, body));

        /// <summary>
        /// ## Custom Fields: Metafield Intro.
        /// **Chargify refers to Custom Fields in the API documentation as metafields and metadata.** Within the Chargify UI, metadata and metafields are grouped together under the umbrella of "Custom Fields." All of our UI-based documentation that references custom fields will not cite the terminology metafields or metadata.
        /// + **Metafield is the custom field**.
        /// + **Metadata is the data populating the custom field.**.
        /// Chargify Metafields are used to add meaningful attributes to subscription and customer resources. Full documentation on how to create Custom Fields in the Chargify UI can be located [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405332553613-Custom-Fields-Reference). For additional documentation on how to record data within custom fields, please see our subscription-based documentation [here.](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404434903181-Subscription-Summary#custom-fields).
        /// Metafield are the place where you will set up your resource to accept additional data. It is scoped to the site instead of a specific customer or subscription. Think of it as the key, and Metadata as the value on every record.
        /// ## Create Metafields.
        /// Use this endpoint to create metafields for your Site. Metafields can be populated with metadata after the fact.
        /// Each site is limited to 100 unique Metafields (i.e. keys, or names) per resource. This means you can have 100 Metafields for Subscription and another 100 for Customer.
        /// ### Metafields "On-the-Fly".
        /// It is possible to create Metafields “on the fly” when you create your Metadata – if a non-existant name is passed when creating Metadata, a Metafield for that key will be automatically created. The Metafield API, however, gives you more control over your “keys”.
        /// ### Metafield Scope Warning.
        /// If configuring metafields in the Admin UI or via the API, be careful sending updates to metafields with the scope attribute – **if a partial update is sent it will overwrite the current configuration**.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public async Task<List<Models.Metafield>> CreateMetafieldsAsync(
                Models.ResourceType resourceType,
                Models.CreateMetafieldsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metafield>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SingleErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint lists metafields associated with a site. The metafield description and usage is contained in the response.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.ListMetafieldsResponse response from the API call.</returns>
        public Models.ListMetafieldsResponse ListMetafields(
                Models.ListMetafieldsInput input)
            => CoreHelper.RunTask(ListMetafieldsAsync(input));

        /// <summary>
        /// This endpoint lists metafields associated with a site. The metafield description and usage is contained in the response.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListMetafieldsResponse response from the API call.</returns>
        public async Task<Models.ListMetafieldsResponse> ListMetafieldsAsync(
                Models.ListMetafieldsInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListMetafieldsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(input.ResourceType).Trim('\"')))
                      .Query(_query => _query.Setup("name", input.Name))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use the following method to update metafields for your Site. Metafields can be populated with metadata after the fact.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public List<Models.Metafield> UpdateMetafield(
                Models.ResourceType resourceType,
                Models.UpdateMetafieldsRequest body = null)
            => CoreHelper.RunTask(UpdateMetafieldAsync(resourceType, body));

        /// <summary>
        /// Use the following method to update metafields for your Site. Metafields can be populated with metadata after the fact.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metafield response from the API call.</returns>
        public async Task<List<Models.Metafield>> UpdateMetafieldAsync(
                Models.ResourceType resourceType,
                Models.UpdateMetafieldsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metafield>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SingleErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Use the following method to delete a metafield. This will remove the metafield from the Site.
        /// Additionally, this will remove the metafield and associated metadata with all Subscriptions on the Site.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="name">Optional parameter: The name of the metafield to be deleted.</param>
        public void DeleteMetafield(
                Models.ResourceType resourceType,
                string name = null)
            => CoreHelper.RunVoidTask(DeleteMetafieldAsync(resourceType, name));

        /// <summary>
        /// Use the following method to delete a metafield. This will remove the metafield from the Site.
        /// Additionally, this will remove the metafield and associated metadata with all Subscriptions on the Site.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="name">Optional parameter: The name of the metafield to be deleted.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteMetafieldAsync(
                Models.ResourceType resourceType,
                string name = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/{resource_type}/metafields.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Query(_query => _query.Setup("name", name))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ## Custom Fields: Metadata Intro.
        /// **Chargify refers to Custom Fields in the API documentation as metafields and metadata.** Within the Chargify UI, metadata and metafields are grouped together under the umbrella of "Custom Fields." All of our UI-based documentation that references custom fields will not cite the terminology metafields or metadata.
        /// + **Metafield is the custom field**.
        /// + **Metadata is the data populating the custom field.**.
        /// Chargify Metafields are used to add meaningful attributes to subscription and customer resources. Full documentation on how to create Custom Fields in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407659856411). For additional documentation on how to record data within custom fields, please see our subscription-based documentation [here.](https://chargify.zendesk.com/hc/en-us/articles/4407884887835#custom-fields).
        /// Metadata is associated to a customer or subscription, and corresponds to a Metafield. When creating a new metadata object for a given record, **if the metafield is not present it will be created**.
        /// ## Metadata limits.
        /// Metadata values are limited to 2kB in size. Additonally, there are limits on the number of unique metafields available per resource.
        /// ## Create Metadata.
        /// This method will create a metafield for the site on the fly if it does not already exist, and populate the metadata value.
        /// ### Subscription or Customer Resource.
        /// Please pay special attention to the resource you use when creating metadata.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="resourceId">Required parameter: The Chargify id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public List<Models.Metadata> CreateMetadata(
                Models.ResourceType resourceType,
                int resourceId,
                Models.CreateMetadataRequest body = null)
            => CoreHelper.RunTask(CreateMetadataAsync(resourceType, resourceId, body));

        /// <summary>
        /// ## Custom Fields: Metadata Intro.
        /// **Chargify refers to Custom Fields in the API documentation as metafields and metadata.** Within the Chargify UI, metadata and metafields are grouped together under the umbrella of "Custom Fields." All of our UI-based documentation that references custom fields will not cite the terminology metafields or metadata.
        /// + **Metafield is the custom field**.
        /// + **Metadata is the data populating the custom field.**.
        /// Chargify Metafields are used to add meaningful attributes to subscription and customer resources. Full documentation on how to create Custom Fields in the Chargify UI can be located [here](https://chargify.zendesk.com/hc/en-us/articles/4407659856411). For additional documentation on how to record data within custom fields, please see our subscription-based documentation [here.](https://chargify.zendesk.com/hc/en-us/articles/4407884887835#custom-fields).
        /// Metadata is associated to a customer or subscription, and corresponds to a Metafield. When creating a new metadata object for a given record, **if the metafield is not present it will be created**.
        /// ## Metadata limits.
        /// Metadata values are limited to 2kB in size. Additonally, there are limits on the number of unique metafields available per resource.
        /// ## Create Metadata.
        /// This method will create a metafield for the site on the fly if it does not already exist, and populate the metadata value.
        /// ### Subscription or Customer Resource.
        /// Please pay special attention to the resource you use when creating metadata.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="resourceId">Required parameter: The Chargify id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public async Task<List<Models.Metadata>> CreateMetadataAsync(
                Models.ResourceType resourceType,
                int resourceId,
                Models.CreateMetadataRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metadata>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Template(_template => _template.Setup("resource_id", resourceId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SingleErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This request will list all of the metadata belonging to a particular resource (ie. subscription, customer) that is specified.
        /// ## Metadata Data.
        /// This endpoint will also display the current stats of your metadata to use as a tool for pagination.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public Models.PaginatedMetadata ListMetadata(
                Models.ListMetadataInput input)
            => CoreHelper.RunTask(ListMetadataAsync(input));

        /// <summary>
        /// This request will list all of the metadata belonging to a particular resource (ie. subscription, customer) that is specified.
        /// ## Metadata Data.
        /// This endpoint will also display the current stats of your metadata to use as a tool for pagination.
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public async Task<Models.PaginatedMetadata> ListMetadataAsync(
                Models.ListMetadataInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaginatedMetadata>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(input.ResourceType).Trim('\"')))
                      .Template(_template => _template.Setup("resource_id", input.ResourceId))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This method allows you to update the existing metadata associated with a subscription or customer.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="resourceId">Required parameter: The Chargify id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public List<Models.Metadata> UpdateMetadata(
                Models.ResourceType resourceType,
                int resourceId,
                Models.UpdateMetadataRequest body = null)
            => CoreHelper.RunTask(UpdateMetadataAsync(resourceType, resourceId, body));

        /// <summary>
        /// This method allows you to update the existing metadata associated with a subscription or customer.
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="resourceId">Required parameter: The Chargify id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.Metadata response from the API call.</returns>
        public async Task<List<Models.Metadata>> UpdateMetadataAsync(
                Models.ResourceType resourceType,
                int resourceId,
                Models.UpdateMetadataRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Metadata>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Template(_template => _template.Setup("resource_id", resourceId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("422", CreateErrorCase("HTTP Response Not OK. Status code: {$statusCode}. Response: '{$response.body}'.", (_reason, _context) => new SingleErrorResponseException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// This method removes the metadata from the subscriber/customer cited.
        /// ## Query String Usage.
        /// For instance if you wanted to delete the metadata for customer 99 named weight you would request:.
        /// ```.
        /// https://acme.chargify.com/customers/99/metadata.json?name=weight.
        /// ```.
        /// If you want to delete multiple metadata fields for a customer 99 named: `weight` and `age` you wrould request:.
        /// ```.
        /// https://acme.chargify.com/customers/99/metadata.json?names[]=weight&names[]=age.
        /// ```.
        /// ## Successful Response.
        /// For a success, there will be a code `200` and the plain text response `true`.
        /// ## Unsuccessful Response.
        /// When a failed response is encountered, you will receive a `404` response and the plain text response of `true`.
        /// ]]>
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="resourceId">Required parameter: The Chargify id of the customer or the subscription for which the metadata applies.</param>
        /// <param name="name">Optional parameter: Name of field to be removed..</param>
        /// <param name="names"><![CDATA[Optional parameter: Names of fields to be removed. Use in query: `names[]=field1&names[]=my-field&names[]=another-field`..]]></param>
        public void DeleteMetadata(
                Models.ResourceType resourceType,
                int resourceId,
                string name = null,
                List<string> names = null)
            => CoreHelper.RunVoidTask(DeleteMetadataAsync(resourceType, resourceId, name, names));

        /// <summary>
        /// <![CDATA[
        /// This method removes the metadata from the subscriber/customer cited.
        /// ## Query String Usage.
        /// For instance if you wanted to delete the metadata for customer 99 named weight you would request:.
        /// ```.
        /// https://acme.chargify.com/customers/99/metadata.json?name=weight.
        /// ```.
        /// If you want to delete multiple metadata fields for a customer 99 named: `weight` and `age` you wrould request:.
        /// ```.
        /// https://acme.chargify.com/customers/99/metadata.json?names[]=weight&names[]=age.
        /// ```.
        /// ## Successful Response.
        /// For a success, there will be a code `200` and the plain text response `true`.
        /// ## Unsuccessful Response.
        /// When a failed response is encountered, you will receive a `404` response and the plain text response of `true`.
        /// ]]>
        /// </summary>
        /// <param name="resourceType">Required parameter: the resource type to which the metafields belong.</param>
        /// <param name="resourceId">Required parameter: The Chargify id of the customer or the subscription for which the metadata applies.</param>
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
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/{resource_type}/{resource_id}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(resourceType).Trim('\"')))
                      .Template(_template => _template.Setup("resource_id", resourceId))
                      .Query(_query => _query.Setup("name", name))
                      .Query(_query => _query.Setup("names", names))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Not Found:'{$response.body}'", (_reason, _context) => new ApiException(_reason, _context), true)))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// This method will provide you information on usage of metadata across your selected resource (ie. subscriptions, customers).
        /// ## Metadata Data.
        /// This endpoint will also display the current stats of your metadata to use as a tool for pagination.
        /// ### Metadata for multiple records.
        /// `https://acme.chargify.com/subscriptions/metadata.json?resource_ids[]=1&resource_ids[]=2`.
        /// ## Read Metadata for a Site.
        /// This endpoint will list the number of pages of metadata information that are contained within a site.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public Models.PaginatedMetadata ListMetadataForResourceType(
                Models.ListMetadataForResourceTypeInput input)
            => CoreHelper.RunTask(ListMetadataForResourceTypeAsync(input));

        /// <summary>
        /// <![CDATA[
        /// This method will provide you information on usage of metadata across your selected resource (ie. subscriptions, customers).
        /// ## Metadata Data.
        /// This endpoint will also display the current stats of your metadata to use as a tool for pagination.
        /// ### Metadata for multiple records.
        /// `https://acme.chargify.com/subscriptions/metadata.json?resource_ids[]=1&resource_ids[]=2`.
        /// ## Read Metadata for a Site.
        /// This endpoint will list the number of pages of metadata information that are contained within a site.
        /// ]]>
        /// </summary>
        /// <param name="input">Object containing request parameters.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PaginatedMetadata response from the API call.</returns>
        public async Task<Models.PaginatedMetadata> ListMetadataForResourceTypeAsync(
                Models.ListMetadataForResourceTypeInput input,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PaginatedMetadata>(ArraySerialization.UnIndexed)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/{resource_type}/metadata.json")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("resource_type", ApiHelper.JsonSerialize(input.ResourceType).Trim('\"')))
                      .Query(_query => _query.Setup("page", input.Page))
                      .Query(_query => _query.Setup("per_page", input.PerPage))
                      .Query(_query => _query.Setup("date_field", (input.DateField.HasValue) ? ApiHelper.JsonSerialize(input.DateField.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("start_date", input.StartDate.HasValue ? input.StartDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("end_date", input.EndDate.HasValue ? input.EndDate.Value.ToString("yyyy'-'MM'-'dd") : null))
                      .Query(_query => _query.Setup("start_datetime", input.StartDatetime.HasValue ? input.StartDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("end_datetime", input.EndDatetime.HasValue ? input.EndDatetime.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK") : null))
                      .Query(_query => _query.Setup("with_deleted", input.WithDeleted))
                      .Query(_query => _query.Setup("resource_ids", input.ResourceIds))
                      .Query(_query => _query.Setup("direction", (input.Direction.HasValue) ? ApiHelper.JsonSerialize(input.Direction.Value).Trim('\"') : null))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}