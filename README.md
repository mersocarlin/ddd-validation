[![Build Status](https://travis-ci.org/mersocarlin/ddd-validation.svg?branch=master)](https://travis-ci.org/mersocarlin/ddd-validation)

# ddd-validation

DDD Library for validate your entities according Vaughn Vernon using C# / ASP.NET.

## Install via nuget package

```bash
Install-Package DDDValidation
```

## Setup your class

```c#
using DDDValidation.Validation;

namespace ExampleOfUse
{
	public class DDDValidationClass
	{
	    public DDDValidationClass()
	    {

	    }

	    public string EqualsProperty { get; set; }
	    public string LengthProperty { get; set; }
	    public string NullProperty { get; set; }
	    public string EmailProperty { get; set; }

	    public void Validate()
	    {
	        AssertionConcern.AssertArgumentEquals(this.EqualsProperty, "ddd-validation", "The property value for EqualsProperty must be equals to 'ddd-validation'");
	        AssertionConcern.AssertArgumentLength(this.LengthProperty, 30, "The property value for LengthProperty has a maxlength of 30");
	        AssertionConcern.AssertArgumentNotNull(this.NullProperty, "The value for NullProperty must be a not null value");
	        EmailAssertionConcern.AssertEmailFormat(this.EmailProperty, "The property value for EmailProperty must be a valid email address");
	    }
	}
}
```

## Example of usage

```c#
public void SaveInfo(DDDValidationClass validationClass)
{
    try
    {
        validationClass.Validate();
        //continue implementation
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        throw ex;
    }
}
```
