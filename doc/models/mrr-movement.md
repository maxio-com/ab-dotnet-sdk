
# MRR Movement

## Structure

`MRRMovement`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | `int?` | Optional | - |
| `Category` | `string` | Optional | - |
| `SubscriberDelta` | `int?` | Optional | - |
| `LeadDelta` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

MRRMovement mRRMovement = new MRRMovement
{
    Amount = 116,
    Category = "category4",
    SubscriberDelta = 100,
    LeadDelta = 128,
};
```

