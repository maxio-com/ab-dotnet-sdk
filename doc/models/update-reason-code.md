
# Update Reason Code

## Structure

`UpdateReasonCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Optional | The unique identifier for the ReasonCode |
| `Description` | `string` | Optional | The friendly summary of what the code signifies |
| `Position` | `int?` | Optional | The order that code appears in lists |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateReasonCode updateReasonCode = new UpdateReasonCode
{
    Code = "code4",
    Description = "description6",
    Position = 4,
};
```

