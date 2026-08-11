
# Payment Collection Method Changed

## Structure

`PaymentCollectionMethodChanged`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PreviousValue` | `string` | Required | - |
| `CurrentValue` | `string` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PaymentCollectionMethodChanged paymentCollectionMethodChanged = new PaymentCollectionMethodChanged
{
    PreviousValue = "previous_value4",
    CurrentValue = "current_value2",
};
```

