
# Create Wallet Adjustment Request

A signed correction to a specific grant's balance, or to an overdraft entry's usage, intended for support and ops use.

## Structure

`CreateWalletAdjustmentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Adjustment` | [`Adjustment`](../../doc/models/adjustment.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateWalletAdjustmentRequest createWalletAdjustmentRequest = new CreateWalletAdjustmentRequest
{
    Adjustment = new Adjustment
    {
        Amount = AdjustmentAmount.FromString("String7"),
        Reason = "reason0",
        GrantId = 104,
        SourceTransactionId = 126,
        ExpectedRemaining = "expected_remaining6",
        ExpectedSourceCorrections = "expected_source_corrections8",
    },
};
```

