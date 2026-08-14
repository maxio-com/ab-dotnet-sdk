
# List Subscription Groups Meta

## Structure

`ListSubscriptionGroupsMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrentPage` | `int?` | Optional | - |
| `TotalCount` | `int?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListSubscriptionGroupsMeta listSubscriptionGroupsMeta = new ListSubscriptionGroupsMeta
{
    CurrentPage = 104,
    TotalCount = 128,
};
```

