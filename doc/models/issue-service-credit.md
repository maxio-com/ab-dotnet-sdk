
# Issue Service Credit

## Structure

`IssueServiceCredit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`IssueServiceCreditAmount`](../../doc/models/containers/issue-service-credit-amount.md) | Required | This is a container for one-of cases. |
| `Memo` | `string` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

IssueServiceCredit issueServiceCredit = new IssueServiceCredit
{
    Amount = IssueServiceCreditAmount.FromPrecision(44.88),
    Memo = "memo6",
};
```

