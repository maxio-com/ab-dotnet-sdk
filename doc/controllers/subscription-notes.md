# Subscription Notes

```csharp
SubscriptionNotesController subscriptionNotesController = client.SubscriptionNotesController;
```

## Class Name

`SubscriptionNotesController`

## Methods

* [Create Subscription Note](../../doc/controllers/subscription-notes.md#create-subscription-note)
* [List Subscription Notes](../../doc/controllers/subscription-notes.md#list-subscription-notes)
* [Read Subscription Note](../../doc/controllers/subscription-notes.md#read-subscription-note)
* [Update Subscription Note](../../doc/controllers/subscription-notes.md#update-subscription-note)
* [Delete Subscription Note](../../doc/controllers/subscription-notes.md#delete-subscription-note)


# Create Subscription Note

Creates a note for a subscription.

Notes allow you to record information about a particular Subscription in a free text format.

If you have structured data such as birth date, color, etc., consider using [Metadata](../../doc/controllers/custom-fields.md#create-metadata) instead.

For more information, see [Adding Notes](https://docs.maxio.com/hc/en-us/articles/24251654953997-Understanding-the-Subscription-Summary-Page#billing-portal-status:~:text=documentation%20for%20more.-,Adding%20Notes,-Notes%20are%20optional) in the product documentation.

```csharp
CreateSubscriptionNoteAsync(
    int subscriptionId,
    Models.UpdateSubscriptionNoteRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `body` | [`UpdateSubscriptionNoteRequest`](../../doc/models/update-subscription-note-request.md) | Body, Optional | Updatable fields for Subscription Note |

## Response Type

**200**: OK

[`Task<Models.SubscriptionNoteResponse>`](../../doc/models/subscription-note-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
UpdateSubscriptionNoteRequest body = new UpdateSubscriptionNoteRequest
{
    Note = new UpdateSubscriptionNote
    {
        Body = "New test note.",
        Sticky = true,
    },
};

try
{
    SubscriptionNoteResponse result = await subscriptionNotesController.CreateSubscriptionNoteAsync(
        subscriptionId,
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
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# List Subscription Notes

Retrieves a list of notes associated with a subscription. The response will be an array of Notes.

```csharp
ListSubscriptionNotesAsync(
    Models.ListSubscriptionNotesInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListSubscriptionNotesInput`](../../doc/models/list-subscription-notes-input.md) | Required | Input structure for the method ListSubscriptionNotes |

## Response Type

**200**: OK

[`Task<List<Models.SubscriptionNoteResponse>>`](../../doc/models/subscription-note-response.md)

## Example Usage

```csharp
ListSubscriptionNotesInput listSubscriptionNotesInput = new ListSubscriptionNotesInput
{
    SubscriptionId = 222,
    Page = 1,
    PerPage = 50,
};

try
{
    List<SubscriptionNoteResponse> result = await subscriptionNotesController.ListSubscriptionNotesAsync(listSubscriptionNotesInput);
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
    "note": {
      "body": "Test note.",
      "created_at": "2015-06-15T13:26:47-04:00",
      "id": 5,
      "sticky": false,
      "subscription_id": 100046,
      "updated_at": "2015-06-15T13:28:12-04:00"
    }
  },
  {
    "note": {
      "body": "Another test note.",
      "created_at": "2015-06-15T12:04:46-04:00",
      "id": 4,
      "sticky": false,
      "subscription_id": 100046,
      "updated_at": "2015-06-15T13:26:33-04:00"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Read Subscription Note

Retrieves a specific note attached to a subscription.

```csharp
ReadSubscriptionNoteAsync(
    int subscriptionId,
    int noteId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `noteId` | `int` | Template, Required | The Advanced Billing id of the note |

## Response Type

**200**: OK

[`Task<Models.SubscriptionNoteResponse>`](../../doc/models/subscription-note-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int noteId = 66;
try
{
    SubscriptionNoteResponse result = await subscriptionNotesController.ReadSubscriptionNoteAsync(
        subscriptionId,
        noteId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "note": {
    "body": "Test note.",
    "created_at": "2015-06-15T13:26:47-04:00",
    "id": 5,
    "sticky": false,
    "subscription_id": 100046,
    "updated_at": "2015-06-15T13:28:12-04:00"
  }
}
```


# Update Subscription Note

Updates a note for a subscription.

```csharp
UpdateSubscriptionNoteAsync(
    int subscriptionId,
    int noteId,
    Models.UpdateSubscriptionNoteRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `noteId` | `int` | Template, Required | The Advanced Billing id of the note |
| `body` | [`UpdateSubscriptionNoteRequest`](../../doc/models/update-subscription-note-request.md) | Body, Optional | Updatable fields for Subscription Note |

## Response Type

**200**: OK

[`Task<Models.SubscriptionNoteResponse>`](../../doc/models/subscription-note-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int noteId = 66;
UpdateSubscriptionNoteRequest body = new UpdateSubscriptionNoteRequest
{
    Note = new UpdateSubscriptionNote
    {
        Body = "Modified test note.",
        Sticky = true,
    },
};

try
{
    SubscriptionNoteResponse result = await subscriptionNotesController.UpdateSubscriptionNoteAsync(
        subscriptionId,
        noteId,
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
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Delete Subscription Note

Deletes a note for a Subscription.

```csharp
DeleteSubscriptionNoteAsync(
    int subscriptionId,
    int noteId)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `noteId` | `int` | Template, Required | The Advanced Billing id of the note |

## Response Type

**200**: OK

`Task`

## Example Usage

```csharp
int subscriptionId = 222;
int noteId = 66;
try
{
    await subscriptionNotesController.DeleteSubscriptionNoteAsync(
        subscriptionId,
        noteId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

