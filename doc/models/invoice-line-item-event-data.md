
# Invoice Line Item Event Data

## Structure

`InvoiceLineItemEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Title` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `QuantityDelta` | `int?` | Optional | - |
| `UnitPrice` | `string` | Optional | - |
| `PeriodRangeStart` | `string` | Optional | - |
| `PeriodRangeEnd` | `string` | Optional | - |
| `Amount` | `string` | Optional | - |
| `LineReferences` | `string` | Optional | - |
| `PricingDetailsIndex` | `int?` | Optional | - |
| `PricingDetails` | [`List<InvoiceLineItemPricingDetail>`](../../doc/models/invoice-line-item-pricing-detail.md) | Optional | - |
| `TaxCode` | `string` | Optional | - |
| `TaxAmount` | `string` | Optional | - |
| `ProductId` | `int?` | Optional | - |
| `ProductPricePointId` | `int?` | Optional | - |
| `PricePointId` | `int?` | Optional | - |
| `ComponentId` | `int?` | Optional | - |
| `BillingScheduleItemId` | `int?` | Optional | - |
| `CustomItem` | `bool?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

InvoiceLineItemEventData invoiceLineItemEventData = new InvoiceLineItemEventData
{
    Uid = "uid4",
    Title = "title0",
    Description = "description4",
    Quantity = 190,
    QuantityDelta = 36,
};
```

