using System.Collections.Generic;
using NUnit.Framework;
using ScalarAPI.Collections;

namespace ScalarAPI.Tests.Collections
{
    public class MinInEnumerableTests
    {
        [Test]
        public void UniqueMinInIntArrayTest()
        {
            int[] source = new int[] {1, 2, 3};
            Assert.AreEqual(
                new MinInEnumerable<int>(source).Value(),
                1);
        }
        
        [Test]
        public void NotUniqueMinInIntArrayTest()
        {
            int[] source = new int[] {1, 2, 3, 3, 2, 1};
            Assert.AreEqual(
                new MinInEnumerable<int>(source).Value(),
                1);
        }

        [Test]
        public void MinInDoubleListTest()
        {
            List<double> source = new List<double>() {1.0, 2.0, 3.0, 0.0};
            Assert.AreEqual(
                new MinInEnumerable<double>(source).Value(),
                0.0,
                1e-6);
        }
    }
}