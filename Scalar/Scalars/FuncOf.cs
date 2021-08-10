using System;
using ScalarAPI.Interfaces;

namespace ScalarAPI.Scalars
{
    public class FuncOf<T> : IScalar<T>
    {
        private Func<T> _func;

        public FuncOf(Func<T> func)
        {
            _func = func;
        }

        public T Value()
        {
            return _func();
        }
    }
}