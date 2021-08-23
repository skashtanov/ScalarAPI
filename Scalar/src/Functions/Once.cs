using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Functions
{
    public class Once<T>: IScalar<T>
    {
        private readonly Func<IScalar<T>> _producer;
        private IScalar<T> _scalar;
        private bool _evaluated;
        public bool Evaluated => _evaluated;

        public Once(Func<IScalar<T>> producer)
        {
            _producer = producer;
        }

        public Once(Func<T> producer):
            this(() => new ScalarOf<T>(producer()))
        {
            
        }

        public Once(IScalar<T> value) :
            this(() => value)
        {
            
        }

        public Once(T value) :
            this(() => new ScalarOf<T>(value))
        {
            
        }
        
        public T Value()
        {
            if (_evaluated == false)
            {
                _scalar = _producer();
                _evaluated = true;
            }

            return _scalar.Value();
        }
    }
}