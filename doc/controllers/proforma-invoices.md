# Proforma Invoices

```csharp
ProformaInvoicesController proformaInvoicesController = client.ProformaInvoicesController;
```

## Class Name

`ProformaInvoicesController`

## Methods

* [Create Consolidated Proforma Invoice](../../doc/controllers/proforma-invoices.md#create-consolidated-proforma-invoice)
* [List Subscription Group Proforma Invoices](../../doc/controllers/proforma-invoices.md#list-subscription-group-proforma-invoices)
* [Read Proforma Invoice](../../doc/controllers/proforma-invoices.md#read-proforma-invoice)
* [Create Proforma Invoice](../../doc/controllers/proforma-invoices.md#create-proforma-invoice)
* [List Proforma Invoices](../../doc/controllers/proforma-invoices.md#list-proforma-invoices)
* [Deliver Proforma Invoice](../../doc/controllers/proforma-invoices.md#deliver-proforma-invoice)
* [Void Proforma Invoice](../../doc/controllers/proforma-invoices.md#void-proforma-invoice)
* [Preview Proforma Invoice](../../doc/controllers/proforma-invoices.md#preview-proforma-invoice)
* [Create Signup Proforma Invoice](../../doc/controllers/proforma-invoices.md#create-signup-proforma-invoice)
* [Preview Signup Proforma Invoice](../../doc/controllers/proforma-invoices.md#preview-signup-proforma-invoice)


# Create Consolidated Proforma Invoice

Creates a consolidated proforma invoice asynchronously. It will return a 201 with no message, or a 422 with any errors. To find and view the new consolidated proforma invoice, you may poll the subscription group listing for proforma invoices; only one consolidated proforma invoice may be created per group at a time.

If the information becomes outdated, simply void the old consolidated proforma invoice and generate a new one.

## Restrictions

Proforma invoices are only available on Relationship Invoicing sites. To create a proforma invoice, the subscription must not be prepaid, and must be in a live state.

```csharp
CreateConsolidatedProformaInvoiceAsync(
    string uid)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `uid` | `string` | Template, Required | The uid of the subscription group |

## Response Type

**201**: Created

`Task`

## Example Usage

```csharp
string uid = "uid0";
try
{
    await proformaInvoicesController.CreateConsolidatedProformaInvoiceAsync(uid);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# List Subscription Group Proforma Invoices

Lists proforma invoices with a `consolidation_level` of parent for the subscription group.

By default, proforma invoices returned on the index will only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, `custom_fields`. To include breakdowns, pass the specific field as a key in the query with a value set to true.

```csharp
ListSubscriptionGroupProformaInvoicesAsync(
    Models.ListSubscriptionGroupProformaInvoicesInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListSubscriptionGroupProformaInvoicesInput`](../../doc/models/list-subscription-group-proforma-invoices-input.md) | Required | Input structure for the method ListSubscriptionGroupProformaInvoices |

## Response Type

**200**: OK

[`Task<Models.ListProformaInvoicesResponse>`](../../doc/models/list-proforma-invoices-response.md)

## Example Usage

```csharp
ListSubscriptionGroupProformaInvoicesInput listSubscriptionGroupProformaInvoicesInput = new ListSubscriptionGroupProformaInvoicesInput
{
    Uid = "uid0",
    LineItems = false,
    Discounts = false,
    Taxes = false,
    Credits = false,
    Payments = false,
    CustomFields = false,
};

try
{
    ListProformaInvoicesResponse result = await proformaInvoicesController.ListSubscriptionGroupProformaInvoicesAsync(listSubscriptionGroupProformaInvoicesInput);
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


# Read Proforma Invoice

Returns the details of an existing proforma invoice.

## Restrictions

Proforma invoices are only available on Relationship Invoicing sites.

```csharp
ReadProformaInvoiceAsync(
    string proformaInvoiceUid)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `proformaInvoiceUid` | `string` | Template, Required | The uid of the proforma invoice |

## Response Type

**200**: OK

[`Task<Models.ProformaInvoice>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
string proformaInvoiceUid = "proforma_invoice_uid4";
try
{
    ProformaInvoice result = await proformaInvoicesController.ReadProformaInvoiceAsync(proformaInvoiceUid);
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


# Create Proforma Invoice

Creates a proforma invoice and returns it as a response. If the information becomes outdated, simply void the old proforma invoice and generate a new one.

If you would like to preview the next billing amounts without generating a full proforma invoice, use the renewal preview endpoint.

## Restrictions

Proforma invoices are only available on Relationship Invoicing sites. To create a proforma invoice, the subscription must not be in a group, must not be prepaid, and must be in a live state.

```csharp
CreateProformaInvoiceAsync(
    int subscriptionId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |

## Response Type

**200**: OK

[`Task<Models.ProformaInvoice>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
int subscriptionId = 222;
try
{
    ProformaInvoice result = await proformaInvoicesController.CreateProformaInvoiceAsync(subscriptionId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# List Proforma Invoices

Lists proforma invoices for a subscription. By default, results only include totals, not detailed breakdowns for `line_items`, `discounts`, `taxes`, `credits`, `payments`, or `custom_fields`. To include breakdowns, pass the specific field as a key in the query with a value set to `true`.

```csharp
ListProformaInvoicesAsync(
    Models.ListProformaInvoicesInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListProformaInvoicesInput`](../../doc/models/list-proforma-invoices-input.md) | Required | Input structure for the method ListProformaInvoices |

## Response Type

**200**: OK

[`Task<Models.ListProformaInvoicesResponse>`](../../doc/models/list-proforma-invoices-response.md)

## Example Usage

```csharp
ListProformaInvoicesInput listProformaInvoicesInput = new ListProformaInvoicesInput
{
    SubscriptionId = 222,
    Page = 1,
    PerPage = 50,
    Direction = Direction.Desc,
    LineItems = false,
    Discounts = false,
    Taxes = false,
    Credits = false,
    Payments = false,
    CustomFields = false,
};

try
{
    ListProformaInvoicesResponse result = await proformaInvoicesController.ListProformaInvoicesAsync(listProformaInvoicesInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```


# Deliver Proforma Invoice

Delivers a proforma invoice programmatically via email. Supports email
delivery to direct recipients, carbon-copy (cc) recipients, and blind carbon-copy (bcc) recipients.

If `recipient_emails` is omitted, the system will fall back to the primary recipient derived from the invoice or
subscription. At least one recipient must be present, either via the request body or via this default behavior, so an
empty body may still succeed when defaults are available.

```csharp
DeliverProformaInvoiceAsync(
    string proformaInvoiceUid,
    Models.DeliverProformaInvoiceRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `proformaInvoiceUid` | `string` | Template, Required | The uid of the proforma invoice |
| `body` | [`DeliverProformaInvoiceRequest`](../../doc/models/deliver-proforma-invoice-request.md) | Body, Optional | - |

## Response Type

**201**: Created

[`Task<Models.ProformaInvoice>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
string proformaInvoiceUid = "proforma_invoice_uid4";
DeliverProformaInvoiceRequest body = new DeliverProformaInvoiceRequest
{
    RecipientEmails = new List<string>
    {
        "user0@example.com",
    },
    CcRecipientEmails = new List<string>
    {
        "user1@example.com",
    },
    BccRecipientEmails = new List<string>
    {
        "user2@example.com",
    },
};

try
{
    ProformaInvoice result = await proformaInvoicesController.DeliverProformaInvoiceAsync(
        proformaInvoiceUid,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Void Proforma Invoice

Voids a proforma invoice that has the status "draft".

## Restrictions

Proforma invoices are only available on Relationship Invoicing sites.

Only proforma invoices that have the appropriate status may be reopened. If the invoice identified by {uid} does not have the appropriate status, the response will have HTTP status code 422 and an error message.

A reason for the void operation is required to be included in the request body. If one is not provided, the response will have HTTP status code 422 and an error message.

```csharp
VoidProformaInvoiceAsync(
    string proformaInvoiceUid,
    Models.VoidInvoiceRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `proformaInvoiceUid` | `string` | Template, Required | The uid of the proforma invoice |
| `body` | [`VoidInvoiceRequest`](../../doc/models/void-invoice-request.md) | Body, Optional | - |

## Response Type

**200**: OK

[`Task<Models.ProformaInvoice>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
string proformaInvoiceUid = "proforma_invoice_uid4";
try
{
    ProformaInvoice result = await proformaInvoicesController.VoidProformaInvoiceAsync(proformaInvoiceUid);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Preview Proforma Invoice

Previews the data that will be included on a given subscription's proforma invoice if one were to be generated. It will have similar line items and totals as a renewal preview, but the response will be presented in the format of a proforma invoice. Consequently it will include additional information such as the name and addresses that will appear on the proforma invoice.

The preview endpoint is subject to all the same conditions as the proforma invoice endpoint. For example, previews are only available on the Relationship Invoicing architecture, and previews cannot be made for end-of-life subscriptions.

If all the data returned in the preview is as expected, you may then create a static proforma invoice and send it to your customer. The data within a preview will not be saved and will not be accessible after the call is made.

Alternatively, if you have some proforma invoices already, you may make a preview call to determine whether any billing information for the subscription's upcoming renewal has changed.

```csharp
PreviewProformaInvoiceAsync(
    int subscriptionId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |

## Response Type

**200**: OK

[`Task<Models.ProformaInvoice>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
int subscriptionId = 222;
try
{
    ProformaInvoice result = await proformaInvoicesController.PreviewProformaInvoiceAsync(subscriptionId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ErrorListResponseException)
    {
       // TODO: Handle ErrorListResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Create Signup Proforma Invoice

Creates a proforma invoice to preview costs before a subscription's signup. This endpoint is only available for Relationship Invoicing sites and cannot be used to create consolidated proforma invoices or preview prepaid subscriptions. Like other proforma invoices, it can be emailed to the customer, voided, and publicly viewed on the chargifypay domain.

Pass a payload that resembles a subscription create or signup preview request. For example, you can specify components, coupons/a referral, offers, custom pricing, and an existing customer or payment profile to populate a shipping or billing address.

A product and customer first name, last name, and email are the minimum requirements. We recommend associating the proforma invoice with a customer_id to easily find their proforma invoices, since the subscription_id will always be blank.

```csharp
CreateSignupProformaInvoiceAsync(
    Models.CreateSubscriptionRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateSubscriptionRequest`](../../doc/models/create-subscription-request.md) | Body, Optional | - |

## Response Type

**201**: Created

[`Task<Models.ProformaInvoice>`](../../doc/models/proforma-invoice.md)

## Example Usage

```csharp
CreateSubscriptionRequest body = new CreateSubscriptionRequest
{
    Subscription = new CreateSubscription
    {
        ProductHandle = "gold-product",
        CustomerAttributes = new CustomerAttributes
        {
            FirstName = "Myra",
            LastName = "Maisel",
            Email = "mmaisel@example.com",
        },
    },
};

try
{
    ProformaInvoice result = await proformaInvoicesController.CreateSignupProformaInvoiceAsync(body);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ProformaBadRequestErrorResponseException)
    {
       // TODO: Handle ProformaBadRequestErrorResponseException exception here
    }
    if (e is ErrorArrayMapResponseException)
    {
       // TODO: Handle ErrorArrayMapResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ProformaBadRequestErrorResponseException`](../../doc/models/proforma-bad-request-error-response-exception.md) |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |


# Preview Signup Proforma Invoice

Creates a signup preview in the format of a proforma invoice to preview costs before a subscription's signup. This endpoint is only available for Relationship Invoicing sites and cannot be used to create consolidated proforma invoice previews or preview prepaid subscriptions. You have the option of previewing the first renewal's costs as well. The proforma invoice preview will not be persisted.

Pass a payload that resembles a subscription create or signup preview request. For example, you can specify components, coupons/a referral, offers, custom pricing, and an existing customer or payment profile to populate a shipping or billing address.

A product and customer first name, last name, and email are the minimum requirements.

```csharp
PreviewSignupProformaInvoiceAsync(
    Models.CreateSignupProformaPreviewInclude? include = null,
    Models.CreateSubscriptionRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`CreateSignupProformaPreviewInclude?`](../../doc/models/create-signup-proforma-preview-include.md) | Query, Optional | Choose to include a proforma invoice preview for the first renewal. Use in query `include=next_proforma_invoice`. |
| `body` | [`CreateSubscriptionRequest`](../../doc/models/create-subscription-request.md) | Body, Optional | - |

## Response Type

**201**: Created

[`Task<Models.SignupProformaPreviewResponse>`](../../doc/models/signup-proforma-preview-response.md)

## Example Usage

```csharp
CreateSubscriptionRequest body = new CreateSubscriptionRequest
{
    Subscription = new CreateSubscription
    {
        ProductHandle = "gold-plan",
        CustomerAttributes = new CustomerAttributes
        {
            FirstName = "first",
            LastName = "last",
            Email = "flast@example.com",
        },
    },
};

try
{
    SignupProformaPreviewResponse result = await proformaInvoicesController.PreviewSignupProformaInvoiceAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is ProformaBadRequestErrorResponseException)
    {
       // TODO: Handle ProformaBadRequestErrorResponseException exception here
    }
    if (e is ErrorArrayMapResponseException)
    {
       // TODO: Handle ErrorArrayMapResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ProformaBadRequestErrorResponseException`](../../doc/models/proforma-bad-request-error-response-exception.md) |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |

