
# Create Reason Code Request

## Structure

`CreateReasonCodeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReasonCode` | [`CreateReasonCode`](../../doc/models/create-reason-code.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateReasonCodeRequest createReasonCodeRequest = new CreateReasonCodeRequest
{
    ReasonCode = new CreateReasonCode
    {
        Code = "code4",
        Description = "description6",
        Position = 14,
    },
};
```

