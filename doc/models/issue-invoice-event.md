
# Issue Invoice Event

## Structure

`IssueInvoiceEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `long` | Required | - |
| `Timestamp` | `DateTimeOffset` | Required | - |
| `Invoice` | [`Invoice`](../../doc/models/invoice.md) | Required | - |
| `EventType` | [`InvoiceEventType`](../../doc/models/invoice-event-type.md) | Required | **Default**: `InvoiceEventType.issue_invoice` |
| `EventData` | [`IssueInvoiceEventData`](../../doc/models/issue-invoice-event-data.md) | Required | Example schema for an `issue_invoice` event |

## Example (as JSON)

```json
{
  "id": 130,
  "timestamp": "2016-03-13T12:52:32.123Z",
  "invoice": {
    "issue_date": "2024-01-01",
    "due_date": "2024-01-01",
    "paid_date": "2024-01-01",
    "public_url_expires_on": "2024-01-21",
    "id": 166,
    "uid": "uid6",
    "site_id": 92,
    "customer_id": 204,
    "subscription_id": 20
  },
  "event_type": "issue_invoice",
  "event_data": {
    "consolidation_level": "child",
    "from_status": "open",
    "to_status": "pending",
    "due_amount": "due_amount8",
    "total_amount": "total_amount2"
  }
}
```

