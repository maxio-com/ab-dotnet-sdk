# API Exports

```csharp
APIExportsController aPIExportsController = client.APIExportsController;
```

## Class Name

`APIExportsController`

## Methods

* [List Exported Proforma Invoices](../../doc/controllers/api-exports.md#list-exported-proforma-invoices)
* [List Exported Invoices](../../doc/controllers/api-exports.md#list-exported-invoices)
* [List Exported Subscriptions](../../doc/controllers/api-exports.md#list-exported-subscriptions)
* [Export Proforma Invoices](../../doc/controllers/api-exports.md#export-proforma-invoices)
* [Export Invoices](../../doc/controllers/api-exports.md#export-invoices)
* [Export Subscriptions](../../doc/controllers/api-exports.md#export-subscriptions)
* [Read Proforma Invoices Export](../../doc/controllers/api-exports.md#read-proforma-invoices-export)
* [Read Invoices Export](../../doc/controllers/api-exports.md#read-invoices-export)
* [Read Subscriptions Export](../../doc/controllers/api-exports.md#read-subscriptions-export)


# List Exported Proforma Invoices

This API returns an array of exported proforma invoices for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.

Example: `GET https://{subdomain}.chargify.com/api_exports/proforma_invoices/123/rows?per_page=10000&page=1`.

```csharp
ListExportedProformaInvoicesAsync(
    Models.ListExportedProformaInvoicesInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request.<br>Default value is 100.<br>The maximum allowed values is 10000; any per_page value over 10000 will be changed to 10000.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 10000` |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |

## Response Type

[`Task<List<Models.ProformaInvoice>>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
ListExportedProformaInvoicesInput listExportedProformaInvoicesInput = new ListExportedProformaInvoicesInput
{
    BatchId = "batch_id8",
    PerPage = 100,
    Page = 2,
};

try
{
    List<ProformaInvoice> result = await aPIExportsController.ListExportedProformaInvoicesAsync(listExportedProformaInvoicesInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# List Exported Invoices

This API returns an array of exported invoices for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.

Example: `GET https://{subdomain}.chargify.com/api_exports/invoices/123/rows?per_page=10000&page=1`.

```csharp
ListExportedInvoicesAsync(
    Models.ListExportedInvoicesInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request.<br>Default value is 100.<br>The maximum allowed values is 10000; any per_page value over 10000 will be changed to 10000.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 10000` |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |

## Response Type

[`Task<List<Models.Invoice>>`](../../doc/models/invoice.md)

## Example Usage

```csharp
ListExportedInvoicesInput listExportedInvoicesInput = new ListExportedInvoicesInput
{
    BatchId = "batch_id8",
    PerPage = 100,
    Page = 2,
};

try
{
    List<Invoice> result = await aPIExportsController.ListExportedInvoicesAsync(listExportedInvoicesInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# List Exported Subscriptions

This API returns an array of exported subscriptions for a provided `batch_id`. Pay close attention to pagination in order to control responses from the server.

Example: `GET https://{subdomain}.chargify.com/api_exports/subscriptions/123/rows?per_page=200&page=1`.

```csharp
ListExportedSubscriptionsAsync(
    Models.ListExportedSubscriptionsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request.<br>Default value is 100.<br>The maximum allowed values is 10000; any per_page value over 10000 will be changed to 10000.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 10000` |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |

## Response Type

[`Task<List<Models.Subscription>>`](../../doc/models/subscription.md)

## Example Usage

```csharp
ListExportedSubscriptionsInput listExportedSubscriptionsInput = new ListExportedSubscriptionsInput
{
    BatchId = "batch_id8",
    PerPage = 100,
    Page = 2,
};

try
{
    List<Subscription> result = await aPIExportsController.ListExportedSubscriptionsAsync(listExportedSubscriptionsInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Export Proforma Invoices

This API creates a proforma invoices export and returns a batchjob object.

It is only available for Relationship Invoicing architecture.

```csharp
ExportProformaInvoicesAsync()
```

## Response Type

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
try
{
    BatchJobResponse result = await aPIExportsController.ExportProformaInvoicesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 409 | Conflict | [`SingleErrorResponseException`](../../doc/models/single-error-response-exception.md) |


# Export Invoices

This API creates an invoices export and returns a batchjob object.

```csharp
ExportInvoicesAsync()
```

## Response Type

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
try
{
    BatchJobResponse result = await aPIExportsController.ExportInvoicesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 409 | Conflict | [`SingleErrorResponseException`](../../doc/models/single-error-response-exception.md) |


# Export Subscriptions

This API creates a subscriptions export and returns a batchjob object.

```csharp
ExportSubscriptionsAsync()
```

## Response Type

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
try
{
    BatchJobResponse result = await aPIExportsController.ExportSubscriptionsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 409 | Conflict | [`SingleErrorResponseException`](../../doc/models/single-error-response-exception.md) |


# Read Proforma Invoices Export

This API returns a batchjob object for proforma invoices export.

```csharp
ReadProformaInvoicesExportAsync(
    string batchId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |

## Response Type

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
string batchId = "batch_id8";
try
{
    BatchJobResponse result = await aPIExportsController.ReadProformaInvoicesExportAsync(batchId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Read Invoices Export

This API returns a batchjob object for invoices export.

```csharp
ReadInvoicesExportAsync(
    string batchId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |

## Response Type

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
string batchId = "batch_id8";
try
{
    BatchJobResponse result = await aPIExportsController.ReadInvoicesExportAsync(batchId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Read Subscriptions Export

This API returns a batchjob object for subscriptions export.

```csharp
ReadSubscriptionsExportAsync(
    string batchId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |

## Response Type

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
string batchId = "batch_id8";
try
{
    BatchJobResponse result = await aPIExportsController.ReadSubscriptionsExportAsync(batchId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |

