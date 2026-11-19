
# Wallet Product Price Point Attributes

A price point to create for the Wallet Product, in the same call that creates or updates it.

## Structure

`WalletProductPricePointAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The price point's name. Required. Omitting it fails validation with a message that reads `Name: cannot be blank.`, not naming the price point. |
| `Handle` | `string` | Optional | - |
| `PricingScheme` | [`PricingScheme?`](../../doc/models/pricing-scheme.md) | Optional | The identifier for the pricing scheme. See [Product Components](https://help.chargify.com/products/product-components.html) for an overview of pricing schemes. |
| `UnitPrice` | `string` | Optional | Required when `pricing_scheme` is `per_unit`. |
| `TaxIncluded` | `bool?` | Optional | - |
| `Interval` | `int?` | Optional | Requires Multifrequency to be enabled on the site. |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | - |
| `UseSiteExchangeRate` | `bool?` | Optional | - |
| `Prices` | [`List<Price1>`](../../doc/models/price-1.md) | Optional | Required for every `pricing_scheme` other than `per_unit`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

WalletProductPricePointAttributes walletProductPricePointAttributes = new WalletProductPricePointAttributes
{
    Name = "name8",
    Handle = "handle4",
    PricingScheme = PricingScheme.PerUnit,
    UnitPrice = "unit_price6",
    TaxIncluded = false,
    Interval = 120,
};
```

