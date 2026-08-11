
# Prepaid Subscription Balance Changed

## Structure

`PrepaidSubscriptionBalanceChanged`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Reason` | `string` | Required | - |
| `CurrentAccountBalanceInCents` | `long` | Required | - |
| `PrepaymentAccountBalanceInCents` | `long` | Required | - |
| `CurrentUsageAmountInCents` | `long` | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

PrepaidSubscriptionBalanceChanged prepaidSubscriptionBalanceChanged = new PrepaidSubscriptionBalanceChanged
{
    Reason = "reason6",
    CurrentAccountBalanceInCents = 194L,
    PrepaymentAccountBalanceInCents = 100L,
    CurrentUsageAmountInCents = 186L,
};
```

