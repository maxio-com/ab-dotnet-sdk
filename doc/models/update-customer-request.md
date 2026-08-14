
# Update Customer Request

## Structure

`UpdateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`UpdateCustomer`](../../doc/models/update-customer.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

UpdateCustomerRequest updateCustomerRequest = new UpdateCustomerRequest
{
    Customer = new UpdateCustomer
    {
        FirstName = "first_name0",
        LastName = "last_name8",
        Email = "email6",
        CcEmails = "cc_emails0",
        Organization = "organization6",
    },
};
```

