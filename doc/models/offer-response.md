
# Offer Response

## Structure

`OfferResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Offer` | [`Offer`](../../doc/models/offer.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

OfferResponse offerResponse = new OfferResponse
{
    Offer = new Offer
    {
        Id = 28,
        SiteId = 210,
        ProductFamilyId = 224,
        ProductId = 30,
        ProductPricePointId = 150,
    },
};
```

