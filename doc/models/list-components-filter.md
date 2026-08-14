
# List Components Filter

## Structure

`ListComponentsFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ids` | `List<int>` | Optional | Allows fetching components with matching id based on provided value. Use in query `filter[ids]=1,2,3`.<br><br>**Constraints**: *Minimum Items*: `1` |
| `UseSiteExchangeRate` | `bool?` | Optional | Allows fetching components with matching use_site_exchange_rate based on provided value (refers to default price point). Use in query `filter[use_site_exchange_rate]=true`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListComponentsFilter listComponentsFilter = new ListComponentsFilter
{
    Ids = new List<int>
    {
        1,
        2,
        3,
    },
    UseSiteExchangeRate = false,
};
```

