
# Scheduled Renewal Configuration

## Structure

`ScheduledRenewalConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | ID of the renewal. |
| `SiteId` | `int?` | Optional | ID of the site to which the renewal belongs. |
| `SubscriptionId` | `int?` | Optional | The id of the subscription. |
| `StartsAt` | `DateTimeOffset?` | Optional | - |
| `EndsAt` | `DateTimeOffset?` | Optional | - |
| `LockInAt` | `DateTimeOffset?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `Status` | `string` | Optional | - |
| `ScheduledRenewalConfigurationItems` | [`List<ScheduledRenewalConfigurationItem>`](../../doc/models/scheduled-renewal-configuration-item.md) | Optional | - |
| `Contract` | [`Contract`](../../doc/models/contract.md) | Optional | Contract linked to the scheduled renewal configuration. |

## Example (as JSON)

```json
{
  "id": 152,
  "site_id": 78,
  "subscription_id": 6,
  "starts_at": "2016-03-13T12:52:32.123Z",
  "ends_at": "2016-03-13T12:52:32.123Z"
}
```

