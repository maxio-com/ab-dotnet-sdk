
# Issue Service Credit Request

## Structure

`IssueServiceCreditRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceCredit` | [`IssueServiceCredit`](../../doc/models/issue-service-credit.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

IssueServiceCreditRequest issueServiceCreditRequest = new IssueServiceCreditRequest
{
    ServiceCredit = new IssueServiceCredit
    {
        Amount = IssueServiceCreditAmount.FromPrecision(31.42),
        Memo = "memo0",
    },
};
```

