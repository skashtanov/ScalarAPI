using System;
using NUnit.Framework;
using ScalarAPI.Collections;

namespace ScalarAPI.Tests.Collections
{
    class Person: IComparable<Person>
    {
        public int Age;
        public string Name;

        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0) return ageComparison;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
    
    public class MaxInObjectsEnumerableTests
    {
        [Test]
        public void OldestPersonTest()
        {
            Person[] persons = new Person[]
            {
                new() {Age = 18, Name = "Jeffrey"},
                new() {Age = 20, Name = "Josh"},
                new() {Age = 19, Name = "Nick"}
            };
            Assert.AreEqual(
                new MaxInEnumerable<Person>(persons).Value().Age,
                20);
        }
    }
}