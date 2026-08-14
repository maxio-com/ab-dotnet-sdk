
# Change Invoice Collection Method Event Data

Example schema for an `change_invoice_collection_method` event

## Structure

`ChangeInvoiceCollectionMethodEventData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FromCollectionMethod` | `string` | Required | The previous collection method of the invoice. |
| `ToCollectionMethod` | `string` | Required | The new collection method of the invoice. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ChangeInvoiceCollectionMethodEventData changeInvoiceCollectionMethodEventData = new ChangeInvoiceCollectionMethodEventData
{
    FromCollectionMethod = "from_collection_method8",
    ToCollectionMethod = "to_collection_method4",
};
```

