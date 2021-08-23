using NUnit.Framework;
using ScalarAPI.Functions;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests.Functions
{
    public class InvokesCountTest
    {
        [Test]
        public void IncrementInvokesTest()
        {
            var counter = new InvokesCount<int>(() => new ScalarOf<int>(1));
            Assert.AreEqual(counter.Invokes, 0);
            counter.Value();
            Assert.AreEqual(counter.Invokes, 1);
        }
    }
}