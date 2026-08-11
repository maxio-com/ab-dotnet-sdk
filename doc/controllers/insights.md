# Insights

```csharp
InsightsController insightsController = client.InsightsController;
```

## Class Name

`InsightsController`

## Methods

* [Read Site Stats](../../doc/controllers/insights.md#read-site-stats)
* [Read Mrr](../../doc/controllers/insights.md#read-mrr)
* [List Mrr Movements](../../doc/controllers/insights.md#list-mrr-movements)
* [List Mrr per Subscription](../../doc/controllers/insights.md#list-mrr-per-subscription)


# Read Site Stats

Returns basic site-level stats. This API call only answers with JSON responses. An XML version is not provided.

## Stats Documentation

There currently is not a complimentary matching set of documentation that compliments this endpoint. However, each Site's dashboard will reflect the summary of information provided in the Stats response.

```
https://subdomain.chargify.com/dashboard
```

```csharp
ReadSiteStatsAsync()
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Response Type

**200**: OK

[`Task<Models.SiteSummary>`](../../doc/models/site-summary.md)

## Example Usage

```csharp
try
{
    SiteSummary result = await insightsController.ReadSiteStatsAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "seller_name": "Acme, Inc.",
  "site_name": "Production",
  "site_id": 12345,
  "site_currency": "USD",
  "stats": {
    "total_subscriptions": 120,
    "subscriptions_today": 4,
    "total_revenue": "$45,978.81",
    "revenue_today": "$1,405.12",
    "revenue_this_month": "$10,000.00",
    "revenue_this_year": "$27,935.24"
  }
}
```


# Read Mrr

**This endpoint is deprecated.**

Returns your site's current MRR, including plan and usage breakouts.

```csharp
ReadMrrAsync(
    DateTimeOffset? atTime = null,
    int? subscriptionId = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `atTime` | `DateTimeOffset?` | Query, Optional | submit a timestamp in ISO8601 format to request MRR for a historic time. |
| `subscriptionId` | `int?` | Query, Optional | submit the id of a subscription in order to limit results. |

## Response Type

**200**: OK

[`Task<Models.MRRResponse>`](../../doc/models/mrr-response.md)

## Example Usage

```csharp
try
{
    MRRResponse result = await insightsController.ReadMrrAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "mrr": {
    "amount_in_cents": 9915593,
    "amount_formatted": "$99,155.93",
    "currency": "USD",
    "currency_symbol": "$",
    "at_time": "2021-02-03T14:23:17-05:00",
    "breakouts": {
      "plan_amount_in_cents": 9913593,
      "plan_amount_formatted": "$99,135.93",
      "usage_amount_in_cents": 2000,
      "usage_amount_formatted": "$20.00"
    }
  }
}
```


# List Mrr Movements

**This endpoint is deprecated.**

Lists your site's MRR movements.

## Understanding MRR movements

This endpoint will aid in accessing your site's [MRR Report](https://maxio.zendesk.com/hc/en-us/articles/24285894587021-MRR-Analytics) data.

Whenever a subscription event occurs that causes your site's MRR to change (such as a signup or upgrade), we record an MRR movement. These records are accessible via the MRR Movements endpoint.

Each MRR Movement belongs to a subscription and contains a timestamp, category, and an amount. `line_items` represent the subscription's product configuration at the time of the movement.

### Plan & Usage Breakouts

In the MRR Report UI, we support a setting to [include or exclude](https://maxio.zendesk.com/hc/en-us/articles/24285894587021-MRR-Analytics#displaying-component-based-metered-usage-in-mrr) usage revenue. In the MRR APIs, responses include `plan` and `usage` breakouts.

Plan includes revenue from:

* Products
* Quantity-Based Components
* On/Off Components

Usage includes revenue from:

* Metered Components
* Prepaid Usage Components

```csharp
ListMrrMovementsAsync(
    Models.ListMrrMovementsInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListMrrMovementsInput`](../../doc/models/list-mrr-movements-input.md) | Required | Input structure for the method ListMrrMovements |

## Response Type

**200**: OK

[`Task<Models.ListMRRResponse>`](../../doc/models/list-mrr-response.md)

## Example Usage

```csharp
ListMrrMovementsInput listMrrMovementsInput = new ListMrrMovementsInput
{
    Page = 1,
    PerPage = 20,
};

try
{
    ListMRRResponse result = await insightsController.ListMrrMovementsAsync(listMrrMovementsInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "mrr": {
    "page": 0,
    "per_page": 10,
    "total_pages": 80,
    "total_entries": 791,
    "currency": "USD",
    "currency_symbol": "$",
    "movements": [
      {
        "timestamp": "2014-12-03T13:59:46-05:00",
        "amount_in_cents": 2173,
        "amount_formatted": "$21.73",
        "description": "Awesome Company signed up for Super Product ($21.73/mo)",
        "category": "new_business",
        "breakouts": {
          "plan_amount_in_cents": 2173,
          "plan_amount_formatted": "$21.73",
          "usage_amount_in_cents": 0,
          "usage_amount_formatted": "$0.00"
        },
        "line_items": [
          {
            "product_id": 306386,
            "component_id": 0,
            "price_point_id": 3856987,
            "name": "Cached Queries",
            "mrr": 2173,
            "mrr_movements": [
              {
                "amount": 2173,
                "category": "new_business",
                "subscriber_delta": 0,
                "lead_delta": 0
              }
            ],
            "quantity": 1,
            "prev_quantity": 0,
            "recurring": true
          }
        ],
        "subscription_id": 12355,
        "subscriber_name": "Amy Smith"
      }
    ]
  }
}
```


# List Mrr per Subscription

**This endpoint is deprecated.**

Lists your site's current MRR, including plan and usage breakouts split per subscription.

```csharp
ListMrrPerSubscriptionAsync(
    Models.ListMrrPerSubscriptionInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListMrrPerSubscriptionInput`](../../doc/models/list-mrr-per-subscription-input.md) | Required | Input structure for the method ListMrrPerSubscription |

## Response Type

**200**: OK

[`Task<Models.SubscriptionMRRResponse>`](../../doc/models/subscription-mrr-response.md)

## Example Usage

```csharp
ListMrrPerSubscriptionInput listMrrPerSubscriptionInput = new ListMrrPerSubscriptionInput
{
    Filter = new ListMrrFilter
    {
        SubscriptionIds = new List<int>
        {
            1,
            2,
            3,
        },
    },
    AtTime = "at_time=2022-01-10T10:00:00-05:00",
    Page = 1,
    PerPage = 50,
    Direction = Direction.Desc,
};

try
{
    SubscriptionMRRResponse result = await insightsController.ListMrrPerSubscriptionAsync(listMrrPerSubscriptionInput);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is SubscriptionsMrrErrorResponseException)
    {
       // TODO: Handle SubscriptionsMrrErrorResponseException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`SubscriptionsMrrErrorResponseException`](../../doc/models/subscriptions-mrr-error-response-exception.md) |

