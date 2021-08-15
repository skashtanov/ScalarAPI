using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Caching
{
    public class CachedScalar<T>: IScalar<T>
    {
        private bool _evaluated;
        private readonly Func<IScalar<T>> _producer;
        private IScalar<T> _scalar;

        public bool Cached => _evaluated;

        public CachedScalar(Func<IScalar<T>> producer)
        {
            _producer = producer;
        }

        public CachedScalar(Func<T> producer) :
            this(() => new ScalarOf<T>(producer()))
        {
            
        }

        public CachedScalar(IScalar<T> scalar) :
            this(() => scalar)
        {
            
        }

        public CachedScalar(T scalar) :
            this(() => new ScalarOf<T>(scalar))
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