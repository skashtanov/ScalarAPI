using NUnit.Framework;
using Sandbox;
using ScalarAPI.BooleanOperators;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests
{
    public class OrTests
    {
        [Test]
        public void FromPrimitivesTest()
        {
            Assert.True(new Or(true, true).Value());
            Assert.True(new Or(true, false).Value());
            Assert.True(new Or(false, true).Value());
            Assert.False(new Or(false, false).Value());
        }

        [Test]
        public void FromScalarsTest()
        {
            Assert.True(new Or(
                new ScalarOf<bool>(true),
                new ScalarOf<bool>(true)
            ).Value());

            Assert.True(new Or(
                new ScalarOf<bool>(true),
                new ScalarOf<bool>(false)
            ).Value());

            Assert.True(new Or(
                new ScalarOf<bool>(false),
                new ScalarOf<bool>(true)
            ).Value());

            Assert.False(new Or(
                new ScalarOf<bool>(false),
                new ScalarOf<bool>(false)
            ).Value());
        }
    }
}