# Components

```csharp
ComponentsController componentsController = client.ComponentsController;
```

## Class Name

`ComponentsController`

## Methods

* [Create Metered Component](../../doc/controllers/components.md#create-metered-component)
* [Create Quantity Based Component](../../doc/controllers/components.md#create-quantity-based-component)
* [Create on Off Component](../../doc/controllers/components.md#create-on-off-component)
* [Create Prepaid Usage Component](../../doc/controllers/components.md#create-prepaid-usage-component)
* [Create Event Based Component](../../doc/controllers/components.md#create-event-based-component)
* [Find Component](../../doc/controllers/components.md#find-component)
* [Read Component](../../doc/controllers/components.md#read-component)
* [Update Product Family Component](../../doc/controllers/components.md#update-product-family-component)
* [Archive Component](../../doc/controllers/components.md#archive-component)
* [List Components](../../doc/controllers/components.md#list-components)
* [Update Component](../../doc/controllers/components.md#update-component)
* [List Components for Product Family](../../doc/controllers/components.md#list-components-for-product-family)


# Create Metered Component

This request will create a component definition of kind **metered_component** under the specified product family. Metered component can then be added and “allocated” for a subscription.

Metered components are used to bill for any type of unit that resets to 0 at the end of the billing period (think daily Google Adwords clicks or monthly cell phone minutes). This is most commonly associated with usage-based billing and many other pricing schemes.

Note that this is different from recurring quantity-based components, which DO NOT reset to zero at the start of every billing period. If you want to bill for a quantity of something that does not change unless you change it, then you want quantity components, instead.

For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).

```csharp
CreateMeteredComponentAsync(
    string productFamilyId,
    Models.CreateMeteredComponent body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `string` | Template, Required | Either the product family's id or its handle prefixed with `handle:` |
| `body` | [`CreateMeteredComponent`](../../doc/models/create-metered-component.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
string productFamilyId = "product_family_id4";
CreateMeteredComponent body = new CreateMeteredComponent
{
    MeteredComponent = new MeteredComponent
    {
        Name = "Text messages",
        UnitName = "text message",
        PricingScheme = PricingScheme.PerUnit,
        Taxable = false,
        Prices = new List<Price>
        {
            new Price
            {
                StartingQuantity = PriceStartingQuantity.FromNumber(1),
                UnitPrice = PriceUnitPrice.FromPrecision(1),
            },
        },
    },
};

try
{
    ComponentResponse result = await componentsController.CreateMeteredComponentAsync(
        productFamilyId,
        body
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
  "component": {
    "id": 292609,
    "name": "Text messages",
    "handle": "text-messages",
    "pricing_scheme": "per_unit",
    "unit_name": "unit",
    "unit_price": "10.0",
    "product_family_id": 528484,
    "product_family_name": "Cloud Compute Servers",
    "price_per_unit_in_cents": null,
    "kind": "metered_component",
    "archived": false,
    "taxable": false,
    "description": null,
    "default_price_point_id": 2944263,
    "prices": [
      {
        "id": 55423,
        "component_id": 30002,
        "starting_quantity": 1,
        "ending_quantity": null,
        "unit_price": "10.0",
        "price_point_id": 2944263,
        "formatted_unit_price": "$10.00",
        "segment_id": null
      }
    ],
    "price_point_count": 1,
    "price_points_url": "https://demo-3238403362.chargify.com/components/30002/price_points",
    "default_price_point_name": "Original",
    "tax_code": null,
    "recurring": false,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2024-01-23T06:08:05-05:00",
    "updated_at": "2024-01-23T06:08:05-05:00",
    "archived_at": null,
    "hide_date_range_on_invoice": false,
    "allow_fractional_quantities": false,
    "use_site_exchange_rate": true,
    "item_category": null,
    "accounting_code": null
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Create Quantity Based Component

This request will create a component definition of kind **quantity_based_component** under the specified product family. Quantity Based component can then be added and “allocated” for a subscription.

When defining Quantity Based component, You can choose one of 2 types:

#### Recurring

Recurring quantity-based components are used to bill for the number of some unit (think monthly software user licenses or the number of pairs of socks in a box-a-month club). This is most commonly associated with billing for user licenses, number of users, number of employees, etc.

#### One-time

One-time quantity-based components are used to create ad hoc usage charges that do not recur. For example, at the time of signup, you might want to charge your customer a one-time fee for onboarding or other services.

The allocated quantity for one-time quantity-based components immediately gets reset back to zero after the allocation is made.

For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).

```csharp
CreateQuantityBasedComponentAsync(
    string productFamilyId,
    Models.CreateQuantityBasedComponent body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `string` | Template, Required | Either the product family's id or its handle prefixed with `handle:` |
| `body` | [`CreateQuantityBasedComponent`](../../doc/models/create-quantity-based-component.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
string productFamilyId = "product_family_id4";
CreateQuantityBasedComponent body = new CreateQuantityBasedComponent
{
    QuantityBasedComponent = new QuantityBasedComponent
    {
        Name = "Quantity Based Component",
        UnitName = "Component",
        PricingScheme = PricingScheme.PerUnit,
        Description = "Example of JSON per-unit component example",
        Taxable = true,
        UnitPrice = QuantityBasedComponentUnitPrice.FromString("10"),
        DisplayOnHostedPage = true,
        AllowFractionalQuantities = true,
        PublicSignupPageIds = new List<int>
        {
            323397,
        },
    },
};

try
{
    ComponentResponse result = await componentsController.CreateQuantityBasedComponentAsync(
        productFamilyId,
        body
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
  "component": {
    "id": 292609,
    "name": "Text messages",
    "handle": "text-messages",
    "pricing_scheme": "per_unit",
    "unit_name": "unit",
    "unit_price": "10.0",
    "product_family_id": 528484,
    "product_family_name": "Cloud Compute Servers",
    "price_per_unit_in_cents": null,
    "kind": "quantity_based_component",
    "archived": false,
    "taxable": false,
    "description": null,
    "default_price_point_id": 2944263,
    "prices": [
      {
        "id": 55423,
        "component_id": 30002,
        "starting_quantity": 1,
        "ending_quantity": null,
        "unit_price": "10.0",
        "price_point_id": 2944263,
        "formatted_unit_price": "$10.00",
        "segment_id": null
      }
    ],
    "price_point_count": 1,
    "price_points_url": "https://demo-3238403362.chargify.com/components/30002/price_points",
    "default_price_point_name": "Original",
    "tax_code": null,
    "recurring": false,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2024-01-23T06:08:05-05:00",
    "updated_at": "2024-01-23T06:08:05-05:00",
    "archived_at": null,
    "hide_date_range_on_invoice": false,
    "allow_fractional_quantities": false,
    "use_site_exchange_rate": true,
    "item_category": null,
    "accounting_code": null
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Create on Off Component

This request will create a component definition of kind **on_off_component** under the specified product family. On/Off component can then be added and “allocated” for a subscription.

On/off components are used for any flat fee, recurring add on (think $99/month for tech support or a flat add on shipping fee).

For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).

```csharp
CreateOnOffComponentAsync(
    string productFamilyId,
    Models.CreateOnOffComponent body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `string` | Template, Required | Either the product family's id or its handle prefixed with `handle:` |
| `body` | [`CreateOnOffComponent`](../../doc/models/create-on-off-component.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
string productFamilyId = "product_family_id4";
CreateOnOffComponent body = new CreateOnOffComponent
{
    OnOffComponent = new OnOffComponent
    {
        Name = "Annual Support Services",
        UnitPrice = OnOffComponentUnitPrice.FromString("100.00"),
        Description = "Prepay for support services",
        Taxable = true,
        DisplayOnHostedPage = true,
        PublicSignupPageIds = new List<int>
        {
            320495,
        },
    },
};

try
{
    ComponentResponse result = await componentsController.CreateOnOffComponentAsync(
        productFamilyId,
        body
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
  "component": {
    "id": 292609,
    "name": "Test On-Off Component 46124",
    "handle": "test-on-off-component-4612422802",
    "pricing_scheme": null,
    "unit_name": "on/off",
    "unit_price": "10.0",
    "product_family_id": 528484,
    "product_family_name": "Cloud Compute Servers",
    "price_per_unit_in_cents": null,
    "kind": "on_off_component",
    "archived": false,
    "taxable": false,
    "description": null,
    "default_price_point_id": 2944263,
    "price_point_count": 1,
    "price_points_url": "https://demo-3238403362.chargify.com/components/30002/price_points",
    "default_price_point_name": "Original",
    "tax_code": null,
    "recurring": true,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2024-01-23T06:08:05-05:00",
    "updated_at": "2024-01-23T06:08:05-05:00",
    "archived_at": null,
    "hide_date_range_on_invoice": false,
    "allow_fractional_quantities": false,
    "use_site_exchange_rate": true,
    "item_category": null,
    "accounting_code": null
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Create Prepaid Usage Component

This request will create a component definition of kind **prepaid_usage_component** under the specified product family. Prepaid component can then be added and “allocated” for a subscription.

Prepaid components allow customers to pre-purchase units that can be used up over time on their subscription. In a sense, they are the mirror image of metered components; while metered components charge at the end of the period for the amount of units used, prepaid components are charged for at the time of purchase, and we subsequently keep track of the usage against the amount purchased.

For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).

```csharp
CreatePrepaidUsageComponentAsync(
    string productFamilyId,
    Models.CreatePrepaidComponent body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `string` | Template, Required | Either the product family's id or its handle prefixed with `handle:` |
| `body` | [`CreatePrepaidComponent`](../../doc/models/create-prepaid-component.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
string productFamilyId = "product_family_id4";
CreatePrepaidComponent body = new CreatePrepaidComponent
{
    PrepaidUsageComponent = new PrepaidUsageComponent
    {
        Name = "Minutes",
        UnitName = "minutes",
        PricingScheme = PricingScheme.PerUnit,
        OveragePricing = new OveragePricing
        {
            PricingScheme = PricingScheme.Stairstep,
            Prices = new List<Price>
            {
                new Price
                {
                    StartingQuantity = PriceStartingQuantity.FromNumber(1),
                    UnitPrice = PriceUnitPrice.FromPrecision(3),
                    EndingQuantity = PriceEndingQuantity.FromNumber(100),
                },
                new Price
                {
                    StartingQuantity = PriceStartingQuantity.FromNumber(101),
                    UnitPrice = PriceUnitPrice.FromPrecision(5),
                },
            },
        },
        UnitPrice = PrepaidUsageComponentUnitPrice.FromPrecision(2),
        RolloverPrepaidRemainder = true,
        RenewPrepaidAllocation = true,
        ExpirationInterval = 15,
        ExpirationIntervalUnit = ExpirationIntervalUnit.Day,
    },
};

try
{
    ComponentResponse result = await componentsController.CreatePrepaidUsageComponentAsync(
        productFamilyId,
        body
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
  "component": {
    "id": 292609,
    "name": "Test Prepaid Component 98505",
    "handle": "test-prepaid-component-9850584842",
    "pricing_scheme": "per_unit",
    "unit_name": "unit",
    "unit_price": "10.0",
    "product_family_id": 528484,
    "product_family_name": "Test Product Family 27791",
    "price_per_unit_in_cents": null,
    "kind": "prepaid_usage_component",
    "archived": false,
    "taxable": false,
    "description": "Description for: Test Prepaid Component 98505",
    "default_price_point_id": 2944263,
    "overage_prices": [
      {
        "id": 55964,
        "component_id": 30427,
        "starting_quantity": 1,
        "ending_quantity": null,
        "unit_price": "1.0",
        "price_point_id": 2944756,
        "formatted_unit_price": "$1.00",
        "segment_id": null
      }
    ],
    "prices": [
      {
        "id": 55963,
        "component_id": 30427,
        "starting_quantity": 1,
        "ending_quantity": null,
        "unit_price": "1.0",
        "price_point_id": 2944756,
        "formatted_unit_price": "$1.00",
        "segment_id": null
      }
    ],
    "price_point_count": 1,
    "price_points_url": "https://demo-3238403362.chargify.com/components/30002/price_points",
    "default_price_point_name": "Original",
    "tax_code": null,
    "recurring": true,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2024-01-23T06:08:05-05:00",
    "updated_at": "2024-01-23T06:08:05-05:00",
    "archived_at": null,
    "hide_date_range_on_invoice": false,
    "allow_fractional_quantities": false,
    "use_site_exchange_rate": true,
    "item_category": null,
    "accounting_code": null
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Create Event Based Component

This request will create a component definition of kind **event_based_component** under the specified product family. Event-based component can then be added and “allocated” for a subscription.

Event-based components are similar to other component types, in that you define the component parameters (such as name and taxability) and the pricing. A key difference for the event-based component is that it must be attached to a metric. This is because the metric provides the component with the actual quantity used in computing what and how much will be billed each period for each subscription.

So, instead of reporting usage directly for each component (as you would with metered components), the usage is derived from analysis of your events.

For more information on components, please see our documentation [here](https://maxio.zendesk.com/hc/en-us/articles/24261141522189-Components-Overview).

```csharp
CreateEventBasedComponentAsync(
    string productFamilyId,
    Models.CreateEBBComponent body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `string` | Template, Required | Either the product family's id or its handle prefixed with `handle:` |
| `body` | [`CreateEBBComponent`](../../doc/models/create-ebb-component.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
string productFamilyId = "product_family_id4";
CreateEBBComponent body = new CreateEBBComponent
{
    EventBasedComponent = new EBBComponent
    {
        Name = "Component Name",
        UnitName = "string",
        PricingScheme = PricingScheme.PerUnit,
        EventBasedBillingMetricId = 123,
        Description = "string",
        Handle = "some_handle",
        Taxable = true,
        Prices = new List<Price>
        {
            new Price
            {
                StartingQuantity = PriceStartingQuantity.FromNumber(1),
                UnitPrice = PriceUnitPrice.FromString("0.49"),
            },
        },
    },
};

try
{
    ComponentResponse result = await componentsController.CreateEventBasedComponentAsync(
        productFamilyId,
        body
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
  "component": {
    "id": 1489581,
    "name": "stripeCharges",
    "handle": null,
    "pricing_scheme": null,
    "unit_name": "charge",
    "unit_price": null,
    "product_family_id": 1517093,
    "product_family_name": "Billing Plans",
    "price_per_unit_in_cents": null,
    "kind": "event_based_component",
    "archived": false,
    "taxable": false,
    "description": null,
    "default_price_point_id": null,
    "price_point_count": 0,
    "price_points_url": "https://staging.chargify.com/components/1489581/price_points",
    "default_price_point_name": "Original",
    "tax_code": null,
    "recurring": false,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2021-10-12T07:33:24-05:00",
    "updated_at": "2021-10-12T07:33:24-05:00",
    "archived_at": null,
    "hide_date_range_on_invoice": false,
    "allow_fractional_quantities": false,
    "use_site_exchange_rate": null,
    "item_category": null,
    "accounting_code": null,
    "event_based_billing_metric_id": 1163
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Find Component

This request will return information regarding a component having the handle you provide. You can identify your components with a handle so you don't have to save or reference the IDs we generate.

```csharp
FindComponentAsync(
    string handle)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `handle` | `string` | Query, Required | The handle of the component to find |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
string handle = "handle6";
try
{
    ComponentResponse result = await componentsController.FindComponentAsync(handle);
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
  "component": {
    "id": 399853,
    "name": "Annual Support Services",
    "pricing_scheme": null,
    "unit_name": "on/off",
    "unit_price": "100.0",
    "product_family_id": 997233,
    "price_per_unit_in_cents": null,
    "kind": "on_off_component",
    "archived": false,
    "taxable": true,
    "description": "Prepay for support services",
    "default_price_point_id": 121003,
    "price_point_count": 4,
    "price_points_url": "https://general-goods.chargify.com/components/399853/price_points",
    "tax_code": "D0000000",
    "recurring": true,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2019-08-02T05:54:53-04:00",
    "default_price_point_name": "Original",
    "product_family_name": "Chargify"
  }
}
```


# Read Component

This request will return information regarding a component from a specific product family.

You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.

```csharp
ReadComponentAsync(
    int productFamilyId,
    string componentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `int` | Template, Required | The Advanced Billing id of the product family to which the component belongs |
| `componentId` | `string` | Template, Required | Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`<br><br>**Constraints**: *Pattern*: `/\A(?:\d+\|handle:(?:uuid:\|[a-z])(?:\w\|-)+)\z/` |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
int productFamilyId = 140;
string componentId = "component_id8";
try
{
    ComponentResponse result = await componentsController.ReadComponentAsync(
        productFamilyId,
        componentId
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
  "component": {
    "id": 399853,
    "name": "Annual Support Services",
    "pricing_scheme": null,
    "unit_name": "on/off",
    "unit_price": "100.0",
    "product_family_id": 997233,
    "price_per_unit_in_cents": null,
    "kind": "on_off_component",
    "archived": false,
    "taxable": true,
    "description": "Prepay for support services",
    "default_price_point_id": 121003,
    "price_point_count": 4,
    "price_points_url": "https://general-goods.chargify.com/components/399853/price_points",
    "tax_code": "D0000000",
    "recurring": true,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2019-08-02T05:54:53-04:00",
    "default_price_point_name": "Original",
    "product_family_name": "Chargify",
    "product_family_handle": "chargify"
  }
}
```


# Update Product Family Component

This request will update a component from a specific product family.

You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.

```csharp
UpdateProductFamilyComponentAsync(
    int productFamilyId,
    string componentId,
    Models.UpdateComponentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `int` | Template, Required | The Advanced Billing id of the product family to which the component belongs |
| `componentId` | `string` | Template, Required | Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`<br><br>**Constraints**: *Pattern*: `/\A(?:\d+\|handle:(?:uuid:\|[a-z])(?:\w\|-)+)\z/` |
| `body` | [`UpdateComponentRequest`](../../doc/models/update-component-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
int productFamilyId = 140;
string componentId = "component_id8";
UpdateComponentRequest body = new UpdateComponentRequest
{
    Component = new UpdateComponent
    {
        ItemCategory = ItemCategory.EnumBusinessSoftware,
    },
};

try
{
    ComponentResponse result = await componentsController.UpdateProductFamilyComponentAsync(
        productFamilyId,
        componentId,
        body
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
  "component": {
    "id": 399853,
    "name": "Annual Support Services",
    "pricing_scheme": null,
    "unit_name": "on/off",
    "unit_price": "100.0",
    "product_family_id": 997233,
    "price_per_unit_in_cents": null,
    "kind": "on_off_component",
    "archived": false,
    "taxable": true,
    "description": "Prepay for support services",
    "default_price_point_id": 121003,
    "price_point_count": 4,
    "price_points_url": "https://general-goods.chargify.com/components/399853/price_points",
    "tax_code": "D0000000",
    "recurring": true,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2019-08-02T05:54:53-04:00",
    "default_price_point_name": "Original",
    "product_family_name": "Chargify"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Archive Component

Sending a DELETE request to this endpoint will archive the component. All current subscribers will be unffected; their subscription/purchase will continue to be charged as usual.

```csharp
ArchiveComponentAsync(
    int productFamilyId,
    string componentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `int` | Template, Required | The Advanced Billing id of the product family to which the component belongs |
| `componentId` | `string` | Template, Required | Either the Advanced Billing id of the component or the handle for the component prefixed with `handle:`<br><br>**Constraints**: *Pattern*: `/\A(?:\d+\|handle:(?:uuid:\|[a-z])(?:\w\|-)+)\z/` |

## Response Type

[`Task<Models.Component>`](../../doc/models/component.md)

## Example Usage

```csharp
int productFamilyId = 140;
string componentId = "component_id8";
try
{
    Component result = await componentsController.ArchiveComponentAsync(
        productFamilyId,
        componentId
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
  "id": 25407138,
  "name": "cillum aute",
  "pricing_scheme": "stairstep",
  "unit_name": "nulla in",
  "unit_price": "Excepteur veniam",
  "product_family_id": -56705047,
  "kind": "prepaid_usage_component",
  "archived": true,
  "taxable": false,
  "description": "reprehenderit laborum qui fugiat",
  "default_price_point_id": -64328176,
  "price_point_count": 15252407,
  "price_points_url": "dolor mollit consequat",
  "tax_code": "ea nisi",
  "recurring": false,
  "created_at": "2016-11-08T16:22:26-05:00",
  "default_price_point_name": "cupidatat Lorem non aliqua",
  "product_family_name": "do elit",
  "hide_date_range_on_invoice": false
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# List Components

This request will return a list of components for a site.

```csharp
ListComponentsAsync(
    Models.ListComponentsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `dateField` | [`BasicDateField?`](../../doc/models/basic-date-field.md) | Query, Optional | The type of filter you would like to apply to your search. |
| `startDate` | `string` | Query, Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `endDate` | `string` | Query, Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `startDatetime` | `string` | Query, Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |
| `endDatetime` | `string` | Query, Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date.  optional |
| `includeArchived` | `bool?` | Query, Optional | Include archived items |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `filter` | [`ListComponentsFilter`](../../doc/models/list-components-filter.md) | Query, Optional | Filter to use for List Components operations |

## Response Type

[`Task<List<Models.ComponentResponse>>`](../../doc/models/component-response.md)

## Example Usage

```csharp
ListComponentsInput listComponentsInput = new ListComponentsInput
{
    DateField = BasicDateField.UpdatedAt,
    Page = 2,
    PerPage = 50,
    Filter = new ListComponentsFilter
    {
        Ids = new List<int>
        {
            1,
            2,
            3,
        },
    },
};

try
{
    List<ComponentResponse> result = await componentsController.ListComponentsAsync(listComponentsInput);
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
    "component": {
      "id": 399850,
      "name": "$1.00 component",
      "pricing_scheme": "per_unit",
      "unit_name": "Component",
      "unit_price": "1.0",
      "product_family_id": 997233,
      "price_per_unit_in_cents": null,
      "kind": "quantity_based_component",
      "archived": false,
      "taxable": false,
      "description": "Component",
      "default_price_point_id": 121000,
      "prices": [
        {
          "id": 630687,
          "component_id": 399850,
          "starting_quantity": 1,
          "ending_quantity": null,
          "unit_price": "1.0",
          "price_point_id": 121000,
          "formatted_unit_price": "$1.00"
        }
      ],
      "price_point_count": 2,
      "price_points_url": "https://general-goods.chargify.com/components/399850/price_points",
      "tax_code": null,
      "recurring": true,
      "upgrade_charge": null,
      "downgrade_credit": null,
      "created_at": "2019-08-01T09:35:38-04:00",
      "default_price_point_name": "Original",
      "product_family_name": "Chargify",
      "product_family_handle": "chargify",
      "use_site_exchange_rate": true
    }
  },
  {
    "component": {
      "id": 399853,
      "name": "Annual Support Services",
      "pricing_scheme": null,
      "unit_name": "on/off",
      "unit_price": "100.0",
      "product_family_id": 997233,
      "price_per_unit_in_cents": null,
      "kind": "on_off_component",
      "archived": false,
      "taxable": true,
      "description": "Prepay for support services",
      "default_price_point_id": 121003,
      "price_point_count": 4,
      "price_points_url": "https://general-goods.chargify.com/components/399853/price_points",
      "tax_code": "D0000000",
      "recurring": true,
      "upgrade_charge": null,
      "downgrade_credit": null,
      "created_at": "2019-08-01T09:35:37-04:00",
      "default_price_point_name": "Original",
      "product_family_name": "Chargify",
      "product_family_handle": "chargify",
      "use_site_exchange_rate": true
    }
  },
  {
    "component": {
      "id": 386937,
      "name": "Cancellation fee",
      "pricing_scheme": null,
      "unit_name": "on/off",
      "unit_price": "35.0",
      "product_family_id": 997233,
      "price_per_unit_in_cents": null,
      "kind": "on_off_component",
      "archived": false,
      "taxable": false,
      "description": "",
      "default_price_point_id": 108307,
      "price_point_count": 1,
      "price_points_url": "https://general-goods.chargify.com/components/386937/price_points",
      "tax_code": null,
      "recurring": true,
      "upgrade_charge": null,
      "downgrade_credit": null,
      "created_at": "2019-08-01T09:35:38-04:00",
      "default_price_point_name": "Original",
      "product_family_name": "Chargify",
      "product_family_handle": "chargify",
      "use_site_exchange_rate": true
    }
  }
]
```


# Update Component

This request will update a component.

You may read the component by either the component's id or handle. When using the handle, it must be prefixed with `handle:`.

```csharp
UpdateComponentAsync(
    string componentId,
    Models.UpdateComponentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `string` | Template, Required | The id or handle of the component |
| `body` | [`UpdateComponentRequest`](../../doc/models/update-component-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
string componentId = "component_id8";
UpdateComponentRequest body = new UpdateComponentRequest
{
    Component = new UpdateComponent
    {
        ItemCategory = ItemCategory.EnumBusinessSoftware,
    },
};

try
{
    ComponentResponse result = await componentsController.UpdateComponentAsync(
        componentId,
        body
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
  "component": {
    "id": 399853,
    "name": "Annual Support Services",
    "pricing_scheme": null,
    "unit_name": "on/off",
    "unit_price": "100.0",
    "product_family_id": 997233,
    "price_per_unit_in_cents": null,
    "kind": "on_off_component",
    "archived": false,
    "taxable": true,
    "description": "Prepay for support services",
    "default_price_point_id": 121003,
    "price_point_count": 4,
    "price_points_url": "https://general-goods.chargify.com/components/399853/price_points",
    "tax_code": "D0000000",
    "recurring": true,
    "upgrade_charge": null,
    "downgrade_credit": null,
    "created_at": "2019-08-02T05:54:53-04:00",
    "default_price_point_name": "Original",
    "product_family_name": "Chargify"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# List Components for Product Family

This request will return a list of components for a particular product family.

```csharp
ListComponentsForProductFamilyAsync(
    Models.ListComponentsForProductFamilyInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productFamilyId` | `int` | Template, Required | The Advanced Billing id of the product family |
| `includeArchived` | `bool?` | Query, Optional | Include archived items. |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br><br>**Default**: `20`<br><br>**Constraints**: `<= 200` |
| `filter` | [`ListComponentsFilter`](../../doc/models/list-components-filter.md) | Query, Optional | Filter to use for List Components operations |
| `dateField` | [`BasicDateField?`](../../doc/models/basic-date-field.md) | Query, Optional | The type of filter you would like to apply to your search. Use in query `date_field=created_at`. |
| `endDate` | `string` | Query, Optional | The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. |
| `endDatetime` | `string` | Query, Optional | The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. optional. |
| `startDate` | `string` | Query, Optional | The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. |
| `startDatetime` | `string` | Query, Optional | The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. |

## Response Type

[`Task<List<Models.ComponentResponse>>`](../../doc/models/component-response.md)

## Example Usage

```csharp
ListComponentsForProductFamilyInput listComponentsForProductFamilyInput = new ListComponentsForProductFamilyInput
{
    ProductFamilyId = 140,
    Page = 2,
    PerPage = 50,
    Filter = new ListComponentsFilter
    {
        Ids = new List<int>
        {
            1,
            2,
            3,
        },
    },
    DateField = BasicDateField.UpdatedAt,
};

try
{
    List<ComponentResponse> result = await componentsController.ListComponentsForProductFamilyAsync(listComponentsForProductFamilyInput);
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
    "component": {
      "id": 399850,
      "name": "$1.00 component",
      "pricing_scheme": "per_unit",
      "unit_name": "Component",
      "unit_price": "1.0",
      "product_family_id": 997233,
      "price_per_unit_in_cents": null,
      "kind": "quantity_based_component",
      "archived": false,
      "taxable": false,
      "description": "Component",
      "default_price_point_id": 121000,
      "prices": [
        {
          "id": 630687,
          "component_id": 399850,
          "starting_quantity": 1,
          "ending_quantity": null,
          "unit_price": "1.0",
          "price_point_id": 121000,
          "formatted_unit_price": "$1.00"
        }
      ],
      "price_point_count": 2,
      "price_points_url": "https://general-goods.chargify.com/components/399850/price_points",
      "tax_code": null,
      "recurring": true,
      "upgrade_charge": null,
      "downgrade_credit": null,
      "created_at": "2019-08-01T09:35:38-04:00",
      "default_price_point_name": "Original",
      "product_family_name": "Chargify",
      "use_site_exchange_rate": true
    }
  },
  {
    "component": {
      "id": 399853,
      "name": "Annual Support Services",
      "pricing_scheme": null,
      "unit_name": "on/off",
      "unit_price": "100.0",
      "product_family_id": 997233,
      "price_per_unit_in_cents": null,
      "kind": "on_off_component",
      "archived": false,
      "taxable": true,
      "description": "Prepay for support services",
      "default_price_point_id": 121003,
      "price_point_count": 4,
      "price_points_url": "https://general-goods.chargify.com/components/399853/price_points",
      "tax_code": "D0000000",
      "recurring": true,
      "upgrade_charge": null,
      "downgrade_credit": null,
      "created_at": "2019-08-01T09:35:37-04:00",
      "default_price_point_name": "Original",
      "product_family_name": "Chargify",
      "use_site_exchange_rate": true
    }
  },
  {
    "component": {
      "id": 386937,
      "name": "Cancellation fee",
      "pricing_scheme": null,
      "unit_name": "on/off",
      "unit_price": "35.0",
      "product_family_id": 997233,
      "price_per_unit_in_cents": null,
      "kind": "on_off_component",
      "archived": false,
      "taxable": false,
      "description": "",
      "default_price_point_id": 108307,
      "price_point_count": 1,
      "price_points_url": "https://general-goods.chargify.com/components/386937/price_points",
      "tax_code": null,
      "recurring": true,
      "upgrade_charge": null,
      "downgrade_credit": null,
      "created_at": "2019-08-01T09:35:38-04:00",
      "default_price_point_name": "Original",
      "product_family_name": "Chargify",
      "use_site_exchange_rate": true
    }
  }
]
```

