using System;
using NUnit.Framework;
using ScalarAPI.Errors;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests.Errors
{
    public class RetryOnFailTests
    {
        [Test]
        public void NoThrowOnSuccessTest()
        {
            Assert.DoesNotThrow(
                () => new RetryOnFail<int>(
                    new ScalarOf<int>(0), 
                    3).Value()
                );
        }

        [Test]
        public void ThrowsAfterAttemptsTest()
        {
            Assert.Throws<NullReferenceException>(
                () => new RetryOnFail<double>(
                        null, 1
                    ).Value()
                );
        }
    }
}