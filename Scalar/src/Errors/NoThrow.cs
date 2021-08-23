using System;
using System.Collections.Generic;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Errors
{
    public class NoThrow<T>: IScalar<T>, IAttempt
    {
        private readonly IScalar<T> _source;
        private readonly IScalar<T> _default;
        private bool _failed;
        private Exception _occuredError;

        public NoThrow(IScalar<T> source, IScalar<T> defaultValue)
        {
            _source = source;
            _default = defaultValue;
        }

        public NoThrow(IScalar<T> source, T @default):
            this(source, new ScalarOf<T>(@default))
        {
            
        }
        
        public T Value()
        {
            T value = _default.Value();
            try
            {
                var evaluated = _source.Value();
                value = evaluated;
            }
            catch (Exception ex)
            {
                _failed = true;
                _occuredError = ex;
            }

            return value;
        }

        public bool HasErrors()
        {
            return _failed;
        }

        public List<Exception> Errors()
        {
            if (_occuredError is not null)
            {
                return new List<Exception>() { _occuredError };
            }

            return new List<Exception>();
        }
    }
}