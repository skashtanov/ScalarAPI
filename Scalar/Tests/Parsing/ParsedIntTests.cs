using System;
using NUnit.Framework;
using ScalarAPI.Parsed;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests.Parsing
{
    public class ParsedIntTests
    {
        [Test]
        public void TestParseCorrectString()
        {
            Assert.AreEqual(
                new ParsedInteger("-1").Value(),
                -1
            );
            
            Assert.AreEqual(
                new ParsedInteger("0").Value(), 
                0
            );
            
            Assert.AreEqual(
                new ParsedInteger("1").Value(),
                1
            );
        }
        
        [Test]
        public void TestParseInvalidString()
        {
            Assert.Throws<FormatException>(
                () => new ParsedInteger("invalid string").Value()
            );
        }
        
        [Test]
        public void TestParseNullString()
        {
            string s = null;
            Assert.Throws<ArgumentNullException>(
                () => new ParsedInteger(s).Value()
            );
        }
        
        [Test]
        public void TestParseCorrectScalar()
        {
            Assert.AreEqual(
                new ParsedInteger(
                    new ScalarOf<string>("-1")
                ).Value(),
                -1
            );
            Assert.AreEqual(
                new ParsedInteger(
                    new ScalarOf<string>("0")
                ).Value(), 
                0
            );
            Assert.AreEqual(
                new ParsedInteger(
                    new ScalarOf<string>("1")
                ).Value(),
                1
            );
        }
        
        [Test]
        public void TestParseInvalidScalar()
        {
            Assert.Throws<FormatException>(
                () => new ParsedInteger(
                    new ScalarOf<string>("invalid string")
                ).Value()
            );
        }
        
        [Test]
        public void TestParseNullScalar()
        {
            Assert.Throws<ArgumentNullException>(
                () => new ParsedInteger(
                    new ScalarOf<string>(null)
                ).Value()
            );
        }
    }
}