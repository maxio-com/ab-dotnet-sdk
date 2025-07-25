# Events

```csharp
EventsController eventsController = client.EventsController;
```

## Class Name

`EventsController`

## Methods

* [List Events](../../doc/controllers/events.md#list-events)
* [List Subscription Events](../../doc/controllers/events.md#list-subscription-events)
* [Read Events Count](../../doc/controllers/events.md#read-events-count)


# List Events

## Events Intro

Advanced Billing Events include various activity that happens around a Site. This information is **especially** useful to track down issues that arise when subscriptions are not created due to errors.

Within the Advanced Billing UI, "Events" are referred to as "Site Activity".  Full documentation on how to record view Events / Site Activty in the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24250671733517-Site-Activity).

## List Events for a Site

This method will retrieve a list of events for a site. Use query string filters to narrow down results. You may use the `key` filter as part of your query string to narrow down results.

### Legacy Filters

The following keys are no longer supported.

+ `payment_failure_recreated`
+ `payment_success_recreated`
+ `renewal_failure_recreated`
+ `renewal_success_recreated`
+ `zferral_revenue_post_failure` - (Specific to the deprecated Zferral integration)
+ `zferral_revenue_post_success` - (Specific to the deprecated Zferral integration)

## Event Key

The event type is identified by the key property. You can check supported keys [here](../../doc/models/event-key.md).

## Event Specific Data

Different event types may include additional data in `event_specific_data` property.
While some events share the same schema for `event_specific_data`, others may not include it at all.
For precise mappings from key to event_specific_data, refer to [Event](../../doc/models/event.md).

### Example

Here’s an example event for the `subscription_product_change` event:

```
{
    "event": {
        "id": 351,
        "key": "subscription_product_change",
        "message": "Product changed on Marky Mark's subscription from 'Basic' to 'Pro'",
        "subscription_id": 205,
        "event_specific_data": {
            "new_product_id": 3,
            "previous_product_id": 2
        },
        "created_at": "2012-01-30T10:43:31-05:00"
    }
}
```

Here’s an example event for the `subscription_state_change` event:

```
 {
     "event": {
         "id": 353,
         "key": "subscription_state_change",
         "message": "State changed on Marky Mark's subscription to Pro from trialing to active",
         "subscription_id": 205,
         "event_specific_data": {
             "new_subscription_state": "active",
             "previous_subscription_state": "trialing"
         },
         "created_at": "2012-01-30T10:43:33-05:00"
     }
 }
```

```csharp
ListEventsAsync(
    Models.ListEventsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `sinceId` | `long?` | Query, Optional | Returns events with an id greater than or equal to the one specified |
| `maxId` | `long?` | Query, Optional | Returns events with an id less than or equal to the one specified |
| `direction` | [`Direction?`](../../doc/models/direction.md) | Query, Optional | The sort direction of the returned events.<br><br>**Default**: `Direction.desc` |
| `filter` | [`List<EventKey>`](../../doc/models/event-key.md) | Query, Optional | You can pass multiple event keys after comma.<br>Use in query `filter=signup_success,payment_success`. |
| `dateField` | [`ListEventsDateField?`](../../doc/models/list-events-date-field.md) | Query, Optional | The type of filter you would like to apply to your search. |
| `startDate` | `string` | Query, Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `endDate` | `string` | Query, Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `startDatetime` | `string` | Query, Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |
| `endDatetime` | `string` | Query, Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. |

## Response Type

[`Task<List<Models.EventResponse>>`](../../doc/models/event-response.md)

## Example Usage

```csharp
ListEventsInput listEventsInput = new ListEventsInput
{
    Page = 2,
    PerPage = 50,
    Direction = Direction.Desc,
    Filter = new List<EventKey>
    {
        EventKey.CustomFieldValueChange,
        EventKey.PaymentSuccess,
    },
    DateField = ListEventsDateField.CreatedAt,
};

try
{
    List<EventResponse> result = await eventsController.ListEventsAsync(listEventsInput);
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
    "event": {
      "id": 343087780,
      "key": "subscription_state_change",
      "message": "State changed on Test subscription to Monthly Product from active to past_due",
      "subscription_id": 14950962,
      "customer_id": 12345678,
      "created_at": "2016-10-27T16:42:22-04:00",
      "event_specific_data": {
        "previous_subscription_state": "active",
        "new_subscription_state": "past_due"
      }
    }
  },
  {
    "event": {
      "id": 343087742,
      "key": "billing_date_change",
      "message": "Billing date changed on Test's subscription to Monthly Product from 11/27/2016 to 10/27/2016",
      "subscription_id": 14950962,
      "customer_id": 12345678,
      "created_at": "2016-10-27T16:42:19-04:00",
      "event_specific_data": null
    }
  },
  {
    "event": {
      "id": 343085267,
      "key": "statement_closed",
      "message": "Statement 79401838 closed (but not settled) for Test's subscription to ANNUAL product",
      "subscription_id": 14950975,
      "customer_id": 87654321,
      "created_at": "2016-10-27T16:40:40-04:00",
      "event_specific_data": null
    }
  },
  {
    "event": {
      "id": 4481,
      "key": "custom_field_value_change",
      "message": "Custom field (Extra support included) changed for Subscription 117 from 'Yes' to 'No'.",
      "subscription_id": 117,
      "customer_id": 22334455,
      "created_at": "2022-03-24T07:55:06-04:00",
      "event_specific_data": {
        "event_type": "updated",
        "metafield_name": "Extra support included",
        "metafield_id": 2,
        "old_value": "Yes",
        "new_value": "No",
        "resource_type": "Subscription",
        "resource_id": 117
      }
    }
  }
]
```


# List Subscription Events

The following request will return a list of events for a subscription.

## Event Key

The event type is identified by the key property. You can check supported keys [here](../../doc/models/event-key.md).

## Event Specific Data

Different event types may include additional data in `event_specific_data` property.
While some events share the same schema for `event_specific_data`, others may not include it at all.
For precise mappings from key to event_specific_data, refer to [Event](../../doc/models/event.md).

```csharp
ListSubscriptionEventsAsync(
    Models.ListSubscriptionEventsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `sinceId` | `long?` | Query, Optional | Returns events with an id greater than or equal to the one specified |
| `maxId` | `long?` | Query, Optional | Returns events with an id less than or equal to the one specified |
| `direction` | [`Direction?`](../../doc/models/direction.md) | Query, Optional | The sort direction of the returned events.<br><br>**Default**: `Direction.desc` |
| `filter` | [`List<EventKey>`](../../doc/models/event-key.md) | Query, Optional | You can pass multiple event keys after comma.<br>Use in query `filter=signup_success,payment_success`. |

## Response Type

[`Task<List<Models.EventResponse>>`](../../doc/models/event-response.md)

## Example Usage

```csharp
ListSubscriptionEventsInput listSubscriptionEventsInput = new ListSubscriptionEventsInput
{
    SubscriptionId = 222,
    Page = 2,
    PerPage = 50,
    Direction = Direction.Desc,
    Filter = new List<EventKey>
    {
        EventKey.CustomFieldValueChange,
        EventKey.PaymentSuccess,
    },
};

try
{
    List<EventResponse> result = await eventsController.ListSubscriptionEventsAsync(listSubscriptionEventsInput);
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
    "event": {
      "id": 344799837,
      "key": "statement_settled",
      "message": "Statement 79702531 settled successfully for Amelia Example's subscription to Basic Plan",
      "subscription_id": 14900541,
      "customer_id": 77223344,
      "created_at": "2016-11-01T12:41:29-04:00",
      "event_specific_data": null
    }
  },
  {
    "event": {
      "id": 344799815,
      "key": "renewal_success",
      "message": "Successful renewal for Amelia Example's subscription to Basic Plan",
      "subscription_id": 14900541,
      "customer_id": 77223344,
      "created_at": "2016-11-01T12:41:28-04:00",
      "event_specific_data": {
        "product_id": 3792003,
        "account_transaction_id": 7590246
      }
    }
  },
  {
    "event": {
      "id": 344799705,
      "key": "billing_date_change",
      "message": "Billing date changed on Amelia Example's subscription to Basic Plan from 11/26/2016 to 11/01/2016",
      "subscription_id": 14900541,
      "customer_id": 77223344,
      "created_at": "2016-11-01T12:41:25-04:00",
      "event_specific_data": null
    }
  }
]
```


# Read Events Count

Get a count of all the events for a given site by using this method.

```csharp
ReadEventsCountAsync(
    Models.ReadEventsCountInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `sinceId` | `long?` | Query, Optional | Returns events with an id greater than or equal to the one specified |
| `maxId` | `long?` | Query, Optional | Returns events with an id less than or equal to the one specified |
| `direction` | [`Direction?`](../../doc/models/direction.md) | Query, Optional | The sort direction of the returned events.<br><br>**Default**: `Direction.desc` |
| `filter` | [`List<EventKey>`](../../doc/models/event-key.md) | Query, Optional | You can pass multiple event keys after comma.<br>Use in query `filter=signup_success,payment_success`. |

## Response Type

[`Task<Models.CountResponse>`](../../doc/models/count-response.md)

## Example Usage

```csharp
ReadEventsCountInput readEventsCountInput = new ReadEventsCountInput
{
    Page = 2,
    PerPage = 50,
    Direction = Direction.Desc,
    Filter = new List<EventKey>
    {
        EventKey.CustomFieldValueChange,
        EventKey.PaymentSuccess,
    },
};

try
{
    CountResponse result = await eventsController.ReadEventsCountAsync(readEventsCountInput);
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
  "count": 144
}
```

