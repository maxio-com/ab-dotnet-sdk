
# Update Reason Code Request

## Structure

`UpdateReasonCodeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReasonCode` | [`UpdateReasonCode`](../../doc/models/update-reason-code.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateReasonCodeRequest updateReasonCodeRequest = new UpdateReasonCodeRequest
{
    ReasonCode = new UpdateReasonCode
    {
        Code = "code4",
        Description = "description6",
        Position = 14,
    },
};
```

