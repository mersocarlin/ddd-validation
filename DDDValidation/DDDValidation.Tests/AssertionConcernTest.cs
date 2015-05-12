using DDDValidation.Validation;
using NUnit.Framework;
using System;

namespace DDDValidation.Tests
{
    [TestFixture]
    public class AssertionConcernTest
    {
        private const string ExpectedString = "DDDValidation Rocks!";
        private const string ErrorMessage = "There are not strings on me!";

        [Test]
        public void Should_AssertArgumentEquals()
        {
            var testValue = "DDDValidation Rocks!";
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentEquals(testValue, ExpectedString, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentEquals()
        {
            var testValue = "DDDValidation Rocks!!";
            AssertionConcern.AssertArgumentEquals(testValue, ExpectedString, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentFalse()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentFalse(false, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentFalse()
        {
            AssertionConcern.AssertArgumentFalse(true, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentLength_With_Minimum_And_Maximum()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentLength(ExpectedString, 0, ExpectedString.Length, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentLength_With_Minimum_And_Maximum()
        {
            AssertionConcern.AssertArgumentLength(ExpectedString, 0, 1, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentLength_With_Maximum()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentLength(ExpectedString, ExpectedString.Length, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentLength_With_Maximum()
        {
            AssertionConcern.AssertArgumentLength(ExpectedString, 1, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentMatches()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentMatches(@"[a-z]+", ExpectedString, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentMatches()
        {
            AssertionConcern.AssertArgumentMatches(@"\d+", ExpectedString, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentNotEmpty()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentNotEmpty(ExpectedString, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentNotEmpty()
        {
            AssertionConcern.AssertArgumentNotEmpty("", ErrorMessage);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentNotEmpty_With_Null_Value()
        {
            AssertionConcern.AssertArgumentNotEmpty(null, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentNotEquals()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentNotEquals(ExpectedString, ExpectedString + "!", ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentNotEquals()
        {
            AssertionConcern.AssertArgumentNotEquals(ExpectedString, ExpectedString, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentNotNull()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentNotNull(ExpectedString, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentNotNull()
        {
            AssertionConcern.AssertArgumentNotNull(null, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentRange_Double()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentRange(5.0, double.MinValue, double.MaxValue, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentRange_Double()
        {
            AssertionConcern.AssertArgumentRange(20.0, 0.0, 10.0, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentRange_Float()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentRange(5.0F, float.MinValue, float.MaxValue, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentRange_Float()
        {
            AssertionConcern.AssertArgumentRange(20.0F, 0.0F, 10.0F, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentRange_Int()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentRange(5, Int32.MinValue, Int32.MaxValue, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentRange_Int()
        {
            AssertionConcern.AssertArgumentRange(20, 0, 10, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentRange_Long()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentRange(1234567890123, long.MinValue, long.MaxValue, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentRange_Long()
        {
            AssertionConcern.AssertArgumentRange(20, 0, 10, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentTrue()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentTrue(true, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentTrue()
        {
            AssertionConcern.AssertArgumentTrue(false, ErrorMessage);
        }

        [Test]
        public void Should_AssertStateFalse()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertStateFalse(false, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertStateFalse()
        {
            AssertionConcern.AssertStateFalse(true, ErrorMessage);
        }

        [Test]
        public void Should_AssertStateTrue()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertStateTrue(true, ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertStateTrue()
        {
            AssertionConcern.AssertStateTrue(false, ErrorMessage);
        }

        [Test]
        public void Should_AssertArgumentDateTime()
        {
            Assert.DoesNotThrow(() => AssertionConcern.AssertArgumentDateTime("01/01/1900", ErrorMessage));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Should_ThrowsAssertArgumentDateTime()
        {
            AssertionConcern.AssertArgumentDateTime("", ErrorMessage);
        }
    }
}
