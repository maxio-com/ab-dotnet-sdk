
# Customer Change

## Structure

`CustomerChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Payer` | [`CustomerPayerChange`](../../doc/models/customer-payer-change.md) | Optional | - |
| `ShippingAddress` | [`AddressChange`](../../doc/models/address-change.md) | Optional | - |
| `BillingAddress` | [`AddressChange`](../../doc/models/address-change.md) | Optional | - |
| `CustomFields` | [`CustomerCustomFieldsChange`](../../doc/models/customer-custom-fields-change.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;

CustomerChange customerChange = new CustomerChange
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
};
```

