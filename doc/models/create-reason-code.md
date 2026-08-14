
# Create Reason Code

## Structure

`CreateReasonCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Required | The unique identifier for the ReasonCode |
| `Description` | `string` | Required | The friendly summary of what the code signifies |
| `Position` | `int?` | Optional | The order that code appears in lists |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateReasonCode createReasonCode = new CreateReasonCode
{
    Code = "code4",
    Description = "description6",
    Position = 40,
};
```

