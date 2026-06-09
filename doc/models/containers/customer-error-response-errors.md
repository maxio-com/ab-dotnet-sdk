
# Customer Error Response Errors

## Class Name

`CustomerErrorResponseErrors`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`CustomerError`](../../../doc/models/customer-error.md) | CustomerErrorResponseErrors.FromCustomerError(CustomerError customerError) |
| `List<string>` | CustomerErrorResponseErrors.FromListOfString(List<string> listOfString) |

## CustomerError

### Initialization Code

#### Example

```csharp
CustomerErrorResponseErrors value = CustomerErrorResponseErrors.FromCustomerError(
    new CustomerError
    {
    }
);
```

## List<string>

### Initialization Code

#### Example

```csharp
CustomerErrorResponseErrors value = CustomerErrorResponseErrors.FromListOfString(
    new List<string>
    {
        "String1",
    }
);
```

