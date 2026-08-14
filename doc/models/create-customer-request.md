
# Create Customer Request

## Structure

`CreateCustomerRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`CreateCustomer`](../../doc/models/create-customer.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
{
    Customer = new CreateCustomer
    {
        FirstName = "first_name0",
        LastName = "last_name8",
        Email = "email6",
        CcEmails = "cc_emails0",
        Organization = "organization6",
        Reference = "reference4",
        Address = "address6",
        Address2 = "address_24",
    },
};
```

