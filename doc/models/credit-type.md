
# Credit Type

The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.

## Enumeration

`CreditType`

## Fields

| Name |
|  --- |
| `Full` |
| `Prorated` |
| `None` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreditType creditType = CreditType.Prorated;
```

