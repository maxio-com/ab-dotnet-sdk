
# List Subscription Components Filter

## Structure

`ListSubscriptionComponentsFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Currencies` | `List<string>` | Optional | Allows fetching components allocation with matching currency based on provided values. Use in query `filter[currencies]=EUR,USD`.<br><br>**Constraints**: *Minimum Items*: `1` |
| `UseSiteExchangeRate` | `bool?` | Optional | Allows fetching components allocation with matching use_site_exchange_rate based on provided value. Use in query `filter[use_site_exchange_rate]=true`. |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

ListSubscriptionComponentsFilter listSubscriptionComponentsFilter = new ListSubscriptionComponentsFilter
{
    Currencies = new List<string>
    {
        "EUR",
        "USD",
    },
    UseSiteExchangeRate = false,
};
```

