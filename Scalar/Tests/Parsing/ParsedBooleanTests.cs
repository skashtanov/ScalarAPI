using System;
using NUnit.Framework;
using ScalarAPI.Parsed;
using ScalarAPI.Scalars;

namespace ScalarAPI.Tests.Parsing
{
    public class ParsedBooleanTests
    {
        [Test]
        public void TestParseCorrectString()
        {
            Assert.True(
                new ParsedBoolean("true").Value()
            );
            
            Assert.True(
                new ParsedBoolean("True").Value() 
            );
            
            Assert.False(
                new ParsedBoolean("false").Value()
            );
            
            Assert.False(
                new ParsedBoolean("false").Value()
            );
        }
        
        [Test]
        public void TestParseInvalidString()
        {
            Assert.Throws<FormatException>(
                () => new ParsedBoolean("invalid string").Value()
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
            Assert.True(
                new ParsedBoolean(
                    new ScalarOf<string>("true")
                ).Value()
            );
            
            Assert.True(
                new ParsedBoolean(
                    new ScalarOf<string>("True")
                ).Value()
            );
            
            Assert.False(
                new ParsedBoolean(
                    new ScalarOf<string>("false")
                ).Value()
            );
            
            Assert.False(
                new ParsedBoolean(
                    new ScalarOf<string>("False")
                ).Value()
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
