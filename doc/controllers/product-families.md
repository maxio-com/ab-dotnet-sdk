# Product Families

```csharp
ProductFamiliesController productFamiliesController = client.ProductFamiliesController;
```

## Class Name

`ProductFamiliesController`

## Methods

* [List Products for Product Family](../../doc/controllers/product-families.md#list-products-for-product-family)
* [Create Product Family](../../doc/controllers/product-families.md#create-product-family)
* [List Product Families](../../doc/controllers/product-families.md#list-product-families)
* [Read Product Family](../../doc/controllers/product-families.md#read-product-family)


# List Products for Product Family

Retrieves a list of Products belonging to a Product Family.

```csharp
ListProductsForProductFamilyAsync(
    Models.ListProductsForProductFamilyInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListProductsForProductFamilyInput`](../../doc/models/list-products-for-product-family-input.md) | Required | Input structure for the method ListProductsForProductFamily |

## Response Type

**200**: OK

[`Task<List<Models.ProductResponse>>`](../../doc/models/product-response.md)

## Example Usage

```csharp
ListProductsForProductFamilyInput listProductsForProductFamilyInput = new ListProductsForProductFamilyInput
{
    ProductFamilyId = "product_family_id4",
    Page = 1,
    PerPage = 50,
    DateField = BasicDateField.UpdatedAt,
    Filter = new ListProductsFilter
    {
        Ids = new List<int>
        {
            1,
            2,
            3,
        },
    },
    Include = ListProductsInclude.PrepaidProductPricePoint,
};

try
{
    List<ProductResponse> result = await productFamiliesController.ListProductsForProductFamilyAsync(listProductsForProductFamilyInput);
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
    "product": {
      "id": 3801242,
      "name": "Free product",
      "handle": "zero-dollar-product",
      "description": "",
      "accounting_code": "",
      "request_credit_card": true,
      "expiration_interval": null,
      "expiration_interval_unit": "never",
      "created_at": "2016-04-21T16:08:39-04:00",
      "updated_at": "2016-08-03T11:27:53-04:00",
      "price_in_cents": 10000,
      "interval": 1,
      "interval_unit": "month",
      "initial_charge_in_cents": 0,
      "trial_price_in_cents": null,
      "trial_interval": null,
      "trial_interval_unit": "month",
      "archived_at": null,
      "require_credit_card": false,
      "return_params": "",
      "taxable": false,
      "update_return_url": "",
      "initial_charge_after_trial": false,
      "version_number": 4,
      "update_return_params": "",
      "product_family": {
        "id": 527890,
        "name": "Acme Projects",
        "description": "",
        "handle": "billing-plans",
        "accounting_code": null
      },
      "public_signup_pages": [
        {
          "id": 283460,
          "return_url": null,
          "return_params": "",
          "url": "https://general-goods.chargify.com/subscribe/smcc4j3d2w6h/zero-dollar-product"
        }
      ],
      "product_price_point_name": "Default",
      "use_site_exchange_rate": true
    }
  },
  {
    "product": {
      "id": 3858146,
      "name": "Calendar Billing Product",
      "handle": "calendar-billing-product",
      "description": "",
      "accounting_code": "",
      "request_credit_card": true,
      "expiration_interval": null,
      "expiration_interval_unit": "never",
      "created_at": "2016-07-05T13:07:38-04:00",
      "updated_at": "2016-07-05T13:07:38-04:00",
      "price_in_cents": 10000,
      "interval": 1,
      "interval_unit": "month",
      "initial_charge_in_cents": null,
      "trial_price_in_cents": null,
      "trial_interval": null,
      "trial_interval_unit": "month",
      "archived_at": null,
      "require_credit_card": true,
      "return_params": "",
      "taxable": false,
      "update_return_url": "",
      "initial_charge_after_trial": false,
      "version_number": 1,
      "update_return_params": "",
      "product_family": {
        "id": 527890,
        "name": "Acme Projects",
        "description": "",
        "handle": "billing-plans",
        "accounting_code": null
      },
      "public_signup_pages": [
        {
          "id": 289193,
          "return_url": "",
          "return_params": "",
          "url": "https://general-goods.chargify.com/subscribe/gxdbfxzxhcjq/calendar-billing-product"
        }
      ],
      "product_price_point_name": "Default",
      "use_site_exchange_rate": true
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Not Found | `ApiException` |


# Create Product Family

Creates a Product Family within your Advanced Billing site. Create a Product Family to act as a container for your products, components, and coupons.

Full documentation on how Product Families operate within the Advanced Billing UI can be located [here](https://maxio.zendesk.com/hc/en-us/articles/24261098936205-Product-Families).

```csharp
CreateProductFamilyAsync(
    Models.CreateProductFamilyRequest body = null)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateProductFamilyRequest`](../../doc/models/create-product-family-request.md) | Body, Optional | - |

## Response Type

**201**: Created

[`Task<Models.ProductFamilyResponse>`](../../doc/models/product-family-response.md)

## Example Usage

```csharp
CreateProductFamilyRequest body = new CreateProductFamilyRequest
{
    ProductFamily = new CreateProductFamily
    {
        Name = "Acme Projects",
        Description = "Amazing project management tool",
    },
};

try
{
    ProductFamilyResponse result = await productFamiliesController.CreateProductFamilyAsync(body);
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
  "product_family": {
    "id": 933860,
    "name": "Acme Projects",
    "description": "Amazing project management tool",
    "handle": "acme-projects",
    "accounting_code": null
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 422 | Unprocessable Entity (WebDAV) | [`ErrorListResponseException`](../../doc/models/error-list-response-exception.md) |


# List Product Families

Returns a list of Product Families for a site.

```csharp
ListProductFamiliesAsync(
    Models.ListProductFamiliesInput input)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `input` | [`Models.ListProductFamiliesInput`](../../doc/models/list-product-families-input.md) | Required | Input structure for the method ListProductFamilies |

## Response Type

**200**: OK

[`Task<List<Models.ProductFamilyResponse>>`](../../doc/models/product-family-response.md)

## Example Usage

```csharp
ListProductFamiliesInput listProductFamiliesInput = new ListProductFamiliesInput
{
    DateField = BasicDateField.UpdatedAt,
};

try
{
    List<ProductFamilyResponse> result = await productFamiliesController.ListProductFamiliesAsync(listProductFamiliesInput);
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
    "product_family": {
      "id": 37,
      "name": "Acme Projects",
      "description": null,
      "handle": "acme-projects",
      "accounting_code": null,
      "created_at": "2013-02-20T15:05:51-07:00",
      "updated_at": "2013-02-20T15:05:51-07:00",
      "archived_at": null
    }
  },
  {
    "product_family": {
      "id": 155,
      "name": "Bat Family",
      "description": "Another family.",
      "handle": "bat-family",
      "accounting_code": null,
      "created_at": "2014-04-16T12:41:13-06:00",
      "updated_at": "2014-04-16T12:41:13-06:00",
      "archived_at": "2024-11-05T09:30:00-07:00"
    }
  }
]
```


# Read Product Family

Retrieves a Product Family via the `product_family_id`. The response will contain a Product Family object.

The product family can be specified either with the id number, or with the `handle:my-family` format.

```csharp
ReadProductFamilyAsync(
    int id)
```

## Authentication

This endpoint requires [BasicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `int` | Template, Required | The Advanced Billing id of the product family |

## Response Type

**200**: OK

[`Task<Models.ProductFamilyResponse>`](../../doc/models/product-family-response.md)

## Example Usage

```csharp
int id = 112;
try
{
    ProductFamilyResponse result = await productFamiliesController.ReadProductFamilyAsync(id);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "product_family": {
    "id": 527890,
    "name": "Acme Projects",
    "description": "",
    "handle": "billing-plans",
    "accounting_code": null,
    "archived_at": null
  }
}
```

