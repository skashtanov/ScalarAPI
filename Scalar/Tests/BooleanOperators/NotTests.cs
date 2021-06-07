using NUnit.Framework;
using Sandbox;
using ScalarAPI.BooleanOperators;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests
{
    public class NotTests
    {
        [Test]
        public void FromPrimitivesTest()
        {
            Assert.False(new Not(true).Value());
            Assert.True(new Not(false).Value());
        }

        [Test]
        public void FromScalarsTest()
        {
            Assert.False(new Not(
                new ScalarOf<bool>(true)
            ).Value());

            Assert.True(new Not(
                new ScalarOf<bool>(false)
            ).Value());
        }
    }
}