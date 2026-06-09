
# Scheduled Renewal Update Request Renewal Configuration Item

## Class Name

`ScheduledRenewalUpdateRequestRenewalConfigurationItem`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ScheduledRenewalItemRequestBodyComponent`](../../../doc/models/scheduled-renewal-item-request-body-component.md) | ScheduledRenewalUpdateRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(ScheduledRenewalItemRequestBodyComponent scheduledRenewalItemRequestBodyComponent) |
| [`ScheduledRenewalItemRequestBodyProduct`](../../../doc/models/scheduled-renewal-item-request-body-product.md) | ScheduledRenewalUpdateRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyProduct(ScheduledRenewalItemRequestBodyProduct scheduledRenewalItemRequestBodyProduct) |

## ScheduledRenewalItemRequestBodyComponent

### Initialization Code

#### Example

```csharp
ScheduledRenewalUpdateRequestRenewalConfigurationItem value = ScheduledRenewalUpdateRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyComponent(
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
ScheduledRenewalUpdateRequestRenewalConfigurationItem value = ScheduledRenewalUpdateRequestRenewalConfigurationItem.FromScheduledRenewalItemRequestBodyProduct(
    new ScheduledRenewalItemRequestBodyProduct
    {
        ItemType = "Product",
        ItemId = 32,
    }
);
```

