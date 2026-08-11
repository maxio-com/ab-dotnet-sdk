
# Group Settings

## Structure

`GroupSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Target` | [`GroupTarget`](../../doc/models/group-target.md) | Required | Attributes of the target customer who will be the responsible payer of the created subscription. Required. |
| `Billing` | [`GroupBilling`](../../doc/models/group-billing.md) | Optional | (Optional) Attributes related to billing date and accrual. Note: Only applicable for new subscriptions. |

## Example

```csharp
using AdvancedBilling.Standard.Models;

GroupSettings groupSettings = new GroupSettings
{
    Target = new GroupTarget
    {
        Type = GroupTargetType.Parent,
        Id = 236,
    },
    Billing = new GroupBilling
    {
        Accrue = false,
        AlignDate = false,
        Prorate = false,
    },
};
```

