
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

## Example (as JSON)

```json
{
  "uid": "uid4",
  "title": "title0",
  "description": "description6",
  "quantity": 40,
  "quantity_delta": 114
}
```

