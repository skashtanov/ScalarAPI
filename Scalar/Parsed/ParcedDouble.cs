using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Parsed
{
    public class ParsedDouble: IScalar<double>
    {
        private readonly IScalar<string> _source;

        public ParsedDouble(IScalar<string> source)
        {
            _source = source;
        }

        public ParsedDouble(string source):
            this(new ScalarOf<string>(source))
        {
            
        }
        
        public double Value()
        {
            return double.Parse(_source.Value());
        }
    }
}