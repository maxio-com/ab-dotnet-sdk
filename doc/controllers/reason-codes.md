# Reason Codes

```csharp
ReasonCodesController reasonCodesController = client.ReasonCodesController;
```

## Class Name

`ReasonCodesController`

## Methods

* [Create Reason Code](../../doc/controllers/reason-codes.md#create-reason-code)
* [List Reason Codes](../../doc/controllers/reason-codes.md#list-reason-codes)
* [Read Reason Code](../../doc/controllers/reason-codes.md#read-reason-code)
* [Update Reason Code](../../doc/controllers/reason-codes.md#update-reason-code)
* [Delete Reason Code](../../doc/controllers/reason-codes.md#delete-reason-code)


# Create Reason Code

Creates a reason code for a given site.

# Reason Codes Intro

Reason Codes are a way to gain a high-level view of why your customers are cancelling the subscription to your product or service.

Add a set of churn reason codes to be displayed in-app and/or the Maxio Billing Portal. As your subscribers decide to cancel their subscription, learn why they decided to cancel.

## Reason Code Documentation

Full documentation on how Reason Codes operate within Advanced Billing can be located under the following links.

[Churn Reason Codes](https://maxio.zendesk.com/hc/en-us/articles/24286647554701-Churn-Reason-Codes)

## Create Reason Code

This method gives a merchant the option to create reason codes for a given site.

```csharp
CreateReasonCodeAsync(
    Models.CreateReasonCodeRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateReasonCodeRequest`](../../doc/models/create-reason-code-request.md) | Body, Optional | - |

## Response Type

**200**: OK

[`Task<Models.ReasonCodeResponse>`](../../doc/models/reason-code-response.md)

## Example Usage

```csharp
CreateReasonCodeRequest body = new CreateReasonCodeRequest
{
    ReasonCode = new CreateReasonCode
    {
        Code = "NOTHANKYOU",
        Description = "No thank you!",
        Position = 5,
    },
};

try
{
    ReasonCodeResponse result = await reasonCodesController.CreateReasonCodeAsync(body);
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


# List Reason Codes

Lists all current churn codes for a given site.

```csharp
ListReasonCodesAsync(
    Models.ListReasonCodesInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListReasonCodesInput`](../../doc/models/list-reason-codes-input.md) | Required | Input structure for the method ListReasonCodes |

## Response Type

**200**: OK

[`Task<List<Models.ReasonCodeResponse>>`](../../doc/models/reason-code-response.md)

## Example Usage

```csharp
ListReasonCodesInput listReasonCodesInput = new ListReasonCodesInput
{
    Page = 1,
    PerPage = 50,
};

try
{
    List<ReasonCodeResponse> result = await reasonCodesController.ListReasonCodesAsync(listReasonCodesInput);
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

## Example Response *(as JSON)*

```json
[
  {
    "reason_code": {
      "id": 2,
      "site_id": 2,
      "code": "LARGE",
      "description": "This is too complicated",
      "position": 1,
      "created_at": "2017-02-16T16:49:07-05:00",
      "updated_at": "2017-02-17T16:29:51-05:00"
    }
  },
  {
    "reason_code": {
      "id": 1,
      "site_id": 2,
      "code": "CH1",
      "description": "This does not meet my needs",
      "position": 2,
      "created_at": "2017-02-16T16:48:45-05:00",
      "updated_at": "2017-02-17T16:29:59-05:00"
    }
  },
  {
    "reason_code": {
      "id": 5,
      "site_id": 2,
      "code": "HAN99",
      "description": "Hard to setup",
      "position": 3,
      "created_at": "2017-02-17T16:29:42-05:00",
      "updated_at": "2017-02-17T16:29:59-05:00"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Read Reason Code

Returns a particular churn reason code for a given site by its unique ID.

```csharp
ReadReasonCodeAsync(
    int reasonCodeId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `reasonCodeId` | `int` | Template, Required | The Advanced Billing id of the reason code |

## Response Type

**200**: OK

[`Task<Models.ReasonCodeResponse>`](../../doc/models/reason-code-response.md)

## Example Usage

```csharp
int reasonCodeId = 32;
try
{
    ReasonCodeResponse result = await reasonCodesController.ReadReasonCodeAsync(reasonCodeId);
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


# Update Reason Code

Updates an existing reason code for a given site.

```csharp
UpdateReasonCodeAsync(
    int reasonCodeId,
    Models.UpdateReasonCodeRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `reasonCodeId` | `int` | Template, Required | The Advanced Billing id of the reason code |
| `body` | [`UpdateReasonCodeRequest`](../../doc/models/update-reason-code-request.md) | Body, Optional | - |

## Response Type

**200**: OK

[`Task<Models.ReasonCodeResponse>`](../../doc/models/reason-code-response.md)

## Example Usage

```csharp
int reasonCodeId = 32;
try
{
    ReasonCodeResponse result = await reasonCodesController.UpdateReasonCodeAsync(reasonCodeId);
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


# Delete Reason Code

Deletes a reason code from the Churn Reason Codes. This code will be immediately removed. This action is not reversible.

```csharp
DeleteReasonCodeAsync(
    int reasonCodeId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `reasonCodeId` | `int` | Template, Required | The Advanced Billing id of the reason code |

## Response Type

**200**: OK

[`Task<Models.OkResponse>`](../../doc/models/ok-response.md)

## Example Usage

```csharp
int reasonCodeId = 32;
try
{
    OkResponse result = await reasonCodesController.DeleteReasonCodeAsync(reasonCodeId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "ok": "ok"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |

