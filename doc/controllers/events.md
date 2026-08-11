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

Lists events for a site.

## Events Intro

Advanced Billing Events include various activity that happens around a Site. This information is **especially** useful to track down issues that arise when subscriptions are not created due to errors.

Within the Advanced Billing UI, "Events" are referred to as "Site Activity".  See the [Site Activity](https://maxio.zendesk.com/hc/en-us/articles/24250671733517-Site-Activity) article in the product documentation for details on how to record view Events / Site Activty in the Advanced Billing UI.

If you’re using the [enhanced Catalog experience](page:help/announcements/2026-announcements#new-catalog-experience-and-terminology), you’ll see updated naming in webhook events and messages.

Event name changes:

- subscription_product_change → subscription_plan_change
- component_allocation_change → allocation_change
- component_billing_date_change → product_billing_date_change

Message updates:

- “Plan changed on Subscription from previous plan to new plan”
- “Successful payment for allocation changes to Product on Subscription”
- “Failed payment for allocation changes to Product on Subscription”

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
        "message": "Product changed on Mark Alan's subscription from 'Basic' to 'Pro'",
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
         "message": "State changed on Mark Alan's subscription to Pro from trialing to active",
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

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListEventsInput`](../../doc/models/list-events-input.md) | Required | Input structure for the method ListEvents |

## Response Type

**200**: OK

[`Task<List<Models.EventResponse>>`](../../doc/models/event-response.md)

## Example Usage

```csharp
ListEventsInput listEventsInput = new ListEventsInput
{
    Page = 1,
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

Lists events for a subscription.

## Event Key

The event type is identified by the key property. You can check supported keys [here](../../doc/models/event-key.md).

If you’re using the [enhanced Catalog experience](page:help/announcements/2026-announcements#new-catalog-experience-and-terminology), you’ll see updated naming in webhook events and messages.

Event name changes:

- subscription_product_change → subscription_plan_change
- component_allocation_change → allocation_change
- component_billing_date_change → product_billing_date_change

Message updates:

- “Successful payment for allocation changes to Product on Subscription”
- “Failed payment for allocation changes to Product on Subscription”
- “Plan changed on Subscription from previous plan to new plan”

## Event Specific Data

Different event types may include additional data in `event_specific_data` property.
While some events share the same schema for `event_specific_data`, others may not include it at all.
For precise mappings from key to event_specific_data, refer to [Event](../../doc/models/event.md).

```csharp
ListSubscriptionEventsAsync(
    Models.ListSubscriptionEventsInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListSubscriptionEventsInput`](../../doc/models/list-subscription-events-input.md) | Required | Input structure for the method ListSubscriptionEvents |

## Response Type

**200**: OK

[`Task<List<Models.EventResponse>>`](../../doc/models/event-response.md)

## Example Usage

```csharp
ListSubscriptionEventsInput listSubscriptionEventsInput = new ListSubscriptionEventsInput
{
    SubscriptionId = 222,
    Page = 1,
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

Returns the total count of events for a given site.

If you’re using the [enhanced Catalog experience](page:help/announcements/2026-announcements#new-catalog-experience-and-terminology), you’ll see updated naming in webhook events and messages.

Event name changes:

- subscription_product_change → subscription_plan_change
- component_allocation_change → allocation_change
- component_billing_date_change → product_billing_date_change

Message updates:

- “Successful payment for allocation changes to Product on Subscription”
- “Failed payment for allocation changes to Product on Subscription”
- “Plan changed on Subscription from previous plan to new plan”

```csharp
ReadEventsCountAsync(
    Models.ReadEventsCountInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ReadEventsCountInput`](../../doc/models/read-events-count-input.md) | Required | Input structure for the method ReadEventsCount |

## Response Type

**200**: OK

[`Task<Models.CountResponse>`](../../doc/models/count-response.md)

## Example Usage

```csharp
ReadEventsCountInput readEventsCountInput = new ReadEventsCountInput
{
    Page = 1,
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
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "count": 144
}
```

