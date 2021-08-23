using System;
using System.Collections.Generic;
using System.Linq;
using ScalarAPI.Interfaces;

namespace ScalarAPI.Collections
{
    public class MinInEnumerable<T>: IScalar<T>
        where T : IComparable<T>
    {
        private readonly ExtremumInIterable<T> _min;

        public MinInEnumerable(IEnumerable<T> source)
        {
            _min = new ExtremumInIterable<T>(
                source, (x, y) => y.CompareTo(x));
        }
        public T Value()
        {
            return _min.Value();
        }
    }
}