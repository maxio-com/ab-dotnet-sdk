
# Offer

## Structure

`Offer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `SiteId` | `int?` | Optional | - |
| `ProductFamilyId` | `int?` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `ProductRevisableNumber` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `ArchivedAt` | `DateTimeOffset?` | Optional | - |
| `OfferItems` | [`List<OfferItem>`](../../doc/models/offer-item.md) | Optional | - |
| `OfferDiscounts` | [`List<OfferDiscount>`](../../doc/models/offer-discount.md) | Optional | - |
| `ProductFamilyName` | `string` | Optional | - |
| `ProductName` | `string` | Optional | - |
| `ProductPricePointName` | `string` | Optional | - |
| `ProductPriceInCents` | `long?` | Optional | - |
| `OfferSignupPages` | [`List<OfferSignupPage>`](../../doc/models/offer-signup-page.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

Offer offer = new Offer
{
    Id = 28,
    SiteId = 210,
    ProductFamilyId = 224,
    ProductId = 30,
    ProductPricePointId = 150,
};
```

