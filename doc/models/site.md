
# Site

## Structure

`Site`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `Name` | `string` | Optional | - |
| `Subdomain` | `string` | Optional | - |
| `Currency` | `string` | Optional | - |
| `SellerId` | `int?` | Optional | - |
| `NonPrimaryCurrencies` | `List<string>` | Optional | - |
| `RelationshipInvoicingEnabled` | `bool?` | Optional | - |
| `CustomerHierarchyEnabled` | `bool?` | Optional | - |
| `WhopaysEnabled` | `bool?` | Optional | - |
| `WhopaysDefaultPayer` | `string` | Optional | - |
| `AllocationSettings` | [`AllocationSettings`](../../doc/models/allocation-settings.md) | Optional | - |
| `DefaultPaymentCollectionMethod` | `string` | Optional | - |
| `OrganizationAddress` | [`OrganizationAddress`](../../doc/models/organization-address.md) | Optional | - |
| `TaxConfiguration` | [`TaxConfiguration`](../../doc/models/tax-configuration.md) | Optional | - |
| `NetTerms` | [`NetTerms`](../../doc/models/net-terms.md) | Optional | - |
| `Test` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "id": 34,
  "name": "name0",
  "subdomain": "subdomain4",
  "currency": "currency0",
  "seller_id": 198
}
```

