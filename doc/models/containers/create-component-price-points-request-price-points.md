
# Create Component Price Points Request Price Points

## Class Name

`CreateComponentPricePointsRequestPricePoints`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`CreateComponentPricePoint`](../../../doc/models/create-component-price-point.md) | CreateComponentPricePointsRequestPricePoints.FromCreateComponentPricePoint(CreateComponentPricePoint createComponentPricePoint) |
| [`CreatePrepaidUsageComponentPricePoint`](../../../doc/models/create-prepaid-usage-component-price-point.md) | CreateComponentPricePointsRequestPricePoints.FromCreatePrepaidUsageComponentPricePoint(CreatePrepaidUsageComponentPricePoint createPrepaidUsageComponentPricePoint) |

## CreateComponentPricePoint

### Initialization Code

#### Example

```csharp
CreateComponentPricePointsRequestPricePoints value = CreateComponentPricePointsRequestPricePoints.FromCreateComponentPricePoint(
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
CreateComponentPricePointsRequestPricePoints value = CreateComponentPricePointsRequestPricePoints.FromCreatePrepaidUsageComponentPricePoint(
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

