
# List Subscription Groups Item

## Structure

`ListSubscriptionGroupsItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uid` | `string` | Optional | - |
| `Scheme` | `int?` | Optional | - |
| `CustomerId` | `int?` | Optional | - |
| `PaymentProfileId` | `int?` | Optional | - |
| `SubscriptionIds` | `List<int>` | Optional | - |
| `PrimarySubscriptionId` | `int?` | Optional | - |
| `NextAssessmentAt` | `DateTimeOffset?` | Optional | - |
| `State` | `string` | Optional | - |
| `CancelAtEndOfPeriod` | `bool?` | Optional | - |
| `AccountBalances` | [`SubscriptionGroupBalances`](../../doc/models/subscription-group-balances.md) | Optional | - |

## Example (as JSON)

```json
{
  "uid": "uid0",
  "scheme": 124,
  "customer_id": 144,
  "payment_profile_id": 52,
  "subscription_ids": [
    254
  ]
}
```

