using DDDValidation.Validation;
using NUnit.Framework;
using System;

namespace DDDValidation.Tests
{
    [TestFixture]
    public class CNPJAssertionConcertTest
    {
        private const string ValidCNPJ = "83.817.759/0001-99";
        private const string ValidCNPJ_WithoutMask = "83817759000199";

        private const string InvalidCNPJ = "11.111.111/1111-11";
        private const string InvalidCNPJ_WithoutMask = "11111111111111";

        [Test]
        public void Should_AssertCNPJFormat()
        {
            Assert.DoesNotThrow(() => CNPJAssertionConcern.AssertCNPJFormat(ValidCNPJ, "error message"));
        }

        [Test]
        public void Should_AssertCNPJFormat_WithoutMask()
        {
            Assert.DoesNotThrow(() => CNPJAssertionConcern.AssertCNPJFormat(ValidCNPJ_WithoutMask, "error message"));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsInvalidCNPJ()
        {
            CNPJAssertionConcern.AssertCNPJFormat(InvalidCNPJ, "error message");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsInvalidCNPJ_WithoutMask()
        {
            CNPJAssertionConcern.AssertCNPJFormat(InvalidCNPJ_WithoutMask, "error message");
        }
    }
}

