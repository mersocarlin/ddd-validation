using DDDValidation.Validation;
using NUnit.Framework;
using System;

namespace DDDValidation.Tests
{
    [TestFixture]
    public class EmailAssertionConcernTest
    {
        [Test]
        public void Should_AssertEmailFormat()
        {
            Assert.DoesNotThrow(() => EmailAssertionConcern.AssertEmailFormat("your_email@domain.com", "error message"));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsInvalidEmail()
        {
            EmailAssertionConcern.AssertEmailFormat("your_email@domain", "error message");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsInvalidEmail_WhenIsText()
        {
            EmailAssertionConcern.AssertEmailFormat("tries email validation with text", "error message");
        }
    }
}

