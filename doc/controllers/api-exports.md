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

Lists exported proforma invoices for a provided `batch_id`. Use pagination to control responses returned from the server.

Example: `GET https://{subdomain}.chargify.com/api_exports/proforma_invoices/123/rows?per_page=10000&page=1`.

```csharp
ListExportedProformaInvoicesAsync(
    Models.ListExportedProformaInvoicesInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListExportedProformaInvoicesInput`](../../doc/models/list-exported-proforma-invoices-input.md) | Required | Input structure for the method ListExportedProformaInvoices |

## Response Type

**200**: OK

[`Task<List<Models.ProformaInvoice>>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
ListExportedProformaInvoicesInput listExportedProformaInvoicesInput = new ListExportedProformaInvoicesInput
{
    BatchId = "batch_id8",
    PerPage = 100,
    Page = 1,
};

try
{
    List<ProformaInvoice> result = await aPIExportsController.ListExportedProformaInvoicesAsync(listExportedProformaInvoicesInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# List Exported Invoices

Lists exported invoices for a provided `batch_id`. Use pagination to control responses returned from the server.

Example: `GET https://{subdomain}.chargify.com/api_exports/invoices/123/rows?per_page=10000&page=1`.

```csharp
ListExportedInvoicesAsync(
    Models.ListExportedInvoicesInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListExportedInvoicesInput`](../../doc/models/list-exported-invoices-input.md) | Required | Input structure for the method ListExportedInvoices |

## Response Type

**200**: OK

[`Task<List<Models.Invoice>>`](../../doc/models/invoice.md)

## Example Usage

```csharp
ListExportedInvoicesInput listExportedInvoicesInput = new ListExportedInvoicesInput
{
    BatchId = "batch_id8",
    PerPage = 100,
    Page = 1,
};

try
{
    List<Invoice> result = await aPIExportsController.ListExportedInvoicesAsync(listExportedInvoicesInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# List Exported Subscriptions

Lists exported subscriptions for a provided `batch_id`. Use pagination to control responses returned from the server.

Example: `GET https://{subdomain}.chargify.com/api_exports/subscriptions/123/rows?per_page=200&page=1`.

```csharp
ListExportedSubscriptionsAsync(
    Models.ListExportedSubscriptionsInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListExportedSubscriptionsInput`](../../doc/models/list-exported-subscriptions-input.md) | Required | Input structure for the method ListExportedSubscriptions |

## Response Type

**200**: OK

[`Task<List<Models.Subscription>>`](../../doc/models/subscription.md)

## Example Usage

```csharp
ListExportedSubscriptionsInput listExportedSubscriptionsInput = new ListExportedSubscriptionsInput
{
    BatchId = "batch_id8",
    PerPage = 100,
    Page = 1,
};

try
{
    List<Subscription> result = await aPIExportsController.ListExportedSubscriptionsAsync(listExportedSubscriptionsInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Export Proforma Invoices

Creates a proforma invoices export and returns a batch job object. Proforma invoices are only available on Relationship Invoicing sites.

```csharp
ExportProformaInvoicesAsync()
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Response Type

**201**: Created

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
try
{
    BatchJobResponse result = await aPIExportsController.ExportProformaInvoicesAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is SingleErrorResponseException)
    {
       // TODO: Handle SingleErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 409 | Conflict | [`SingleErrorResponseException`](../../doc/models/single-error-response-exception.md) |


# Export Invoices

Creates an invoices export and returns a batch job object.

```csharp
ExportInvoicesAsync()
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Response Type

**201**: Created

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
try
{
    BatchJobResponse result = await aPIExportsController.ExportInvoicesAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is SingleErrorResponseException)
    {
       // TODO: Handle SingleErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 409 | Conflict | [`SingleErrorResponseException`](../../doc/models/single-error-response-exception.md) |


# Export Subscriptions

Creates a subscriptions export and returns a batch job object.

```csharp
ExportSubscriptionsAsync()
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Response Type

**201**: Created

[`Task<Models.BatchJobResponse>`](../../doc/models/batch-job-response.md)

## Example Usage

```csharp
try
{
    BatchJobResponse result = await aPIExportsController.ExportSubscriptionsAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is SingleErrorResponseException)
    {
       // TODO: Handle SingleErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 409 | Conflict | [`SingleErrorResponseException`](../../doc/models/single-error-response-exception.md) |


# Read Proforma Invoices Export

Returns a batch job object for a proforma invoices export. Proforma invoices are only available on Relationship Invoicing sites.

```csharp
ReadProformaInvoicesExportAsync(
    string batchId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |

## Response Type

**200**: OK

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
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Read Invoices Export

Returns a batch job object for an invoices export.

```csharp
ReadInvoicesExportAsync(
    string batchId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |

## Response Type

**200**: OK

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
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Read Subscriptions Export

Returns a batch job object for a subscriptions export.

```csharp
ReadSubscriptionsExportAsync(
    string batchId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `batchId` | `string` | Template, Required | Id of a Batch Job. |

## Response Type

**200**: OK

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
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |

