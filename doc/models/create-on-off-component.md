
# Create On Off Component

## Structure

`CreateOnOffComponent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OnOffComponent` | [`OnOffComponent`](../../doc/models/on-off-component.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;

CreateOnOffComponent createOnOffComponent = new CreateOnOffComponent
{
    OnOffComponent = new OnOffComponent
    {
        Name = "name6",
        UnitPrice = OnOffComponentUnitPrice.FromString("String5"),
        Description = "description6",
        Handle = "handle2",
        Taxable = false,
        UpgradeCharge = CreditType.Full,
        DowngradeCredit = CreditType.Full,
    },
};
```

