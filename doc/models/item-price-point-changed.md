
# Item Price Point Changed

## Structure

`ItemPricePointChanged`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ItemId` | `int` | Required | - |
| `ItemType` | `string` | Required | - |
| `ItemHandle` | `string` | Required | - |
| `ItemName` | `string` | Required | - |
| `PreviousPricePoint` | [`ItemPricePointData`](../../doc/models/item-price-point-data.md) | Required | - |
| `CurrentPricePoint` | [`ItemPricePointData`](../../doc/models/item-price-point-data.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ItemPricePointChanged itemPricePointChanged = new ItemPricePointChanged
{
    ItemId = 30,
    ItemType = "item_type6",
    ItemHandle = "item_handle4",
    ItemName = "item_name8",
    PreviousPricePoint = new ItemPricePointData
    {
        Id = 216,
        Handle = "handle6",
        Name = "name0",
    },
    CurrentPricePoint = new ItemPricePointData
    {
        Id = 218,
        Handle = "handle6",
        Name = "name0",
    },
};
```

