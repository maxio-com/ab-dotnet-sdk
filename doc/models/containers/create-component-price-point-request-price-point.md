
# Create Component Price Point Request Price Point

## Class Name

`CreateComponentPricePointRequestPricePoint`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`CreateComponentPricePoint`](../../../doc/models/create-component-price-point.md) | CreateComponentPricePointRequestPricePoint.FromCreateComponentPricePoint(CreateComponentPricePoint createComponentPricePoint) |
| [`CreatePrepaidUsageComponentPricePoint`](../../../doc/models/create-prepaid-usage-component-price-point.md) | CreateComponentPricePointRequestPricePoint.FromCreatePrepaidUsageComponentPricePoint(CreatePrepaidUsageComponentPricePoint createPrepaidUsageComponentPricePoint) |

## CreateComponentPricePoint

### Initialization Code

#### Example

```csharp
CreateComponentPricePointRequestPricePoint value = CreateComponentPricePointRequestPricePoint.FromCreateComponentPricePoint(
    new CreateComponentPricePoint
    {
        Name = "name0",
        PricingScheme = PricingScheme.PerUnit,
        Prices = new List<Price>
        {
            new Price
            {
                StartingQuantity = PriceStartingQuantity.FromNumber(242),
                UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            },
        },
        UseSiteExchangeRate = true,
    }
);
```

## CreatePrepaidUsageComponentPricePoint

### Initialization Code

#### Example

```csharp
CreateComponentPricePointRequestPricePoint value = CreateComponentPricePointRequestPricePoint.FromCreatePrepaidUsageComponentPricePoint(
    new CreatePrepaidUsageComponentPricePoint
    {
        Name = "name0",
        PricingScheme = PricingScheme.PerUnit,
        Prices = new List<Price>
        {
            new Price
            {
                StartingQuantity = PriceStartingQuantity.FromNumber(242),
                UnitPrice = PriceUnitPrice.FromPrecision(23.26),
            },
        },
        OveragePricing = new OveragePricing
        {
            PricingScheme = PricingScheme.Stairstep,
        },
        UseSiteExchangeRate = true,
    }
);
```

