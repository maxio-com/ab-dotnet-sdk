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

Use the following method to create a note for a subscription.

## How to Use Subscription Notes

Notes allow you to record information about a particular Subscription in a free text format.

If you have structured data such as birth date, color, etc., consider using Metadata instead.

Full documentation on how to use Notes in the Chargify UI can be located [here](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404434903181-Subscription-Summary#notes).

```csharp
CreateSubscriptionNoteAsync(
    int subscriptionId,
    Models.UpdateSubscriptionNoteRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `body` | [`UpdateSubscriptionNoteRequest`](../../doc/models/update-subscription-note-request.md) | Body, Optional | Updatable fields for Subscription Note |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# List Subscription Notes

Use this method to retrieve a list of Notes associated with a Subscription. The response will be an array of Notes.

```csharp
ListSubscriptionNotesAsync(
    Models.ListSubscriptionNotesInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`. |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`. |

## Response Type

[`Task<List<Models.SubscriptionNoteResponse>>`](../../doc/models/subscription-note-response.md)

## Example Usage

```csharp
ListSubscriptionNotesInput listSubscriptionNotesInput = new ListSubscriptionNotesInput
{
    SubscriptionId = 222,
    Page = 2,
    PerPage = 50,
};

try
{
    List<SubscriptionNoteResponse> result = await subscriptionNotesController.ListSubscriptionNotesAsync(listSubscriptionNotesInput);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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


# Read Subscription Note

Once you have obtained the ID of the note you wish to read, use this method to show a particular note attached to a subscription.

```csharp
ReadSubscriptionNoteAsync(
    int subscriptionId,
    int noteId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `noteId` | `int` | Template, Required | The Chargify id of the note |

## Response Type

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
    // TODO: Handle exception here
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

Use the following method to update a note for a Subscription.

```csharp
UpdateSubscriptionNoteAsync(
    int subscriptionId,
    int noteId,
    Models.UpdateSubscriptionNoteRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `noteId` | `int` | Template, Required | The Chargify id of the note |
| `body` | [`UpdateSubscriptionNoteRequest`](../../doc/models/update-subscription-note-request.md) | Body, Optional | Updatable fields for Subscription Note |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Subscription Note

Use the following method to delete a note for a Subscription.

```csharp
DeleteSubscriptionNoteAsync(
    int subscriptionId,
    int noteId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `noteId` | `int` | Template, Required | The Chargify id of the note |

## Response Type

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
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

