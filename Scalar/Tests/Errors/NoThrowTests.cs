using System;
using NUnit.Framework;
using ScalarAPI.Errors;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests.Errors
{
    public class NoThrowTests
    {
        [Test]
        public void NoThrowTest()
        {
            Assert.DoesNotThrow(() => new NoThrow<double>(
                new ScalarOf<double>(Math.Sqrt(-1)),
                0.0d
            ).Value());
        }
    }
}