
# Subscription Group Create Error Response Errors

## Class Name

`SubscriptionGroupCreateErrorResponseErrors`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`SubscriptionGroupMembersArrayError`](../../../doc/models/subscription-group-members-array-error.md) | SubscriptionGroupCreateErrorResponseErrors.FromSubscriptionGroupMembersArrayError(SubscriptionGroupMembersArrayError subscriptionGroupMembersArrayError) |
| [`SubscriptionGroupSingleError`](../../../doc/models/subscription-group-single-error.md) | SubscriptionGroupCreateErrorResponseErrors.FromSubscriptionGroupSingleError(SubscriptionGroupSingleError subscriptionGroupSingleError) |
| `string` | SubscriptionGroupCreateErrorResponseErrors.FromString(string mString) |

## SubscriptionGroupMembersArrayError

### Initialization Code

#### Example

```csharp
SubscriptionGroupCreateErrorResponseErrors value = SubscriptionGroupCreateErrorResponseErrors.FromSubscriptionGroupMembersArrayError(
    new SubscriptionGroupMembersArrayError
    {
        Members = new List<string>
        {
            "members6",
        },
    }
);
```

## SubscriptionGroupSingleError

### Initialization Code

#### Example

```csharp
SubscriptionGroupCreateErrorResponseErrors value = SubscriptionGroupCreateErrorResponseErrors.FromSubscriptionGroupSingleError(
    new SubscriptionGroupSingleError
    {
        SubscriptionGroup = "subscription_group2",
    }
);
```

## string

### Initialization Code

#### Example

```csharp
SubscriptionGroupCreateErrorResponseErrors value = SubscriptionGroupCreateErrorResponseErrors.FromString("String0");
```

