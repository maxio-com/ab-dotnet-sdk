
# Create Offer

## Structure

`CreateOffer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Handle` | `string` | Required | - |
| `Description` | `string` | Optional | - |
| `ProductId` | `int` | Required | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `Components` | [`List<CreateOfferComponent>`](../../doc/models/create-offer-component.md) | Optional | - |
| `Coupons` | `List<string>` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CreateOffer createOffer = new CreateOffer
{
    Name = "name6",
    Handle = "handle2",
    ProductId = 66,
    Description = "description6",
    ProductPricePointId = 246,
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
        "coupons5",
        "coupons4",
    },
};
```

