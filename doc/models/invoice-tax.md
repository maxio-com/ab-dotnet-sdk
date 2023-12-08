
# Invoice Tax

## Structure

`InvoiceTax`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Title` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `SourceType` | `string` | Optional | - |
| `SourceId` | `int?` | Optional | - |
| `Percentage` | `string` | Optional | - |
| `TaxableAmount` | `string` | Optional | - |
| `TaxAmount` | `string` | Optional | - |
| `TransactionId` | `int?` | Optional | - |
| `LineItemBreakouts` | [`List<InvoiceTaxBreakout>`](../../doc/models/invoice-tax-breakout.md) | Optional | - |
| `TaxComponentBreakouts` | [`List<InvoiceTaxComponentBreakout>`](../../doc/models/invoice-tax-component-breakout.md) | Optional | - |

## Example (as JSON)

```json
{
  "uid": "uid8",
  "title": "title6",
  "description": "description2",
  "source_type": "source_type8",
  "source_id": 164
}
```

