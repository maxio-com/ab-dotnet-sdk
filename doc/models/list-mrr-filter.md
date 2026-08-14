
# List Mrr Filter

## Structure

`ListMrrFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionIds` | `List<int>` | Optional | Submit ids in order to limit results. Use in query: `filter[subscription_ids]=1,2,3`.<br><br>**Constraints**: *Minimum Items*: `1` |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListMrrFilter listMrrFilter = new ListMrrFilter
{
    SubscriptionIds = new List<int>
    {
        1,
        2,
        3,
    },
};
```

