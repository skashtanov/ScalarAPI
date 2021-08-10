using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Caching
{
    public class CachedScalar<T>: IScalar<T>
    {
        private bool _evaluated;
        private readonly IScalar<T> _scalar;
        private T _value;

        public CachedScalar(IScalar<T> scalar)
        {
            _scalar = scalar;
        }

        public CachedScalar(T scalar) :
            this(new ScalarOf<T>(scalar))
        {
            
        }

        public T Value()
        {
            if (_evaluated == false)
            {
                _value = _scalar.Value();
                _evaluated = true;
            }

            return _value;
        }
    }
}