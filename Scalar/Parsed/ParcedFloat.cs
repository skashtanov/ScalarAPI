using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Parsed
{
    public class ParsedFloat: IScalar<float>
    {
        private readonly IScalar<string> _source;

        public ParsedFloat(IScalar<string> source)
        {
            _source = source;
        }

        public ParsedFloat(string source):
            this(new ScalarOf<string>(source))
        {
            
        }
        
        public float Value()
        {
            return float.Parse(_source.Value());
        }
    }
}