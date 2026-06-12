
# Scheduled Renewal Configuration Item Request Renewal Configuration Item

## Class Name

`ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ScheduledRenewalItemRequestBodyComponent`](../../../doc/models/scheduled-renewal-item-request-body-component.md) | ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(ScheduledRenewalItemRequestBodyComponent scheduledRenewalItemRequestBodyComponent) |
| [`ScheduledRenewalItemRequestBodyProduct`](../../../doc/models/scheduled-renewal-item-request-body-product.md) | ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyProduct(ScheduledRenewalItemRequestBodyProduct scheduledRenewalItemRequestBodyProduct) |

## ScheduledRenewalItemRequestBodyComponent

### Initialization Code

#### Example

```csharp
ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem value = ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(
    new ScheduledRenewalItemRequestBodyComponent
    {
        ItemType = "Component",
        ItemId = 108,
    }
);
```

## ScheduledRenewalItemRequestBodyProduct

### Initialization Code

#### Example

```csharp
ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem value = ScheduledRenewalConfigurationItemRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyProduct(
    new ScheduledRenewalItemRequestBodyProduct
    {
        ItemType = "Product",
        ItemId = 32,
    }
);
```

