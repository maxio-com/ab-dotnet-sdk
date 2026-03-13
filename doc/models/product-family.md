
# Product Family

## Structure

`ProductFamily`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Handle` | `string` | Optional | - |
| `AccountingCode` | `string` | Optional | - |
| `Description` | `string` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |
| `UpdatedAt` | `DateTimeOffset?` | Optional | - |
| `ArchivedAt` | `DateTimeOffset?` | Optional | Timestamp indicating when this product family was archived. `null` if the product family is not archived. |

## Example (as JSON)

```json
{
  "id": 194,
  "name": "name2",
  "handle": "handle8",
  "accounting_code": "accounting_code8",
  "description": "description8"
}
```

