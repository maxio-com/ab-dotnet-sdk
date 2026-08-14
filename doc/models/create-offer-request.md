
# Create Offer Request

## Structure

`CreateOfferRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Offer` | [`CreateOffer`](../../doc/models/create-offer.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateOfferRequest createOfferRequest = new CreateOfferRequest
{
    Offer = new CreateOffer
    {
        Name = "name4",
        Handle = "handle0",
        ProductId = 30,
        Description = "description6",
        ProductPricePointId = 150,
        Components = new List<CreateOfferComponent>
        {
            new CreateOfferComponent
            {
                ComponentId = 108,
                PricePointId = 124,
                StartingQuantity = 84,
            },
            new CreateOfferComponent
            {
                ComponentId = 108,
                PricePointId = 124,
                StartingQuantity = 84,
            },
        },
        Coupons = new List<string>
        {
            "coupons6",
        },
    },
};
```

