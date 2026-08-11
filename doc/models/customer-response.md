
# Customer Response

## Structure

`CustomerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`Customer`](../../doc/models/customer.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CustomerResponse customerResponse = new CustomerResponse
{
    Customer = new Customer
    {
        FirstName = "first_name0",
        LastName = "last_name8",
        Email = "email6",
        CcEmails = "cc_emails0",
        Organization = "organization6",
    },
};
```

