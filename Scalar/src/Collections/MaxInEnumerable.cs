using System;
using System.Collections.Generic;
using System.Linq;
using ScalarAPI.Interfaces;

namespace ScalarAPI.Collections
{
    public class MaxInEnumerable<T>: IScalar<T>
        where T : IComparable<T>
    {
        private readonly ExtremumInIterable<T> _max;

        public MaxInEnumerable(IEnumerable<T> source)
        {
            _max = new ExtremumInIterable<T>(
                source, (x, y) => x.CompareTo(y));
        }
        public T Value()
        {
            return _max.Value();
        }
    }
}