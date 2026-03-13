# Subscription Renewals

```csharp
SubscriptionRenewalsController subscriptionRenewalsController = client.SubscriptionRenewalsController;
```

## Class Name

`SubscriptionRenewalsController`

## Methods

* [Create Scheduled Renewal Configuration](../../doc/controllers/subscription-renewals.md#create-scheduled-renewal-configuration)
* [List Scheduled Renewal Configurations](../../doc/controllers/subscription-renewals.md#list-scheduled-renewal-configurations)
* [Read Scheduled Renewal Configuration](../../doc/controllers/subscription-renewals.md#read-scheduled-renewal-configuration)
* [Update Scheduled Renewal Configuration](../../doc/controllers/subscription-renewals.md#update-scheduled-renewal-configuration)
* [Schedule Scheduled Renewal Lock In](../../doc/controllers/subscription-renewals.md#schedule-scheduled-renewal-lock-in)
* [Lock in Scheduled Renewal Immediately](../../doc/controllers/subscription-renewals.md#lock-in-scheduled-renewal-immediately)
* [Unpublish Scheduled Renewal Configuration](../../doc/controllers/subscription-renewals.md#unpublish-scheduled-renewal-configuration)
* [Cancel Scheduled Renewal Configuration](../../doc/controllers/subscription-renewals.md#cancel-scheduled-renewal-configuration)
* [Create Scheduled Renewal Configuration Item](../../doc/controllers/subscription-renewals.md#create-scheduled-renewal-configuration-item)
* [Update Scheduled Renewal Configuration Item](../../doc/controllers/subscription-renewals.md#update-scheduled-renewal-configuration-item)
* [Delete Scheduled Renewal Configuration Item](../../doc/controllers/subscription-renewals.md#delete-scheduled-renewal-configuration-item)


# Create Scheduled Renewal Configuration

Creates a scheduled renewal configuration for a subscription. The scheduled renewal is based on the subscription’s current product and component setup.

```csharp
CreateScheduledRenewalConfigurationAsync(
    int subscriptionId,
    Models.ScheduledRenewalConfigurationRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `body` | [`ScheduledRenewalConfigurationRequest`](../../doc/models/scheduled-renewal-configuration-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationResponse>`](../../doc/models/scheduled-renewal-configuration-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
ScheduledRenewalConfigurationRequest body = new ScheduledRenewalConfigurationRequest
{
    RenewalConfiguration = new ScheduledRenewalConfigurationRequestBody
    {
        StartsAt = DateTime.ParseExact("2024-12-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        EndsAt = DateTime.ParseExact("2025-12-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        LockInAt = DateTime.ParseExact("2024-11-15T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        ContractId = 222,
    },
};

try
{
    ScheduledRenewalConfigurationResponse result = await subscriptionRenewalsController.CreateScheduledRenewalConfigurationAsync(
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration": {
    "id": 123,
    "site_id": 456,
    "subscription_id": 12345,
    "starts_at": "2024-12-01T00:00:00Z",
    "ends_at": "2025-12-01T00:00:00Z",
    "lock_in_at": "2024-11-15T00:00:00Z",
    "created_at": "2024-09-01T12:00:00Z",
    "status": "scheduled",
    "scheduled_renewal_configuration_items": [
      {
        "id": 789,
        "subscription_id": 12345,
        "subscription_renewal_configuration_id": 123,
        "item_id": 4,
        "item_type": "Product",
        "item_subclass": "Product",
        "price_point_id": 7,
        "price_point_type": "ProductPricePoint",
        "quantity": 1,
        "decimal_quantity": "1.0",
        "created_at": "2024-09-01T12:00:00Z"
      }
    ],
    "contract": {
      "id": 107,
      "maxio_id": "maxio-id",
      "number": null,
      "register": {
        "id": 12,
        "maxio_id": "maxio_id-id",
        "name": "Register",
        "currency_code": "USD"
      }
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# List Scheduled Renewal Configurations

Lists scheduled renewal configurations for the subscription and permits an optional status query filter.

```csharp
ListScheduledRenewalConfigurationsAsync(
    int subscriptionId,
    Models.Status? status = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `status` | [`Status?`](../../doc/models/status.md) | Query, Optional | (Optional) Status filter for scheduled renewal configurations. |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationsResponse>`](../../doc/models/scheduled-renewal-configurations-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
try
{
    ScheduledRenewalConfigurationsResponse result = await subscriptionRenewalsController.ListScheduledRenewalConfigurationsAsync(subscriptionId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configurations": [
    {
      "id": 123,
      "site_id": 456,
      "subscription_id": 12345,
      "starts_at": "2024-12-01T00:00:00Z",
      "ends_at": "2025-12-01T00:00:00Z",
      "lock_in_at": "2024-11-15T00:00:00Z",
      "created_at": "2024-09-01T12:00:00Z",
      "status": "scheduled",
      "scheduled_renewal_configuration_items": [
        {
          "id": 789,
          "subscription_id": 12345,
          "subscription_renewal_configuration_id": 123,
          "item_id": 4,
          "item_type": "Product",
          "item_subclass": "Product",
          "price_point_id": 7,
          "price_point_type": "ProductPricePoint",
          "quantity": 1,
          "decimal_quantity": "1.0",
          "created_at": "2024-09-01T12:00:00Z"
        }
      ],
      "contract": {
        "id": 107,
        "maxio_id": "maxio-id",
        "number": null,
        "register": {
          "id": 12,
          "maxio_id": "maxio-id",
          "name": "Register",
          "currency_code": "USD"
        }
      }
    }
  ]
}
```


# Read Scheduled Renewal Configuration

Retrieves the configuration settings for the scheduled renewal.

```csharp
ReadScheduledRenewalConfigurationAsync(
    int subscriptionId,
    int id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `id` | `int` | Template, Required | The renewal id. |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationResponse>`](../../doc/models/scheduled-renewal-configuration-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int id = 112;
try
{
    ScheduledRenewalConfigurationResponse result = await subscriptionRenewalsController.ReadScheduledRenewalConfigurationAsync(
        subscriptionId,
        id
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
  "scheduled_renewal_configuration": {
    "id": 123,
    "site_id": 456,
    "subscription_id": 12345,
    "starts_at": "2024-12-01T00:00:00Z",
    "ends_at": "2025-12-01T00:00:00Z",
    "lock_in_at": "2024-11-15T00:00:00Z",
    "created_at": "2024-09-01T12:00:00Z",
    "status": "scheduled",
    "scheduled_renewal_configuration_items": [
      {
        "id": 789,
        "subscription_id": 12345,
        "subscription_renewal_configuration_id": 123,
        "item_id": 4,
        "item_type": "Product",
        "item_subclass": "Product",
        "price_point_id": 7,
        "price_point_type": "ProductPricePoint",
        "quantity": 1,
        "decimal_quantity": "1.0",
        "created_at": "2024-09-01T12:00:00Z"
      }
    ],
    "contract": {
      "id": 107,
      "maxio_id": "maxio-id",
      "number": null,
      "register": {
        "id": 12,
        "maxio_id": "maxio-id",
        "name": "Register",
        "currency_code": "USD"
      }
    }
  }
}
```


# Update Scheduled Renewal Configuration

Updates an existing configuration.

```csharp
UpdateScheduledRenewalConfigurationAsync(
    int subscriptionId,
    int id,
    Models.ScheduledRenewalConfigurationRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `id` | `int` | Template, Required | The renewal id. |
| `body` | [`ScheduledRenewalConfigurationRequest`](../../doc/models/scheduled-renewal-configuration-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationResponse>`](../../doc/models/scheduled-renewal-configuration-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int id = 112;
ScheduledRenewalConfigurationRequest body = new ScheduledRenewalConfigurationRequest
{
    RenewalConfiguration = new ScheduledRenewalConfigurationRequestBody
    {
        StartsAt = DateTime.ParseExact("2025-12-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        EndsAt = DateTime.ParseExact("2026-12-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        LockInAt = DateTime.ParseExact("2025-11-15T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
    },
};

try
{
    ScheduledRenewalConfigurationResponse result = await subscriptionRenewalsController.UpdateScheduledRenewalConfigurationAsync(
        subscriptionId,
        id,
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration": {
    "id": 123,
    "site_id": 456,
    "subscription_id": 12345,
    "starts_at": "2025-12-01T00:00:00Z",
    "ends_at": "2026-12-01T00:00:00Z",
    "lock_in_at": "2025-11-15T00:00:00Z",
    "created_at": "2025-09-01T12:00:00Z",
    "status": "scheduled",
    "scheduled_renewal_configuration_items": [
      {
        "id": 789,
        "subscription_id": 12345,
        "subscription_renewal_configuration_id": 123,
        "item_id": 4,
        "item_type": "Product",
        "item_subclass": "Product",
        "price_point_id": 7,
        "price_point_type": "ProductPricePoint",
        "quantity": 1,
        "decimal_quantity": "1.0",
        "created_at": "2025-09-01T12:00:00Z"
      }
    ],
    "contract": {
      "id": 107,
      "maxio_id": "maxio-id",
      "number": null,
      "register": {
        "id": 12,
        "maxio_id": "maxio-id",
        "name": "Register",
        "currency_code": "USD"
      }
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Schedule Scheduled Renewal Lock In

Schedules a future lock-in date for the renewal.

```csharp
ScheduleScheduledRenewalLockInAsync(
    int subscriptionId,
    int id,
    Models.ScheduledRenewalLockInRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `id` | `int` | Template, Required | The renewal id. |
| `body` | [`ScheduledRenewalLockInRequest`](../../doc/models/scheduled-renewal-lock-in-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationResponse>`](../../doc/models/scheduled-renewal-configuration-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int id = 112;
ScheduledRenewalLockInRequest body = new ScheduledRenewalLockInRequest
{
    LockInAt = DateTime.Parse("2025-11-15"),
};

try
{
    ScheduledRenewalConfigurationResponse result = await subscriptionRenewalsController.ScheduleScheduledRenewalLockInAsync(
        subscriptionId,
        id,
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration": {
    "id": 123,
    "site_id": 456,
    "subscription_id": 12345,
    "starts_at": "2025-12-01T00:00:00Z",
    "ends_at": "2026-12-01T00:00:00Z",
    "lock_in_at": "2025-11-15T00:00:00Z",
    "created_at": "2025-09-01T12:00:00Z",
    "status": "scheduled",
    "scheduled_renewal_configuration_items": [
      {
        "id": 789,
        "subscription_id": 12345,
        "subscription_renewal_configuration_id": 123,
        "item_id": 4,
        "item_type": "Product",
        "item_subclass": "Product",
        "price_point_id": 7,
        "price_point_type": "ProductPricePoint",
        "quantity": 1,
        "decimal_quantity": "1.0",
        "created_at": "2025-09-01T12:00:00Z"
      }
    ],
    "contract": {
      "id": 107,
      "maxio_id": "maxio-id",
      "number": null,
      "register": {
        "id": 12,
        "maxio_id": "maxio-id",
        "name": "Register",
        "currency_code": "USD"
      }
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Lock in Scheduled Renewal Immediately

Locks in the renewal immediately.

```csharp
LockInScheduledRenewalImmediatelyAsync(
    int subscriptionId,
    int id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `id` | `int` | Template, Required | The renewal id. |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationResponse>`](../../doc/models/scheduled-renewal-configuration-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int id = 112;
try
{
    ScheduledRenewalConfigurationResponse result = await subscriptionRenewalsController.LockInScheduledRenewalImmediatelyAsync(
        subscriptionId,
        id
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration": {
    "id": 987,
    "site_id": 321,
    "subscription_id": 12345,
    "starts_at": "2025-12-01T00:00:00Z",
    "ends_at": "2026-12-01T00:00:00Z",
    "lock_in_at": "2025-11-15T00:00:00Z",
    "created_at": "2025-09-01T12:00:00Z",
    "status": "scheduled",
    "scheduled_renewal_configuration_items": [
      {
        "id": 555,
        "subscription_id": 12345,
        "subscription_renewal_configuration_id": 987,
        "item_id": 42,
        "item_type": "Product",
        "price_point_id": 73,
        "price_point_type": "ProductPricePoint",
        "quantity": 1,
        "decimal_quantity": "1.0",
        "created_at": "2025-09-01T12:00:00Z"
      }
    ],
    "contract": {
      "id": 222,
      "maxio_id": "maxio-id",
      "number": null,
      "register": {
        "id": 12,
        "maxio_id": "maxio-id",
        "name": "Register",
        "currency_code": "USD"
      }
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Unpublish Scheduled Renewal Configuration

Returns a scheduled renewal configuration to an editable state.

```csharp
UnpublishScheduledRenewalConfigurationAsync(
    int subscriptionId,
    int id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `id` | `int` | Template, Required | The renewal id. |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationResponse>`](../../doc/models/scheduled-renewal-configuration-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int id = 112;
try
{
    ScheduledRenewalConfigurationResponse result = await subscriptionRenewalsController.UnpublishScheduledRenewalConfigurationAsync(
        subscriptionId,
        id
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration": {
    "id": 987,
    "site_id": 321,
    "subscription_id": 12345,
    "starts_at": "2025-12-01T00:00:00Z",
    "ends_at": "2026-12-01T00:00:00Z",
    "lock_in_at": "2025-11-15T00:00:00Z",
    "created_at": "2025-09-01T12:00:00Z",
    "status": "draft",
    "scheduled_renewal_configuration_items": [
      {
        "id": 555,
        "subscription_id": 12345,
        "subscription_renewal_configuration_id": 987,
        "item_id": 42,
        "item_type": "Product",
        "price_point_id": 73,
        "price_point_type": "ProductPricePoint",
        "quantity": 1,
        "decimal_quantity": "1.0",
        "created_at": "2025-09-01T12:00:00Z"
      }
    ],
    "contract": {
      "id": 222
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Cancel Scheduled Renewal Configuration

Cancels a scheduled renewal configuration.

```csharp
CancelScheduledRenewalConfigurationAsync(
    int subscriptionId,
    int id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `id` | `int` | Template, Required | The renewal id. |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationResponse>`](../../doc/models/scheduled-renewal-configuration-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int id = 112;
try
{
    ScheduledRenewalConfigurationResponse result = await subscriptionRenewalsController.CancelScheduledRenewalConfigurationAsync(
        subscriptionId,
        id
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration": {
    "id": 987,
    "site_id": 321,
    "subscription_id": 12345,
    "starts_at": "2025-12-01T00:00:00Z",
    "ends_at": "2026-12-01T00:00:00Z",
    "lock_in_at": "2025-11-15T00:00:00Z",
    "created_at": "2025-09-01T12:00:00Z",
    "status": "canceled",
    "scheduled_renewal_configuration_items": [
      {
        "id": 555,
        "subscription_id": 12345,
        "subscription_renewal_configuration_id": 987,
        "item_id": 42,
        "item_type": "Product",
        "price_point_id": 73,
        "price_point_type": "ProductPricePoint",
        "quantity": 1,
        "decimal_quantity": "1.0",
        "created_at": "2025-09-01T12:00:00Z"
      }
    ],
    "contract": {
      "id": 222
    }
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Create Scheduled Renewal Configuration Item

Adds product and component line items to the scheduled renewal.

```csharp
CreateScheduledRenewalConfigurationItemAsync(
    int subscriptionId,
    int scheduledRenewalsConfigurationId,
    Models.ScheduledRenewalConfigurationItemRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `scheduledRenewalsConfigurationId` | `int` | Template, Required | The scheduled renewal configuration id. |
| `body` | [`ScheduledRenewalConfigurationItemRequest`](../../doc/models/scheduled-renewal-configuration-item-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationItemResponse>`](../../doc/models/scheduled-renewal-configuration-item-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int scheduledRenewalsConfigurationId = 250;
ScheduledRenewalConfigurationItemRequest body = new ScheduledRenewalConfigurationItemRequest
{
    RenewalConfigurationItem = ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(
        new ScheduledRenewalItemRequestBodyComponent
        {
            ItemType = "Component",
            ItemId = 57,
            Quantity = 1,
            CustomPrice = new ScheduledRenewalComponentCustomPrice
            {
                PricingScheme = PricingScheme.Stairstep,
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(1),
                        UnitPrice = PriceUnitPrice.FromPrecision(5),
                        EndingQuantity = null,
                    },
                },
            },
        }
    ),
};

try
{
    ScheduledRenewalConfigurationItemResponse result = await subscriptionRenewalsController.CreateScheduledRenewalConfigurationItemAsync(
        subscriptionId,
        scheduledRenewalsConfigurationId,
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration_item": {
    "id": 555,
    "subscription_id": 12345,
    "subscription_renewal_configuration_id": 987,
    "item_id": 42,
    "item_type": "Product",
    "item_subclass": "SubscriptionProduct",
    "price_point_id": 73,
    "price_point_type": "ProductPricePoint",
    "quantity": 1,
    "decimal_quantity": "1.0",
    "created_at": "2025-09-01T12:00:00Z"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Update Scheduled Renewal Configuration Item

Updates an existing configuration item’s pricing and quantity.

```csharp
UpdateScheduledRenewalConfigurationItemAsync(
    int subscriptionId,
    int scheduledRenewalsConfigurationId,
    int id,
    Models.ScheduledRenewalUpdateRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `scheduledRenewalsConfigurationId` | `int` | Template, Required | The scheduled renewal configuration id. |
| `id` | `int` | Template, Required | The scheduled renewal configuration item id. |
| `body` | [`ScheduledRenewalUpdateRequest`](../../doc/models/scheduled-renewal-update-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ScheduledRenewalConfigurationItemResponse>`](../../doc/models/scheduled-renewal-configuration-item-response.md)

## Example Usage

```csharp
int subscriptionId = 222;
int scheduledRenewalsConfigurationId = 250;
int id = 112;
ScheduledRenewalUpdateRequest body = new ScheduledRenewalUpdateRequest
{
    RenewalConfigurationItem = ScheduledRenewalUpdateRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(
        new ScheduledRenewalItemRequestBodyComponent
        {
            ItemType = "Component",
            ItemId = 57,
            Quantity = 2,
            CustomPrice = new ScheduledRenewalComponentCustomPrice
            {
                PricingScheme = PricingScheme.Stairstep,
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(1),
                        UnitPrice = PriceUnitPrice.FromPrecision(5),
                        EndingQuantity = null,
                    },
                },
            },
        }
    ),
};

try
{
    ScheduledRenewalConfigurationItemResponse result = await subscriptionRenewalsController.UpdateScheduledRenewalConfigurationItemAsync(
        subscriptionId,
        scheduledRenewalsConfigurationId,
        id,
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

## Example Response *(as JSON)*

```json
{
  "scheduled_renewal_configuration_item": {
    "id": 555,
    "subscription_id": 12345,
    "subscription_renewal_configuration_id": 987,
    "item_id": 42,
    "item_type": "Component",
    "item_subclass": "SubscriptionComponent",
    "price_point_id": 73,
    "price_point_type": "ComponentPricePoint",
    "quantity": 3,
    "decimal_quantity": "3.0",
    "created_at": "2025-09-01T12:00:00Z"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Delete Scheduled Renewal Configuration Item

Removes an item from the pending renewal configuration.

```csharp
DeleteScheduledRenewalConfigurationItemAsync(
    int subscriptionId,
    int scheduledRenewalsConfigurationId,
    int id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `subscriptionId` | `int` | Template, Required | The Chargify id of the subscription. |
| `scheduledRenewalsConfigurationId` | `int` | Template, Required | The scheduled renewal configuration id. |
| `id` | `int` | Template, Required | The scheduled renewal configuration item id. |

## Response Type

`Task`

## Example Usage

```csharp
int subscriptionId = 222;
int scheduledRenewalsConfigurationId = 250;
int id = 112;
try
{
    await subscriptionRenewalsController.DeleteScheduledRenewalConfigurationItemAsync(
        subscriptionId,
        scheduledRenewalsConfigurationId,
        id
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

