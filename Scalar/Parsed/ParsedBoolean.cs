using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Parsed
{
    public class ParsedBoolean: IScalar<bool>
    {
        private readonly IScalar<string> _source;

        public ParsedBoolean(IScalar<string> source)
        {
            _source = source;
        }

        public ParsedBoolean(string source):
            this(new ScalarOf<string>(source))
        {
            
        }
        
        public bool Value()
        {
            return bool.Parse(_source.Value());
        }
    }
}