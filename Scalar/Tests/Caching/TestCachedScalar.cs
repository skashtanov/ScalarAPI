using System.Linq;
using NUnit.Framework;
using ScalarAPI.Caching;

namespace ScalarAPI.Tests.Caching
{
    public class TestCachedScalar
    {
        [Test]
        public void TestSecondEvaluationTakesFromCache()
        {
            var cache = new CachedScalar<int[]>(
                () => Enumerable.Repeat(0, 10).ToArray()
            );
            Assert.False(cache.Cached);
            var arrayBefore = cache.Value();
            Assert.True(cache.Cached);
            var arrayAfter = cache.Value();
            Assert.True(
                Enumerable.SequenceEqual(
                    arrayBefore, arrayAfter
                )
            );
        }
    }
}