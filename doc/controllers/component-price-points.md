# Component Price Points

```csharp
ComponentPricePointsController componentPricePointsController = client.ComponentPricePointsController;
```

## Class Name

`ComponentPricePointsController`

## Methods

* [Promote Component Price Point to Default](../../doc/controllers/component-price-points.md#promote-component-price-point-to-default)
* [Create Component Price Point](../../doc/controllers/component-price-points.md#create-component-price-point)
* [List Component Price Points](../../doc/controllers/component-price-points.md#list-component-price-points)
* [Bulk Create Component Price Points](../../doc/controllers/component-price-points.md#bulk-create-component-price-points)
* [Update Component Price Point](../../doc/controllers/component-price-points.md#update-component-price-point)
* [Read Component Price Point](../../doc/controllers/component-price-points.md#read-component-price-point)
* [Archive Component Price Point](../../doc/controllers/component-price-points.md#archive-component-price-point)
* [Unarchive Component Price Point](../../doc/controllers/component-price-points.md#unarchive-component-price-point)
* [Create Currency Prices](../../doc/controllers/component-price-points.md#create-currency-prices)
* [Update Currency Prices](../../doc/controllers/component-price-points.md#update-currency-prices)
* [List All Component Price Points](../../doc/controllers/component-price-points.md#list-all-component-price-points)


# Promote Component Price Point to Default

Sets a new default price point for the component. This new default will apply to all new subscriptions going forward - existing subscriptions will remain on their current price point.

See [Price Points Documentation](https://maxio.zendesk.com/hc/en-us/articles/24261191737101-Price-Points-Components) for more information on price points and moving subscriptions between price points.

Note: Custom price points are not able to be set as the default for a component.

```csharp
PromoteComponentPricePointToDefaultAsync(
    int componentId,
    int pricePointId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `int` | Template, Required | The Advanced Billing id of the component to which the price point belongs |
| `pricePointId` | `int` | Template, Required | The Advanced Billing id of the price point |

## Response Type

[`Task<Models.ComponentResponse>`](../../doc/models/component-response.md)

## Example Usage

```csharp
int componentId = 222;
int pricePointId = 10;
try
{
    ComponentResponse result = await componentPricePointsController.PromoteComponentPricePointToDefaultAsync(
        componentId,
        pricePointId
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
    "pricing_scheme": "stairstep",
    "unit_name": "text message",
    "unit_price": null,
    "product_family_id": 528484,
    "price_per_unit_in_cents": null,
    "kind": "metered_component",
    "archived": false,
    "taxable": false,
    "description": null,
    "created_at": "2019-08-02T05:54:53-04:00",
    "prices": [
      {
        "id": 47,
        "component_id": 292609,
        "starting_quantity": 1,
        "ending_quantity": null,
        "unit_price": "1.0",
        "price_point_id": 173,
        "formatted_unit_price": "$1.00"
      }
    ],
    "default_price_point_name": "Original"
  }
}
```


# Create Component Price Point

This endpoint can be used to create a new price point for an existing component.

```csharp
CreateComponentPricePointAsync(
    int componentId,
    Models.CreateComponentPricePointRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `int` | Template, Required | The Advanced Billing id of the component |
| `body` | [`CreateComponentPricePointRequest`](../../doc/models/create-component-price-point-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentPricePointResponse>`](../../doc/models/component-price-point-response.md)

## Example Usage

```csharp
int componentId = 222;
CreateComponentPricePointRequest body = new CreateComponentPricePointRequest
{
    PricePoint = CreateComponentPricePointRequestPricePoint.FromCreateComponentPricePoint(
        new CreateComponentPricePoint
        {
            Name = "Wholesale",
            PricingScheme = PricingScheme.Stairstep,
            Prices = new List<Price>
            {
                new Price
                {
                    StartingQuantity = PriceStartingQuantity.FromString("1"),
                    UnitPrice = PriceUnitPrice.FromString("5.00"),
                    EndingQuantity = PriceEndingQuantity.FromString("100"),
                },
                new Price
                {
                    StartingQuantity = PriceStartingQuantity.FromString("101"),
                    UnitPrice = PriceUnitPrice.FromString("4.00"),
                },
            },
            Handle = "wholesale-handle",
            UseSiteExchangeRate = false,
        }
    ),
};

try
{
    ComponentPricePointResponse result = await componentPricePointsController.CreateComponentPricePointAsync(
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |


# List Component Price Points

Use this endpoint to read current price points that are associated with a component.

You may specify the component by using either the numeric id or the `handle:gold` syntax.

When fetching a component's price points, if you have defined multiple currencies at the site level, you can optionally pass the `?currency_prices=true` query param to include an array of currency price data in the response.

If the price point is set to `use_site_exchange_rate: true`, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency.

```csharp
ListComponentPricePointsAsync(
    Models.ListComponentPricePointsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `int` | Template, Required | The Advanced Billing id of the component |
| `currencyPrices` | `bool?` | Query, Optional | Include an array of currency price data |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br>**Default**: `1`<br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br>**Default**: `20`<br>**Constraints**: `<= 200` |
| `filterType` | [`List<PricePointType>`](../../doc/models/price-point-type.md) | Query, Optional | Use in query: `filter[type]=catalog,default`. |

## Response Type

[`Task<Models.ComponentPricePointsResponse>`](../../doc/models/component-price-points-response.md)

## Example Usage

```csharp
ListComponentPricePointsInput listComponentPricePointsInput = new ListComponentPricePointsInput
{
    ComponentId = 222,
    Page = 2,
    PerPage = 50,
Liquid error: Value cannot be null. (Parameter 'key')};

try
{
    ComponentPricePointsResponse result = await componentPricePointsController.ListComponentPricePointsAsync(listComponentPricePointsInput);
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
  "price_points": [
    {
      "id": 80,
      "default": false,
      "name": "Wholesale Two",
      "pricing_scheme": "per_unit",
      "component_id": 74,
      "handle": "wholesale-two",
      "archived_at": null,
      "created_at": "2017-07-05T13:55:40-04:00",
      "updated_at": "2017-07-05T13:55:40-04:00",
      "prices": [
        {
          "id": 121,
          "component_id": 74,
          "starting_quantity": 1,
          "ending_quantity": null,
          "unit_price": "5.0"
        }
      ]
    },
    {
      "id": 81,
      "default": false,
      "name": "MSRP",
      "pricing_scheme": "per_unit",
      "component_id": 74,
      "handle": "msrp",
      "archived_at": null,
      "created_at": "2017-07-05T13:55:40-04:00",
      "updated_at": "2017-07-05T13:55:40-04:00",
      "prices": [
        {
          "id": 122,
          "component_id": 74,
          "starting_quantity": 1,
          "ending_quantity": null,
          "unit_price": "4.0"
        }
      ]
    }
  ]
}
```


# Bulk Create Component Price Points

Use this endpoint to create multiple component price points in one request.

```csharp
BulkCreateComponentPricePointsAsync(
    string componentId,
    Models.CreateComponentPricePointsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `string` | Template, Required | The Advanced Billing id of the component for which you want to fetch price points. |
| `body` | [`CreateComponentPricePointsRequest`](../../doc/models/create-component-price-points-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentPricePointsResponse>`](../../doc/models/component-price-points-response.md)

## Example Usage

```csharp
string componentId = "component_id8";
CreateComponentPricePointsRequest body = new CreateComponentPricePointsRequest
{
    PricePoints = new List<CreateComponentPricePointsRequestPricePoints>
    {
        CreateComponentPricePointsRequestPricePoints.FromCreateComponentPricePoint(
            new CreateComponentPricePoint
            {
                Name = "Wholesale",
                PricingScheme = PricingScheme.PerUnit,
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(1),
                        UnitPrice = PriceUnitPrice.FromPrecision(5),
                    },
                },
                Handle = "wholesale",
            }
        ),
        CreateComponentPricePointsRequestPricePoints.FromCreateComponentPricePoint(
            new CreateComponentPricePoint
            {
                Name = "MSRP",
                PricingScheme = PricingScheme.PerUnit,
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(1),
                        UnitPrice = PriceUnitPrice.FromPrecision(4),
                    },
                },
                Handle = "msrp",
            }
        ),
        CreateComponentPricePointsRequestPricePoints.FromCreateComponentPricePoint(
            new CreateComponentPricePoint
            {
                Name = "Special Pricing",
                PricingScheme = PricingScheme.PerUnit,
                Prices = new List<Price>
                {
                    new Price
                    {
                        StartingQuantity = PriceStartingQuantity.FromNumber(1),
                        UnitPrice = PriceUnitPrice.FromPrecision(5),
                    },
                },
                Handle = "special",
            }
        ),
    },
};

try
{
    ComponentPricePointsResponse result = await componentPricePointsController.BulkCreateComponentPricePointsAsync(
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
  "price_points": [
    {
      "id": 80,
      "default": false,
      "name": "Wholesale Two",
      "pricing_scheme": "per_unit",
      "component_id": 74,
      "handle": "wholesale-two",
      "archived_at": null,
      "created_at": "2017-07-05T13:55:40-04:00",
      "updated_at": "2017-07-05T13:55:40-04:00",
      "prices": [
        {
          "id": 121,
          "component_id": 74,
          "starting_quantity": 1,
          "ending_quantity": null,
          "unit_price": "5.0"
        }
      ]
    },
    {
      "id": 81,
      "default": false,
      "name": "MSRP",
      "pricing_scheme": "per_unit",
      "component_id": 74,
      "handle": "msrp",
      "archived_at": null,
      "created_at": "2017-07-05T13:55:40-04:00",
      "updated_at": "2017-07-05T13:55:40-04:00",
      "prices": [
        {
          "id": 122,
          "component_id": 74,
          "starting_quantity": 1,
          "ending_quantity": null,
          "unit_price": "4.0"
        }
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Update Component Price Point

When updating a price point, it's prices can be updated as well by creating new prices or editing / removing existing ones.

Passing in a price bracket without an `id` will attempt to create a new price.

Including an `id` will update the corresponding price, and including the `_destroy` flag set to true along with the `id` will remove that price.

Note: Custom price points cannot be updated directly. They must be edited through the Subscription.

```csharp
UpdateComponentPricePointAsync(
    UpdateComponentPricePointComponentId componentId,
    UpdateComponentPricePointPricePointId pricePointId,
    Models.UpdateComponentPricePointRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | [`UpdateComponentPricePointComponentId`](../../doc/models/containers/update-component-price-point-component-id.md) | Template, Required | This is a container for one-of cases. |
| `pricePointId` | [`UpdateComponentPricePointPricePointId`](../../doc/models/containers/update-component-price-point-price-point-id.md) | Template, Required | This is a container for one-of cases. |
| `body` | [`UpdateComponentPricePointRequest`](../../doc/models/update-component-price-point-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentPricePointResponse>`](../../doc/models/component-price-point-response.md)

## Example Usage

```csharp
UpdateComponentPricePointComponentId componentId = UpdateComponentPricePointComponentId.FromNumber(144);

UpdateComponentPricePointPricePointId pricePointId = UpdateComponentPricePointPricePointId.FromNumber(188);

UpdateComponentPricePointRequest body = new UpdateComponentPricePointRequest
{
    PricePoint = new UpdateComponentPricePoint
    {
        Name = "Default",
        Prices = new List<UpdatePrice>
        {
            new UpdatePrice
            {
                Id = 1,
                EndingQuantity = UpdatePriceEndingQuantity.FromNumber(100),
                UnitPrice = UpdatePriceUnitPrice.FromPrecision(5),
            },
            new UpdatePrice
            {
                Id = 2,
                Destroy = true,
            },
            new UpdatePrice
            {
                UnitPrice = UpdatePriceUnitPrice.FromPrecision(4),
                StartingQuantity = UpdatePriceStartingQuantity.FromNumber(101),
            },
        },
    },
};

try
{
    ComponentPricePointResponse result = await componentPricePointsController.UpdateComponentPricePointAsync(
        componentId,
        pricePointId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |


# Read Component Price Point

Use this endpoint to retrieve details for a specific component price point. You can achieve this by using either the component price point ID or handle.

```csharp
ReadComponentPricePointAsync(
    ReadComponentPricePointComponentId componentId,
    ReadComponentPricePointPricePointId pricePointId,
    bool? currencyPrices = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | [`ReadComponentPricePointComponentId`](../../doc/models/containers/read-component-price-point-component-id.md) | Template, Required | This is a container for one-of cases. |
| `pricePointId` | [`ReadComponentPricePointPricePointId`](../../doc/models/containers/read-component-price-point-price-point-id.md) | Template, Required | This is a container for one-of cases. |
| `currencyPrices` | `bool?` | Query, Optional | Include an array of currency price data |

## Response Type

[`Task<Models.ComponentPricePointResponse>`](../../doc/models/component-price-point-response.md)

## Example Usage

```csharp
ReadComponentPricePointComponentId componentId = ReadComponentPricePointComponentId.FromNumber(144);

ReadComponentPricePointPricePointId pricePointId = ReadComponentPricePointPricePointId.FromNumber(188);

try
{
    ComponentPricePointResponse result = await componentPricePointsController.ReadComponentPricePointAsync(
        componentId,
        pricePointId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Archive Component Price Point

A price point can be archived at any time. Subscriptions using a price point that has been archived will continue using it until they're moved to another price point.

```csharp
ArchiveComponentPricePointAsync(
    ArchiveComponentPricePointComponentId componentId,
    ArchiveComponentPricePointPricePointId pricePointId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | [`ArchiveComponentPricePointComponentId`](../../doc/models/containers/archive-component-price-point-component-id.md) | Template, Required | This is a container for one-of cases. |
| `pricePointId` | [`ArchiveComponentPricePointPricePointId`](../../doc/models/containers/archive-component-price-point-price-point-id.md) | Template, Required | This is a container for one-of cases. |

## Response Type

[`Task<Models.ComponentPricePointResponse>`](../../doc/models/component-price-point-response.md)

## Example Usage

```csharp
ArchiveComponentPricePointComponentId componentId = ArchiveComponentPricePointComponentId.FromNumber(144);

ArchiveComponentPricePointPricePointId pricePointId = ArchiveComponentPricePointPricePointId.FromNumber(188);

try
{
    ComponentPricePointResponse result = await componentPricePointsController.ArchiveComponentPricePointAsync(
        componentId,
        pricePointId
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
  "price_point": {
    "id": 79,
    "default": false,
    "name": "Wholesale",
    "pricing_scheme": "stairstep",
    "component_id": 74,
    "handle": "wholesale-handle",
    "archived_at": "2017-07-06T15:04:00-04:00",
    "created_at": "2017-07-05T13:44:30-04:00",
    "updated_at": "2017-07-05T13:44:30-04:00",
    "prices": [
      {
        "id": 119,
        "component_id": 74,
        "starting_quantity": 1,
        "ending_quantity": 100,
        "unit_price": "5.0"
      },
      {
        "id": 120,
        "component_id": 74,
        "starting_quantity": 101,
        "ending_quantity": null,
        "unit_price": "4.0"
      }
    ]
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Unarchive Component Price Point

Use this endpoint to unarchive a component price point.

```csharp
UnarchiveComponentPricePointAsync(
    int componentId,
    int pricePointId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `componentId` | `int` | Template, Required | The Advanced Billing id of the component to which the price point belongs |
| `pricePointId` | `int` | Template, Required | The Advanced Billing id of the price point |

## Response Type

[`Task<Models.ComponentPricePointResponse>`](../../doc/models/component-price-point-response.md)

## Example Usage

```csharp
int componentId = 222;
int pricePointId = 10;
try
{
    ComponentPricePointResponse result = await componentPricePointsController.UnarchiveComponentPricePointAsync(
        componentId,
        pricePointId
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
  "price_point": {
    "id": 79,
    "default": false,
    "name": "Wholesale",
    "pricing_scheme": "stairstep",
    "component_id": 74,
    "handle": "wholesale-handle",
    "archived_at": null,
    "created_at": "2017-07-05T13:44:30-04:00",
    "updated_at": "2017-07-05T13:44:30-04:00",
    "prices": [
      {
        "id": 119,
        "component_id": 74,
        "starting_quantity": 1,
        "ending_quantity": 100,
        "unit_price": "5.0"
      },
      {
        "id": 120,
        "component_id": 74,
        "starting_quantity": 101,
        "ending_quantity": null,
        "unit_price": "4.0"
      }
    ]
  }
}
```


# Create Currency Prices

This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.

When creating currency prices, they need to mirror the structure of your primary pricing. For each price level defined on the component price point, there should be a matching price level created in the given currency.

Note: Currency Prices are not able to be created for custom price points.

```csharp
CreateCurrencyPricesAsync(
    int pricePointId,
    Models.CreateCurrencyPricesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pricePointId` | `int` | Template, Required | The Advanced Billing id of the price point |
| `body` | [`CreateCurrencyPricesRequest`](../../doc/models/create-currency-prices-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentCurrencyPricesResponse>`](../../doc/models/component-currency-prices-response.md)

## Example Usage

```csharp
int pricePointId = 10;
CreateCurrencyPricesRequest body = new CreateCurrencyPricesRequest
{
    CurrencyPrices = new List<CreateCurrencyPrice>
    {
        new CreateCurrencyPrice
        {
            Currency = "EUR",
            Price = 50,
            PriceId = 20,
        },
        new CreateCurrencyPrice
        {
            Currency = "EUR",
            Price = 40,
            PriceId = 21,
        },
    },
};

try
{
    ComponentCurrencyPricesResponse result = await componentPricePointsController.CreateCurrencyPricesAsync(
        pricePointId,
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
  "currency_prices": [
    {
      "id": 100,
      "currency": "EUR",
      "price": "123",
      "formatted_price": "€123,00",
      "price_id": 32669,
      "price_point_id": 25554
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |


# Update Currency Prices

This endpoint allows you to update currency prices for a given currency that has been defined on the site level in your settings.

Note: Currency Prices are not able to be updated for custom price points.

```csharp
UpdateCurrencyPricesAsync(
    int pricePointId,
    Models.UpdateCurrencyPricesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pricePointId` | `int` | Template, Required | The Advanced Billing id of the price point |
| `body` | [`UpdateCurrencyPricesRequest`](../../doc/models/update-currency-prices-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ComponentCurrencyPricesResponse>`](../../doc/models/component-currency-prices-response.md)

## Example Usage

```csharp
int pricePointId = 10;
UpdateCurrencyPricesRequest body = new UpdateCurrencyPricesRequest
{
    CurrencyPrices = new List<UpdateCurrencyPrice>
    {
        new UpdateCurrencyPrice
        {
            Id = 100,
            Price = 51,
        },
        new UpdateCurrencyPrice
        {
            Id = 101,
            Price = 41,
        },
    },
};

try
{
    ComponentCurrencyPricesResponse result = await componentPricePointsController.UpdateCurrencyPricesAsync(
        pricePointId,
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
  "currency_prices": [
    {
      "id": 100,
      "currency": "EUR",
      "price": "123",
      "formatted_price": "€123,00",
      "price_id": 32669,
      "price_point_id": 25554
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |


# List All Component Price Points

This method allows to retrieve a list of Components Price Points belonging to a Site.

```csharp
ListAllComponentPricePointsAsync(
    Models.ListAllComponentPricePointsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`ListComponentsPricePointsInclude?`](../../doc/models/list-components-price-points-include.md) | Query, Optional | Allows including additional data in the response. Use in query: `include=currency_prices`. |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br>**Default**: `1`<br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br>**Default**: `20`<br>**Constraints**: `<= 200` |
| `direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Query, Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |
| `filter` | [`ListPricePointsFilter`](../../doc/models/list-price-points-filter.md) | Query, Optional | Filter to use for List PricePoints operations |

## Response Type

[`Task<Models.ListComponentsPricePointsResponse>`](../../doc/models/list-components-price-points-response.md)

## Example Usage

```csharp
ListAllComponentPricePointsInput listAllComponentPricePointsInput = new ListAllComponentPricePointsInput
{
    Include = ListComponentsPricePointsInclude.CurrencyPrices,
    Page = 2,
    PerPage = 50,
    Filter = new ListPricePointsFilter
    {
        StartDate = DateTime.Parse("2011-12-17"),
        EndDate = DateTime.Parse("2011-12-15"),
        StartDatetime = DateTime.ParseExact("12/19/2011 09:15:30", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        EndDatetime = DateTime.ParseExact("06/07/2019 17:20:06", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Type = new List<PricePointType>
        {
            PricePointType.Catalog,
            PricePointType.Default,
            PricePointType.Custom,
        },
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
    ListComponentsPricePointsResponse result = await componentPricePointsController.ListAllComponentPricePointsAsync(listAllComponentPricePointsInput);
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
  "price_points": [
    {
      "id": 1,
      "name": "Auto-created",
      "type": "default",
      "pricing_scheme": "per_unit",
      "component_id": 2,
      "handle": "auto-created",
      "archived_at": null,
      "created_at": "2021-02-21T11:05:57-05:00",
      "updated_at": "2021-02-21T11:05:57-05:00",
      "prices": [
        {
          "id": 3,
          "component_id": 2,
          "starting_quantity": 0,
          "ending_quantity": null,
          "unit_price": "1.0",
          "price_point_id": 1,
          "formatted_unit_price": "$1.00",
          "segment_id": null
        }
      ],
      "tax_included": false
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |

