using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Parsed
{
    public class ParsedInteger: IScalar<int>
    {
        private readonly IScalar<string> _source;

        public ParsedInteger(IScalar<string> source)
        {
            _source = source;
        }

        public ParsedInteger(string source):
            this(new ScalarOf<string>(source))
        {
            
        }
        
        public int Value()
        {
            return int.Parse(_source.Value());
        }
    }
}