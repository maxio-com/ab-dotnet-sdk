
# Wallet Products List Response

## Structure

`WalletProductsListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WalletProducts` | [`List<WalletProductListItem>`](../../doc/models/wallet-product-list-item.md) | Required | - |
| `TotalCount` | `int` | Required | Total number of Wallet Products matching the filters, across all pages. |
| `ArchivedCount` | `int` | Required | Not a simple count of archived products matching the filters. With `status=archived`, equals `total_count` (there's nothing else to report). With any other `status`, it's `0` whenever `total_count` is non-zero, and only when `total_count` is `0` does it become the number of archived Wallet Products matching the same `q` search term (ignoring `status`): an empty-state hint, not a running total. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

WalletProductsListResponse walletProductsListResponse = new WalletProductsListResponse
{
    WalletProducts = new List<WalletProductListItem>
    {
        new WalletProductListItem
        {
            Id = 70,
            Name = "name4",
            Handle = "handle0",
            PricingScheme = PricingScheme.Stairstep,
            UnitName = "unit_name6",
            ItemCategory = ItemCategory.EnumBusinessSoftware,
        },
    },
    TotalCount = 214,
    ArchivedCount = 238,
};
```

