
# Product

## Structure

`Product`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | The product name |
| `Handle` | `string` | Optional | The product API handle |
| `Description` | `string` | Optional | The product description |
| `AccountingCode` | `string` | Optional | E.g. Internal ID or SKU Number |
| `RequestCreditCard` | `bool?` | Optional | Deprecated value that can be ignored unless you have legacy hosted pages. For Public Signup Page users, please read this attribute from under the signup page. |
| `ExpirationInterval` | `int?` | Optional | A numerical interval for the length a subscription to this product will run before it expires. See the description of interval for a description of how this value is coupled with an interval unit to calculate the full interval |
| `ExpirationIntervalUnit` | [`ProductExpirationIntervalUnit`](../../doc/models/containers/product-expiration-interval-unit.md) | Optional | This is a container for one-of cases. |
| `CreatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this product was created |
| `UpdatedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this product was last updated |
| `PriceInCents` | `long?` | Optional | The product price, in integer cents |
| `Interval` | `int?` | Optional | The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this product would renew every 30 days |
| `IntervalUnit` | [`IntervalUnit?`](../../doc/models/interval-unit.md) | Optional | A string representing the interval unit for this product, either month or day |
| `InitialChargeInCents` | `long?` | Optional | The up front charge you have specified. |
| `TrialPriceInCents` | `long?` | Optional | The price of the trial period for a subscription to this product, in integer cents. |
| `TrialInterval` | `int?` | Optional | A numerical interval for the length of the trial period of a subscription to this product. See the description of interval for a description of how this value is coupled with an interval unit to calculate the full interval |
| `TrialIntervalUnit` | [`ProductTrialIntervalUnit`](../../doc/models/containers/product-trial-interval-unit.md) | Optional | This is a container for one-of cases. |
| `ArchivedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this product was archived |
| `RequireCreditCard` | `bool?` | Optional | Boolean that controls whether a payment profile is required to be entered for customers wishing to sign up on this product. |
| `ReturnParams` | `string` | Optional | - |
| `Taxable` | `bool?` | Optional | - |
| `UpdateReturnUrl` | `string` | Optional | The url to which a customer will be returned after a successful account update |
| `InitialChargeAfterTrial` | `bool?` | Optional | - |
| `VersionNumber` | `int?` | Optional | The version of the product |
| `UpdateReturnParams` | `string` | Optional | The parameters will append to the url after a successful account update. See [help documentation](https://help.chargify.com/products/product-editing.html#return-parameters-after-account-update) |
| `ProductFamily` | [`ProductFamily`](../../doc/models/product-family.md) | Optional | - |
| `PublicSignupPages` | [`List<PublicSignupPage>`](../../doc/models/public-signup-page.md) | Optional | - |
| `ProductPricePointName` | `string` | Optional | - |
| `RequestBillingAddress` | `bool?` | Optional | A boolean indicating whether to request a billing address on any Self-Service Pages that are used by subscribers of this product. |
| `RequireBillingAddress` | `bool?` | Optional | A boolean indicating whether a billing address is required to add a payment profile, especially at signup. |
| `RequireShippingAddress` | `bool?` | Optional | A boolean indicating whether a shipping address is required for the customer, especially at signup. |
| `TaxCode` | `string` | Optional | A string representing the tax code related to the product type. This is especially important when using the Avalara service to tax based on locale. This attribute has a max length of 10 characters. |
| `DefaultProductPricePointId` | `int?` | Optional | - |
| `UseSiteExchangeRate` | `bool?` | Optional | - |
| `ItemCategory` | `string` | Optional | One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other |
| `ProductPricePointId` | `int?` | Optional | - |
| `ProductPricePointHandle` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "id": 180,
  "name": "name4",
  "handle": "handle0",
  "description": "description4",
  "accounting_code": "accounting_code0"
}
```

