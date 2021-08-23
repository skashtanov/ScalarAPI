using NUnit.Framework;
using ScalarAPI.Functions;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests.Functions
{
    public class OnceTest
    {
        [Test]
        public void OnlyFirstInvocationTest()
        {
            var once = new Once<int>(() => new ScalarOf<int>(1));
            Assert.False(once.Evaluated);
            Assert.AreEqual(once.Value(), 1);
            Assert.True(once.Evaluated);
        }
    }
}