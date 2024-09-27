# Product Price Points

```csharp
ProductPricePointsController productPricePointsController = client.ProductPricePointsController;
```

## Class Name

`ProductPricePointsController`

## Methods

* [Create Product Price Point](../../doc/controllers/product-price-points.md#create-product-price-point)
* [List Product Price Points](../../doc/controllers/product-price-points.md#list-product-price-points)
* [Update Product Price Point](../../doc/controllers/product-price-points.md#update-product-price-point)
* [Read Product Price Point](../../doc/controllers/product-price-points.md#read-product-price-point)
* [Archive Product Price Point](../../doc/controllers/product-price-points.md#archive-product-price-point)
* [Unarchive Product Price Point](../../doc/controllers/product-price-points.md#unarchive-product-price-point)
* [Promote Product Price Point to Default](../../doc/controllers/product-price-points.md#promote-product-price-point-to-default)
* [Bulk Create Product Price Points](../../doc/controllers/product-price-points.md#bulk-create-product-price-points)
* [Create Product Currency Prices](../../doc/controllers/product-price-points.md#create-product-currency-prices)
* [Update Product Currency Prices](../../doc/controllers/product-price-points.md#update-product-currency-prices)
* [List All Product Price Points](../../doc/controllers/product-price-points.md#list-all-product-price-points)


# Create Product Price Point

[Product Price Point Documentation](https://maxio.zendesk.com/hc/en-us/articles/24261111947789-Product-Price-Points)

```csharp
CreateProductPricePointAsync(
    CreateProductPricePointProductId productId,
    Models.CreateProductPricePointRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | [`CreateProductPricePointProductId`](../../doc/models/containers/create-product-price-point-product-id.md) | Template, Required | This is a container for one-of cases. |
| `body` | [`CreateProductPricePointRequest`](../../doc/models/create-product-price-point-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ProductPricePointResponse>`](../../doc/models/product-price-point-response.md)

## Example Usage

```csharp
CreateProductPricePointProductId productId = CreateProductPricePointProductId.FromNumber(124);

CreateProductPricePointRequest body = new CreateProductPricePointRequest
{
    PricePoint = new CreateProductPricePoint
    {
        Name = "Educational",
        PriceInCents = 1000L,
        Interval = 1,
        IntervalUnit = IntervalUnit.Month,
        Handle = "educational",
        TrialPriceInCents = 4900L,
        TrialInterval = 1,
        TrialIntervalUnit = IntervalUnit.Month,
        TrialType = "payment_expected",
        InitialChargeInCents = 120000L,
        InitialChargeAfterTrial = false,
        ExpirationInterval = 12,
        ExpirationIntervalUnit = ExpirationIntervalUnit.Month,
    },
};

try
{
    ProductPricePointResponse result = await productPricePointsController.CreateProductPricePointAsync(
        productId,
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
  "price_point": {
    "id": 283,
    "name": "Educational",
    "handle": "educational",
    "price_in_cents": 1000,
    "interval": 1,
    "interval_unit": "month",
    "trial_price_in_cents": 4900,
    "trial_interval": 1,
    "trial_interval_unit": "month",
    "trial_type": "payment_expected",
    "initial_charge_in_cents": 120000,
    "initial_charge_after_trial": false,
    "expiration_interval": 12,
    "expiration_interval_unit": "month",
    "product_id": 901,
    "archived_at": "2023-11-30T06:37:20-05:00",
    "created_at": "2023-11-27T06:37:20-05:00",
    "updated_at": "2023-11-27T06:37:20-05:00"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ProductPricePointErrorResponseException`](../../doc/models/product-price-point-error-response-exception.md) |


# List Product Price Points

Use this endpoint to retrieve a list of product price points.

```csharp
ListProductPricePointsAsync(
    Models.ListProductPricePointsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | [`ListProductPricePointsInputProductId`](../../doc/models/containers/list-product-price-points-input-product-id.md) | Template, Required | This is a container for one-of cases. |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br>**Default**: `1`<br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 10. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>**Default**: `10`<br>**Constraints**: `<= 200` |
| `currencyPrices` | `bool?` | Query, Optional | When fetching a product's price points, if you have defined multiple currencies at the site level, you can optionally pass the ?currency_prices=true query param to include an array of currency price data in the response. If the product price point is set to use_site_exchange_rate: true, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency. |
| `filterType` | [`List<PricePointType>`](../../doc/models/price-point-type.md) | Query, Optional | Use in query: `filter[type]=catalog,default`. |

## Response Type

[`Task<Models.ListProductPricePointsResponse>`](../../doc/models/list-product-price-points-response.md)

## Example Usage

```csharp
ListProductPricePointsInput listProductPricePointsInput = new ListProductPricePointsInput
{
    ProductId = ListProductPricePointsInputProductId.FromNumber(124),
    Page = 2,
    PerPage = 10,
Liquid error: Value cannot be null. (Parameter 'key')};

try
{
    ListProductPricePointsResponse result = await productPricePointsController.ListProductPricePointsAsync(listProductPricePointsInput);
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
      "id": 283,
      "name": "Educational",
      "handle": "educational",
      "price_in_cents": 1000,
      "interval": 1,
      "interval_unit": "month",
      "trial_price_in_cents": 4900,
      "trial_interval": 1,
      "trial_interval_unit": "month",
      "trial_type": "payment_expected",
      "initial_charge_in_cents": 120000,
      "initial_charge_after_trial": false,
      "expiration_interval": 12,
      "expiration_interval_unit": "month",
      "product_id": 901,
      "archived_at": "2023-11-30T06:37:20-05:00",
      "created_at": "2023-11-27T06:37:20-05:00",
      "updated_at": "2023-11-27T06:37:20-05:00"
    }
  ]
}
```


# Update Product Price Point

Use this endpoint to update a product price point.

Note: Custom product price points are not able to be updated.

```csharp
UpdateProductPricePointAsync(
    UpdateProductPricePointProductId productId,
    UpdateProductPricePointPricePointId pricePointId,
    Models.UpdateProductPricePointRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | [`UpdateProductPricePointProductId`](../../doc/models/containers/update-product-price-point-product-id.md) | Template, Required | This is a container for one-of cases. |
| `pricePointId` | [`UpdateProductPricePointPricePointId`](../../doc/models/containers/update-product-price-point-price-point-id.md) | Template, Required | This is a container for one-of cases. |
| `body` | [`UpdateProductPricePointRequest`](../../doc/models/update-product-price-point-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.ProductPricePointResponse>`](../../doc/models/product-price-point-response.md)

## Example Usage

```csharp
UpdateProductPricePointProductId productId = UpdateProductPricePointProductId.FromNumber(124);

UpdateProductPricePointPricePointId pricePointId = UpdateProductPricePointPricePointId.FromNumber(188);

UpdateProductPricePointRequest body = new UpdateProductPricePointRequest
{
    PricePoint = new UpdateProductPricePoint
    {
        Handle = "educational",
        PriceInCents = 1250L,
    },
};

try
{
    ProductPricePointResponse result = await productPricePointsController.UpdateProductPricePointAsync(
        productId,
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
  "price_point": {
    "id": 283,
    "name": "Educational",
    "handle": "educational",
    "price_in_cents": 1000,
    "interval": 1,
    "interval_unit": "month",
    "trial_price_in_cents": 4900,
    "trial_interval": 1,
    "trial_interval_unit": "month",
    "trial_type": "payment_expected",
    "initial_charge_in_cents": 120000,
    "initial_charge_after_trial": false,
    "expiration_interval": 12,
    "expiration_interval_unit": "month",
    "product_id": 901,
    "archived_at": "2023-11-30T06:37:20-05:00",
    "created_at": "2023-11-27T06:37:20-05:00",
    "updated_at": "2023-11-27T06:37:20-05:00"
  }
}
```


# Read Product Price Point

Use this endpoint to retrieve details for a specific product price point. You can achieve this by using either the product price point ID or handle.

```csharp
ReadProductPricePointAsync(
    ReadProductPricePointProductId productId,
    ReadProductPricePointPricePointId pricePointId,
    bool? currencyPrices = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | [`ReadProductPricePointProductId`](../../doc/models/containers/read-product-price-point-product-id.md) | Template, Required | This is a container for one-of cases. |
| `pricePointId` | [`ReadProductPricePointPricePointId`](../../doc/models/containers/read-product-price-point-price-point-id.md) | Template, Required | This is a container for one-of cases. |
| `currencyPrices` | `bool?` | Query, Optional | When fetching a product's price points, if you have defined multiple currencies at the site level, you can optionally pass the ?currency_prices=true query param to include an array of currency price data in the response. If the product price point is set to use_site_exchange_rate: true, it will return pricing based on the current exchange rate. If the flag is set to false, it will return all of the defined prices for each currency. |

## Response Type

[`Task<Models.ProductPricePointResponse>`](../../doc/models/product-price-point-response.md)

## Example Usage

```csharp
ReadProductPricePointProductId productId = ReadProductPricePointProductId.FromNumber(124);

ReadProductPricePointPricePointId pricePointId = ReadProductPricePointPricePointId.FromNumber(188);

try
{
    ProductPricePointResponse result = await productPricePointsController.ReadProductPricePointAsync(
        productId,
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
    "id": 283,
    "name": "Educational",
    "handle": "educational",
    "price_in_cents": 1000,
    "interval": 1,
    "interval_unit": "month",
    "trial_price_in_cents": 4900,
    "trial_interval": 1,
    "trial_interval_unit": "month",
    "trial_type": "payment_expected",
    "initial_charge_in_cents": 120000,
    "initial_charge_after_trial": false,
    "expiration_interval": 12,
    "expiration_interval_unit": "month",
    "product_id": 901,
    "archived_at": "2023-11-30T06:37:20-05:00",
    "created_at": "2023-11-27T06:37:20-05:00",
    "updated_at": "2023-11-27T06:37:20-05:00"
  }
}
```


# Archive Product Price Point

Use this endpoint to archive a product price point.

```csharp
ArchiveProductPricePointAsync(
    ArchiveProductPricePointProductId productId,
    ArchiveProductPricePointPricePointId pricePointId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | [`ArchiveProductPricePointProductId`](../../doc/models/containers/archive-product-price-point-product-id.md) | Template, Required | This is a container for one-of cases. |
| `pricePointId` | [`ArchiveProductPricePointPricePointId`](../../doc/models/containers/archive-product-price-point-price-point-id.md) | Template, Required | This is a container for one-of cases. |

## Response Type

[`Task<Models.ProductPricePointResponse>`](../../doc/models/product-price-point-response.md)

## Example Usage

```csharp
ArchiveProductPricePointProductId productId = ArchiveProductPricePointProductId.FromNumber(124);

ArchiveProductPricePointPricePointId pricePointId = ArchiveProductPricePointPricePointId.FromNumber(188);

try
{
    ProductPricePointResponse result = await productPricePointsController.ArchiveProductPricePointAsync(
        productId,
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
    "id": 283,
    "name": "Educational",
    "handle": "educational",
    "price_in_cents": 1000,
    "interval": 1,
    "interval_unit": "month",
    "trial_price_in_cents": 4900,
    "trial_interval": 1,
    "trial_interval_unit": "month",
    "trial_type": "payment_expected",
    "initial_charge_in_cents": 120000,
    "initial_charge_after_trial": false,
    "expiration_interval": 12,
    "expiration_interval_unit": "month",
    "product_id": 901,
    "archived_at": "2023-11-30T06:37:20-05:00",
    "created_at": "2023-11-27T06:37:20-05:00",
    "updated_at": "2023-11-27T06:37:20-05:00"
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# Unarchive Product Price Point

Use this endpoint to unarchive an archived product price point.

```csharp
UnarchiveProductPricePointAsync(
    int productId,
    int pricePointId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | `int` | Template, Required | The Advanced Billing id of the product to which the price point belongs |
| `pricePointId` | `int` | Template, Required | The Advanced Billing id of the product price point |

## Response Type

[`Task<Models.ProductPricePointResponse>`](../../doc/models/product-price-point-response.md)

## Example Usage

```csharp
int productId = 202;
int pricePointId = 10;
try
{
    ProductPricePointResponse result = await productPricePointsController.UnarchiveProductPricePointAsync(
        productId,
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
    "id": 283,
    "name": "Educational",
    "handle": "educational",
    "price_in_cents": 1000,
    "interval": 1,
    "interval_unit": "month",
    "trial_price_in_cents": 4900,
    "trial_interval": 1,
    "trial_interval_unit": "month",
    "trial_type": "payment_expected",
    "initial_charge_in_cents": 120000,
    "initial_charge_after_trial": false,
    "expiration_interval": 12,
    "expiration_interval_unit": "month",
    "product_id": 901,
    "archived_at": "2023-11-30T06:37:20-05:00",
    "created_at": "2023-11-27T06:37:20-05:00",
    "updated_at": "2023-11-27T06:37:20-05:00"
  }
}
```


# Promote Product Price Point to Default

Use this endpoint to make a product price point the default for the product.

Note: Custom product price points are not able to be set as the default for a product.

```csharp
PromoteProductPricePointToDefaultAsync(
    int productId,
    int pricePointId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | `int` | Template, Required | The Advanced Billing id of the product to which the price point belongs |
| `pricePointId` | `int` | Template, Required | The Advanced Billing id of the product price point |

## Response Type

[`Task<Models.ProductResponse>`](../../doc/models/product-response.md)

## Example Usage

```csharp
int productId = 202;
int pricePointId = 10;
try
{
    ProductResponse result = await productPricePointsController.PromoteProductPricePointToDefaultAsync(
        productId,
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
  "product": {
    "id": 29778,
    "name": "Educational",
    "handle": "educational",
    "description": null,
    "accounting_code": null,
    "request_credit_card": true,
    "expiration_interval": 12,
    "expiration_interval_unit": "month",
    "created_at": "2023-12-01T06:56:12-05:00",
    "updated_at": "2023-12-01T06:56:26-05:00",
    "price_in_cents": 100,
    "interval": 2,
    "interval_unit": "month",
    "initial_charge_in_cents": 120000,
    "trial_price_in_cents": 4900,
    "trial_interval": 1,
    "trial_interval_unit": "month",
    "archived_at": null,
    "require_credit_card": true,
    "return_params": null,
    "taxable": false,
    "update_return_url": null,
    "tax_code": null,
    "initial_charge_after_trial": false,
    "version_number": 1,
    "update_return_params": null,
    "default_product_price_point_id": 32395,
    "request_billing_address": false,
    "require_billing_address": false,
    "require_shipping_address": false,
    "use_site_exchange_rate": true,
    "item_category": null,
    "product_price_point_id": 32395,
    "product_price_point_name": "Default",
    "product_price_point_handle": "uuid:8c878f50-726e-013c-c71b-0286551bb34f",
    "product_family": {
      "id": 933860,
      "name": "Acme Projects",
      "description": "Amazing project management tool",
      "handle": "acme-projects",
      "accounting_code": null,
      "created_at": "2023-12-01T06:56:12-05:00",
      "updated_at": "2023-12-01T06:56:12-05:00"
    }
  }
}
```


# Bulk Create Product Price Points

Use this endpoint to create multiple product price points in one request.

```csharp
BulkCreateProductPricePointsAsync(
    int productId,
    Models.BulkCreateProductPricePointsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productId` | `int` | Template, Required | The Advanced Billing id of the product to which the price points belong |
| `body` | [`BulkCreateProductPricePointsRequest`](../../doc/models/bulk-create-product-price-points-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.BulkCreateProductPricePointsResponse>`](../../doc/models/bulk-create-product-price-points-response.md)

## Example Usage

```csharp
int productId = 202;
BulkCreateProductPricePointsRequest body = new BulkCreateProductPricePointsRequest
{
    PricePoints = new List<CreateProductPricePoint>
    {
        new CreateProductPricePoint
        {
            Name = "Educational",
            PriceInCents = 1000L,
            Interval = 1,
            IntervalUnit = IntervalUnit.Month,
            Handle = "educational",
            TrialPriceInCents = 4900L,
            TrialInterval = 1,
            TrialIntervalUnit = IntervalUnit.Month,
            TrialType = "payment_expected",
            InitialChargeInCents = 120000L,
            InitialChargeAfterTrial = false,
            ExpirationInterval = 12,
            ExpirationIntervalUnit = ExpirationIntervalUnit.Month,
        },
        new CreateProductPricePoint
        {
            Name = "More Educational",
            PriceInCents = 2000L,
            Interval = 1,
            IntervalUnit = IntervalUnit.Month,
            Handle = "more-educational",
            TrialPriceInCents = 4900L,
            TrialInterval = 1,
            TrialIntervalUnit = IntervalUnit.Month,
            TrialType = "payment_expected",
            InitialChargeInCents = 120000L,
            InitialChargeAfterTrial = false,
            ExpirationInterval = 12,
            ExpirationIntervalUnit = ExpirationIntervalUnit.Month,
        },
    },
};

try
{
    BulkCreateProductPricePointsResponse result = await productPricePointsController.BulkCreateProductPricePointsAsync(
        productId,
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
      "id": 283,
      "name": "Educational",
      "handle": "educational",
      "price_in_cents": 1000,
      "interval": 1,
      "interval_unit": "month",
      "trial_price_in_cents": 4900,
      "trial_interval": 1,
      "trial_interval_unit": "month",
      "trial_type": "payment_expected",
      "initial_charge_in_cents": 120000,
      "initial_charge_after_trial": false,
      "expiration_interval": 12,
      "expiration_interval_unit": "month",
      "product_id": 901,
      "archived_at": "2023-11-30T06:37:20-05:00",
      "created_at": "2023-11-27T06:37:20-05:00",
      "updated_at": "2023-11-27T06:37:20-05:00"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | `ApiException` |


# Create Product Currency Prices

This endpoint allows you to create currency prices for a given currency that has been defined on the site level in your settings.

When creating currency prices, they need to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.

Note: Currency Prices are not able to be created for custom product price points.

```csharp
CreateProductCurrencyPricesAsync(
    int productPricePointId,
    Models.CreateProductCurrencyPricesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productPricePointId` | `int` | Template, Required | The Advanced Billing id of the product price point |
| `body` | [`CreateProductCurrencyPricesRequest`](../../doc/models/create-product-currency-prices-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.CurrencyPricesResponse>`](../../doc/models/currency-prices-response.md)

## Example Usage

```csharp
int productPricePointId = 234;
CreateProductCurrencyPricesRequest body = new CreateProductCurrencyPricesRequest
{
    CurrencyPrices = new List<CreateProductCurrencyPrice>
    {
        new CreateProductCurrencyPrice
        {
            Currency = "EUR",
            Price = 60,
            Role = CurrencyPriceRole.Baseline,
        },
        new CreateProductCurrencyPrice
        {
            Currency = "EUR",
            Price = 30,
            Role = CurrencyPriceRole.Trial,
        },
        new CreateProductCurrencyPrice
        {
            Currency = "EUR",
            Price = 100,
            Role = CurrencyPriceRole.Initial,
        },
    },
};

try
{
    CurrencyPricesResponse result = await productPricePointsController.CreateProductCurrencyPricesAsync(
        productPricePointId,
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
      "price": 123,
      "formatted_price": "€123,00",
      "product_price_point_id": 32669,
      "role": "baseline"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |


# Update Product Currency Prices

This endpoint allows you to update the `price`s of currency prices for a given currency that exists on the product price point.

When updating the pricing, it needs to mirror the structure of your primary pricing. If the product price point defines a trial and/or setup fee, each currency must also define a trial and/or setup fee.

Note: Currency Prices are not able to be updated for custom product price points.

```csharp
UpdateProductCurrencyPricesAsync(
    int productPricePointId,
    Models.UpdateCurrencyPricesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `productPricePointId` | `int` | Template, Required | The Advanced Billing id of the product price point |
| `body` | [`UpdateCurrencyPricesRequest`](../../doc/models/update-currency-prices-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.CurrencyPricesResponse>`](../../doc/models/currency-prices-response.md)

## Example Usage

```csharp
int productPricePointId = 234;
UpdateCurrencyPricesRequest body = new UpdateCurrencyPricesRequest
{
    CurrencyPrices = new List<UpdateCurrencyPrice>
    {
        new UpdateCurrencyPrice
        {
            Id = 200,
            Price = 15,
        },
        new UpdateCurrencyPrice
        {
            Id = 201,
            Price = 5,
        },
    },
};

try
{
    CurrencyPricesResponse result = await productPricePointsController.UpdateProductCurrencyPricesAsync(
        productPricePointId,
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
      "id": 123,
      "currency": "EUR",
      "price": 100,
      "formatted_price": "€123,00",
      "product_price_point_id": 32669,
      "role": "baseline"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorArrayMapResponseException`](../../doc/models/error-array-map-response-exception.md) |


# List All Product Price Points

This method allows retrieval of a list of Products Price Points belonging to a Site.

```csharp
ListAllProductPricePointsAsync(
    Models.ListAllProductPricePointsInput input)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `direction` | [`SortingDirection?`](../../doc/models/sorting-direction.md) | Query, Optional | Controls the order in which results are returned.<br>Use in query `direction=asc`. |
| `filter` | [`ListPricePointsFilter`](../../doc/models/list-price-points-filter.md) | Query, Optional | Filter to use for List PricePoints operations |
| `include` | [`ListProductsPricePointsInclude?`](../../doc/models/list-products-price-points-include.md) | Query, Optional | Allows including additional data in the response. Use in query: `include=currency_prices`. |
| `page` | `int?` | Query, Optional | Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.<br>Use in query `page=1`.<br>**Default**: `1`<br>**Constraints**: `>= 1` |
| `perPage` | `int?` | Query, Optional | This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.<br>Use in query `per_page=200`.<br>**Default**: `20`<br>**Constraints**: `<= 200` |

## Response Type

[`Task<Models.ListProductPricePointsResponse>`](../../doc/models/list-product-price-points-response.md)

## Example Usage

```csharp
ListAllProductPricePointsInput listAllProductPricePointsInput = new ListAllProductPricePointsInput
{
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
    Include = ListProductsPricePointsInclude.CurrencyPrices,
    Page = 2,
    PerPage = 50,
};

try
{
    ListProductPricePointsResponse result = await productPricePointsController.ListAllProductPricePointsAsync(listAllProductPricePointsInput);
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
      "id": 0,
      "name": "My pricepoint",
      "handle": "handle",
      "price_in_cents": 10,
      "interval": 5,
      "interval_unit": "month",
      "trial_price_in_cents": 10,
      "trial_interval": 1,
      "trial_interval_unit": "month",
      "trial_type": "payment_expected",
      "introductory_offer": true,
      "initial_charge_in_cents": 0,
      "initial_charge_after_trial": true,
      "expiration_interval": 0,
      "expiration_interval_unit": "month",
      "product_id": 1230,
      "created_at": "2021-04-02T17:52:09-04:00",
      "updated_at": "2021-04-02T17:52:09-04:00",
      "use_site_exchange_rate": true
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |

