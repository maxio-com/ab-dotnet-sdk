
# Reason Code Response

## Structure

`ReasonCodeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReasonCode` | [`ReasonCode`](../../doc/models/reason-code.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ReasonCodeResponse reasonCodeResponse = new ReasonCodeResponse
{
    ReasonCode = new ReasonCode
    {
        Id = 240,
        SiteId = 166,
        Code = "code4",
        Description = "description6",
        Position = 14,
    },
};
```

