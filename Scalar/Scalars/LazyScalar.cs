using System;
using System.Runtime.CompilerServices;
using ScalarAPI.Interfaces;

namespace ScalarAPI.Scalars
{
    public class LazyScalar<T>: IScalar<T>
    {
        private readonly Lazy<T> _scalar;
        
        public LazyScalar(Func<T> scalar)
        {
            _scalar = new Lazy<T>(scalar);
        }
        public T Value()
        {
            return _scalar.Value;
        }
    }
}