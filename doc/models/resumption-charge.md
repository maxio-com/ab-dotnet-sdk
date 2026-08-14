
# Resumption Charge

(For calendar billing subscriptions only) The way that the resumed subscription's charge should be handled

## Enumeration

`ResumptionCharge`

## Fields

| Name |
|  --- |
| `Prorated` |
| `Immediate` |
| `Delayed` |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ResumptionCharge resumptionCharge = ResumptionCharge.Immediate;
```

