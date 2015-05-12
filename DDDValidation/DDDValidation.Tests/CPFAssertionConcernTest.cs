using DDDValidation.Validation;
using NUnit.Framework;
using System;

namespace DDDValidation.Tests
{
    [TestFixture]
    public class CPFAssertionConcernTest
    {
        private const string ValidCPF_WithMask = "476.394.022-80";
        private const string ValidCPF_WithoutMask = "47639402280";

        private const string InvalidCPF_WithMask = "111.111.111-11";
        private const string InvalidCPF_WithoutMask = "111111111-11";

        [Test]
        public void Should_AssertCPFFormat()
        {
            Assert.DoesNotThrow(() => CPFAssertionConcern.AssertCPFFormat(ValidCPF_WithMask, "error message"));
        }

        [Test]
        public void Should_AssertCPFFormat_WithoutMask()
        {
            Assert.DoesNotThrow(() => CPFAssertionConcern.AssertCPFFormat(ValidCPF_WithoutMask, "error message"));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsInvalidCPF()
        {
            CPFAssertionConcern.AssertCPFFormat(InvalidCPF_WithMask, "error message");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsInvalidCPF_WithoutMask()
        {
            CPFAssertionConcern.AssertCPFFormat(InvalidCPF_WithoutMask, "error message");
        }
    }
}
