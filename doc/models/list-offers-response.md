
# List Offers Response

## Structure

`ListOffersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Offers` | [`List<Offer>`](../../doc/models/offer.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListOffersResponse listOffersResponse = new ListOffersResponse
{
    Offers = new List<Offer>
    {
        new Offer
        {
            Id = 12,
            SiteId = 194,
            ProductFamilyId = 16,
            ProductId = 210,
            ProductPricePointId = 134,
        },
    },
};
```

