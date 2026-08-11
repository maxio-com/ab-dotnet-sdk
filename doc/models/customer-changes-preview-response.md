
# Customer Changes Preview Response

## Structure

`CustomerChangesPreviewResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Changes` | [`CustomerChange`](../../doc/models/customer-change.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CustomerChangesPreviewResponse customerChangesPreviewResponse = new CustomerChangesPreviewResponse
{
    Changes = new CustomerChange
    {
        Payer = new CustomerPayerChange
        {
            Before = new InvoicePayerChange
            {
                FirstName = "first_name0",
                LastName = "last_name8",
                Organization = "organization4",
                Email = "email6",
            },
            After = new InvoicePayerChange
            {
                FirstName = "first_name2",
                LastName = "last_name0",
                Organization = "organization4",
                Email = "email4",
            },
        },
        ShippingAddress = new AddressChange
        {
            Before = new InvoiceAddress
            {
                Street = "street0",
                Line2 = "line24",
                City = "city0",
                State = "state6",
                Zip = "zip4",
            },
            After = new InvoiceAddress
            {
                Street = "street2",
                Line2 = "line26",
                City = "city8",
                State = "state2",
                Zip = "zip4",
            },
        },
        BillingAddress = new AddressChange
        {
            Before = new InvoiceAddress
            {
                Street = "street0",
                Line2 = "line24",
                City = "city0",
                State = "state6",
                Zip = "zip4",
            },
            After = new InvoiceAddress
            {
                Street = "street2",
                Line2 = "line26",
                City = "city8",
                State = "state2",
                Zip = "zip4",
            },
        },
        CustomFields = new CustomerCustomFieldsChange
        {
            Before = new List<InvoiceCustomField>
            {
                new InvoiceCustomField
                {
                    OwnerId = 26,
                    OwnerType = CustomFieldOwner.Customer,
                    Name = "name0",
                    MValue = "value2",
                    MetadatumId = 26,
                },
                new InvoiceCustomField
                {
                    OwnerId = 26,
                    OwnerType = CustomFieldOwner.Customer,
                    Name = "name0",
                    MValue = "value2",
                    MetadatumId = 26,
                },
            },
            After = new List<InvoiceCustomField>
            {
                new InvoiceCustomField
                {
                    OwnerId = 130,
                    OwnerType = CustomFieldOwner.Customer,
                    Name = "name2",
                    MValue = "value4",
                    MetadatumId = 130,
                },
                new InvoiceCustomField
                {
                    OwnerId = 130,
                    OwnerType = CustomFieldOwner.Customer,
                    Name = "name2",
                    MValue = "value4",
                    MetadatumId = 130,
                },
                new InvoiceCustomField
                {
                    OwnerId = 130,
                    OwnerType = CustomFieldOwner.Customer,
                    Name = "name2",
                    MValue = "value4",
                    MetadatumId = 130,
                },
            },
        },
    },
};
```

