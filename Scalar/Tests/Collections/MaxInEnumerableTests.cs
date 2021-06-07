using System.Collections.Generic;
using NUnit.Framework;
using ScalarAPI.Collections;

namespace ScalarAPI.Tests.Collections
{
    public class MaxInEnumerableTests
    {
        [Test]
        public void UniqueMaxInIntArrayTest()
        {
            int[] source = new int[] {1, 2, 3};
            Assert.AreEqual(
                new MaxInEnumerable<int>(source).Value(),
                3);
        }
        
        [Test]
        public void NotUniqueMaxInIntArrayTest()
        {
            int[] source = new int[] {1, 2, 3, 3, 2, 1};
            Assert.AreEqual(
                new MaxInEnumerable<int>(source).Value(),
                3);
        }

        [Test]
        public void MaxInDoubleListTest()
        {
            List<double> source = new List<double>() {1.0, 2.0, 3.0, 0.0};
            Assert.AreEqual(
                new MaxInEnumerable<double>(source).Value(),
                3.0,
                1e-6);
        }
    }
}