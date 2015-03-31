
# 1.0.0.2 (2015-03-30)

### Feature

* EmailAssertionConcern validating null values

# 1.0.0.1 (2015-03-16)

### Features

* CPFAssertionConcern validating null values
* CNPJAssertionConcern validating null values
* AssertionConcern validating DateTime values: 

```c#
public static void AssertArgumentDateTime(string dateTimeValue, string message)
{
    DateTime dateTime = DateTime.Now;
    if (!DateTime.TryParse(dateTimeValue, out dateTime))
        throw new InvalidOperationException(message);
}
```

### Breaking changes

* `CPFAssertionConcern.Validate(cpf, message)` changed to `CPFAssertionConcern.AssertCPFFormat(cpf, message)`
* `CNPJAssertionConcern.Validate(cnpj, message)` changed to `CNPJAssertionConcern.AssertCNPJFormat(cnpj, message)`
* `EmailAssertionConcern.AssertIsValid(email, message)` changed to `EmailAssertionConcern.AssertEmailFormat(email, message)`

# 1.0.0.0 (2015-03-07)

* Library first version