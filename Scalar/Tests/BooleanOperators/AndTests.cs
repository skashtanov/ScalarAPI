using NUnit.Framework;
using Sandbox;
using ScalarAPI.BooleanOperators;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests
{
    public class AndTests
    {
        [Test]
        public void FromPrimitivesTest()
        {
            Assert.True(new And(true, true).Value());
            Assert.False(new And(true, false).Value());
            Assert.False(new And(false, true).Value());
            Assert.False(new And(false, false).Value());
        }

        [Test]
        public void FromScalarsTest()
        {
            Assert.True(new And(
                new ScalarOf<bool>(true),
                new ScalarOf<bool>(true)
            ).Value());

            Assert.False(new And(
                new ScalarOf<bool>(true),
                new ScalarOf<bool>(false)
            ).Value());

            Assert.False(new And(
                new ScalarOf<bool>(false),
                new ScalarOf<bool>(true)
            ).Value());

            Assert.False(new And(
                new ScalarOf<bool>(false),
                new ScalarOf<bool>(false)
            ).Value());
        }
    }
}